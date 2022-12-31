using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppStoneLibrary.Tables;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        welcome.InnerHtml = "Welcome " + SessionObjects.EmployeeObject.Email;
    }
}