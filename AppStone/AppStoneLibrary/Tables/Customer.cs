using SametLibrary.Genel;
using SametLibrary.VeriTabaniIslemleri;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoneLibrary.Tables
{
    public class Customer
    {
        public long CstId { get; set; }

        public string CmpName { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public long Housenumber { get; set; }

        public string Email { get; set; }

        public long TelNumber { get; set; }

        private void fillFromDataRow(DataRow dr)
        {
            CstId = GenelParser.ParseLong(dr["CstId"].ToString());
            CmpName = dr["CmpName"].ToString();
            City = dr["City"].ToString();
            Street = dr["Street"].ToString();
            Housenumber = GenelParser.ParseLong(dr["Housenumber"].ToString());
            Email = dr["HourlyRate"].ToString();
            TelNumber = GenelParser.ParseLong(dr["TelNumber"].ToString());

        }

        public static Customer Get(long id)
        {

            DataTable dt = Islemler.Sorgu("Select * from customerWithInfo where CstId = @1", new object[] { id });

            if (dt.Rows.Count > 0)
            {
                Customer customer = new Customer();

                customer.fillFromDataRow(dt.Rows[0]);

                return customer;         
            }
            else
                return new Customer() { CstId = -1 };
        }

        public static string employeeHtml(Customer customer)
        {
            StringBuilder sb = new StringBuilder();


            sb.Append("<div class=\"card tasmayan\">");
            sb.Append("    <div class=\"card-body profile-card pt-4 d-flex flex-column align-items-center\">");
            sb.Append("<div><h1>Name: " + customer.CmpName +  "</h1></div>");
            sb.Append("<div><h1>Adress: " + customer.Street + " No:" + customer.Housenumber.ToString() + " / " + customer.City + "</h1></div>");
            sb.Append("<div><h1>Email: " + customer.Email+ "</h1></div>");
            sb.Append("<div><h1>Tel Number: "  + customer.TelNumber.ToString() + "</h1></div>");

            sb.Append("</div>");
            sb.Append("</div>");


            return sb.ToString();
        }
    }
}
