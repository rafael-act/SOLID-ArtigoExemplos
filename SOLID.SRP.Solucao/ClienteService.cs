using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Solucao
{
    public class ClienteService
    {
        /*Já no método cliente colocamos em uma classe que será responsável 
         * por todas ações de inserção do novo cliente.*/

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar()) 
            {
                return "Dados inválidos";
            }

            var repo = new ClienteRepository();
            repo.AdicionarCliente(Cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
