using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3DVR_Biller_BL
{
    public delegate IDataReader DBSelect(ListParams Criteria);

    public interface IDBObject
    {
        void FillProperties(IDataReader dr);
        void FillConfig();
    }


    public interface IDBObjectList : System.Collections.IList
    {
        IDBObject NewItem();
        IDBObjectList GetList(ListParams Criteria);
        int GetCount(ListParams Criteria);

    }

    public interface IValidator
    {
        bool ValidateRules(string userName, DateTime currentDate, string operationName);
    }

    [Serializable]
    public class ListParams : Dictionary<string, object>
    {
        public int RowIndex { get; set; }
        public int PageSize { get; set; }


        public ListParams(string key, object Value)
            : base()
        {
            RowIndex = 1;
            Add(key, Value);
        }
        public ListParams(string key, object Value, int PgSize)
            : base()
        {
            RowIndex = 1;
            PageSize = PgSize;
            Add(key, Value);


        }
        public ListParams()
            : base()
        {
        }
        public ListParams(System.Runtime.Serialization.SerializationInfo Info, System.Runtime.Serialization.StreamingContext Context)
            : base(Info, Context)
        {
        }

    }

    public abstract class DBService
    {
        public static StringBuilder GetWhereClauseEx(ListParams Criteria, string[] Expr, string[] Fields)
        {

            return GetWhereClauseEx(new StringBuilder(), Criteria, Expr, Fields, Fields);
        }

        public static StringBuilder GetWhereClauseEx(ListParams Criteria, string[] Expr, string[] Fields, string[] Keys)
        {
            return GetWhereClauseEx(new StringBuilder(), Criteria, Expr, Fields, Keys);
        }

        public static StringBuilder GetWhereClauseEx(StringBuilder SQL, ListParams Criteria, string[] Expr, string[] Fields)
        {
            return GetWhereClauseEx(SQL, Criteria, Expr, Fields, Fields);
        }

        public static StringBuilder GetWhereClauseEx(StringBuilder SQL, ListParams Criteria, string[] Expr, string[] Fields, string[] Keys)
        {
            string And = "";

            if (Criteria.Count > 0)
            {
                if (SQL.Length > 0)
                    And = "AND";
                else
                    SQL.Append(" WHERE ");

                for (int i = 0; i < Keys.Length; i++)
                {
                    if (Criteria.Keys.Contains(Keys[i]))
                    {

                        SQL.Append(string.Format(" {0} " + Expr[i], And, Fields[i], Criteria[Keys[i]]));
                        And = "AND";
                    }
                }
            }
            return SQL;
        }
    }


    public static partial class DataLister
    {
        public static IDBObject FillData(IDBObject BizObj, IDataReader dr)
        {
            if (dr.Read())
            {
                BizObj.FillProperties(dr);
            }
            dr.Close();
            dr.Dispose();

            return BizObj;
        }


        public static IDBObject FillData(IDBObject BizObj, DBSelect DoSelect, ListParams Criteria)
        {
            IDataReader dr = DoSelect(Criteria);
            return FillData(BizObj, dr);
        }

        public static IDBObjectList FillData(IDBObjectList List, DBSelect DoSelect, ListParams Criteria)
        {
            IDataReader dr = DoSelect(Criteria);

            return FillData(List, dr);

        }

        public static IDBObjectList FillData(IDBObjectList List, IDataReader dr)
        {

            while (dr.Read())
            {
                IDBObject objArr = List.NewItem();
                objArr.FillProperties(dr);
                List.Add(objArr);

            }
            dr.Close();
            dr.Dispose();

            return List;

        }
        public static IDBObjectList NewObjectList(IDBObjectList list)
        {
            IDBObject objArr = list.NewItem();
            list.Add(objArr);
            return list;
        }

        public static List<IDBObjectList> FillMultipleData(List<IDBObjectList> list, IDataReader dr)
        {
            foreach (IDBObjectList ObjList in list)
            {
                while (dr.Read())
                {
                    IDBObject objArr = ObjList.NewItem();
                    objArr.FillProperties(dr);
                    ObjList.Add(objArr);

                }
                dr.NextResult();
            }
            dr.Close();
            dr.Dispose();

            return list;

        }
    }

}
