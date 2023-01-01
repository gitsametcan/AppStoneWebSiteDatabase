using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SametLibrary.Genel;
using SametLibrary.Guvenlik;
using SametLibrary.VeriTabaniIslemleri;
using System.Threading.Tasks;
using System.Data;
using System.Security.Policy;

namespace AppStoneLibrary.Tables
{
    public class Account
    {
        public long EmpId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }


        private void fillFromDataRow(DataRow dr)
        {
            EmpId = GenelParser.ParseLong(dr["EmpId"].ToString());
            Email = dr["Email"].ToString();
            Password = dr["Password"].ToString();
        }

        public static Account Giris(string ePosta, string sifre)
        {

            DataTable dt = Islemler.Sorgu("Select * from Account where Email = @1 and Password = @2", new object[] { ePosta, sifre });

            if (dt.Rows.Count > 0)
            {
                Account account = new Account();

                account.fillFromDataRow(dt.Rows[0]);

                return account;
            }
            else
                return new Account() { EmpId = -1, Email = "", Password = "" };
        }
    }
}
