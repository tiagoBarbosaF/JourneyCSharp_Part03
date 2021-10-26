namespace NetBank.Funcionarios
{
  public abstract class Funcionario
  {
    public static int TotalDeFuncionarios { get; private set; }
    public string Nome { get; set; }
    public string Cpf { get; private set; }
    public decimal Salario { get; protected set; }

    public Funcionario(string cpf)
    {
      TotalDeFuncionarios++;
      Cpf = cpf;
    }
    
    public Funcionario(string cpf, decimal salario)
    {
      Cpf = cpf;
      Salario = salario;
      TotalDeFuncionarios++;
    }

    public abstract void AumentarSalario();

    public abstract decimal GetBonificacao();
  }
}