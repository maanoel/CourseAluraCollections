using System.Collections.Generic;

namespace CollectionsAlura
{
  public class Aula03
  {
    public void Executando()
    {
      var aulaIntro = new Aula("Introdução ás coleções", 20);
      var aulaModelando = new Aula("Modelando a classe aula", 18);
      var aulaSets = new Aula("trabalhando com conjuntos", 16);

      List<Aula> aulas = new List<Aula>();

      aulas.Add(aulaIntro);
      aulas.Add(aulaModelando);
      aulas.Add(aulaSets);

      Imprimir(aulas);
      aulas.Sort();

      Imprimir(aulas);

      aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));

      Imprimir(aulas);


      System.Console.WriteLine("****************************");
      Curso csharpColecoes = new Curso("C# Collections", "Vitor");
      csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));

      Imprimir(csharpColecoes.Aulas);

      csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
      csharpColecoes.Adiciona(new Aula("Modelando com coleções", 19));

      Imprimir(csharpColecoes.Aulas);
      
      List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

      aulasCopiadas.Sort();

      Imprimir(aulasCopiadas);

      System.Console.WriteLine(csharpColecoes.TempoTotal);

    }

    private static void Imprimir(IList<Aula> aulas)
    {
      foreach (var aula in aulas)
      {
        System.Console.WriteLine(aula);
      }
    }
  }
}
