namespace NetBank.Funcionarios
{
  public class Desenvolvedor : Funcionario
  {
    public Desenvolvedor(string cpf) : base(cpf, 3000)
    {
    }

    public override void AumentarSalario()
    {
      Salario *= (decimal) 1.15;
    }

    public override decimal GetBonificacao()
    {
      return Salario * (decimal) 0.1;
    }
  }
}