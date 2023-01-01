using AjaxPro;
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

        /*Kullanici kullanici = Kullanici.Getir(SessionNesneleri.KullaniciObj.Id);

        takipEdilenler.InnerHtml = divIcerikTakipEdilenler(kullanici);
        takipEdenler.InnerHtml = divIcerikTakipEdenler(kullanici);
        fotovead.InnerHtml = adVeFotoAyarla(kullanici);
        fotoVeBilgi.InnerHtml = fotoVeBilgiGuncelle(kullanici);
        */
        
    }
}