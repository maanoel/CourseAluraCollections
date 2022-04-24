﻿using System;

namespace CollectionsAlura
{
  public class Aula : IComparable
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
