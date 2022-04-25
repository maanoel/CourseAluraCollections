namespace ConsoleApp1
{
  public class Aula
  {
    public string Nome { get; set; }
    public int Matricula { get; set; }

    public Aula(string nome, int matricula)
    {
      Nome = nome;
      Matricula = matricula;
    }

    public override string ToString()
    {
      return Nome;
    }
  }
}