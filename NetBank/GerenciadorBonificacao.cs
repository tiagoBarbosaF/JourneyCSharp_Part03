using NetBank.Funcionarios;

namespace NetBank
{
  public class GerenciadorBonificacao
  {
    private decimal _totalBonificacao;

    public void Registrar(Funcionario funcionario)
    {
      _totalBonificacao += funcionario.GetBonificacao();
    }
    
    public decimal GetTotalBonificacao()
    {
      return _totalBonificacao;
    }
  }
}