-- Criação das Tabelas
CREATE TABLE aluno (
    Matr_Aluno INTEGER IDENTITY(1,1),
    Nome_Aluno   VARCHAR(40) NOT NULL,
    Tel_Aluno  VARCHAR(40) NOT NULL,
	Email_Aluno  VARCHAR(40) NOT NULL,
    CONSTRAINT pk_Matr_Aluno PRIMARY KEY (Matr_Aluno),
   );
  	 
CREATE TABLE aula (
    Cod_aula INTEGER IDENTITY(1,1),
    Hora_aula TIME NOT NULL,
    Data_aula DATE NOT NULL,
	Matr_Prof INTEGER,
	CONSTRAINT pk_Cod_aula PRIMARY KEY (Cod_aula),
   );

CREATE TABLE turma (
    Cod_turma INTEGER IDENTITY(1,1),
    Periodo CHAR(1) NOT NULL,
    Ano INTEGER NOT NULL, 
	Matr_Prof INTEGER,
	Cod_curso INTEGER,
	CONSTRAINT pk_Cod_turma PRIMARY KEY (Cod_turma),
	CONSTRAINT ck_Periodo CHECK (Periodo='M' or Periodo='V' or Periodo='N')
   );

CREATE TABLE professor (
    Matr_Prof INTEGER IDENTITY(1,1),
    Nome_Prof   VARCHAR(40) NOT NULL,
    Salario  DECIMAL (8,2) NOT NULL,
	Tel_Prof  VARCHAR(40) NOT NULL,
	Email_Prof  VARCHAR(40) NOT NULL,
    CONSTRAINT pk_Matr_Prof PRIMARY KEY (Matr_Prof),
   );

CREATE TABLE curso(
    Cod_curso INTEGER IDENTITY(1,1),
    Nome_Curso   VARCHAR(40) NOT NULL,
    Carga_horaria  INTEGER NOT NULL,
	Vagas INTEGER NOT NULL,
    CONSTRAINT pk_Cod_curso PRIMARY KEY (Cod_curso),
   );


CREATE TABLE aula_aluno (
    Cod_aula_aluno INTEGER IDENTITY(1,1),
	Cod_aula    INTEGER,
    Matr_Aluno    INTEGER,
	--presenca_aluno  BIT NOT NULL,
    CONSTRAINT pk_Cod_aula_aluno PRIMARY KEY (Cod_aula_aluno),
    CONSTRAINT fk_Cod_aula FOREIGN KEY (Cod_aula)
       REFERENCES aula (Cod_aula),
    CONSTRAINT fk_Matr_Aluno FOREIGN KEY (Matr_Aluno)
       REFERENCES aluno (Matr_Aluno)
);

CREATE TABLE turma_aluno (
    Cod_turma_aluno INTEGER IDENTITY(1,1),
	Cod_turma    INTEGER,
    Matr_Aluno    INTEGER,
    CONSTRAINT pk_Cod_turma_aluno PRIMARY KEY (Cod_turma_aluno),
    CONSTRAINT fk_Cod_turma FOREIGN KEY (Cod_turma)
       REFERENCES turma (Cod_turma),
);


-- Adição de algumas FKs
ALTER TABLE aula
ADD CONSTRAINT fk_Matr_Prof FOREIGN KEY (Matr_Prof)
       REFERENCES professor (Matr_Prof);

ALTER TABLE turma
ADD CONSTRAINT fk_Matric_Prof FOREIGN KEY (Matr_Prof)
       REFERENCES professor (Matr_Prof);

ALTER TABLE turma
ADD CONSTRAINT fk_Cod_curso FOREIGN KEY (Cod_curso)
       REFERENCES curso (Cod_curso);

ALTER TABLE aula
	ADD Cod_turma INT NOT NULL;

ALTER TABLE aula
	ADD CONSTRAINT FK_aula_turma
		FOREIGN KEY (Cod_turma)
		REFERENCES turma (Cod_turma);


-- Criação de chaves únicas
CREATE UNIQUE INDEX UK_professor ON professor (Nome_Prof, Email_Prof);

CREATE UNIQUE INDEX UK_aluno ON aluno (Nome_Aluno, Email_Aluno);

CREATE UNIQUE INDEX UK_aula ON aula (Cod_turma, Data_Aula, Hora_Aula);

CREATE UNIQUE INDEX UK_aula_aluno ON aula_aluno (Cod_aula, Matr_Aluno, presenca_aluno);

ALTER TABLE curso
ADD CONSTRAINT UK_curso UNIQUE (Nome_Curso);

	-- Teste chave unitaria pelo nome do curso
		--INSERT INTO curso VALUES ('Violão', 90, 10);

CREATE UNIQUE INDEX UK_turma_aluno ON turma_aluno (Cod_turma, Matr_Aluno);