using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CollectionsAlura
{
  public class Curso
  {
    private string nome;
    private string instrutor;
    private List<Aula> aulas;
    private ISet<Aluno> alunos = new HashSet<Aluno>();
    public IList<Aluno> Alunos {
      get {
        return new ReadOnlyCollection<Aluno>(alunos.ToList());
      }
    }

    public IList<Aula> Aulas
    {
      get { return new ReadOnlyCollection<Aula>(aulas); }
    }

    public Curso(string nome, string instrutor)
    {
      this.nome = nome;
      this.instrutor = instrutor;
      this.aulas = new List<Aula>();
    }

    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }

    public void Matricula(Aluno aluno)
    {
      alunos.Add(aluno);
    }

    public string Instrutor
    {
      get { return instrutor; }
      set { instrutor = value; }
    }

    public bool EstaMatriculado(Aluno aluno01)
    {
      return alunos.Contains(aluno01);
    }

    public int TempoTotal
    {
      get
      {
        //return aulas.Select(x => x.Tempo).Sum();
        return aulas.Sum(x => x.Tempo);
      }
    }

    public void Adiciona(Aula aula)
    {
      this.aulas.Add(aula);
    }

    public override string ToString()
    {
      return $"Curso: {nome}, Tempo{TempoTotal}, Aulas: {string.Join(",", aulas)}";
    }
  }
}
