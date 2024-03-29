﻿namespace CollectionsAlura
{
  public class Aluno
  {
    private string nome;
    private int numeroMatricula;
    public Aluno(string nome, int numeroMatricula)
    {
      this.nome = nome;
      this.numeroMatricula = numeroMatricula;
    }

    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }

    public int NumeroMatricula
    {
      get { return numeroMatricula; }
      set { numeroMatricula = value; }
    }

    public override string ToString()
    {
      return $"Nome: {nome} matricula: {numeroMatricula}";
    }

    //Sempre que implementar o equals,
    //devemos implementar também o GetHashCode
    public override bool Equals(object obj)
    {
      var outro = obj as Aluno;

      if (outro == null) return false;

      return this.nome.Equals(outro.Nome);
    }

    public override int GetHashCode()
    {
      return this.nome.GetHashCode();
    }
  }
}
