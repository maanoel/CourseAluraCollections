using System.Collections.Generic;

namespace CollectionsAlura
{
  public class Aula08
  {
    Queue<string> pedagio = new Queue<string>();

    public void Executando()
    {
      Enfileirar("Van");
    }

    private void Enfileirar(string nomeVeiculo)
    {
      System.Console.WriteLine($"Entrou na fila: {nomeVeiculo}");

      pedagio.Enqueue(nomeVeiculo);

      FilaAtual();
    }

    private void FilaAtual()
    {
      System.Console.WriteLine("FILA: ");

      foreach (var item in pedagio)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}
