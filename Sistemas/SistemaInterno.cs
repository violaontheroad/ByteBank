using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao ByteBank System!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta!");
                return false;
            }
        }
    }
}