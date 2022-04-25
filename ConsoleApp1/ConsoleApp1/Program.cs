using System;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Curso curso = new Curso();

      Aula aula01 = new Aula("Teste 01", 0000);

      curso.AdicionarAula(aula01);
      curso.AdicionarAula(new Aula("Teste 02", 1111));
      curso.AdicionarAula(new Aula("Teste 03", 2222));
      curso.AdicionarAula(new Aula("Teste 04", 3333));

      Console.WriteLine(string.Join(",", curso.Aulas));
      Console.WriteLine(aula01);
      Console.WriteLine(curso.ObterAula(3333));
      Console.WriteLine(curso.ObterAulaComHash(3333));
    }
  }
}

