using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imob_app.client
{
    public partial class DetalheImovel : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            business.Imovel imov = new business.Imovel();
            dao.imovel imovel = imov.SelecionarImov(Convert.ToInt32(Request.QueryString["Imovel"]));
            CarregarImagens(imovel);
            CarregarDetalhes(imovel);
            CarregarCaracteristicas(imovel);
        }
        
        private void CarregarImagens(dao.imovel imovel)
        {
            dtlMini.DataSource = imovel.imagem;
            dtlMini.DataBind();
        }

        private void CarregarDetalhes(dao.imovel imovel)
        {
            lblImovel.Text = imovel.categoria.ds_item;
            lblCidade.Text = lblCidade.Text + imovel.bairro.municipio.nm_municipio + " - " + imovel.bairro.municipio.estado.cd_estado;
            lblValor.Text = lblValor.Text + String.Format("{0:C}", imovel.vl_imovel);
            lblCondominio.Text = lblCondominio.Text + String.Format("{0:C}", imovel.vl_condominio);
            lblIPTU.Text = lblIPTU.Text + String.Format("{0:C}", imovel.vl_iptu);
            lblID.Text = lblID.Text + imovel.id_imovel;
            lblBanheiro.Text = lblBanheiro.Text + imovel.ds_banheiro;
            lblGaragem.Text = lblGaragem.Text + imovel.ds_garagem;
            lblPortaria.Text = lblPortaria.Text + imovel.ds_portaria;
            lblElevador.Text = lblElevador.Text + imovel.ic_elevador;
            lblVazio.Text = lblVazio.Text + imovel.ic_vazio;
        }

        private void CarregarCaracteristicas(dao.imovel imovel)
        {
            dtAcabamento.DataSource = imovel.acabamento;
            dtAcabamento.DataBind();

            dtArmarios.DataSource = imovel.armario;
            dtArmarios.DataBind();

            dtIntima.DataSource = imovel.intima;
            dtIntima.DataBind();

            dtLazer.DataSource = imovel.lazer;
            dtLazer.DataBind();

            dtServicos.DataSource = imovel.servico;
            dtServicos.DataBind();

            dtSocial.DataSource = imovel.social;
            dtSocial.DataBind();
        }

        protected void dtlMini_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            Image img = (Image)e.Item.FindControl("Imagem");
            dao.imagem imagem = ((dao.imagem)e.Item.DataItem);
            img.ImageUrl = "../Imagem.ashx?idFoto=" + imagem.id_imagem;
        }
    }
}