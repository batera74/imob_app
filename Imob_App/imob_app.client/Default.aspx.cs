using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using imob_app.business;
using imob_app.dao;

namespace imob_app.client
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CarregarCombosPesquisa();

        }

        private void CarregarCombosPesquisa()
        {
            business.Combo combo = new business.Combo();
            combo.CarregarCombo(ref ddlUF, new business.Estado(), "cd_estado", "id_estado", "UF *");
            combo.CarregarCombo(ref ddlMunicipio, new business.Municipio(), "nm_municipio", "id_municipio", "Município *");
            combo.CarregarCombo(ref ddlBairro, new business.Bairro(), "nm_bairro", "id_bairro", "Bairro *");
            combo.CarregarCombo(ref ddlDormitorios, new business.Dormitorio(), "ds_item", "id", "Dormitorios *");
            combo.CarregarCombo(ref ddlTipo, new business.Tipo(), "ds_item", "id", "Tipo *");
        }

        protected void ddlUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            business.Combo combo = new business.Combo();
            combo.CarregarCombo(ref ddlMunicipio, new business.Municipio(),
                "nm_municipio", "id_municipio", "Municipio *", Convert.ToInt16(ddlUF.SelectedValue));
        }

        protected void ddlMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            business.Combo combo = new business.Combo();
            combo.CarregarCombo(ref ddlBairro, new business.Bairro(),
                "nm_bairro", "id_bairro", "Bairro *", Convert.ToInt16(ddlMunicipio.SelectedValue));
        }
    }
}