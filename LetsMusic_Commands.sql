	-- Lista total de professores da escola
	SELECT * FROM professor;

	-- Sal�rio m�dio de professores da escola
	SELECT AVG(p.Salario) FROM professor p;

	-- Quais professores recebem acima do sal�rio m�dio da escola
	SELECT * FROM professor p
	WHERE p.Salario > (SELECT AVG(p.Salario) FROM professor p);

	-- Quais foram os cursos ministrados pelo professor X utilizando PROCEDURE
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

	EXECUTE cursos_professor 'Jo�o C. Martins';

		
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

	EXECUTE cursos_professor_ano 'Jo�o C. Martins', 2022;


	-- Quais s�o as turmas do ano corrente
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


	-- Percentual de presen�a para um aluno X atrav�s de uma fun��o
	CREATE FUNCTION calcula_percentual_presenca(@pMatr_Aluno INT)
	RETURNS DECIMAL(4,2) AS 
BEGIN
		DECLARE @vTotalAulas DECIMAL(4,2), @vPresencas DECIMAL(4,2), @resultado DECIMAL(4,2)
		SET @vTotalAulas = (SELECT COUNT(*) FROM aula_aluno a WHERE a.Matr_Aluno = @pMatr_Aluno)
		SET @vPresencas = (SELECT COUNT(*) FROM aula_aluno a WHERE a.Matr_Aluno = @pMatr_Aluno AND a.presenca_aluno = 1)
		IF @vTotalAulas = 0
			SET @resultado = 0
		ELSE 
			SET @resultado = @vPresencas / @vTotalAulas
		RETURN @resultado * 100
END

SELECT dbo.calcula_percentual_presenca(1) AS 'Percentual de Presen�a';

	-- Lista de presen�a da aula 1
	SELECT al.Matr_Aluno, al.Nome_Aluno, CASE WHEN aula_aluno.presenca_aluno = 0 THEN 'Ausente' ELSE 'Presente' END AS 'Presen�a' 
	FROM aluno al
	JOIN aula_aluno
	ON al.Matr_Aluno = aula_aluno.Matr_Aluno
	WHERE aula_aluno.Cod_aula = 1;