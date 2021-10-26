using System;
using NetBank.Funcionarios;

namespace NetBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      CalcularBonificacao();
    }

    public static void CalcularBonificacao()
    {
      var gerenciadorBonificacao = new GerenciadorBonificacao();

      var pedro = new Designer("987.654.321-32")
      {
        Nome = "Pedro"
      };

      var roberta = new Diretor("321.654.987-65")
      {
        Nome = "Roberta"
      };

      var igor = new Auxiliar("789.456.123-78")
      {
        Nome = "Igor"
      };

      var camila = new GerenteDeConta("123.456.789-12")
      {
        Nome = "Camila"
      };

      gerenciadorBonificacao.Registrar(pedro);
      gerenciadorBonificacao.Registrar(roberta);
      gerenciadorBonificacao.Registrar(igor);
      gerenciadorBonificacao.Registrar(camila);

      Console.WriteLine($"Total de bonificação do mês: {gerenciadorBonificacao.GetTotalBonificacao():F2}");
    }
  }
}