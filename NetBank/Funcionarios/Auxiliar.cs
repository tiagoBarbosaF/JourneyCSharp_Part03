namespace NetBank.Funcionarios
{
  public class Auxiliar : Funcionario
  {
    public Auxiliar(string cpf) : base(cpf, 2000)
    {
    }

    public override decimal GetBonificacao()
    {
      return Salario + (decimal) 0.2;
    }

    public override void AumentarSalario()
    {
      Salario += (decimal) 1.1;
    }
  }
}