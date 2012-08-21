using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using imob_app.dao;

namespace imob_app.client
{
    public partial class DetalheImovel : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            business.Imovel imov = new business.Imovel();
            dao.imovel imovel = imov.SelecionarImovel(Convert.ToInt32(Request.QueryString["Imovel"]));
            //CarregarImagens(imovel);
            CarregarDetalhes(imovel);
            CarregarCaracteristicas(imovel);
        }
        /*
        private void CarregarImagens(dao.imovel imovel)
        {
            dao.imobappEntities _ctx = new imobappEntities();

            if (imovel.imagem != null && imovel.imagem.Count > 0)
                galeria.DataSource = imovel.imagem;
            else
            {
                dao.imagem img = new imagem();
                img.ds_imagem = "Sem imagem";
                img.id_imagem = 0;

                galeria.DataSource = new List<dao.imagem>() { img };
            }
        }*/

        private void CarregarDetalhes(dao.imovel imovel)
        {
            lblImovel.Text = imovel.categoria.ds_item + " - " + imovel.dormitorio.ds_item + "dorm(s)";
            lblCidade.Text = lblCidade.Text + imovel.bairro.municipio.nm_municipio + " - " + imovel.bairro.municipio.estado.cd_estado;
            lblValor.Text = lblValor.Text + String.Format("{0:C}", imovel.vl_imovel);            
            lblCondominio.Text = lblCondominio.Text + String.Format("{0:C}", imovel.vl_condominio);
            lblIPTU.Text = lblIPTU.Text + String.Format("{0:C}", imovel.vl_iptu);
            lblID.Text = lblID.Text + imovel.id_imovel;
            lblPadrao.Text = lblPadrao.Text + imovel.padrao.ds_item;
            lblPosicao.Text = imovel.posicaoimovel.ds_item;
            lblEstadoImovel.Text = imovel.estadoimovel.ds_item;
            lblBanheiro.Text = lblBanheiro.Text + imovel.qt_banheiro;
            lblSuite.Text = imovel.qt_suite.ToString();
            lblArea.Text = imovel.vl_area_util.ToString() + "m² Útil -" + imovel.vl_area_total.ToString() + "m² Total";
            lblGaragem.Text = lblGaragem.Text + imovel.garagem.ds_item;
            lblPortaria.Text = lblPortaria.Text + (imovel.ic_portaria == true ? "Sim" : "Não");
            lblElevador.Text = lblElevador.Text + (imovel.ic_elevador == true ? "Sim" : "Não");
            lblVazio.Text = lblVazio.Text + (imovel.ic_vazio == true ? "Sim" : "Não");
            lblFinanciamento.Text = lblFinanciamento.Text + (imovel.ic_financiamento == true ? "Sim" : "Não");
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
            DataTable dt = new DataTable("NaoInformado");
            dt.Columns.Add("ds_item");
            DataRow dr = dt.NewRow();
            dr["ds_item"] = "Não Informado";
            dt.Rows.Add(dr);

            dataList.DataSource = source;                        
            dataList.DataBind();

            if(dataList.Items.Count == 0)
                dataList.DataSource = dt;

            dataList.DataBind();
        }
    }
}