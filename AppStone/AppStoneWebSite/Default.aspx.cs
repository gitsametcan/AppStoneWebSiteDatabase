using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppStoneLibrary.Tables;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (SessionObjects.AccountObject.EmpId < 1)
            Page.ClientScript.RegisterStartupScript(GetType(), "LoginSayfasinaYonlendir_JS", "window.location = 'login.aspx';", true);

        Employee employee = Employee.Giris(SessionObjects.AccountObject.EmpId);

        var modulAdi = Request.QueryString["s"];

        if (String.IsNullOrEmpty(modulAdi))
            modulAdi = "anaSayfa";

        solUst.InnerHtml = solUstOlustur(employee);
        kullaniciSayfasiLabel.InnerHtml = kullaniciSayfaLabelOlustur();

        if (!(employee.MgrId>0))
            admin.InnerHtml = adminLabelOlustur();

        modulYukle(modulAdi);


    }

    private void modulYukle(string modulAdi)
    {
        placeHolderAna.Controls.Add(Page.LoadControl("KullaniciUIModuller\\" + modulAdi + ".ascx"));
    }

    public string solUstOlustur(Employee employee)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<a class=\"nav-link nav-profile d-flex align-items-center pe-0\" href=\"#\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">");
        //sb.Append("   <img  style=\"width: 45px; height: 45px;\"  src = \"profilFotoImages/" + SessionNesneleri.KullaniciObj.ProfilFoto + "\" alt=\"Profile\" class=\"rounded-circle\">");
        sb.Append("   <span class=\"d -none d-md-block dropdown-toggle ps-2\">" + employee.FirstName + " " + employee.LastName + "</span>");
        sb.Append("</a>");
        return sb.ToString();
    }

    public string kullaniciSayfaLabelOlustur()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<a class=\"nav-link collapsed\" href=\"Default.aspx?s=kullaniciSayfasi&id=" + SessionObjects.AccountObject.EmpId + "\">");
        sb.Append("  <i class=\"bi bi-layout-text-window-reverse\"></i>");
        sb.Append("  <span>My Informations</span>");
        sb.Append("</a>");

        return sb.ToString();
    }

    public string adminLabelOlustur()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<a class=\"nav-link collapsed\" href=\"Default.aspx?s=adminSayfasi\">");
        sb.Append("  <i class=\"bi bi-layout-text-window-reverse\"></i>");
        sb.Append("  <span>Manager Page</span>");
        sb.Append("</a>");

        return sb.ToString();
    }
}