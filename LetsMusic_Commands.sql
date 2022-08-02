	-- Lista total de professores da escola
	SELECT * FROM professor;

	-- Salário médio de professores da escola
	SELECT AVG(p.Salario) FROM professor p;

	-- Quais professores recebem acima do salário médio da escola
	SELECT * FROM professor p
	WHERE p.Salario > (SELECT AVG(p.Salario) FROM professor p);

	-- Quais foram os cursos ministrados pelo professor X?
	CREATE PROCEDURE cursos_professor
	(@pNomeProfessor VARCHAR(40))
	AS
		SELECT DISTINCT p.Nome_Prof, c.Nome_Curso FROM professor p 
		JOIN aula a
		ON p.Matr_Prof = a.Matr_Prof
		JOIN turma t
		ON a.Cod_turma = t.Cod_turma
		JOIN curso c
		ON t.Cod_curso = c.Cod_curso
		WHERE p.Nome_Prof = @pNomeProfessor
	;

	EXECUTE cursos_professor 'João C. Martins';

		
	-- Quais foram os cursos ministrados pelo professor no ano X utilizando PROCEDURE
	CREATE PROCEDURE cursos_professor_ano
(@pNomeProfessor VARCHAR(40), @pAnoPesquisa INT) 
	AS
		SELECT DISTINCT p.Nome_Prof, c.Nome_Curso, t.Ano FROM professor p 
		JOIN aula a
		ON p.Matr_Prof = a.Matr_Prof
		JOIN turma t
		ON a.Cod_turma = t.Cod_turma
		JOIN curso c
		ON t.Cod_curso = c.Cod_curso
		WHERE p.Nome_Prof = @pNomeProfessor AND t.Ano = @pAnoPesquisa
	;

	EXECUTE cursos_professor_ano 'João C. Martins', 2022;


	-- Quais são as turmas do ano corrente?
	CREATE VIEW turmas_ano AS
	SELECT DISTINCT p.Nome_Prof, c.Nome_Curso, t.Cod_turma, t.Ano FROM professor p 
	JOIN aula a
	ON p.Matr_Prof = a.Matr_Prof
	JOIN turma t
	ON a.Cod_turma = t.Cod_turma
	JOIN curso c
	ON t.Cod_curso = c.Cod_curso
	WHERE t.Ano = YEAR(GETDATE())
	;

	SELECT * from turmas_ano;


	-- Percentual de presença para um aluno X através de uma função
	CREATE FUNCTION percentual_presenca(@pMatr_Aluno INT, @pCod_curso INT)
	RETURNS DECIMAL(4,2) AS 
BEGIN
		DECLARE @vTotalAulas DECIMAL(4,2), @vPresencas DECIMAL(4,2), @resultado DECIMAL(4,2)
		SET @vTotalAulas = (SELECT COUNT(*) FROM aula_aluno a 
								JOIN aula ON a.Cod_aula = aula.Cod_aula
								JOIN turma ON aula.Cod_turma = turma.Cod_turma
								JOIN curso ON turma.Cod_curso = curso.Cod_curso
								WHERE a.Matr_Aluno = @pMatr_Aluno AND curso.Cod_curso = @pCod_curso)
		SET @vPresencas = (SELECT COUNT(*) FROM aula_aluno a 
								JOIN aula ON a.Cod_aula = aula.Cod_aula
								JOIN turma ON aula.Cod_turma = turma.Cod_turma
								JOIN curso ON turma.Cod_curso = curso.Cod_curso
								WHERE a.Matr_Aluno = @pMatr_Aluno AND a.presenca_aluno = 1 AND curso.Cod_curso = @pCod_curso)
		IF @vTotalAulas = 0
			SET @resultado = 0
		ELSE 
			SET @resultado = @vPresencas / @vTotalAulas
		RETURN @resultado * 100
END

SELECT Nome_Aluno, Nome_Curso, dbo.percentual_presenca(Matr_Aluno, Cod_curso) AS 'Percentual de Presença' 
FROM aluno, curso 
WHERE Matr_Aluno = 1 AND Cod_curso = 1

	-- Lista de presença da aula 11
	SELECT p.Nome_Prof, aula.Data_aula, al.Matr_Aluno, al.Nome_Aluno, 
	CASE WHEN aula_aluno.presenca_aluno = 0 
	THEN 'Ausente' ELSE 'Presente' END AS 'Presença' 
	FROM aluno al
	JOIN aula_aluno
	ON al.Matr_Aluno = aula_aluno.Matr_Aluno
	JOIN aula
	ON aula_aluno.Cod_aula = aula.Cod_aula
	JOIN professor p
	ON aula.Matr_Prof = p.Matr_Prof
	WHERE aula_aluno.Cod_aula = 11;


	--Aumento do salário em 10% por turma adicionada no ano
	CREATE TRIGGER aumenta_salario
	ON turma
	AFTER INSERT
	AS
	BEGIN
		DECLARE @qtd_turma DECIMAL, @matr_inserida INT
		SET @matr_inserida = (SELECT Matr_Prof FROM inserted)
		SET @qtd_turma = (SELECT COUNT(*) FROM turma 
		WHERE turma.Matr_Prof = @matr_inserida AND turma.Ano = YEAR(GETDATE()))
	
		IF @qtd_turma > 1
			UPDATE professor
			SET professor.Salario = professor.Salario * (1 + @qtd_turma / 10)
			WHERE professor.Matr_Prof = @matr_inserida  
	END

	--TESTE DO TRIGGER: INSERT INTO turma VALUES ('M', 2022, 2, 3)
