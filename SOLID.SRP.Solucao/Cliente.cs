using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Solucao
{
    public class Cliente
    {

        /*Seguindo esse princípio declaramos que a classe “Cliente” 
         * deve ser especializada em um único assunto e possuir apenas uma 
         * responsabilidade dentro do software, ou seja, a classe deve ter 
         * uma única tarefa ou ação para executar.
           Então na classe cliente somente terá suas propriedades de 
           acordo com código a abaixo:*/
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Email Email  { get; set; }
        public CPF Cpf{ get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
