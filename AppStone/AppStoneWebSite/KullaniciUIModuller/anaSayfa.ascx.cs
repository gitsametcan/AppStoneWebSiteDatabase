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


    }
    

}