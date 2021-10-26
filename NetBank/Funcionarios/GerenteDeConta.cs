namespace NetBank.Funcionarios
{
  public class GerenteDeConta : Funcionario
  {
    public GerenteDeConta(string cpf) : base(cpf, 4000)
    {
    }

    public override decimal GetBonificacao()
    {
      return Salario * (decimal) 0.25;
    }

    public override void AumentarSalario()
    {
      Salario += (decimal) 1.05;
    }
  }
}