using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using imob_app.business;

namespace imob_app.client
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarCombosPesquisa();
        }

        private void CarregarCombosPesquisa()
        {
            business.Estado estados = new business.Estado();
            ddlUF.Items.Clear();
            ddlUF.Items.Add(new ListItem("UF *", ""));
            ddlUF.AppendDataBoundItems = true;
            ddlUF.DataSource = estados.SelecionarTodos();
            ddlUF.DataTextField = "cd_estado";
            ddlUF.DataValueField = "id_estado";
            ddlUF.DataBind();
        }
    }
}