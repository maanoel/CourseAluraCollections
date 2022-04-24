using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAlura
{
  public class Aula02
  {
    public void Executando()
    {
      string aulaIntro = "Introdução ás coleções";
      string aulaModelando = "Modelando a classe aula";
      string aulaSets = "trabalhando com conjuntos";

      //List<string> aulas = new List<string>
      //{
      //  aulaIntro,
      //  aulaModelando,
      //  aulaSets
      //};

      List<string> aulas = new List<string>();
      aulas.Add(aulaIntro);
      aulas.Add(aulaModelando);
      aulas.Add(aulaSets);

      Imprimir(aulas);

      Console.WriteLine("A primeira aula é " + aulas[0]);
      Console.WriteLine("A ultima aula é " + aulas[aulas.Count - 1]);

      Console.WriteLine("A primeira aula é " + aulas.First());
      Console.WriteLine("A ultima aula é " + aulas.Last());


      aulas[0] = "Trabalhando com listas";

      Imprimir(aulas);

      Console.WriteLine("A primeira aula é 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));

      Console.WriteLine("A ultima aula é 'Trabalhando' é: " + aulas.Last(aula=> aula.Contains("Trabalhando")));

      Console.WriteLine("A aula ultima aula : " + aulas.FirstOrDefault(aula=>aula.Contains("sSASAAA")));


      aulas.RemoveAt(aulas.Count - 1); // ultimo

      aulas.Sort();

      Imprimir(aulas);

      List<string> copia = aulas.GetRange(aulas.Count - 2, 2);

      Imprimir(copia);

      List<string> clone = new List<string>(aulas); //CLONANDO ELEMENTOS

      Imprimir(clone);

      clone.RemoveRange(clone.Count - 2, 2);

    }

    private static void Imprimir(List<string> aulas)
    {
      //foreach (var aula in aulas)
      //{
      //  Console.WriteLine(aula);
      //}

      //for (int i = 0; i < aulas.Count; i++)
      //{
      //  Console.WriteLine(aulas[i]);
      //}

      aulas.ForEach(item =>
      {
        Console.WriteLine(item);
      });
    }
  }
}
