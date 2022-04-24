using System;
using System.Collections.Generic;

namespace CollectionsAlura
{
  public class Aula05
  {
    public void Executando()
    {
      Curso cshapColecoes = new Curso("C# Coleções", "Vitor Brito");

      cshapColecoes.Adiciona(new Aula("Trabalhando com listas", 20));
      cshapColecoes.Adiciona(new Aula("Criando uma aula", 20));
      cshapColecoes.Adiciona(new Aula("Modelando coleções", 24));

      Aluno aluno01 = new Aluno("Vitor Brito", 34672);
      Aluno aluno02 = new Aluno("Nadine Brito", 77777);
      Aluno aluno03 = new Aluno("Rafaela Moura", 55555);

      cshapColecoes.Matricula(aluno01);
      cshapColecoes.Matricula(aluno02);
      cshapColecoes.Matricula(aluno03);

      //Imprimindo alunos matriculados
      foreach (var aluno in cshapColecoes.Alunos)
      {
        Console.WriteLine(aluno);
      }

      Console.WriteLine($"O aluno aluno1 {aluno01.Nome} está matriculado?");

      Console.WriteLine(cshapColecoes.EstaMatriculado(aluno01));

      Aluno aluno04 = new Aluno("Rafaela Moura", 55555);
      Console.WriteLine(cshapColecoes.EstaMatriculado(aluno04));

      Console.WriteLine(aluno03 == aluno04);

      Console.WriteLine(aluno03.Equals(aluno04));

      Console.Clear();


      Console.WriteLine("Quem é o aluno com a matricula 55555?");

      Aluno alunoMatriculado = cshapColecoes.BuscaMatriculado(55555);

      Console.WriteLine("alunoMatriculado" + alunoMatriculado);

      Aluno alunoMatriculado2 = cshapColecoes.BuscaMatriculado(5618);

      Console.Clear();

      IDictionary<string, int> dictionary = new Dictionary<string, int>();
      dictionary.Add("Teste", 2);
      dictionary["Teste"] = 3;

      Console.WriteLine(dictionary["Teste"]);



    }
  }
}
