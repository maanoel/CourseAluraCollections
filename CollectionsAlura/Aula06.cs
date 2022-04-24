using System.Collections.Generic;

namespace CollectionsAlura
{
  public class Aula06
  {
    public void Executando()
    {
      List<string> frutas = new List<string>
      {
        "Abacate",
        "Banana",
        "Melão"
      };

      foreach (var fruta in frutas)
      {
        System.Console.WriteLine(fruta);
      }

      //LINKED LIST, mais rápidas que Lists
      //Não precisam estar em sequência em memória
      //Adiciono de maneira mais eficiente
      ////elementos em diversas posições da lista
      ///
      //LINKED LIST NÃO DÁ SUPORTE ARA BUSCA ´DE ÍNDICES
      //Não é eficiente para obter elementos

      LinkedList<string> dias = new LinkedList<string>();
      //Não pode iniciar com os default

      LinkedListNode<string> quarta = dias.AddFirst("Quarta");

      LinkedListNode<string> quinta = dias.AddBefore(quarta, "Quinta");

      LinkedListNode<string> terca = dias.AddBefore(quarta, "Terça");

      LinkedListNode<string> sexta = dias.AddBefore(quinta, "Sexta");

      LinkedListNode<string> sabado = dias.AddBefore(sexta, "Sexta");

      System.Console.WriteLine(quarta.Value);
      System.Console.WriteLine(quinta.Value);
      System.Console.WriteLine(terca.Value);
      System.Console.WriteLine(sexta.Value);
      System.Console.WriteLine(sabado.Value);

      //quarta.Next é igual a quinta
      //quinta.Previous é igual a quarta


    }
  }
}
