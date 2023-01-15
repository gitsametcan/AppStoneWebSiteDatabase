using AjaxPro;
using AppStoneLibrary.Tables;
using SametLibrary.Genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[AjaxNamespace("KULLANICISAYFASI_AJAX")]
public partial class KullaniciUIModuller_kullaniciSayfasi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Utility.RegisterTypeForAjax(typeof(KullaniciUIModuller_kullaniciSayfasi), Page);

        Employee employee = Employee.Giris(SessionObjects.AccountObject.EmpId);

        kullaniciIsmi.InnerHtml = employee.FirstName + " " + employee.LastName;
        department.InnerHtml = employee.Department;
        birthdate.InnerHtml = employee.Birthdate.ToString("d");
        hourlyrate.InnerHtml = employee.HourlyRate.ToString()+"£";
        address.InnerHtml = employee.Street + " " + employee.HouseNumber.ToString() + " " + employee.City;
        emptip.InnerHtml = employee.EmploymentType;
        manager.InnerHtml = employee.MgrId.ToString();
        kullaniciMail.InnerHtml = SessionObjects.AccountObject.Email;

        Div1.InnerHtml = Employee.employeeHtmlUpdatable(employee);

    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string updateEmployee(string Department, long HouseNo, string City, string Street)
    {
        Employee employee = Employee.Giris(SessionObjects.AccountObject.EmpId);

        employee.Department = Department;
        employee.City = City;
        employee.Street = Street;
        employee.HouseNumber = HouseNo;
        employee.Update();

        return "ss";
    }

}