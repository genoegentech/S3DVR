using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S3DVR_Biller_BL.DataServices.Products;
using S3DVR_Biller_DAL;

namespace S3DVR_Biller_BL.Products
{
    public class Units : IDBObject, IValidator
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsCompound { get; set; }

        public void FillProperties(System.Data.IDataReader dr)
        {
            ID = Convert.ToInt32(dr["ID"].ToString());
            Name = dr["Name"].ToString();
            DisplayName = dr["DisplayName"].ToString();
            IsCompound = Convert.ToBoolean(dr["IsCompund"]);
        }

        public void FillConfig()
        {
            throw new NotImplementedException();
        }

        public bool ValidateRules(string userName, DateTime currentDate, string operationName)
        {
            throw new NotImplementedException();
        }
        public bool DeleteUnit()
        {
            return DataBaseUtils.SQLContext.TransactData(DeleteRecord) > 0;
        }
        private int DeleteRecord(DBContext Context)
        {
            return UnitsService.DeleteDetails(this, Context);
        }
        public bool UpdateData()
        {
            int res = DataBaseUtils.SQLContext.TransactData(UpdateUnitsDetails);
            return (res > 0);
        }
        private int UpdateUnitsDetails(DBContext Context)
        {
            return UnitsService.UpdateUnits(this, Context);
        }
        public bool IsExistsUnit()
        {
            return UnitsService.IsExistsUnit(this) > 0;
        }
    }
    public class UnitsList : List<Units>, IDBObjectList
    {

        public IDBObject NewItem()
        {
            return (new Units());
        }

        public IDBObjectList GetList(ListParams Criteria)
        {
            return DataLister.FillData(this, UnitsService.getAllUnitsData(Criteria));
        }

        public int GetCount(ListParams Criteria)
        {
            throw new NotImplementedException();
        }
    }
}
