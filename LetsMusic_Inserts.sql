--- ==========================INPUTS===============================
INSERT INTO aluno
VALUES ('Maria de Lourdes','11 998756321','lourdes@email.com');
INSERT INTO aluno
VALUES ('Angelo Pontes','11 996671355','angelo@email.com');
INSERT INTO aluno
VALUES ('Bernardo Santos','11 992248775','bernardo@email.com');
INSERT INTO aluno
VALUES ('Carlos R. Silva','11 996359977','carlos@email.com');
INSERT INTO aluno
VALUES ('Daniela Alves','11 995851447','daniela@email.com');
INSERT INTO aluno
VALUES ('Erika Martins','11 985584669','erika@email.com');
INSERT INTO aluno
VALUES ('Fabiano Mesquita','11 958743356','fabiano@email.com');
INSERT INTO aluno
VALUES ('Gislaine Cavalcante','11 982285679','gislaine@email.com');
INSERT INTO aluno
VALUES ('Helio Pires','11 969941622','helio@email.com');


INSERT INTO professor
VALUES ('André C. Matos',3500.00,'11 914091971', 'andre.matos@email.com');
INSERT INTO professor
VALUES ('João C. Martins',3200.00,'11 919400625', 'jcmartins@email.com');
INSERT INTO professor
VALUES ('Nazaré Dias',3400.00,'11 921471911', 'nazadias@email.com');


INSERT INTO curso
VALUES ('Canto', 150, 4);
INSERT INTO curso
VALUES ('Violão', 80, 6);
INSERT INTO curso
VALUES ('Piano', 200, 4);
INSERT INTO curso
VALUES ('Bateria', 160, 4);


INSERT INTO turma 
VALUES('N', 2021, 1, 1);
INSERT INTO turma 
VALUES('V', 2022, 2, 2);
INSERT INTO turma 
VALUES('M', 2020, 1, 1);
INSERT INTO turma 
VALUES('M', 2019, 1, 1);

INSERT INTO aula 
VALUES('20:00', '2021-01-03', 1, 1);
INSERT INTO aula 
VALUES('20:00', '2021-01-05', 1, 1);
INSERT INTO aula
VALUES('20:00', '2021-01-07', 1, 1);
INSERT INTO aula 
VALUES('20:00', '2021-01-09', 1, 1);

INSERT INTO aula 
VALUES('15:00', '2022-03-10', 2, 2);
INSERT INTO aula 
VALUES('15:00', '2022-03-12', 2, 2);
INSERT INTO aula 
VALUES('15:00', '2022-03-14', 2, 2);
INSERT INTO aula 
VALUES('15:00', '2022-03-16', 2, 2);
INSERT INTO aula 
VALUES('15:00', '2022-03-18', 2, 2);
INSERT INTO aula 
VALUES('15:00', '2022-03-20', 2, 2);


-- Alunos

INSERT INTO aluno VALUES
('Marília Galvão de Castro','11 91234569','marilialiliu@hotmail.com'),
('natalia fontanezi','11 91234569','natalia.fontanezi@gmail.com'),
('Nathan Lubawski','11 91234569','nathanlubawski1@gmail.com'),
('Víctor Gonçalves','11 91234569','victor.gsantos@hotmail.com'),
('Jhuliani Cristina Amorim dos Santos','11 91234569','jhulianisantos@gmail.com'),
('Luiza Motta Campello','11 91234569','lumcampello@gmail.com'),
('Marco Antônio Batista de Souza','11 91234569','cootoonhoo@gmail.com'),
('Marcus Fábio Abel Pinto','11 91234569','mfabio.abel@gmail.com'),
('Roberto Avelino Alves Junio','11 91234569','roberto.avelino97@gmail.com'),
('Thayssa Afonso Souza','11 91234569','thayssa.souzaf@gmail.com'),
('Lucas Henriques Pereira','11 91234569','lucasphenriques@hotmail.com'),
('Lugan Thierry Fernandes da Costa','11 91234569','luganthierry@hotmail.com'),
('Marcella Roverato Pastore','11 91234569','marcella.rpastore@gmail.com'),
('Taina Costa Maia','11 91234569','taina.cmaia@hotmail.com'),
('Viviane Perrotti','11 91234569','viperrotti@gmail.com'),
('Marcelo Oliveira Silva','11 91234569','marcelo.olisi@gmail.com'),
('Mariane de Souza Carvalho','11 91234569','mscarvall@gmail.com'),
('ROBSON TAKESHI NISHIKAWA','11 91234569','takeshinishikawa@gmail.com'),
('Sathya de Camargo Andrade Gimenes','11 91234569','sathya.gimenes@gmail.com'),
('Sérgio Fleury Dias Filho','11 91234569','sergiofdf@gmail.com'),
('Mateus Augusto dos Santos Fonseca','11 91234569','mateus.asfonseca@gmail.com'),
('Matheus Alencastro Braner Kenderessy','11 91234569','alencastromatheus@gmail.com'),
('Matheus Amaro Silva','11 91234569','mat.amaro427@gmail.com'),
('Natália Cristina de Campos da Silva','11 91234569','nataliacamposnccs@gmail.com'),
('Thiago Conceição da Silva Costa','11 91234569','thiago_291@zoho.com');

INSERT INTO turma VALUES('N', 2022, 14,9);

INSERT INTO aula VALUES ('18:30', '2022-08-01', 14, 8);

INSERT INTO aula_aluno VALUES 
(11,11,1),
(11,12,1),
(11,13,1),
(11,14,1),
(11,15,1),
(11,16,1),
(11,17,1),
(11,18,1),
(11,19,1),
(11,20,1),
(11,21,1),
(11,22,1),
(11,23,1),
(11,24,0),
(11,25,0),
(11,26,1),
(11,27,1),
(11,28,1),
(11,29,1),
(11,30,0),
(11,31,1),
(11,32,1),
(11,33,1),
(11,34,1),
(11,35,1);