using NetBank.Sistemas;

namespace NetBank.Funcionarios
{
  public class Diretor : FuncionarioAutenticavel
  {
    public Diretor(string cpf) : base(cpf, 5000)
    {
    }

    public override decimal GetBonificacao()
    {
      return Salario * (decimal) 0.5;
    }

    public override void AumentarSalario()
    {
      Salario *= (decimal) 1.15;
    }
  }
}