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

 

        /*Kullanici kullanici = Kullanici.Getir(SessionNesneleri.KullaniciObj.Id);

        takipEdilenler.InnerHtml = divIcerikTakipEdilenler(kullanici);
        takipEdenler.InnerHtml = divIcerikTakipEdenler(kullanici);
        fotovead.InnerHtml = adVeFotoAyarla(kullanici);
        fotoVeBilgi.InnerHtml = fotoVeBilgiGuncelle(kullanici);
        */


    }

    private string fotoVeBilgiGuncelle(Employee employee)
    {
        StringBuilder sb = new StringBuilder();

        //AD
        sb.Append("<div class=\"row mb-3\">");
        sb.Append("    <label for=\"txtAd\" class=\"col-md-4 col-lg-3 col-form-label\">İsim</label>");
        sb.Append("    <div class=\"col-md-8 col-lg-9\">");
        sb.Append("        <input name = \"txtAd\" type=\"text\" class=\"form-control\" id=\"txtAd\" value=\"" + employee.FirstName + "\">");
        sb.Append("    </div>");
        sb.Append("</div>");
        //Soyad
        sb.Append("<div class=\"row mb-3\">");
        sb.Append("    <label for=\"txtSoyad\" class=\"col-md-4 col-lg-3 col-form-label\">Soyisim</label>");
        sb.Append("    <div class=\"col-md-8 col-lg-9\">");
        sb.Append("        <input name = \"txtSoyad\" type=\"text\" class=\"form-control\" id=\"txtSoyad\" value=\"" + employee.LastName + "\">");
        sb.Append("    </div>");
        sb.Append("</div>");
        //Mail
        sb.Append("<div class=\"row mb-3\">");
        sb.Append("    <label for=\"txtMail\" class=\"col-md-4 col-lg-3 col-form-label\">Email</label>");
        sb.Append("    <div class=\"col-md-8 col-lg-9\">");
        sb.Append("        <input name = \"txtMail\" type=\"text\" class=\"form-control\" id=\"txtMail\" value=\"" + employee.Street + "\">");
        sb.Append("    </div>");
        sb.Append("</div>");
        //Buton
        sb.Append("<div class=\"text-center\">");
        sb.Append("    <button type = \"submit\" class=\"btn btn-primary\" onclick=\"kaydet(" + employee.City + ");\">Güncelle</button>");
        sb.Append("</div>");

        return sb.ToString();
    }

}