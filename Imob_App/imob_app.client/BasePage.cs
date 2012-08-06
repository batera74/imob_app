using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace imob_app.client
{
    public class BasePage : System.Web.UI.Page
    {
        public void Alert(string message)
        {
            ClientScript.RegisterClientScriptBlock(this.GetType(), "PopupScript", "<script language=\"javascript\">alert('" + message + "');</script>");
        }
    }
}