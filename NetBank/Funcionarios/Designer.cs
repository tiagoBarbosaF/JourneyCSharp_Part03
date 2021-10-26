namespace NetBank.Funcionarios
{
  public class Designer : Funcionario
  {
    public Designer(string cpf) : base(cpf, 3000)
    {
    }

    public override decimal GetBonificacao()
    {
      return Salario * (decimal) 0.17;
    }

    public override void AumentarSalario()
    {
      Salario *= (decimal) 1.11;
    }
  }
}