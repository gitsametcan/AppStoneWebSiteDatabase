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

        public string HourlyRate { get; set; }

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
            HourlyRate = dr["HourlyRate"].ToString();
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

        public static string employeeHtml(Employee employee)
        {
            StringBuilder sb = new StringBuilder();


            sb.Append("<div class=\"card tasmayan\">");
            sb.Append("    <div class=\"card-body profile-card pt-4 d-flex flex-column align-items-center\">");
            sb.Append("<div><h1>Name: " + employee.FirstName +" "+ employee.LastName + "</h1></div>");
            sb.Append("<div><h1>Adress: " + employee.Street+ " No:"+ employee.HouseNumber.ToString() +" / "+employee.City + "</h1></div>");
            sb.Append("<div><h1>Hourly Rate: " + employee.HourlyRate.ToString() + "£" + "</h1></div>");
            sb.Append("<div><h1>Birthdate: " + employee.Birthdate.ToString("d") +"("+employee.Age.ToString()+")"+ "</h1></div>");

            sb.Append("</div>");
            sb.Append("</div>");


            return sb.ToString();
        }

        public static string employeeHtmlUpdatable(Employee employee)
        {
            StringBuilder sb = new StringBuilder();


            sb.Append("<div class=\"card tasmayan\">");
            sb.Append("    <div class=\"card-body profile-card pt-4 d-flex flex-column align-items-center\">");
            sb.Append("<div><h1>Name: " + employee.FirstName + " " + employee.LastName + "</h1></div>");
            sb.Append("    <div class=\"col-md-8 col-lg-9\">");
            sb.Append("        <input type=\"text\" class=\"form-control\" id=\"street\" value=\"" + employee.Street + "\">");
            sb.Append("    </div>");
            sb.Append("    <div class=\"col-md-8 col-lg-9\">");
            sb.Append("        <input type=\"text\" class=\"form-control\" id=\"HouseNo\" value=\"" + employee.HouseNumber + "\">");
            sb.Append("    </div>");
            sb.Append("    <div class=\"col-md-8 col-lg-9\">");
            sb.Append("        <input type=\"text\" class=\"form-control\" id=\"City\" value=\"" + employee.City + "\">");
            sb.Append("    </div>");
            sb.Append("    <div class=\"col-md-8 col-lg-9\">");
            sb.Append("        <input type=\"text\" class=\"form-control\" id=\"Department\" value=\"" + employee.Department + "\">");
            sb.Append("    </div>");
            sb.Append("    <div class=\"col-md-8 col-lg-9\">");
            sb.Append("        <input type=\"text\" class=\"form-control\" id=\"HourlyRate\" value=\"" + employee.HourlyRate + "\">");
            sb.Append("    </div>");
            sb.Append("<div><h1>Birthdate: " + employee.Birthdate.ToString("d") + "(" + employee.Age.ToString() + ")" + "</h1></div>");
            sb.Append("<div>");
            sb.Append(" <button type=\"button\" class=\"btn btn-primary btn-block mb-4\" onclick=\"update();\">Update</button>");
            sb.Append("</div>");
            
            sb.Append("</div>");
            sb.Append("</div>");


            return sb.ToString();
        }

        public static List<Employee> TumunuGetir()
        {
            var employees = new List<Employee>();

            DataTable dt = Islemler.Sorgu("Select * from Employee", new object[] { });

            foreach (DataRow dr in dt.Rows)
            {
                Employee employee = new Employee();

                employee.fillFromDataRow(dr);

                employees.Add(employee);
            }

            return employees;
        }

        public void Add()
        {
            Islemler.SorguDisi("INSERT INTO Employee(FirstName, LastName, Department, Birthdate, HourlyRate, EmploymentType, City, Street, Housenumber, Gender, MgrId) " +
                "values (@1 , @2 , @3 , @4 , @5, @6, @7, @8, @9, @10, @11)", new object[] { FirstName, LastName, Department, Birthdate, HourlyRate, EmploymentType, City, Street,HouseNumber,Gender,MgrId });
        }

        public void Update()
        {
            Islemler.SorguDisi("Update Employee set Department = @1, HourlyRate = @2, City = @3, Street = @4, Housenumber = @5 where EmpId = @6", new object[] { Department, HourlyRate, City, Street, HouseNumber,  EmpId });
        }
    }
}
