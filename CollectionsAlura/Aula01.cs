﻿using System;

namespace CollectionsAlura
{
  public class Aula01
  {
    public void Executando()
    {
      string aulaIntro = "Introdução ás coleções";
      string aulaModelando = "Modelando a classe aula";
      string aulaSets = "trabalhando com conjuntos";

      string[] aulas = new string[] {
        aulaIntro,
        aulaModelando,
        aulaSets
      };

      string[] aulasDois = new string[3];

      aulasDois[0] = aulaIntro;
      aulasDois[1] = aulaModelando;
      aulasDois[2] = aulaSets;

      Console.WriteLine(aulasDois);

      Imprimir(aulasDois);

      Console.WriteLine(aulasDois[0]);
      Console.WriteLine(aulasDois[aulasDois.Length - 1]);

      Console.WriteLine("-------------------");
      aulaIntro = "TESTE";

      Imprimir(aulasDois);

      Console.WriteLine("Aula modelando está no índice: " + Array.IndexOf(aulasDois, aulaModelando));
      Console.WriteLine(Array.LastIndexOf(aulasDois, aulaModelando));

      //Idempotência,
      //o valor pode ser alterado várias vezes, sem modificar o valor original

      Array.Reverse(aulasDois);

      Imprimir(aulasDois);

      Array.Reverse(aulasDois);

      Imprimir(aulasDois);


      Array.Resize(ref aulasDois, 2);

      Imprimir(aulasDois);

      Array.Resize(ref aulasDois, 3);

      Imprimir(aulasDois);

      aulasDois[aulasDois.Length - 1] = "Conclusão";

      Array.Sort(aulasDois);

      Imprimir(aulasDois);

      string[] copia = new string[2];

      Array.Copy(aulasDois, 1, copia, 0, 2);

      Imprimir(copia);

      string[] clone = aulasDois.Clone() as string[];
      //string[]  (string[]) clone = aulasDois.Clone()

      Imprimir(clone);

      Array.Clear(clone, 1, 2);

      Imprimir(clone);
    }

    private void Imprimir(string[] aulasDois)
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
