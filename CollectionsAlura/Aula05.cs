namespace CollectionsAlura
{
  public class Aula05
  {
    public void Executando()
    {
      Curso cshapColecoes = new Curso("C# Coleções", "Vitor Brito");

      cshapColecoes.Adiciona(new Aula("Trabalhando com listas", 20));
      cshapColecoes.Adiciona(new Aula("Criando uma aula", 20));
      cshapColecoes.Adiciona(new Aula("Modelando coleções", 24));

      Aluno aluno01 = new Aluno("Vitor Brito", 34672);
      Aluno aluno02 = new Aluno("Nadine Brito", 77777);
      Aluno aluno03 = new Aluno("Rafaela Moura", 55555);

      cshapColecoes.Matricula(aluno01);
      cshapColecoes.Matricula(aluno02);
      cshapColecoes.Matricula(aluno03);

      //Imprimindo alunos matriculados
      foreach (var aluno in cshapColecoes.Alunos)
      {
        System.Console.WriteLine(aluno);
      }
    }
  }
}
