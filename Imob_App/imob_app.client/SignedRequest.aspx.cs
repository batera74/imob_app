﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imob_app.client
{
    public partial class SignedRequest : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSignedRequest.Text = Request.Form["signed_request"];
        }
    }
}