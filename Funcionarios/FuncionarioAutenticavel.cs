using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        
        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
            {

            }
        
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}