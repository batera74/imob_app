USE imobapp;

INSERT INTO pais VALUES (1, 'BR', 'Brasil');
INSERT INTO estado VALUES (1, 1, 'SP', 'São Paulo');
INSERT INTO estado VALUES (2, 1, 'RJ', 'Rio de Janeiro');

INSERT INTO Municipio (id_estado, nm_municipio) 
VALUES (1, 'Santos'), (1, 'São Vicente'), (1, 'Praia Grande'), (1, 'Guarujá'), (2, 'Rio de Janeiro'), (2, 'Itaipava'), (2, 'Búzios');

INSERT INTO Bairro (id_municipio, nm_bairro) VALUES 
(1, 'Embaré'), (1, 'Gonzaga'), (1, 'Ponta da Praia'), (2, 'Gonzaguinha'), (2, 'Itararé'),
(2, 'Vila São Jorge'), (3, 'Forte'), (3, 'Vila Guilhermina'), (3, 'Boqueirão'), (4, 'Enseada'),
(4, 'Guaiúba'), (4, 'Pitangueiras');
