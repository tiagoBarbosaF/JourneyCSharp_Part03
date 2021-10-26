using NetBank.Funcionarios;

namespace NetBank.Sistemas
{
  public interface IAutenticavel
  {
    bool Autenticar(string senha);
  }
}