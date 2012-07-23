USE imobapp;

INSERT INTO Categoria (ds_item) values ('Apartamento'), ('Casa'), ('Casa Comercial'), ('Casa em Condomínio'), 
('Sobrado'), ('Cobertura'), ('Cobertura Duplex'), ('Flat'), ('Loft'), ('Duplex'),
('Sala Comercial'), ('Kit'), ('Sala Living'), ('Conjunto Comercial'), ('Terreno');

INSERT INTO Dormitorio (ds_item) values (1),(2),(3),(4);

INSERT INTO Acabamento (ds_item) VALUES ('Cerâmica'), ('Taco'), ('Porcelanato'), ('Carpete'), ('Piso Madeira'),
							  ('Mámore'), ('Granito'), ('Rebaixado Gesso');
							  
INSERT INTO Social (ds_item) VALUES ('Sala 1 amb'), ('Saleta'), ('Sala p/ 2 amb'), ('Sacada'), ('Sala de Jantar'),
						  ('Sala de Estar'), ('Sala em L'), ('Terraço Gourmet');
						  
INSERT INTO Intima (ds_item) VALUES ('Dormitorios'), ('Suíte c/ Closet'), ('Suíte'), ('Banheiros'), ('Hidro'), ('Lavabo');


INSERT INTO Servico (ds_item) VALUES ('Cozinha'), ('Despensa'), ('Copa'), ('Dorm. Empregada'), ('Área Livre'),
							('Lavanderia'), ('Área de Serviço'), ('Banheiro de Empregada');
							
INSERT INTO Armario (ds_item) VALUES ('Quartos'), ('Cozinha'), ('Closet'), ('Banheiros');

INSERT INTO Finalidade (ds_item) VALUES ('Venda'),('Locação'),('Revenda');

INSERT INTO Lazer (ds_item) VALUES ('Playground'), ('Piscina'), ('Academia'), ('Cinema');

INSERT INTO EstadoImovel (ds_item) VALUES ('Novo'), ('Seminovo'), ('Em Construção');

INSERT INTO PosicaoImovel (ds_item) VALUES ('Frente'), ('Lateral'), ('Fundos');