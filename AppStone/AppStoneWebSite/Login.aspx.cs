using AjaxPro;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppStoneLibrary.Tables;


[AjaxNamespace("LOGIN_AJAX")]
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Utility.RegisterTypeForAjax(typeof(Login), Page);
    }

    [AjaxMethod(HttpSessionStateRequirement.ReadWrite)]
    public string KullaniciGiris(string ePosta, string sifre)
    {

        SessionObjects.AccountObject = Account.Giris(ePosta, sifre);

        if (SessionObjects.AccountObject.EmpId <= 0)
            throw new Exception("Kullanıcı adı ve/veya şifre yanlış!");

        return "Default.aspx";
    }
}