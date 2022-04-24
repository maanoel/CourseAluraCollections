using System;

namespace CollectionsAlura
{
  class Program
  {
    static void Main(string[] args)
    {
      string aulaIntro = "Introdução ás coleções";
      string aulraModelando = "Modelando a classe aula";
      string aulaSets = "trabalhando com conjuntos";

      string[] aulas = new string[] {
        aulaIntro,
        aulraModelando,
        aulaSets
      };

      string[] aulasDois = new string[3];

      aulasDois[0] = aulaIntro;
      aulasDois[1] = aulraModelando;
      aulasDois[2] = aulaSets;

      Console.WriteLine(aulasDois);

      Imprimir(aulasDois);

      Console.WriteLine(aulasDois[0]);
      Console.WriteLine(aulasDois[aulasDois.Length - 1]);

      Console.WriteLine("-------------------");
      aulaIntro = "TESTE";

      Imprimir(aulasDois);

    }

    private static void Imprimir(string[] aulasDois)
    {
      //foreach (var aula in aulasDois)
      //{
      //  Console.WriteLine(aula);
      //}
      //Cw tab tab já aparece para mim console.writeline

      for (int i = 0; i < aulasDois.Length; i++)
      {
        Console.WriteLine(aulasDois[i]);
      }
    }
  }
}
