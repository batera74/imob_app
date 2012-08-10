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
    public partial class DetalheImovel : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            business.Imovel imov = new business.Imovel();
            dao.imovel imovel = imov.SelecionarImovel(Convert.ToInt32(Request.QueryString["Imovel"]));
            CarregarImagens(imovel);
            CarregarDetalhes(imovel);
            CarregarCaracteristicas(imovel);
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
            lblImovel.Text = imovel.categoria.ds_item + " - " + imovel.dormitorio.ds_item + "dorm(s)";
            lblCidade.Text = lblCidade.Text + imovel.bairro.municipio.nm_municipio + " - " + imovel.bairro.municipio.estado.cd_estado;
            lblValor.Text = lblValor.Text + String.Format("{0:C}", imovel.vl_imovel);
            lblCondominio.Text = lblCondominio.Text + String.Format("{0:C}", imovel.vl_condominio);
            lblIPTU.Text = lblIPTU.Text + String.Format("{0:C}", imovel.vl_iptu);
            lblID.Text = lblID.Text + imovel.id_imovel;
            lblBanheiro.Text = lblBanheiro.Text + imovel.ds_banheiro;
            lblGaragem.Text = lblGaragem.Text + imovel.ds_garagem;
            lblPortaria.Text = lblPortaria.Text + imovel.ds_portaria;
            lblElevador.Text = lblElevador.Text + (imovel.ic_elevador == true ? "Sim" : "Não");
            lblVazio.Text = lblVazio.Text + (imovel.ic_vazio == true ? "Sim" : "Não");
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