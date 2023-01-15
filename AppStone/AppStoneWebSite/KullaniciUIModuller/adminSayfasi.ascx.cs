using AjaxPro;
using SametLibrary.Genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppStoneLibrary.Tables;

[AjaxNamespace("ADMINSAYFASI_AJAX")]
public partial class KullaniciUIModuller_adminSayfasi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Utility.RegisterTypeForAjax(typeof(KullaniciUIModuller_adminSayfasi), Page);

        List<SaleInfo> allSales = SaleInfo.GetAll();
        List<Project> allProjects = Project.TumunuGetir();

        Employee employee = Employee.Giris(SessionObjects.AccountObject.EmpId);

        StringBuilder sbs = new StringBuilder();
        StringBuilder sbp = new StringBuilder();

        long a = 0;
        foreach (SaleInfo sale in allSales)
        {
            
            int b = 0;
            if (sale.SaleId == a)
                b = 1;
            a = sale.SaleId;
            sbs.Append(SaleInfo.saleInfoHtml(sale,b));
        }
            

        foreach (Project project in allProjects)
            sbp.Append(Project.projectHtml(project));

        icerikler.InnerHtml = sbs.ToString();
        kullanicilar.InnerHtml = sbp.ToString();
        //employees.InnerHtml = employeesHtml(employee);

    }

    private string employeesHtml(Employee employee)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("             <div class=\"mb-3\">");
        sb.Append(" <button type=\"button\" class=\"btn btn-success d-table my-5 mx-auto\" data-bs-toggle=\"modal\" data-bs-target=\"#ModalForm\" id=\"btnSifreDegistir\">Add Employee</button>");
        sb.Append("            </div>");

        List<Employee> allEmployee = Employee.TumunuGetir();
        foreach (Employee employe in allEmployee)
            sb.Append(Employee.employeeHtmlUpdatable(employe));

        return sb.ToString();
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string addEmployee(string fName, string lName, string Department, string birthdate, string HoulyRate, string City, string Street, long HouseNo, string Gender)
    {
        Employee employee = new Employee();

        employee.FirstName = fName;
        employee.LastName = lName;
        employee.Department = Department;
        employee.Birthdate = DateTime.ParseExact(birthdate, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
        employee.HourlyRate = HoulyRate;
        employee.City = City;
        employee.Street = Street;
        employee.HouseNumber = HouseNo;
        employee.EmploymentType = "Parttime";
        employee.MgrId = SessionObjects.AccountObject.EmpId;
        employee.Gender = Gender;

        employee.Add();

        return "ss";
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string updateEmployee(long id ,string Department, string HoulyRate, string City, string Street, long HouseNo)
    {
        Employee employee = Employee.Giris(id);

        employee.Department = Department;
        employee.HourlyRate = HoulyRate;
        employee.City = City;
        employee.Street = Street;
        employee.HouseNumber = HouseNo;
        employee.Update();

        return "ss";
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string modalOlustur(long id)
    {

        Employee employee = Employee.Giris(id);

        StringBuilder sb = new StringBuilder();

        sb.Append(id);

        sb.Append("<div class=\"row mb-3\">");
        sb.Append("     <label for=\"inputDate\" class=\"col-sm-2 col-form-lablel\">Bloklanacağı Tarih</label>");
        sb.Append("     <div class=\"col-sm-10\">");
        sb.Append("         <input type=\"date\" id=\"blokTarihi\" class=\"form-control\">");
        sb.Append("     </div>");
        sb.Append("</div>");
        sb.Append(" <button type=\"button\" class=\"btn btn-primary btn-block mb-4\" id=\"blokButonu_" + employee.EmpId + "\" onclick=\"blokla(" + employee.EmpId + ");\">BLOKLA</button>");

        return sb.ToString();
    }
}