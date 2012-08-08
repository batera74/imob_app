using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace imob_app.client.controls
{
    public partial class galeria : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DataSource != null)
            {
                dtlMini.DataSource = DataSource;
                dtlMini.DataBind();
            }
        }

        public IEnumerable DataSource
        {
            get;
            set;
        }
    }
}