using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
  public class Curso
  {
    public ISet<Aula> Aulas { get; }
    public IDictionary<int, Aula> AulasDicionario { get; }
    public Hashtable AulasHashTable { get; }
    public Queue<Aula> AulasFila { get; }
    public Stack<Aula> AulasStack { get; }

    public LinkedList<Aula> AulasLinkedList { get; }

    public Curso()
    {
      Aulas = new HashSet<Aula>();
      AulasDicionario = new Dictionary<int, Aula>();
      AulasHashTable = new Hashtable();
      AulasFila = new Queue<Aula>();
      AulasStack = new Stack<Aula>();
      AulasLinkedList = new LinkedList<Aula>();
    }

    public void AdicionarAula(Aula aula)
    {
      Aulas.Add(aula);
      AulasDicionario.Add(aula.Matricula, aula);
      AulasHashTable.Add(aula.Matricula, aula);
      AulasFila.Enqueue(aula);
      AulasStack.Push(aula);
      //
    }

    public bool AulaRegistrada(Aula aula)
    {
      return Aulas.Contains(aula);
    }

    public Aula ObterAula(int matricula)
    {
      Aula aula = null;

      //Se o indice não existir no dictionary não vai dar erro
      AulasDicionario.TryGetValue(matricula, out aula);

      return aula;
    }

    public Aula ObterAulaComHash(int matricula)
    {
      return AulasHashTable[matricula] as Aula;
    }

  }
}