using AjaxPro;
using AppStoneLibrary.Tables;
using SametLibrary.Genel;
using SametLibrary.Guvenlik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


[AjaxNamespace("PROFIL_AJAX")]
public partial class KullaniciUIModuller_profil : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Utility.RegisterTypeForAjax(typeof(KullaniciUIModuller_profil), Page);

        Employee employee = Employee.Giris(SessionObjects.AccountObject.EmpId);




    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string addProject(string ProjName, long StarDate, string EndDate)
    {
        Project project = new Project();

        project.ProjName = ProjName;
        project.ProjId = StarDate;
        project.EndDate = DateTime.ParseExact(EndDate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

        project.Add();

        return "ss";
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string addCustomer(string CmpName, string City, string Street, long Housenumber, string Email, long TelNumber)
    {
        Customer customer = new Customer();

        customer.CmpName = CmpName;
        customer.City = City;
        customer.Street = Street;
        customer.Housenumber = Housenumber;
        

        customer.Add(Email,TelNumber);

        return "ss";
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string addSalCon(string DeliveryDate, string Company, long ProjId, long TotalPrice, long StarDateCon, string EndDateCon, long cstId)
    {
        Sale sale = new Sale();

        sale.SaleId = StarDateCon;
        sale.DeliveryDate = DateTime.ParseExact(DeliveryDate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        sale.Company = Company;
        sale.ProjId = ProjId;
        sale.TotalPrice = TotalPrice;
        DateTime EndDateC = DateTime.ParseExact(EndDateCon, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);


        sale.Add(EndDateC, cstId);

        return "ss";
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string addPayment(string Amount, string date, long SaleId, long CstID)
    {
        Payment payment = new Payment();

        payment.Amount= Amount;
        payment.PaymentDate = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        payment.SaleId = SaleId;
        payment.ContractId = CstID;
        
        payment.Add();

        return "ss";
    }

}