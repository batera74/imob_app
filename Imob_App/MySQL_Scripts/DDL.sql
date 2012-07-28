drop database if exists `imobapp`;
create database if not exists `imobapp`;

use `imobapp`;

drop table if exists `usuario`;
create table if not exists `usuario` (
 `id_usuario` smallint not null auto_increment primary key,
 `nm_usuario` varchar(70) not null,
 `cd_cpf` char(11) null,
 `cd_creci` varchar(7) not null,
 `ds_login_facebook` varchar(50) null,
 `ds_email` varchar(50) null,
 `ds_password` varchar(500),
 `ds_telefone1` varchar(20) null,
 `ds_tipo_telefone_1` varchar(40) null,
 `ds_telefone2` varchar(20) null,
 `ds_tipo_telefone_2` varchar(40) null
);

drop table if exists `pais`;
create table if not exists `pais` (
 `id_pais` smallint not null auto_increment primary key,
 `cd_pais`  char(2) not null,
 `nm_pais`  varchar(50) not null
);

drop table if exists `estado`;
create table if not exists `estado` (
 `id_estado` smallint not null auto_increment primary key,
 `id_pais` smallint not null,
 `cd_estado` char(2) not null ,
 `nm_estado` varchar(45) not null,
 foreign key (id_pais) references pais(id_pais)
);

drop table if exists `municipio`;
create table if not exists `municipio` (
 `id_municipio` smallint not null auto_increment primary key,
 `id_estado` smallint not null,
 `nm_municipio` varchar(45) not null,
 foreign key (id_estado) references estado(id_estado)   
);
 
drop table if exists `bairro`;
create table if not exists `bairro` (
 `id_bairro` smallint not null auto_increment primary key,
 `id_municipio` smallint not null,
 `nm_bairro` varchar(45) not null,
 foreign key (id_municipio) references municipio(id_municipio)
);


drop table if exists `categoria`;
create table if not exists `categoria` (
 `id` smallint not null auto_increment primary key,
 `ds_item` varchar(40) not null
);
  
drop table if exists `dormitorio`;
create table `dormitorio` (
 `id` smallint not null auto_increment primary key,
 `ds_item` smallint not null
);

drop table if exists `finalidade`;
create table if not exists `finalidade` (
 `id` smallint not null auto_increment primary key,
 `ds_item` varchar(40) not null
);

drop table if exists `estadoimovel`;
create table if not exists `estadoimovel` (
 `id` smallint not null auto_increment primary key,
 `ds_item` varchar(40) not null 
);

drop table if exists `posicaoimovel`;
create table if not exists `posicaoimovel` (
 id smallint not null auto_increment primary key,
 ds_item varchar(20) not null
);

drop table if exists `social`;
create table if not exists `social` (
 id smallint not null auto_increment primary key,
 ds_item varchar(40) null
);

drop table if exists `acabamento`;
create table if not exists `acabamento` (
 id smallint not null auto_increment primary key,
 ds_item varchar(40) null
);

drop table if exists `intima`;
create table if not exists `intima` (
 id smallint not null auto_increment primary key,
 ds_item varchar(40) null
);

drop table if exists `servico`;
create table if not exists `servico` (
 id smallint not null auto_increment primary key,
 ds_item varchar(40) null
);

drop table if exists `armario`;
create table if not exists `armario` (
 id smallint not null auto_increment primary key,
 ds_item varchar(40) null
);

drop table if exists `lazer`;
create table if not exists `lazer` (
 id smallint not null auto_increment primary key,
 ds_item varchar(40) null
);


drop table if exists `imovel`;
create table if not exists `imovel` (
 `id_imovel` smallint not null auto_increment primary key,
 `id_usuario` smallint not null,
 `id_finalidade` smallint not null,
 `id_categoria` smallint not null,
 `ds_padrao` varchar(50) null,
 `ds_endereco` varchar(60) not null,
 `ds_numero_endereco` varchar(10) not null,
 `ds_cep` char(8) null,
 `ds_complemento` varchar(20) not null,
 `id_bairro` smallint not null,
 `ds_garagem` varchar(30) null,
 `ds_portaria` varchar(30) null,
 `ds_situacao` varchar(60) null, 
 `id_estado_imovel` smallint not null,
 `id_dormitorio` smallint null,
 `qt_suite` smallint null,
 `id_posicao_imovel` smallint null,
 `ds_banheiro` varchar(80) null,
 `nm_edificio` varchar(40) null,
 `ic_financiamento` bit null,
 `vl_imovel` decimal not null,
 `vl_sem_comissao` decimal not null,
 `vl_iptu` decimal null,
 `vl_condominio` decimal null,
 `ic_vazio` bit null,
 `cd_registro` varchar(20) null,
 `ic_documentacao` bit null,
 `ic_elevador` bit null,
 `ds_local_chaves` varchar(40) null,
 `vl_area_util` decimal null,
 `vl_area_total` decimal null,
 `ic_destaque` bit null,
 `ic_ativo` bit null,
 `dt_post` date not null,
 foreign key (id_usuario) references usuario(id_usuario),    
 foreign key (id_finalidade) references finalidade(id),
 foreign key (id_categoria) references categoria(id),
 foreign key (id_bairro) references bairro(id_bairro),
 foreign key (id_estado_imovel) references estadoimovel(id), 
 foreign key (id_posicao_imovel) references posicaoimovel(id)
             
);

drop table if exists `imagem`;
create table if not exists `imagem` (
  `id_imagem` smallint not null auto_increment primary key,
  `ds_imagem_cripto` longtext collate latin1_general_ci not null,
  `ds_imagem` varchar(150) not null,
  `id_imovel` smallint not null,  
  `ic_principal` bit not null
);

drop table if exists `imovelsocial`;
create table if not exists `imovelsocial` (
 `id_imovel` smallint not null,
 `id_social` smallint not null,
 primary key(id_imovel,id_social),
 foreign key (id_imovel) references imovel(id_imovel),
 foreign key (id_social) references social(id)
);

drop table if exists `imovelacabamento`;
create table if not exists `imovelacabamento` (
 `id_imovel` smallint not null,
 `id_acabamento` smallint not null,
 primary key(id_imovel,id_acabamento),
 foreign key (id_imovel) references imovel(id_imovel),
 foreign key (id_acabamento) references acabamento(id)
);

drop table if exists `imovelintima`;
create table if not exists `imovelintima` (
 `id_imovel` smallint not null,
 `id_intima` smallint not null,
 primary key(id_imovel,id_intima),
 foreign key (id_imovel) references imovel(id_imovel),
 foreign key (id_intima) references intima(id)
);

drop table if exists `imovelservico`;
create table if not exists `imovelservico` (
 `id_imovel` smallint not null,
 `id_servico` smallint not null,
 primary key(id_imovel,id_servico),
 foreign key (id_imovel) references imovel(id_imovel),
 foreign key (id_servico) references servico(id)
);

drop table if exists `imovelarmario`;
create table if not exists `imovelarmario` (
 `id_imovel` smallint not null,
 `id_armario` smallint not null,
 primary key(id_imovel, id_armario),
 foreign key (id_imovel) references imovel(id_imovel),
 foreign key (id_armario) references armario(id)
);

drop table if exists `imovellazer`;
create table `imovellazer` (
 `id_imovel` smallint not null,
 `id_lazer` smallint not null,
 primary key(id_imovel, id_lazer),
 foreign key (id_imovel) references imovel(id_imovel),
 foreign key (id_lazer) references lazer(id)
);


drop table if exists `errolog`;
create table if not exists `errolog`
(
	`id_erro` smallint not null auto_increment primary key,
	`ds_erro` varchar(500),
	`dt_erro` datetime,
	`ds_stack` varchar(255),
	`ds_metodo` varchar(100)
	
);

drop table if exists `slider`;
create table if not exists `slider`
(
	`id_slider` smallint not null auto_increment primary key,
	`ds_path_imagem` varchar(255) not null,
	`ds_texto1` varchar(29) not null,
	`ds_texto2` varchar(24) not null,
	`ic_ativo` bit not null
);