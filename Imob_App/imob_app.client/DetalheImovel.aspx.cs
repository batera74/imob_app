﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imob_app.client
{
    public partial class DetalheImovel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            business.Imovel imov = new business.Imovel();
            dao.imovel imovel = imov.Selecionar(Convert.ToInt32(Request.QueryString["idImovel"]));
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
            lblCidade.Text = imovel.bairro.municipio.nm_municipio;
            lblValor.Text = lblValor.Text + imovel.vl_imovel;
            lblCondominio.Text = lblCondominio.Text + imovel.vl_condominio;
            lblIPTU.Text = lblIPTU.Text + imovel.vl_iptu;
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
    }
}