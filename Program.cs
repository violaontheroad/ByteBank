using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            
            SistemaInterno sistemaInterno = new SistemaInterno();
            
            Diretor roberta = new Diretor("833.958.897-02");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("456.756.098-03");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "321";

            sistemaInterno.Logar(parceiro, "321");
            sistemaInterno.Logar(roberta, "133");
            sistemaInterno.Logar(camila, "abc");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("343.654.657-01");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("833.958.897-02");
            roberta.Nome = "Roberta";

            Funcionario camila = new GerenteDeConta("456.756.098-03");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}