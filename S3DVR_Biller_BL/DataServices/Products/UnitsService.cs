using S3DVR_Biller_BL.Products;
using S3DVR_Biller_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3DVR_Biller_BL.DataServices.Products
{
    public partial class UnitsService
    {
        public static IDataReader getAllUnitsData(ListParams Criteria)
        {
            StringBuilder SQL = new StringBuilder("");

            if (Criteria.PageSize > 0) SQL.Append(" SELECT   *  FROM   ( ");
            SQL.Append(" SELECT T.ID, T.Name, T.DisplayName,T.IsCompund,");
            SQL.Append("  ROW_NUMBER()  over(ORDER BY   T.DisplayName) rnum   ");
            SQL.Append("  FROM   Units T ");
            SQL.Append(GetWhereClause(Criteria));
            SQL.Append(" ");
            if (Criteria.PageSize > 0) SQL.Append("  ) O WHERE   rnum between (( {0} - 1) *  {1} + 1) AND ( {0} *  {1}) ");

            string Query = string.Format(SQL.ToString(), Criteria.RowIndex, Criteria.PageSize);

            IDataReader dr = DataBaseUtils.SQL.ExecuteReader(Query);

            return dr;
        }
        public static StringBuilder GetWhereClause(ListParams Criteria)
        {
            string[] Keys = { "ID", "NameLike", "DisplayNameLike", "IsCompound"};
            string[] Fields = { "ID", "Name", "DisplayName", "IsCompound" };
            string[] Expr = { " {1} = {2} ", " {1} LIKE '%{2}%' ", " {1} LIKE '%{2}%' ", "  {1} =  {2} " };
            return DBService.GetWhereClauseEx(Criteria, Expr, Fields, Keys);
        }
        public static int DeleteDetails(Units Obj, DBContext context)
        {
            StringBuilder SQL = new StringBuilder();

            SQL.Append(" Delete From Units  Where ID= {0} ; ");

            string Query = string.Format(SQL.ToString(), Obj.ID);

            return context.ExecuteNonQuery(Query);
        }
        public static int UpdateUnits(Units Obj, DBContext Context)
        {
            StringBuilder SQL = new StringBuilder();

            if (Obj.ID > 0)
            {
                SQL.Append("  UPDATE Units  SET  ");

                SQL.Append("Name = '{1}',");
                SQL.Append("DisplayName = '{2}',");
                SQL.Append("IsCompund = {3}");
                SQL.Append("  WHERE ID =  {0} ;  ");
            }
            else
            {
                SQL.Append(" Insert into Units  ");
                SQL.Append(" (Name, DisplayName, IsCompund) ");
                SQL.Append(" Values ('{1}', '{2}', {3}); ");
            }
            string Query = string.Format(SQL.ToString(), Obj.ID, Obj.Name, Obj.DisplayName, Convert.ToInt16(Obj.IsCompound));

            return (Context.ExecuteNonQuery(Query));

        }
        public static int IsExistsUnit(Units Obj)
        {
            StringBuilder SQL = new StringBuilder();

            SQL.Append(" SELECT COUNT(1) FROM Units WHERE (Name = '{1}' OR DisplayName = '{2}')  ");
            if (Obj.ID > 0)
            {
                SQL.Append(" AND ID <> {0} ");
            }

            string Query = string.Format(SQL.ToString(), Obj.ID, Obj.Name, Obj.DisplayName);
            return Convert.ToInt32(DataBaseUtils.SQL.ExecuteScalar(Query));
        }
    }
}
