using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Xml;
using System.IO;
using System.Data.Sql;

namespace S3DVR_Biller_DAL
{
    public delegate void DataFillFunc(IDataReader dr);
    public delegate int DBUpdateFunc(DBContext Context);

    public abstract class DataBase
    {
        public string connectionString { get; set; }
        public string NotificationServiceName { get; set; }
        public string NotificationQueueName { get; set; }
        public abstract IDbConnection GetConnection();

        public virtual IDbCommand GetopenCnCommand(string sql)
        {
            IDbCommand cmd = GetOpenCn().CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandTimeout = 3000;
            return (cmd);
        }
        protected IDbConnection GetOpenCn()
        {
            IDbConnection m_Connection = GetConnection();
            if (m_Connection is SqlConnection)
            {
                SqlConnection sqlConn = m_Connection as SqlConnection;
                sqlConn.InfoMessage += InfoMessageEventHandler;
                sqlConn.Open();
                return sqlConn;
            }
            else
            {
                m_Connection.Open();
                return m_Connection;
            }
        }

        #region infoMessage handler
        /// <summary>
        /// Handles messages from the connection by logging them.
        /// </summary>    
        private void InfoMessageEventHandler(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {
            StringBuilder msg = new StringBuilder();

            foreach (System.Data.SqlClient.SqlError err in e.Errors)
            {
                if (!IgnoreErrorNumber(err.Number))
                {
                    msg.Append("sp: ").Append(e.Errors[0].Procedure).Append(" print output:");
                    msg.Append(err.Message);

                }
            }
        }

        // Returns true if the error should be ignored. 5701 and 5703 get sent
        // by the server upon login.
        private static bool IgnoreErrorNumber(int errorNumber)
        {
            switch (errorNumber)
            {
                // case 5701:
                // "Changed database context ..."
                // case 5703:
                // "Change language setting ..."
                // return true;
                default:
                    return false;
            }
        }
        #endregion infoMessage handler


        public IDataReader ExecuteReader(string sql)
        {
            return (GetopenCnCommand(sql).ExecuteReader(CommandBehavior.CloseConnection));
        }
        public IDataReader ExecuteReader(IDbCommand cmd)
        {
            cmd.Connection = GetOpenCn();
            cmd.CommandTimeout = 3000;
            return (cmd.ExecuteReader(CommandBehavior.CloseConnection));
        }
        public object ExecuteScalar(string sql)
        {
            IDbCommand cmd = GetopenCnCommand(sql);
            object res = cmd.ExecuteScalar();
            cmd.Connection.Close();

            return res;
        }
        public int ExecuteNonQuery(string sql)
        {
            IDbCommand cmd = GetopenCnCommand(sql);
            int res = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return res;
        }
        public int ExecuteNonQuery(IDbCommand cmd)
        {
            int res = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return res;
        }

        /// <summary>
        /// General fuction to execute Stored Procedure as well as text query with or without parameter
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="param"></param>
        /// <param name="isProcedure"></param>
        /// <returns>Total No. of Columns affected</returns>
        public int ExecuteNonQuery(string Query, DBParams param, bool IsProcedure)
        {
            IDbCommand cmd = GetopenCnCommand(Query);
            if (IsProcedure)
                cmd.CommandType = CommandType.StoredProcedure;
            else
                cmd.CommandType = CommandType.Text;
            if (param != null)
                AttachParameters(cmd, param);
            int res = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return res;
        }

        /// <summary>
        /// General fuction to execute Stored Procedure as well as text query 
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="param"></param>
        /// <param name="isProcedure"></param>
        /// <returns>IDataReader</returns>
        public IDataReader ExecuteReader(string Query, DBParams param, bool IsProcedure)
        {
            IDbCommand cmd = GetopenCnCommand(Query);
            if (IsProcedure)
                cmd.CommandType = CommandType.StoredProcedure;
            else
                cmd.CommandType = CommandType.Text;
            if (param != null)
                AttachParameters(cmd, param);
            return (cmd.ExecuteReader(CommandBehavior.CloseConnection));
        }
        private void AttachParameters(IDbCommand command, DBParams param)
        {
            if (param.Count > 0)
            {
                int index = 0;
                IDbDataParameter[] idbParams = new IDbDataParameter[param.Count];
                foreach (KeyValuePair<string, object> kvp in param)
                {
                    idbParams[index] = new SqlParameter();
                    string key = kvp.Key;
                    if (kvp.Key.ToLower().Contains(" output"))
                    {
                        key = key.Substring(0, kvp.Key.Length - 7);
                        idbParams[index].Direction = ParameterDirection.InputOutput;
                        idbParams[index].DbType = (DbType)kvp.Value;
                    }
                    else
                    {
                        idbParams[index].Value = kvp.Value;
                    }
                    idbParams[index].ParameterName = key;
                    index++;

                }
                foreach (IDbDataParameter idbParam in idbParams)
                {
                    if ((idbParam.Direction == ParameterDirection.InputOutput) || (idbParam.Value == null))
                    {
                        idbParam.Value = DBNull.Value;
                    }
                    command.Parameters.Add(idbParam);
                }
            }
        }
        public object ExecuteScalar(string sql, DBParams param, bool IsProcedure)
        {
            IDbCommand cmd = GetopenCnCommand(sql);
            if (IsProcedure)
                cmd.CommandType = CommandType.StoredProcedure;
            else
                cmd.CommandType = CommandType.Text;
            if (param != null)
                AttachParameters(cmd, param);
            object res = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return res;

        }
        public object ExecuteScalar(IDbCommand cmd)
        {
            object res = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return res;
        }
        public void GetData(string SQL, DataFillFunc Fill)
        {
            IDataReader dr = ExecuteReader(SQL);
            GetData(dr, Fill);
        }
        private void GetData(IDataReader dr, DataFillFunc Fill)
        {
            while (dr.Read())
            {
                Fill(dr);
            }
            dr.Close();
            dr.Dispose();
        }

    }

    public abstract class DBContext : DataBase
    {
        protected IDbConnection Connection;
        public IDbTransaction Transaction;
        protected abstract void setTransaction(IDbCommand cmd);
        public DBParams ExecuteParams;

        public override IDbCommand GetopenCnCommand(string sql)
        {
            IDbCommand cmd = Connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandTimeout = 3000;
            cmd.Connection = Transaction.Connection;
            setTransaction(cmd);
            return (cmd);
        }

        public new IDataReader ExecuteReader(IDbCommand cmd)
        {
            cmd.Connection = Transaction.Connection;
            cmd.CommandTimeout = 300;
            setTransaction(cmd);
            return (cmd.ExecuteReader());
        }
        public new IDataReader ExecuteReader(string SQL)
        {
            IDbCommand cmd = Connection.CreateCommand();
            cmd.CommandText = SQL;
            cmd.CommandTimeout = 3000;
            cmd.Connection = Transaction.Connection;
            setTransaction(cmd);
            return (cmd.ExecuteReader());
        }
        public int ExecuteNonQuery(IDbCommand cmd)
        {
            cmd.Connection = Transaction.Connection;
            setTransaction(cmd);
            cmd.CommandTimeout = 300;
            if (System.Configuration.ConfigurationManager.AppSettings["CommandTimeOut"] != null)
                cmd.CommandTimeout = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["CommandTimeOut"]);
            return (cmd.ExecuteNonQuery());
        }

        public object ExecuteScalar(IDbCommand cmd)
        {
            cmd.Connection = Transaction.Connection;
            setTransaction(cmd);
            cmd.CommandTimeout = 300;
            return (cmd.ExecuteScalar());
        }

        public new int ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(GetopenCnCommand(sql));
        }

        public new object ExecuteScalar(string sql)
        {
            return ExecuteScalar(GetopenCnCommand(sql));
        }

        public int TransactData(DBUpdateFunc UpdateData, DBParams executeParams)
        {
            ExecuteParams = executeParams;
            return TransactData(UpdateData);

        }
        public int TransactData(DBUpdateFunc UpdateData)
        {
            int res = 0;

            Connection = GetOpenCn();
            Transaction = Connection.BeginTransaction();
            try
            {
                res = UpdateData(this);
                if (res <= 0)
                    // Database error ...should identify the error
                    throw new Exception("Error in Data");
                Transaction.Commit();
            }
            catch
            {
                Transaction.Rollback();
                throw;
            }
            finally
            {
                Connection.Close();
                Connection.Dispose();
            }

            return res;
        }
    }
    public static class DataBaseUtils
    {
        public static SQLServerDB SQL
        {
            get
            {
                SQLServerDB db = new SQLServerDB();
                db.connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

                return db;
            }
        }
        public static SQLServerDBContext SQLContext
        {
            get
            {
                SQLServerDBContext db = new SQLServerDBContext();
                db.connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                return db;
            }
        }
        public static SQLServerDB SQLNotify
        {
            get
            {
                SQLServerDB db = new SQLServerDB();
                db.connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                db.NotificationServiceName = System.Configuration.ConfigurationManager.AppSettings["NotificationService"].ToString();
                db.NotificationQueueName = System.Configuration.ConfigurationManager.AppSettings["NotificationQueue"].ToString();
                return db;
            }
        }
    }

    public class SQLServerDBContext : DBContext
    {
        public override IDbConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        protected override void setTransaction(IDbCommand cmd)
        {
            cmd.Transaction = Transaction;
        }
    }
    public class SQLServerDB : DataBase
    {
        public override IDbConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public int GetNotificationRequest(string sql)
        {
            SqlCommand cmd = (SqlCommand)GetopenCnCommand(sql);
            SqlNotificationRequest notif = new SqlNotificationRequest();
            notif.UserData = Guid.NewGuid().ToString();
            notif.Options = "Service=" + NotificationServiceName;
            notif.Timeout = Int32.MaxValue;
            cmd.Notification = notif;

            int res = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return res;
        }
        public IDbCommand GetNotificationQueueCommand()
        {
            // setup callback for the message from queue in Service Broker of SQL Server
            SqlConnection con = (SqlConnection)GetOpenCn();
            SqlCommand cmd = new SqlCommand("WAITFOR (Receive * from " + NotificationQueueName + ")", con);
            cmd.CommandTimeout = int.MaxValue;
            return cmd;
        }

        /// <summary>
        /// This exports a Query's results into XML format. 
        /// </summary>
        /// <param name="sql">SQL command</param>
        /// <returns></returns>
        public string getSqlQueryAsXml(SqlCommand cmd)
        {
            System.Xml.XmlReader reader = cmd.ExecuteXmlReader();
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter textWriter = new XmlTextWriter(stringWriter);
            while (!reader.EOF)
            {
                reader.MoveToContent();
                textWriter.WriteNode(reader, false);
            }
            reader.Close();
            return stringWriter.ToString();
        }

        /// <summary>
        /// Exports SQL queries output into file. 
        /// </summary>
        /// <param name="fileName">File Name</param>
        /// <param name="cmd">command</param>
        /// <param name="xmlPrefix">If there is any prefix to XML, otherwise null</param>
        /// <param name="xmlSuffix">If there is any suffix to XML, otherwise null</param>

        public void ExportSqlQueryAsXml(string fileName, SqlCommand cmd, string xmlPrefix, string xmlSuffix)
        {
            cmd.Connection = (SqlConnection)GetOpenCn();
            string xmlStr = getSqlQueryAsXml(cmd);
            if (xmlStr.Length > 0)
                writeXmlToFile(fileName, xmlPrefix + xmlStr + xmlSuffix);
            else
                throw (new Exception("Empty File"));

        }
        /// <summary>
        /// Writes to file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="xmlStr"></param>
        private void writeXmlToFile(string fileName, string xmlStr)
        {
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.Write(xmlStr);
            sw.Close();
        }
    }
    public class DBParams : Dictionary<string, object>
    {
        public DBParams(string name, object value)
            : base()
        {
            Add(name, value);
        }
        public DBParams()
            : base()
        {
        }
    }
}

