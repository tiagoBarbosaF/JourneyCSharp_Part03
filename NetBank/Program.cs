using System;
using NetBank.Funcionarios;
using NetBank.Sistemas;

namespace NetBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      //CalcularBonificacao();
      UsarSistema();
    }

    public static void UsarSistema()
    {
      var sistemaInterno = new SistemaInterno();

      var roberta = new Diretor("321.654.987-65")
      {
        Nome = "Roberta",
        Senha = "123"
      };
      var camila = new GerenteDeConta("123.456.789-12")
      {
        Nome = "Camila",
        Senha = "abc"
      };

      var parceiroComercial = new ParceiroComercial()
      {
        Senha = "123456"
      };

      sistemaInterno.Logar(parceiroComercial, "123456");

      sistemaInterno.Logar(roberta, "123");
      sistemaInterno.Logar(camila, "abc");
    }

    public static void CalcularBonificacao()
    {
      var gerenciadorBonificacao = new GerenciadorBonificacao();

      var pedro = new Designer("987.654.321-32")
      {
        Nome = "Pedro"
      };
      Console.WriteLine(pedro.Nome);
      Console.WriteLine(Funcionario.TotalDeFuncionarios);
      Console.WriteLine(pedro.GetBonificacao());

      var roberta = new Diretor("321.654.987-65")
      {
        Nome = "Roberta"
      };
      Console.WriteLine(roberta.Nome);
      Console.WriteLine(Funcionario.TotalDeFuncionarios);
      Console.WriteLine(roberta.GetBonificacao());

      var igor = new Auxiliar("789.456.123-78")
      {
        Nome = "Igor"
      };
      Console.WriteLine(igor.Nome);
      Console.WriteLine(Funcionario.TotalDeFuncionarios);
      Console.WriteLine(igor.GetBonificacao());

      var camila = new GerenteDeConta("123.456.789-12")
      {
        Nome = "Camila"
      };
      Console.WriteLine(camila.Nome);
      Console.WriteLine(Funcionario.TotalDeFuncionarios);
      Console.WriteLine(camila.GetBonificacao());

      var tiago = new Desenvolvedor("654.987.321-65")
      {
        Nome = "Tiago"
      };
      Console.WriteLine(tiago.Nome);
      Console.WriteLine(Funcionario.TotalDeFuncionarios);
      Console.WriteLine(tiago.GetBonificacao());

      gerenciadorBonificacao.Registrar(pedro);
      gerenciadorBonificacao.Registrar(roberta);
      gerenciadorBonificacao.Registrar(igor);
      gerenciadorBonificacao.Registrar(camila);
      gerenciadorBonificacao.Registrar(tiago);

      Console.WriteLine($"Total de bonificação do mês: {gerenciadorBonificacao.GetTotalBonificacao():F2}");
    }
  }
}