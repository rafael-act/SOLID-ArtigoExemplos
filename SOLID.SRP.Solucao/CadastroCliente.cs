using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Solucao
{
    /*No princípio da Segregação de Interfaces (ISP) diz que “muitas interfaces específicas 
 * são melhores do que uma interface geral” que se trata da coesão em interfaces, 
 * da construção de módulos enxutos, ou seja, com poucos comportamentos. Interfaces 
 * que possuem muitos comportamentos são difíceis de manter e evoluir, e devem ser evitadas.*/
    public class CadastroCliente:ICadastroCliente
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o cliente
        }
    }
}
