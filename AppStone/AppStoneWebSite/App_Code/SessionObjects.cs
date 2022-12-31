using System;
using System.Collections.Generic;
using System.Web;
using AppStoneLibrary.Tables;

/// <summary>
/// Summary description for SessionObjects
/// </summary>
public class SessionObjects
{
   
    public static Employee EmployeeObject
    {
        get
        {
            if (HttpContext.Current.Session["EmployeeObject"] == null)
                HttpContext.Current.Session.Add("EmployeeObject", new Employee());

            return (Employee)HttpContext.Current.Session["EmployeeObject"];

        }


        set
        {
            HttpContext.Current.Session.Add("EmployeeObject", value);
        }
    }
}