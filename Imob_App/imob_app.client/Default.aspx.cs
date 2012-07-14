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
            business.Combo combo = new business.Combo();
            combo.CarregarCombo(ref ddlUF, new business.Estado(), "cd_estado", "id_estado", "UF *");
            combo.CarregarCombo(ref ddlBairro, new business.Bairro(), "nm_bairro", "id_bairro", "Bairro *");
        }
    }
}