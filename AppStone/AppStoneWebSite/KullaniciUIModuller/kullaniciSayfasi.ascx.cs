using AjaxPro;
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
        /*
        Kullanici kullanici = Kullanici.Getir(GenelParser.ParseInt(Request.QueryString["id"]));
        //Kullanici kullanici = Kullanici.Getir(SessionNesneleri.KullaniciObj.Id);
        icerikBu.InnerHtml = divIcerikInnerHtmlOlustur(kullanici);
        fotovead.InnerHtml = adVeFotoAyarla(kullanici);
        kullaniciIsmi.InnerHtml = kullanici.Ad + " " + kullanici.Soyad;
        kullaniciMail.InnerHtml = kullanici.EPosta;
        */
    }

}