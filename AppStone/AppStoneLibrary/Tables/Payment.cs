using SametLibrary.Genel;
using SametLibrary.VeriTabaniIslemleri;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoneLibrary.Tables
{
    public class Payment
    {
        public long PaymentId { get; set; }

        public string Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public long SaleId { get; set; }

        public long ContractId { get; set; }


        private void fillFromDataRow(DataRow dr)
        {
            PaymentId = GenelParser.ParseLong(dr["PaymentId"].ToString());
            Amount = dr["Amount"].ToString();
            PaymentDate = GenelParser.ParseDateTime(dr["PaymentDate"].ToString());
            SaleId = GenelParser.ParseLong(dr["SaleId"].ToString());
            ContractId = GenelParser.ParseLong(dr["ContractId"].ToString());
        }

        public void Add()
        {
            DataTable dt = Islemler.Sorgu("Select Count(*) from Payment", new object[] { });
            DataRow dr = dt.Rows[0];
            long id = GenelParser.ParseLong(dr[0].ToString()) + 1;

            Islemler.SorguDisi("INSERT INTO Payment(PaymentId, Amount, PaymentDate, SaleId,ContractId) " +
                "values (@1 , @2 , @3 , @4, @5)", new object[] { id, Amount, PaymentDate, SaleId, ContractId });
        }
    }
}
