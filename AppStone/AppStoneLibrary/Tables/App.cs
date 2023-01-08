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
    public class App
    {
        public long PrdId { get; set; }

        public long Price { get; set; }

        public string PrdName { get; set; }

        public long SaleId { get; set; }

        public string OperatingSystem { get; set; }

        public string ProgrammingLanguage { get; set; }


        private void fillFromDataRow(DataRow dr)
        {
            PrdId = GenelParser.ParseLong(dr["PrdId"].ToString());
            Price = GenelParser.ParseLong(dr["Price"].ToString());
            PrdName = dr["PrdName"].ToString();
            SaleId = GenelParser.ParseLong(dr["SaleId"].ToString());
            OperatingSystem = dr["OperatingSystem"].ToString();
            ProgrammingLanguage = dr["ProgrammingLanguage"].ToString();

        }

        public static App Get(long id)
        {

            DataTable dt = Islemler.Sorgu("Select * from appProduct where PrdId = @1", new object[] { id });

            if (dt.Rows.Count > 0)
            {
                App app = new App();

                app.fillFromDataRow(dt.Rows[0]);

                return app;
            }
            else
                return new App() { PrdId = -1 };
        }
    }
}
