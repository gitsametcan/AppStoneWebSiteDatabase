using AjaxPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SametLibrary.Genel;

[AjaxNamespace("TAKIPLESME_AJAX")]
public partial class KullaniciUIModuller_takiplesme : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Utility.RegisterTypeForAjax(typeof(KullaniciUIModuller_takiplesme), Page);

        /*Kullanici kullanici = Kullanici.Getir(SessionNesneleri.KullaniciObj.Id);

        var qry = Request.QueryString["query"];

        var sayfaNo = GenelParser.ParseInt(Request.QueryString["sayfaNo"]);

        int toplamKayitSayisi = 0;

        List<Kullanici> liste = (String.IsNullOrEmpty(qry) ?
            Kullanici.TakipEdilmeyenKullanicilariGetir(SessionNesneleri.KullaniciObj.Id, ref toplamKayitSayisi) :
            AramaMotoru.KullaniciAra(qry, sayfaNo, Sabitler._sayfadakiKayitSayisi, ref toplamKayitSayisi));

        kisiler.InnerHtml = Kullanici.ListedenTakiplesmeIcerikOlustur(liste, sayfaNo, SessionNesneleri.KullaniciObj);
        divPager.InnerHtml = PagerMotoru.PagerOlustur(toplamKayitSayisi, sayfaNo, "takiplesme", qry);

        divArama.InnerHtml = "<input type=\"text\" class=\"form-control\" id=\"aranacakKullanici\" placeholder=\"İçerik Ara\" title=\"Enter search keyword\" value=\"" + qry + "\" onkeypress=\"aramayaTikla(event);\"></input>";

        aramaButonu.InnerHtml = ("<button type=\"button\" id=\"aramaButonu\" class=\"btn btn-primary\" title=\"Search\" onclick=\"kullaniciAra();\">Arama</button>");*/
    }

    
}