﻿using AjaxPro;
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
        employees.InnerHtml = employeesHtml(employee);

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
    /*
    public static string kullaniciHtmlOlustur()
    {
        StringBuilder sb = new StringBuilder();

        List<Kullanici> kullanicilar = Kullanici.TumunuGetir();

        foreach (Kullanici kullanici in kullanicilar)
            sb.Append(kullaniciOlustur(kullanici));

        return sb.ToString();
    }

    public static string icerikHtmlOlustur()
    {
        StringBuilder sb = new StringBuilder();

        List<KullaniciIcerik> icerikler = KullaniciIcerik.TumunuGetir();

        foreach (KullaniciIcerik icerik in icerikler)
            sb.Append(icerikOlustur(icerik));

        return sb.ToString();
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public static string kullaniciOlustur(Kullanici kullanici)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<div class=\"card-body\" style=\"border: 1px solid black\">");
        sb.Append("<div class=\"row mb-3\" style=\"border-bottom:1px solid blue;\">");
        sb.Append("<div class=\"row\">");
        sb.Append("<div class=\"col-2\">");
        sb.Append(" <img style=\"width: 70px; height: 70px;\"  src = \"profilFotoImages/" + kullanici.ProfilFoto + "\"" +
            " class=\"avatar-img rounded-circle\" alt=\"...\"onclick=\"window.location = 'Default.aspx?s=kullaniciSayfasi&id=" + kullanici.Id + "';\">");
        sb.Append("</div>");
        sb.Append("<div class=\"col-7\">");
        sb.Append("<div style=\"cursor:pointer;\" onclick=\"window.location = 'Default.aspx?s=kullaniciSayfasi&id=" + kullanici.Id + "';\"> " + kullanici.Ad + " " + kullanici.Soyad + "</div>");


        sb.Append("</div>");
        sb.Append("<div class=\"col-3\">");

        //sb.Append("<div style=\"width:150px; height:55px; color:maroon; text-color:white\" onclick=\"takipEt(" + kullanici.Id+ ");\">Takip Et</div>");

        if (kullanici.IzinTarihi<DateTime.Now)
            sb.Append(" <button type=\"button\" class=\"btn btn-primary btn-block mb-4\" id=\"blokButonu_" + kullanici.Id + "\" onclick=\"modalGoster(" + kullanici.Id+");\">BLOKLA</button>");
        else
            sb.Append(" <button type=\"button\" class=\"btn btn-primary btn-block mb-4\" id=\"blokKaldirButonu_" + kullanici.Id + "\" onclick=\"blokKaldir(" + kullanici.Id + ");\">Blok Kaldır" +kullanici.IzinTarihi+ "</button>");
        sb.Append("</div>");
        sb.Append("</div>");
        sb.Append("</div>");
        sb.Append("</div>");
        sb.Append("<div class=\"row\">");
        sb.Append("<br/>");
        sb.Append("</div>");

        return sb.ToString();
    }

    public static string icerikOlustur(KullaniciIcerik icerik)
    {
        StringBuilder sb = new StringBuilder();
        Kullanici paylasanKullanici = Kullanici.Getir(icerik.KullaniciId);

        sb.Append("<div class=\"row mb-3\" \">");
        sb.Append(" <div class=\"col-1 div-padding\">");
        sb.Append("     <img style=\"width: 70px; height: 70px; margin:5px 5px\"  src = \"profilFotoImages/" + paylasanKullanici.ProfilFoto + "\"" +
            " class=\"avatar-img rounded-circle\" alt=\"...\"onclick=\"window.location = 'Default.aspx?s=kullaniciSayfasi&id=" + paylasanKullanici.Id + "';\">");
        sb.Append(" </div>");
        sb.Append(" <div class=\"col-9\">");
        sb.Append("     <div style=\"cursor:pointer;\" onclick=\"window.location = 'Default.aspx?s=kullaniciSayfasi&id=" + paylasanKullanici.Id + "';\"><h2>" + paylasanKullanici.Ad + "</h2></div>");
        if (icerik.FotoPath != "fotoYok")
            sb.Append("     <img id=\"img_" + icerik.Id + "\" class=\"img-fluid myImg\" src=\"profilFotoImages/" + icerik.FotoPath + "\" alt=\"...\" width=\"400\" height=\"200\" onclick=\"modalGostera(" + icerik.Id + ");\"/>");
        sb.Append("     <p>" + icerik.Icerik + "</p><br/>");
        sb.Append("     <div align=\"right\"><sub>" + icerik.Tarih + "</sub></div>");

        if (icerik.Aktif)
            sb.Append(" <button type=\"button\" class=\"btn btn-primary btn-block mb-4\" id=\"icerikblokButonu_" + icerik.Id + "\" onclick=\"icerikblokla(" + icerik.Id + ");\">BLOKLA</button>");
        else
            sb.Append(" <button type=\"button\" class=\"btn btn-primary btn-block mb-4\" id=\"icerikblokKaldirButonu_" + icerik.Id + "\" onclick=\"icerikblokKaldir(" + icerik.Id + ");\">Blok Kaldır</button>");

        sb.Append(" </div>");
        sb.Append(" <div class=\"col-2\">");
        sb.Append(" </div>");
        sb.Append("</div>");
        sb.Append("<br/>");

        return sb.ToString();
    }


    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public static string KullaniciBlokla(long kullaniciId, string blokTarihi)
    {
        Kullanici kullanici = Kullanici.Getir(kullaniciId);

        kullanici.IzinTarihi = GenelParser.ParseDateTime(blokTarihi);
        kullanici.Guncelle();
        return "Kullanıcı pasifleştirildi";
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public static string KullaniciBlokKaldir(long kullaniciId)
    {
        Kullanici kullanici = Kullanici.Getir(kullaniciId);

        kullanici.IzinTarihi = DateTime.Now;
        kullanici.Guncelle();
        return "Kullanıcı tekrar aktifleştirildi";
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public static string IcerikBlokla(long icerikId)
    {
        KullaniciIcerik icerik = KullaniciIcerik.Getir(icerikId);


        if (icerik.Aktif)
        {
            icerik.Aktif = false;
            icerik.Guncelle();
            return "İçerik pasifleştirildi";
        }
        else
        {
            icerik.Aktif = true;
            icerik.Guncelle();
            return "İçerik aktifleştirildi";
        }
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string modalOlustur(long id)
    {

        Kullanici kullanici = Kullanici.Getir(id);

        StringBuilder sb = new StringBuilder();

        sb.Append(id);

        sb.Append("<div class=\"row mb-3\">");
        sb.Append("     <label for=\"inputDate\" class=\"col-sm-2 col-form-lablel\">Bloklanacağı Tarih</label>");
        sb.Append("     <div class=\"col-sm-10\">");
        sb.Append("         <input type=\"date\" id=\"blokTarihi\" class=\"form-control\">");
        sb.Append("     </div>");
        sb.Append("</div>");
        sb.Append(" <button type=\"button\" class=\"btn btn-primary btn-block mb-4\" id=\"blokButonu_" + kullanici.Id + "\" onclick=\"blokla(" + kullanici.Id + ");\">BLOKLA</button>");

        return sb.ToString();
    }*/
}