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
    public class Service
    {
        public long PrdId { get; set; }

        public long Price { get; set; }

        public string PrdName { get; set; }

        public long SaleId { get; set; }

        public DateTime StarDate { get; set; }

        public DateTime EndDate { get; set; }

        public long TotalTime { get; set; }

        private void fillFromDataRow(DataRow dr)
        {
            PrdId = GenelParser.ParseLong(dr["PrdId"].ToString());
            Price = GenelParser.ParseLong(dr["Price"].ToString());
            PrdName = dr["PrdName"].ToString();
            SaleId = GenelParser.ParseLong(dr["SaleId"].ToString());
            StarDate = GenelParser.ParseDateTime(dr["StartDate"].ToString());
            EndDate = GenelParser.ParseDateTime(dr["EndDate"].ToString());
            TotalTime = GenelParser.ParseLong(dr["TotalTime"].ToString());


        }

        public static Service Get(long id)
        {

            DataTable dt = Islemler.Sorgu("Select * from serviceProduct where PrdId = @1", new object[] { id });

            if (dt.Rows.Count > 0)
            {
                Service service = new Service();

                service.fillFromDataRow(dt.Rows[0]);

                return service;
            }
            else
                return new Service() { PrdId = -1 };
        }
    }
}
