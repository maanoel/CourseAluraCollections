using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAlura
{
  public class Aula07
  {
    public void Executando()
    {
      //STACK -> Pilha
      var navegador = new Navegador();
      navegador.NavegarPara("google.com.br");
      navegador.NavegarPara("caelum.com.br");
      navegador.NavegarPara("alura.com.br");
      navegador.Anterior();
      navegador.Anterior();
      navegador.Anterior();
      navegador.Anterior();
      navegador.Proximo();
    }

    public class Navegador
    {
      private string atual = "vazia";
      private readonly Stack<string> historicoAnterior = new Stack<string>();
      private readonly Stack<string> historicoProximo = new Stack<string>();
      public Navegador()
      {
        System.Console.WriteLine("Pagina atual: " + atual);
      }

      public void NavegarPara(string url)
      {
        historicoAnterior.Push(atual);
        atual = url;

        Console.WriteLine("Pagina atual" + atual);
      }
      public void Anterior()
      {
        if (historicoAnterior.Any())
        {
          historicoProximo.Push(atual);
          atual = historicoAnterior.Pop();
        }

        Console.WriteLine("Pagina atual : " + atual);
      }

      public void Proximo()
      {
        if (historicoProximo.Any())
        {

          historicoAnterior.Push(atual);
          atual = historicoProximo.Pop();
        }

        Console.WriteLine("Pagina atual : " + atual);
      }
    }
  }
}
