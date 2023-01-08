using SametLibrary.Genel;
using SametLibrary.VeriTabaniIslemleri;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoneLibrary.Tables
{
    public class SaleInfo
    {
        public long SaleId { get; set; }

        public long TotalPrice { get; set; }

        public string Amount { get; set; }

        public DateTime EndDate { get; set; }

        public string CmpName { get; set; }


        private void fillFromDataRow(DataRow dr)
        {
            SaleId = GenelParser.ParseLong(dr["Saleid"].ToString());
            TotalPrice = GenelParser.ParseLong(dr["TotalPrice"].ToString());
            Amount = dr["Amount"].ToString();
            EndDate = GenelParser.ParseDateTime(dr["EndDate"].ToString());
            CmpName = dr["CmpName"].ToString();

        }

        public static List<SaleInfo> GetAll()
        {
            var sales = new List<SaleInfo>();

            DataTable dt = Islemler.Sorgu("Select * from SaleInfo", new object[] { });

            foreach (DataRow dr in dt.Rows)
            {
                SaleInfo sale = new SaleInfo();

                sale.fillFromDataRow(dr);

                sales.Add(sale);
            }

            return sales;
        }

        public static string saleInfoHtml(SaleInfo saleInfo, int a)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<div class=\"card tasmayan\">");
            sb.Append("    <div class=\"card-body profile-card pt-4 d-flex flex-column align-items-center\">");
            if (a == 0)
            {
                
                if (Service.Get(saleInfo.SaleId).PrdId == -1)
                    sb.Append("<div><h1>Product Name: " + App.Get(saleInfo.SaleId).PrdName + "</h1></div>");
                if (App.Get(saleInfo.SaleId).PrdId == -1)
                    sb.Append("<div><h1>Product Name: " + Service.Get(saleInfo.SaleId).PrdName + "</h1></div>");
                sb.Append("<div><h1>Company: " + saleInfo.CmpName + "</h1></div>");
                sb.Append("<div><h1>Total Price: " + saleInfo.TotalPrice + ",000 £ "+ "</h1></div>");
                sb.Append("<div><h1>Payment: " + saleInfo.Amount + "</h1></div>");

                
            }
            else
                sb.Append("<div><h1> Additional Payment: " + saleInfo.Amount + "</h1></div>");

            sb.Append("</div>");
            sb.Append("</div>");

            return sb.ToString();
        }

    }


}
