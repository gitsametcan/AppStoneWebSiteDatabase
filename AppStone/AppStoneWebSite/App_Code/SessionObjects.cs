using System;
using System.Collections.Generic;
using System.Web;
using AppStoneLibrary.Tables;

/// <summary>
/// Summary description for SessionObjects
/// </summary>
public class SessionObjects
{
   
    public static Account AccountObject
    {
        get
        {
            if (HttpContext.Current.Session["AccountObject"] == null)
                HttpContext.Current.Session.Add("AccountObject", new Account());

            return (Account)HttpContext.Current.Session["AccountObject"];

        }


        set
        {
            HttpContext.Current.Session.Add("AccountObject", value);
        }
    }
}