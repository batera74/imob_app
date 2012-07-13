<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="imob_app.client._Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Imob App - Facebook</title>
    <meta charset="utf-8">
    <meta name="description" content="Your description">
    <meta name="keywords" content="Your keywords">
    <meta name="author" content="Your name">
    <link rel="stylesheet" href="css/style.css">
    <script src="js/jquery-1.7.1.min.js"></script>
    <script src="js/cufon-yui.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_300.font.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_400.font.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_500.font.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_700.font.js"></script>
    <script src="js/Kozuka_Gothic_Pro_OpenType_900.font.js"></script>
    <script src="js/cufon-replace.js"></script>
    <script src="js/script.js"></script>
    <!--[if lt IE 8]>
   <div style=' clear: both; text-align:center; position: relative;'>
     <a href="http://windows.microsoft.com/en-US/internet-explorer/products/ie/home?ocid=ie6_countdown_bannercode">
       <img src="http://storage.ie6countdown.com/assets/100/images/banners/warning_bar_0000_us.jpg" border="0" height="42" width="820" alt="You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today." />
    </a>
  </div>
<![endif]-->
    <!--[if lt IE 9]>
	<script src="js/html5.js"></script>
	<link rel="stylesheet" href="css/ie.css"> 
<![endif]-->
</head>
<body>
    <!-- PRO Framework Panel Begin -->
    <!--
<div id="advanced"><span class="trigger"><strong></strong><em></em></span><div class="bg_pro"><div class="pro_main"><a href="" class="pro_logo"></a><ul class="pro_menu"><li><a href="index.html"><img src="images/pro_home.png" alt=""></a></li><li><a href="404.html">Pages<span></span></a><ul>	<li><a href="under_construction.html">Under Construction</a></li><li><a href="intro.html">Intro Page</a></li><li><a href="404.html">404 page</a></li></ul></li><li><a href="layouts.html">Layouts</a></li><li><a href="typography.html">Typography</a></li><li><a href="portfolio.html">Gallery Layouts<span></span></a><ul><li><a href="portfolio.html">Portfolio</a></li><li><a href="just-slider.html">Sliders</a><ul><li><a href="just-slider.html">Just Slider</a></li><li><a href="kwicks.html">Kwicks Slider</a></li><li><a href="functional-slider.html">Functional Slider</a></li></ul></li><li><a href="gallery-page1.html">Gallery</a></li></ul></li><li><a href="misc.html">Extras<span></span></a><ul><li><a href="social_media.html">Social and Media<br> Sharing</a></li><li><a href="css3.html">CSS3 Tricks</a></li><li><a href="misc.html">Misc</a></li></ul></li></ul><div class="clear"></div></div></div><div class="bg_pro2"></div></div>-->
    <!-- PRO Framework Panel End -->
    <!-- Header -->
    <div class="main">
        <header>
    	<div class="inner">
        	<div class="fright">
            	<strong class="header-text">
                	Fale com um de nossos corretores:
                </strong>
                <div class="header-phone">
                	+11 43211234
                </div>
            </div>
        	<a href="index.html" class="logo">ImobApp Facebook</a>
        </div>
        <nav>
        	<ul class="sf-menu">
            	<li class="current"><a href="index.html">Home</a></li>
                <li><a href="index-1.html">ImobApp</a>
                	<ul>
                    	<li><a href="more.html">Link 1</a></li>
                        <li><a href="more.html">Link 2</a></li>
                        <li><a href="more.html">Linke 3</a></li>
                    </ul>
                </li>
                <li><a href="index-2.html">Comprar</a></li>
                <li><a href="index-3.html">Anunciar</a></li>
                <li><a href="index-4.html">Servicos</a></li>
                <li><a href="index-6.html">Atendimento</a></li>
            </ul>
        </nav>
    </header>
    </div>
    <!-- Tabs Pesquisa -->
    <div class="tabs_pesquisa">
        <div class="tabs-horz-top">
            <ul class="tabs-nav">
                <li><a href="">pesquisa</a></li>
                <li><a href="">pesquisa avançada</a></li>
            </ul>
            <div class="tab-content">
                <form id="search2">
                <input type="text" onblur="if(this.value==''){this.value='Ex Código: 598752      Ex Nome: Edifício Guanumbis      Ex Endereço: Vila Olímpia - São Paulo'}"
                    onfocus="if(this.value=='Ex Código: 598752      Ex Nome: Edifício Guanumbis      Ex Endereço: Vila Olímpia - São Paulo'){this.value=''}"
                    value="Ex Código: 598752      Ex Nome: Edifício Guanumbis      Ex Endereço: Vila Olímpia - São Paulo"
                    name="search">
                <a class="btn">Pesquisar</a>
                </form>
            </div>
            <div class="tab-content" style="height: 255px;">
                <form id="form2" runat="server">
                <label>
                    <select style="width: 50px">
                        <option>UF *</option>
                        <option>SP</option>
                        <option>RJ</option>
                    </select>
                    <select style="width: 195px;">
                        <option>Região *</option>
                        <option>Grande São Paulo</option>
                        <option>Alphaville e Região</option>
                        <option>Litoral</option>
                    </select>
                    <select style="width: 195px">                    
                        <option>Cidade *</option>
                        <option>São Paulo</option>
                        <option>Osasco</option>
                        <option>Santos</option>
                    </select>
                    <select style="width: 170px">
                        <option>Bairro *</option>
                        <option>Vila Mariana</option>
                        <option>Vila Olímpia</option>
                        <option>Itaim Bibi</option>
                    </select>
                </label>
                <label>
                    <select style="width: 130px">
                        <option>Dormitórios *</option>
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                    </select>
                    <select style="width: 130px">
                        <option>Tipo *</option>
                        <option>Casa</option>
                        <option>Apartamento</option>
                        <option>Comercial</option>
                    </select>
                </label>
                <label>
                    <span class="text-form fleft">Valores:</span>
                </label>
                <label>
                    <input type="text" onblur="if(this.value==''){this.value='DE: Ex 150000 *'}" onfocus="if(this.value='DE: Ex 150000 *'){this.value=''}"
                        value="DE: Ex 150000 *" name="valor1" />
                </label>
                <label>
                    <input type="text" onblur="if(this.value==''){this.value='ATÉ: Ex 250000 *'}" onfocus="if(this.value='ATÉ: Ex 250000 *'){this.value=''}"
                        value="ATÉ: Ex 250000 *" name="valor2" />
                </label>
                <label>
                    <div class="fright" style="margin-top: 15px;">
                        <a class="btn">Pesquisar</a>
                    </div>
                </label>
                </form>
            </div>
        </div>
    </div>
    <!-- Main PAge Slider -->
    <div id="mp_slider">
        <div class="mp_slider">
            <ul class="items">
                <li>
                    <img src="images/slide1.jpg" alt="">
                    <!--<div class="banner b-1"><a href="more.html" class="banner-button-1"><strong>Comprar</strong></a></div>-->
                </li>
                <li>
                    <img src="images/slide2.jpg" alt="">
                    <!--<div class="banner b-2"><a href="more.html" class="banner-button-2"><strong>Comprar</strong></a></div>-->
                </li>
                <li>
                    <img src="images/slide3.jpg" alt="">
                    <!--<div class="banner b-2"><a href="more.html" class="banner-button-2"><strong>Comprar</strong></a></div>-->
                </li>
            </ul>
        </div>
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
                            	</br>
								</br>
								<a href="more.html" class="link">Quero saber +</a>
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
                            	</br>
								</br>
								<a href="more.html" class="link">Quero saber +</a>
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
                            	</br>
								</br>
								<a href="more.html" class="link">Quero saber +</a>
								</br>								
							</div>
                        </dd>                        
                    </dl>
                    <a href="more.html" class="button">Ver todos ></a>
                </div>
            </article>
            <article class="grid_7">
            	<h3 class="head-1">Cadastre-se <em class="heading-row"><i>e receba novidades</i>dos imoveis.</em><em class="heading-row-2">Mude sua vida!</em></h3>
                <form id="accept-card-form" method="get">
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
                    	Voce deseja receber as novidades do site? *
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
                </form>
            </article>
        </div>
    </div>
</section>
    <!-- Footer -->
    <footer>
	<div class="fright">
    	ImobApp  &copy; 2012 <a href="index-7.html">Politca de Privacidade</a>
        <div class="alignright">
        	<!-- {%FOOTER_LINK} -->
        </div>
    </div>
    <ul class="footer-nav">
    	<li><a class="current" href="index.html">Home</a></li>
        <li><a href="index-1.html">ImobApp</a></li>     
        <li><a href="index-2.html">Comprar</a></li>     
        <li><a href="index-3.html">Anunciar</a></li>   
        <li><a href="index-4.html">Servicos</a></li>   
        <li><a href="index-5.html">Central de Atendimento</a></li>  
    </ul>
</footer>
    <script>
        Cufon.now();
    </script>
    <script type="text/javascript">
        var _gaq = _gaq || [];
        _gaq.push(['_setAccount', 'UA-7078796-5']);
        _gaq.push(['_trackPageview']);
        (function () {
            var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
            ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
        })();

    </script>
</body>
</html>
