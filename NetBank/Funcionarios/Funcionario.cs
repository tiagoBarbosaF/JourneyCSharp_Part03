namespace NetBank.Funcionarios
{
  public abstract class Funcionario
  {
    public static int TotalDeFuncionarios { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public decimal Salario { get; protected set; }

    public Funcionario(string cpf, decimal salario)
    {
      Cpf = cpf;
      Salario = salario;
      TotalDeFuncionarios++;
    }

    public virtual void AumentarSalario()
    {
      Salario *= (decimal) 1.1;
    }

    public virtual decimal GetBonificacao()
    {
      return Salario * (decimal) 0.10;
    }
  }
}