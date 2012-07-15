DROP DATABASE IF EXISTS `ImobApp`;
CREATE DATABASE IF NOT EXISTS `ImobApp`;

USE `ImobApp`;

DROP TABLE IF EXISTS `Usuario`;
CREATE TABLE IF NOT EXISTS `Usuario` (
 `id_usuario` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `nm_usuario` VARCHAR(70) NOT NULL,
 `cd_cpf` CHAR(11) NULL,
 `cd_creci` VARCHAR(7) NOT NULL,
 `ds_login_facebook` VARCHAR(50) NULL,
 `ds_email` VARCHAR(50) NULL,
 `ds_password` VARCHAR(500),
 `ds_telefone1` VARCHAR(20) NULL,
 `ds_tipo_telefone_1` VARCHAR(40) NULL,
 `ds_telefone2` VARCHAR(20) NULL,
 `ds_tipo_telefone_2` VARCHAR(40) NULL
);

DROP TABLE IF EXISTS `Pais`;
CREATE TABLE IF NOT EXISTS `Pais` (
 `id_pais` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `cd_pais`  CHAR(2) NOT NULL,
 `nm_pais`  VARCHAR(50) NOT NULL
);

DROP TABLE IF EXISTS `Estado`;
CREATE TABLE IF NOT EXISTS `Estado` (
 `id_estado` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `id_pais` SMALLINT NOT NULL,
 `cd_estado` CHAR(2) NOT NULL ,
 `nm_estado` VARCHAR(45) NOT NULL,
 FOREIGN KEY (id_pais) REFERENCES Pais(id_pais)
);

DROP TABLE IF EXISTS `Municipio`;
CREATE TABLE IF NOT EXISTS `Municipio` (
 `id_municipio` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `id_estado` SMALLINT NOT NULL,
 `nm_municipio` VARCHAR(45) NOT NULL,
 FOREIGN KEY (id_estado) REFERENCES Estado(id_estado)   
);
 
DROP TABLE IF EXISTS `Bairro`;
CREATE TABLE IF NOT EXISTS `Bairro` (
 `id_bairro` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `id_municipio` SMALLINT NOT NULL,
 `nm_bairro` VARCHAR(45) NOT NULL,
 FOREIGN KEY (id_municipio) REFERENCES Municipio(id_municipio)
);


DROP TABLE IF EXISTS `Categoria`;
CREATE TABLE IF NOT EXISTS `Categoria` (
 `id` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `ds_item` VARCHAR(40) NOT NULL
);
  
DROP TABLE IF EXISTS `Dormitorio`;
CREATE TABLE `Dormitorio` (
 `id` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `ds_item` SMALLINT NOT NULL
);

DROP TABLE IF EXISTS `Finalidade`;
CREATE TABLE IF NOT EXISTS `Finalidade` (
 `id` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `ds_item` VARCHAR(40) NOT NULL
);

DROP TABLE IF EXISTS `EstadoImovel`;
CREATE TABLE IF NOT EXISTS `EstadoImovel` (
 `id` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `ds_item` VARCHAR(40) NOT NULL 
);

DROP TABLE IF EXISTS `PosicaoImovel`;
CREATE TABLE IF NOT EXISTS `PosicaoImovel` (
 id SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 ds_item VARCHAR(20) NOT NULL
);

DROP TABLE IF EXISTS `Social`;
CREATE TABLE IF NOT EXISTS `Social` (
 id SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 ds_item VARCHAR(40) NULL
);

DROP TABLE IF EXISTS `Acabamento`;
CREATE TABLE IF NOT EXISTS `Acabamento` (
 id SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 ds_item VARCHAR(40) NULL
);

DROP TABLE IF EXISTS `Intima`;
CREATE TABLE IF NOT EXISTS `Intima` (
 id SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 ds_item VARCHAR(40) NULL
);

DROP TABLE IF EXISTS `Servico`;
CREATE TABLE IF NOT EXISTS `Servico` (
 id SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 ds_item VARCHAR(40) NULL
);

DROP TABLE IF EXISTS `Armario`;
CREATE TABLE IF NOT EXISTS `Armario` (
 id SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 ds_item VARCHAR(40) NULL
);

DROP TABLE IF EXISTS `Lazer`;
CREATE TABLE IF NOT EXISTS `Lazer` (
 id SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 ds_item VARCHAR(40) NULL
);


DROP TABLE IF EXISTS `Imovel`;
CREATE TABLE IF NOT EXISTS `Imovel` (
 `id_imovel` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 `id_usuario` SMALLINT NOT NULL,
 `id_finalidade` SMALLINT NOT NULL,
 `id_categoria` SMALLINT NOT NULL,
 `ds_padrao` VARCHAR(50) NULL,
 `ds_endereco` VARCHAR(60) NOT NULL,
 `ds_numero_endereco` VARCHAR(10) NOT NULL,
 `ds_cep` CHAR(8) NULL,
 `ds_complemento` VARCHAR(20) NOT NULL,
 `id_bairro` SMALLINT NOT NULL,
 `ds_garagem` VARCHAR(30) NULL,
 `ds_portaria` VARCHAR(30) NULL,
 `ds_situacao` VARCHAR(60) NULL, 
 `id_estado_imovel` SMALLINT NOT NULL,
 `id_dormitorio` SMALLINT NULL,
 `qt_suite` SMALLINT NULL,
 `id_posicao_imovel` SMALLINT NULL,
 `ds_banheiro` VARCHAR(80) NULL,
 `nm_edificio` VARCHAR(40) NULL,
 `ic_financiamento` bit NULL,
 `vl_imovel` DECIMAL NOT NULL,
 `vl_sem_comissao` DECIMAL NOT NULL,
 `vl_iptu` DECIMAL NULL,
 `vl_condominio` DECIMAL NULL,
 `ic_vazio` bit NULL,
 `cd_registro` VARCHAR(20) NULL,
 `ic_documentacao` bit NULL,
 `ic_elevador` bit NULL,
 `ds_local_chaves` VARCHAR(40) NULL,
 `vl_area_util` DECIMAL NULL,
 `vl_area_total` DECIMAL NULL,
 `ic_destaque` bit NULL,
 `ic_ativo` bit NULL,
 `dt_post` date NOT NULL,
 FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),    
 FOREIGN KEY (id_finalidade) REFERENCES Finalidade(id),
 FOREIGN KEY (id_categoria) REFERENCES Categoria(id),
 FOREIGN KEY (id_bairro) REFERENCES Bairro(id_bairro),
 FOREIGN KEY (id_estado_imovel) REFERENCES EstadoImovel(id),
 FOREIGN KEY (id_dormitorio) REFERENCES Dormitorio(id),   
 FOREIGN KEY (id_posicao_imovel) REFERENCES PosicaoImovel(id)
             
);

DROP TABLE IF EXISTS `Imagem`;
CREATE TABLE IF NOT EXISTS `Imagem` (
  `id_imagem` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  `ds_imagem_cripto` TEXT COLLATE latin1_general_ci NOT NULL,
  `ds_imagem` VARCHAR(150) NOT NULL,
  `id_imovel` SMALLINT NOT NULL,    
  FOREIGN KEY (id_imovel) REFERENCES Imovel(id_imovel)
);

DROP TABLE IF EXISTS `ImovelSocial`;
CREATE TABLE IF NOT EXISTS `ImovelSocial` (
 `id_imovel` SMALLINT NOT NULL,
 `id_social` SMALLINT NOT NULL,
 PRIMARY KEY(id_imovel,id_social),
 FOREIGN KEY (id_imovel) REFERENCES Imovel(id_imovel),
 FOREIGN KEY (id_social) REFERENCES Social(id)
);

DROP TABLE IF EXISTS `ImovelAcabamento`;
CREATE TABLE IF NOT EXISTS `ImovelAcabamento` (
 `id_imovel` SMALLINT NOT NULL,
 `id_acabamento` SMALLINT NOT NULL,
 PRIMARY KEY(id_imovel,id_acabamento),
 FOREIGN KEY (id_imovel) REFERENCES Imovel(id_imovel),
 FOREIGN KEY (id_acabamento) REFERENCES Acabamento(id)
);

DROP TABLE IF EXISTS `ImovelIntima`;
CREATE TABLE IF NOT EXISTS `ImovelIntima` (
 `id_imovel` SMALLINT NOT NULL,
 `id_intima` SMALLINT NOT NULL,
 PRIMARY KEY(id_imovel,id_intima),
 FOREIGN KEY (id_imovel) REFERENCES Imovel(id_imovel),
 FOREIGN KEY (id_intima) REFERENCES Intima(id)
);

DROP TABLE IF EXISTS `ImovelServico`;
CREATE TABLE IF NOT EXISTS `ImovelServico` (
 `id_imovel` SMALLINT NOT NULL,
 `id_servico` SMALLINT NOT NULL,
 PRIMARY KEY(id_imovel,id_servico),
 FOREIGN KEY (id_imovel) REFERENCES Imovel(id_imovel),
 FOREIGN KEY (id_servico) REFERENCES Servico(id)
);

DROP TABLE IF EXISTS `ImovelArmario`;
CREATE TABLE IF NOT EXISTS `ImovelArmario` (
 `id_imovel` SMALLINT NOT NULL,
 `id_armario` SMALLINT NOT NULL,
 PRIMARY KEY(id_imovel, id_armario),
 FOREIGN KEY (id_imovel) REFERENCES Imovel(id_imovel),
 FOREIGN KEY (id_armario) REFERENCES Armario(id)
);

DROP TABLE IF EXISTS `ImovelLazer`;
CREATE TABLE `ImovelLazer` (
 `id_imovel` SMALLINT NOT NULL,
 `id_lazer` SMALLINT NOT NULL,
 PRIMARY KEY(id_imovel, id_lazer),
 FOREIGN KEY (id_imovel) REFERENCES Imovel(id_imovel),
 FOREIGN KEY (id_lazer) REFERENCES Lazer(id)
);

DROP TABLE IF EXISTS `ErroLog`;
CREATE TABLE IF NOT EXISTS `ErroLog`
(
	`id_erro` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	`ds_erro` VARCHAR(500),
	`dt_erro` DATETIME,
	`ds_stack` VARCHAR(255),
	`ds_metodo` VARCHAR(100)
	
);

DROP TABLE IF EXISTS `Slider`;
CREATE TABLE IF NOT EXISTS `Slider`
(
	`id_slider` SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	`ds_path_imagem` VARCHAR(255) NOT NULL,
	`ds_texto1` VARCHAR(29) NOT NULL,
	`ds_texto2` VARCHAR(24) NOT NULL,
	`ic_ativo` BIT NOT NULL
);