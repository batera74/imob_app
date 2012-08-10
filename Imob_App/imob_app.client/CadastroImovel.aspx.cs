using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using imob_app.dao;

namespace imob_app.client
{
    public partial class CadastroImovel : System.Web.UI.Page
    {
        private int idImovel;

        protected void Page_Load(object sender, EventArgs e)
        {
            //idImovel = Convert.ToInt32(Request.QueryString["Imovel"]);
            idImovel = 1;
            business.Imovel imov = new business.Imovel();            
            dao.imovel imovel = imov.SelecionarImovel(Convert.ToInt32(1));
            CarregarImagens(imovel);
            CarregarDetalhes(imovel);
            CarregarCaracteristicas(imovel);
        }

        private void CarregarCombosPesquisa()
        {
            business.Combo<dao.estado>.CarregarCombo(ref ddlUF, new business.Estado(), "cd_estado", "id_estado", "UF *");
            business.Combo<dao.municipio>.CarregarCombo(ref ddlMunicipio, new business.Municipio(), "nm_municipio", "id_municipio", "Município *");
            business.Combo<dao.bairro>.CarregarCombo(ref ddlBairro, new business.Bairro(), "nm_bairro", "id_bairro", "Bairro *");
            business.Combo<dao.dormitorio>.CarregarCombo(ref ddlDormitorios, new business.Dormitorio(), "ds_item", "id", "Dormitorios *");
            business.Combo<dao.categoria>.CarregarCombo(ref ddlCategoria, new business.Categoria(), "ds_item", "id", "Tipo *");
        }

        private void CarregarImagens(dao.imovel imovel)
        {
            dao.imobappEntities _ctx = new imobappEntities();

            if (imovel.imagem != null || imovel.imagem.Count > 0)
                galeria.DataSource = imovel.imagem;
            else
            {
                var query = from i in _ctx.imagem where i.id_imagem == 1 select i;
                galeria.DataSource = query;
            }
        }

        private void CarregarDetalhes(dao.imovel imovel)
        {
            if (idImovel > 0)
            {
                ddlCategoria.SelectedValue = imovel.categoria.id.ToString();
                ddlUF.SelectedValue = imovel.bairro.municipio.estado.id_estado.ToString();
                ddlMunicipio.SelectedValue = imovel.bairro.municipio.id_municipio.ToString();
                ddlBairro.SelectedValue = imovel.bairro.id_bairro.ToString();
                txtValor.Text = imovel.vl_imovel.ToString();
                txtValorCondominio.Text = imovel.vl_condominio.ToString();
                txtValorIptu.Text = imovel.vl_iptu.ToString();
                txtId.Text = imovel.id_imovel.ToString();
                txtBanheiros.Text = imovel.ds_banheiro;
                txtGaragem.Text = imovel.ds_garagem;
                ddlPortaria.SelectedValue = Convert.ToInt32(imovel.ic_elevador).ToString();
                ddlElevador.SelectedValue = Convert.ToInt32(imovel.ic_elevador).ToString();
                ddlVazio.SelectedValue = Convert.ToInt32(imovel.ic_vazio).ToString();
            }
        }

        private void CarregarCaracteristicas(dao.imovel imovel)
        {
            CarregarDataListCaracteristicas(dtAcabamento, imovel.acabamento);
            CarregarDataListCaracteristicas(dtArmarios, imovel.armario);
            CarregarDataListCaracteristicas(dtIntima, imovel.intima);
            CarregarDataListCaracteristicas(dtLazer, imovel.lazer);
            CarregarDataListCaracteristicas(dtServicos, imovel.servico);
            CarregarDataListCaracteristicas(dtSocial, imovel.social);
        }

        private void CarregarDataListCaracteristicas(DataList dataList, IEnumerable source)
        {
            List<string> nInformado = new List<string>() { "Não Informado" };

            if (source != null)
                dataList.DataSource = source;
            else
                dataList.DataSource = nInformado;

            dataList.DataBind();
        }
    }
}