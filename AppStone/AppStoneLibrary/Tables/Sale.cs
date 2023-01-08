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
    public class Sale
    {
        public long SaleId { get; set; }
       
        public DateTime DeliveryDate { get; set; }

        public string Company { get; set; }

        public long ProjId { get; set; }

        public long TotalPrice { get; set; }

        private void fillFromDataRow(DataRow dr)
        {
            SaleId = GenelParser.ParseLong(dr["SaleId"].ToString());
            DeliveryDate = GenelParser.ParseDateTime(dr["DeliveryDate"].ToString());
            Company = dr["Company"].ToString();
            ProjId = GenelParser.ParseLong(dr["ProjId"].ToString());
            TotalPrice = GenelParser.ParseLong(dr["TotalPrice"].ToString());
        }

        public static Sale Getir(long id)
        {

            DataTable dt = Islemler.Sorgu("Select * from Sale where SaleId = @1", new object[] { id });

            if (dt.Rows.Count > 0)
            {
                Sale sale = new Sale();

                sale.fillFromDataRow(dt.Rows[0]);

                return sale;
            }
            else
                return new Sale() { SaleId = -1 };
        }

        public static List<Sale> TumunuGetir()
        {
            var sales = new List<Sale>();

            DataTable dt = Islemler.Sorgu("Select * from Sale", new object[] { });

            foreach (DataRow dr in dt.Rows)
            {
                Sale sale = new Sale();

                sale.fillFromDataRow(dr);

                sales.Add(sale);
            }

            return sales;
        }

        public static string saleHtml(Sale sale)
        {
            StringBuilder sb = new StringBuilder();


            sb.Append("<div class=\"card tasmayan\">");
            sb.Append("    <div class=\"card-body profile-card pt-4 d-flex flex-column align-items-center\">");
            sb.Append("<div><h1>Delivery Date: " + sale.DeliveryDate.ToString("d") + "</h1></div>");
            sb.Append("<div><h1>Company: " + sale.Company + "</h1></div>");
            sb.Append("<div><h1>Total Price: " + sale.TotalPrice + "</h1></div>");
            sb.Append("<div><h1>Project: " + sale.ProjId + "</h1></div>");

            sb.Append("</div>");
            sb.Append("</div>");


            return sb.ToString();
        }

        public void Add(DateTime star, long cstıd)
        {
            Islemler.SorguDisi("INSERT INTO Sale(SaleId, DeliveryDate, Company, ProjId,TotalPrice) " +
                "values (@1 , @2 , @3 , @4, @5)", new object[] { SaleId, DeliveryDate, Company, ProjId,TotalPrice });

            DataTable dt = Islemler.Sorgu("Select Count(*) from Contracts", new object[] {  });
            DataRow dr = dt.Rows[0];
            long id = GenelParser.ParseLong(dr[0].ToString()) + 1;



            Islemler.SorguDisi("INSERT INTO Contracts(ContractId, EndDate, CstId) " +
                "values (@1 , @2 , @3)", new object[] { id, star, cstıd });
        }
    }
}
