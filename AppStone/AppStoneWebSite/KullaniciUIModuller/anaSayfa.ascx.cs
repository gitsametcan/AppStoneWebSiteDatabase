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

[AjaxNamespace("ANASAYFA_AJAX")]
public partial class KullaniciUIModuller_anaSayfa : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Utility.RegisterTypeForAjax(typeof(KullaniciUIModuller_anaSayfa), Page);

        Employee employee = Employee.Giris(SessionObjects.AccountObject.EmpId);

        List<long> projectIds = Project.Projects(employee.EmpId);

        StringBuilder sb = new StringBuilder();

        foreach (long ProjId in projectIds)
        {
            Project currProj = Project.Getir(ProjId);
            sb.Append(Project.projectHtml(currProj));
        }

        divIcerik.InnerHtml = sb.ToString();



        /*Kullanici kullanici = Kullanici.Getir(SessionNesneleri.KullaniciObj.Id);

        var qry = Request.QueryString["query"];

        var sayfaNo = GenelParser.ParseInt(Request.QueryString["sayfaNo"]);

        int toplamKayitSayisi = 0;

        List<KullaniciIcerik> liste = (String.IsNullOrEmpty(qry) ? 
            KullaniciIcerik.TakipEdilenIcerikleriGetir(SessionNesneleri.KullaniciObj.Id, ref toplamKayitSayisi) :
            AramaMotoru.icerikAra(qry, sayfaNo, Sabitler._sayfadakiKayitSayisi, ref toplamKayitSayisi)); 

        divIcerik.InnerHtml = KullaniciIcerik.ListedenAnaSayfaIcerikOlustur(liste, sayfaNo, SessionNesneleri.KullaniciObj);
        divPager.InnerHtml = PagerMotoru.PagerOlustur(toplamKayitSayisi, sayfaNo, "anaSayfa", qry);

        divArama.InnerHtml = "<input type=\"text\" class=\"form-control\" id=\"aranacakIcerik\" placeholder=\"İçerik Ara\" title=\"Enter search keyword\" value=\"" + qry + "\" onkeypress=\"aramayaTikla(event);\"></input>";

        aramaButonu.InnerHtml = ("<button type=\"button\" id=\"aramaButonu\" class=\"btn btn-primary\" title=\"Search\" onclick=\"icerikAra();\">Arama</button>");
        */
        //divIcerik.InnerHtml = divIcerikInnerHtmlOlustur(kullanici);
    }
    /*
    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public static AramaSonuc icerikBul(string bulunacak)
    {
        int toplamKayitSayisi = 0;

        List<KullaniciIcerik> icerikler = AramaMotoru.icerikAra(bulunacak, 0, Sabitler._sayfadakiKayitSayisi, ref toplamKayitSayisi);

        int pagerAdedi = (toplamKayitSayisi / Sabitler._sayfadakiKayitSayisi) + (toplamKayitSayisi % Sabitler._sayfadakiKayitSayisi > 0 ? 1 : 0);

        StringBuilder sb = new StringBuilder();

        icerikler = icerikler.Skip(0 * Sabitler._sayfadakiKayitSayisi).Take(Sabitler._sayfadakiKayitSayisi).ToList();

        foreach (KullaniciIcerik icerik in icerikler)
            sb.Append(KullaniciIcerik.icerikHtmlOlustur(icerik, SessionNesneleri.KullaniciObj.Id));

        AramaSonuc retVal = new AramaSonuc();

        retVal.Icerik = sb.ToString();
        retVal.PagerIcerik = PagerMotoru.PagerOlustur(toplamKayitSayisi, 0, "anaSayfa", bulunacak);

        return retVal;
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string modalOlustur(long id)
    {

        KullaniciIcerik icerik = KullaniciIcerik.Getir(id);

        StringBuilder sb = new StringBuilder();

        sb.Append("     <img class=\"img-fluid mr-3\" src=\"profilFotoImages/" + icerik.FotoPath + "\" alt=\"...\"/>");

        return sb.ToString();
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public static string icerikBegen(long icerikId)
    {
        KullaniciBegeni begeni = KullaniciBegeni.Getir(SessionNesneleri.KullaniciObj.Id, icerikId);

        if (begeni.Begenme != true)
        {
            begeni.Begenme = true;
            begeni.IcerikId = icerikId;
            begeni.KullaniciId = SessionNesneleri.KullaniciObj.Id;
            begeni.Kaydet();

            return "İçerik beğenildi";
        }
        else
            return "İçerik zaten beğenilmiş";

    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public static string icerikBegenme(long icerikId)
    {
        KullaniciBegeni begeni = KullaniciBegeni.Getir(SessionNesneleri.KullaniciObj.Id, icerikId);

        if (begeni.Id == -1 || begeni.Begenme != false)
        {
            begeni.Begenme = false;
            begeni.IcerikId = icerikId;
            begeni.KullaniciId = SessionNesneleri.KullaniciObj.Id;
            begeni.Kaydet();

            return "İçerik beğenilmedi";
        }
        else
            return "İçerik zaten beğenilmemiş";

    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public static string BegenmeleriOlustur(long icerikId)
    {
        StringBuilder sb = new StringBuilder();

        List<Kullanici> kullanicilar = KullaniciBegeni.BegenenBegenmeyenKullanicilariGetir(icerikId, false);

        foreach (Kullanici kullanici in kullanicilar)
            sb.Append(KullanicilariOlustur(kullanici));

        return sb.ToString();
 
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public static string BegenenleriOlustur(long icerikId)
    {
        StringBuilder sb = new StringBuilder();

        List<Kullanici> kullanicilar = KullaniciBegeni.BegenenBegenmeyenKullanicilariGetir(icerikId, true);

        foreach (Kullanici kullanici in kullanicilar)
            sb.Append(KullanicilariOlustur(kullanici));

        return sb.ToString();

    }

    public static string KullanicilariOlustur(Kullanici kullanici)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<div class=\"card-body\" style=\"border: 1px solid black\">");
        sb.Append("<div class=\"row mb-3\" style=\"border-bottom:1px\">");
        sb.Append("<div class=\"row\">");
        sb.Append("<div class=\"col-2\">");
        sb.Append(" <img style=\"width: 70px; height: 70px;\"  src = \"profilFotoImages/" + kullanici.ProfilFoto + "\"" +
            " class=\"avatar-img rounded-circle\" alt=\"...\"onclick=\"window.location = 'Default.aspx?s=kullaniciSayfasi&id=" + kullanici.Id + "';\">");
        sb.Append("</div>");
        sb.Append("<div class=\"col-7\">");
        sb.Append("<div style=\"cursor:pointer;\" onclick=\"window.location = 'Default.aspx?s=kullaniciSayfasi&id=" + kullanici.Id + "';\"> " + kullanici.Ad + " " + kullanici.Soyad + "</div>");

        sb.Append("</div>");
        sb.Append("<div class=\"col-3\">");
        sb.Append("</div>");
        sb.Append("</div>");
        sb.Append("</div>");
        sb.Append("</div>");
        sb.Append("<div class=\"row\">");
        sb.Append("<br/>");
        sb.Append("</div>");

        return sb.ToString();
    }*/

}