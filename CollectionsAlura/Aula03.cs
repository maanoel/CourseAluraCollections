using System;
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
    }

    private static void Imprimir(List<Aula> aulas)
    {
      foreach (var aula in aulas)
      {
        System.Console.WriteLine(aula);
      }
    }
  }

  class Aula : IComparable
  {
    private string titulo;
    private int tempo;

    public Aula(string titulo, int tempo)
    {
      this.titulo = titulo;
      this.tempo = tempo;
    }

    public string Titulo { get => titulo; set => titulo = value; }
    public int Tempo { get => tempo; set => tempo = value; }

    public int CompareTo(object obj)
    {
      Aula aula = obj as Aula;

      return titulo.CompareTo(aula.titulo);
    }

    public override string ToString()
    {
      return $"[titulo:{Titulo} , tempo: {Tempo}]";
    }
  }
}
