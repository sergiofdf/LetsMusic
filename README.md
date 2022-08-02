# LetsMusic

O Let's Music é um banco de dados SQL desenvolvido para uma escola de música. É conectado ao Aplicativo de Console .NET C# que pode realizar os cadastros e oferece visualização das tabelas criadas.

Possui as tabelas Aluno, Professor, Turma, Curso e Aula, bem como tabelas relacionais aula-aluno e turma-aluno.

Os atributos para cada entidade são: </br>
Professor – nome, telefone, e-mail, salário, matrícula</br>
Aluno – nome, telefone, e-mail, matrícula, turma</br>
Turma – código, ano, período</br> 
Aula – código, hora, data</br>
Curso – código, nome, vagas, carga horária

Foram desenvolvidos os Diagramas de Modelo Conceitual, Lógico e Físico para ilustrar os relacionamentos entre as classes:


**Modelo Conceitual**</br>
![alt text](https://github.com/sergiofdf/LetsMusic/blob/master/Diagrams/Modelo_Conceitual.png)

**Modelo Lógico**</br>
![alt text](https://github.com/sergiofdf/LetsMusic/blob/master/Diagrams/Modelo_Logico.png)

**Modelo Físico**</br>
![alt text](https://github.com/sergiofdf/LetsMusic/blob/master/Diagrams/Modelo_Fisico.png)

**As queries foram divididas em 3 arquivos:** </br>
LetsMusic_Create (Criação das tabelas, Primary Keys, Foreign Keys e Unique Indexes);</br>
LetsMusic_Inserts (Inserções de valores nas tabelas e exemplos de Update e Delete);</br>
LetsMusic_Commands (Function, Procedure, View e Trigger).

 **Exemplos de comandos:**</br>
Procedure cursos_professor: Pesquisa de cursos oferecidos a partir do nome do professor;</br>
View turmas_ano: Visualização das turmas do ano vigente;</br>
Function percentual_presenca: Cálculo do percentual de presença a partir da matrícula do aluno e código do curso;</br>
Lista de presença: Retorna a lista de presença de uma aula e exibe o caractere BIT (0/1) como Ausente/Presente a partir do uso de Select/Joins;</br>
Trigger aumenta_salario: Aumenta em 10% o salário de determinado professor ao adicionar nova turma no ano vigente.


#### Para conexão do app C# com o banco de dados na nuvem 
Na camada Presentation, criar um App.Config e colocar os seguintes dados, alterando *LOGIN* e *SENHA* para valores válidos para alteração do banco LetsMusic:
```
<configuration>
  <connectionStrings>
    <add name="LetsMusic" connectionString="Server=vps40251.publiccloud.com.br;
                      Database=LetsMusic;User Id=**LOGIN**;Password=**SENHA**;"/>
  </connectionStrings>
</configuration> 
```





