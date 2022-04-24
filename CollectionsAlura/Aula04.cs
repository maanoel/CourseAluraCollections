using System.Collections.Generic;

namespace CollectionsAlura
{
  public class Aula04
  {
    public void Executando()
    {
      //Características dos conjuntos
      //Não aceitam duplicidade
      //Não tem uma ordem

      ISet<string> alunos = new HashSet<string>();
      alunos.Add("Vitor brito");
      alunos.Add("Nadine gubert");
      alunos.Add("Rafael dantas");

      System.Console.WriteLine(alunos);
      System.Console.WriteLine(string.Join(",", alunos));

      //Qual a diferença de um conjunto e uma lista?

      alunos.Add("Priscila");
      alunos.Add("Rafael Rollo");
      alunos.Add("Fabio gushiken");

      System.Console.WriteLine(string.Join(",", alunos));


      //E sobre a ordem??

      //para entender vamos remover

      alunos.Remove("Rafael dantas");
      alunos.Add("Marcel");

      System.Console.WriteLine(string.Join(",", alunos));

      //Não permite duplicidade

      //Quando adiciona não dá erro, porém não adiciona o valor no conjunto
      alunos.Add("Marcel");

      System.Console.WriteLine(string.Join(",", alunos));


      //A maior diferença entre conjuntos e lista é que os conjuntos
      //são mais rápido do que as listas
      //

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
