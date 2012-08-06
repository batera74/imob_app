<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="imob_app.client._Default" %>
<%@ Register TagPrefix="slider" TagName="Slider" Src="~/controls/slider.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="conteudo" runat="server">

<!-- Main PAge Slider -->
    <div class="flex_slider_home">
        <slider:Slider runat="server" ID="slider" />
    </div>
    <!-- Content -->
    <section id="content">
	<div class="container_24">
    	<div class="wrapper vr-separator-2">
        	<article class="grid_5 vr-separator-1">
            	<div class="top-box">
                	<img src="images/page1-icon1.gif" alt="" class="img-indent-bot">
                    <h5 class="head-1"><strong>Tudo</strong><b>Online</b></h5>
                    <ul class="list-1 pad-left">
                    	<li><a href="more.html">Texto 1</a></li>
                        <li><a href="more.html">Texto 2</a></li>
                        <li><a href="more.html">Texto 3</a></li>
                    </ul>
                    <a href="more.html" class="button">Ver mais ></a>
                </div>
            </article>
            <article class="grid_5 vr-separator-1">
            	<div class="top-box">
                	<img src="images/page1-icon2.gif" alt="" class="img-indent-bot">
                    <h5 class="head-1"><strong>Seguranca</strong><b>no Pagamento</b></h5>
                    <ul class="list-1 pad-left">
                    	<li><a href="more.html">Texto 1</a></li>
                        <li><a href="more.html">Texto 2</a></li>
                        <li><a href="more.html">Texto 3</a></li>
                    </ul>
                    <a href="more.html" class="button">Ver mais ></a>
                </div>
            </article>
            <article class="grid_5 vr-separator-1">
            	<div class="top-box">
                	<img src="images/page1-icon3.gif" alt="" class="img-indent-bot">
                    <h5 class="head-1"><strong>Atendimento</strong><b>24 horas</b></h5>
                                        <ul class="list-1 pad-left">
                    	<li><a href="more.html">Texto 1</a></li>
                        <li><a href="more.html">Texto 2</a></li>
                        <li><a href="more.html">Texto 3</a></li>
                    </ul>
                    <a href="more.html" class="button">Ver mais ></a>
                </div>
            </article>
            <article class="grid_5 vr-separator-1">
            	<div class="top-box">
                	<img src="images/page1-icon4.gif" alt="" class="img-indent-bot">
                    <h5 class="head-1"><strong>Tudo no</strong><b>seu Celular</b></h5>
                    <ul class="list-1 pad-left">
                    	<li><a href="more.html">Texto 1</a></li>
                        <li><a href="more.html">Texto 2</a></li>
                        <li><a href="more.html">Texto 3</a></li>
                    </ul>
                    <a href="more.html" class="button">Ver mais ></a>
                </div>
            </article>
        </div>
        <div class="border-bot-1"></div>
        <div class="wrapper vr-border-1">
        	<article class="grid_12">
            	<div class="pad-right">
                	<h3 class="head-1 hp-1">Oportunidades <i>Imperdiveis</i></h3>
                    <dl class="def-list-1">
                    	<dt>Apartamento 3 dorm - Sao Paulo</dt>
                        <dd>
							<div class="img_apto">
								<img src="images/apto_exemplo.jpg" alt="">
							</div>
							<div>
                        		Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliqudo consequat.
                            	<br>
                            	</br>
								<br>
								</br>
								<a href="more.html" class="link">Quero saber +</a>
								<br>
								</br>								
							</div>
                        </dd>
                        <dt>Lancamento Imperdivel - Santos</dt>
                        <dd>
							<div class="img_apto">
								<img src="images/apto_exemplo.jpg" alt="">
							</div>
							<div>
                        		Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliqudo consequat.
                            	<br>
                            	</br>
								<br>
								</br>
								<a href="more.html" class="link">Quero saber +</a>
								<br>
								</br>								
							</div>
                        </dd>

                        <dt>Apartamento 2 dorm - Guaruja</dt>
                        <dd>
							<div class="img_apto">
								<img src="images/apto_exemplo.jpg" alt="">
							</div>
							<div>
                        		Consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliqudo consequat.
                            	<br>
                            	</br>
								<br>
								</br>
								<a href="more.html" class="link">Quero saber +</a>
								<br>
								</br>								
							</div>
                        </dd>                        
                    </dl>
                    <a href="more.html" class="button">Ver todos ></a>
                </div>
            </article>
            <article class="grid_7">
            	<h3 class="head-1">Cadastre-se <em class="heading-row"><i>e receba novidades</i>dos imoveis.</em><em class="heading-row-2">Mude sua vida!</em></h3>
                <div id="accept-card-form" method="get">
                	<div class="row-1">
                    	<input type="text" onBlur="if(this.value==''){this.value='Nome *'}" onFocus="if(this.value=='Nome *'){this.value=''}" value="Nome *" name="F_Name">
                    </div>					
                    <div class="row-1">
                    	<input type="text" onBlur="if(this.value==''){this.value='Sobrenome *'}" onFocus="if(this.value=='Sobrenome *'){this.value=''}" value="Sobrenome *" name="L_Name">
                    </div>
<!--
                    <div class="row-1">
                    	<input type="text" onBlur="if(this.value==''){this.value='Business Name *'}" onFocus="if(this.value=='Business Name *'){this.value=''}" value="Business Name *" name="B_Name">
                    </div>
-->
                    <div class="row-1">
                    	<input type="text" onBlur="if(this.value==''){this.value='Cidade *'}" onFocus="if(this.value=='Cidade *'){this.value=''}" value="Cidade *" name="City">
                    </div>

                    <div class="row-1">
                    	<select name="Estado">
                        	<option>Estado *</option>
                            <option>SP</option>
                            <option>RJ</option>
                        </select>
                    </div>
                    <div class="row-1">
                    	<input type="text" onBlur="if(this.value==''){this.value='CEP  *'}" onFocus="if(this.value=='CEP  *'){this.value=''}" value="CEP  *" name="zip">
                    </div>
                    <div class="row-1">
                    	<input type="text" onBlur="if(this.value==''){this.value='Telefone Preferencial *'}" onFocus="if(this.value=='Telefone Preferencial *'){this.value=''}" value="Telefone Preferencial *" name="phone">
                    </div>
                    <div class="row-1">
                    	<input type="text" onBlur="if(this.value==''){this.value='E-Mail *'}" onFocus="if(this.value=='E-Mail *'){this.value=''}" value="E-Mail *" name="email">
                    </div>
                    <div class="row-2">
                    	Aceita receber informativos do site? *
                    </div>
                    <div class="row-3">
                    	<div class="col-1">
                        	<input type="radio" name="rdio-1">
                            <label class="radio-button-label">
                            	Sim 
                        	</label>
                        </div>
                        <div class="col-1">
                           	<input type="radio" name="rdio-1">
                            <label class="radio-button-label">
                                Não
                            </label>
                        </div>
                    </div>
                    <a onClick="document.getElementById('accept-card-form').submit()" class="button">Enviar ></a>
                </div>
            </article>
        </div>
    </div>
</section>

</asp:Content>
