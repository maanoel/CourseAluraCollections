using System.Collections.Generic;
using System.Linq;

namespace CollectionsAlura
{
  public class Aula08
  {
    Queue<string> pedagio = new Queue<string>();

    public void Executando()
    {
      //Primeiro a entrar, primeiro a sair
      //FIRST IN FIRST OUT
      Enfileirar("Van");
      Enfileirar("Kombi");
      Enfileirar("Guincho");
      Enfileirar("PickUp");
      Desenfileirar();
      Desenfileirar();
      Desenfileirar();

    }

    private void Desenfileirar()
    {
      //OPTAR POR USAR O ANY SEMPRE NO LUGAR DO .COUNT
      if (!pedagio.Any()) return;

      if (pedagio.Peek() == "Guincho") {
        System.Console.WriteLine("Guincho fazendo o pagamento");
      }

      string veiculo = pedagio.Dequeue();
      System.Console.WriteLine($"Saiu da fila  {veiculo}");

      FilaAtual();
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
