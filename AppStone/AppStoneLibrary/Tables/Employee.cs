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
    public class Employee
    {
        public long EmpId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public DateTime Birthdate { get; set; }

        public long Age { get; set; }

        public long HourlyRate { get; set; }

        public string EmploymentType { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public long HouseNumber { get; set; }

        public string Gender { get; set; }

        public long MgrId { get; set; }

        private void fillFromDataRow(DataRow dr)
        {
            EmpId = GenelParser.ParseLong(dr["EmpId"].ToString());
            FirstName = dr["FirstName"].ToString();
            LastName = dr["LastName"].ToString();
            Department = dr["Department"].ToString();
            Birthdate = GenelParser.ParseDateTime(dr["Birthdate"].ToString());
            Age = GenelParser.ParseLong(dr["Age"].ToString());
            HourlyRate = GenelParser.ParseLong(dr["HourlyRate"].ToString());
            EmploymentType = dr["EmploymentType"].ToString();
            City = dr["City"].ToString();
            Street = dr["Street"].ToString();
            HouseNumber = GenelParser.ParseLong(dr["HouseNumber"].ToString());
            Gender = dr["Gender"].ToString();
            MgrId = GenelParser.ParseLong(dr["MgrId"].ToString());
        }

        public static Employee Giris(long id)
        {

            DataTable dt = Islemler.Sorgu("Select * from Employee where EmpId = @1", new object[] { id });

            if (dt.Rows.Count > 0)
            {
                Employee employee = new Employee();

                employee.fillFromDataRow(dt.Rows[0]);

                return employee;
            }
            else
                return new Employee() { EmpId = -1};
        }
    }
}
