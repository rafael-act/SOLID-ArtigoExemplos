using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Solucao
{
    public class DebitoConta
    {
        /*Implementando do princípio OCP — Open-Closed Principle
        Portanto quando implementamos o princípio OCP iremos colocar 
        a classe DebitoConta com o tipo abstrato e tendo as propriedades 
        (NumeroTransacao, Debitar, FormatarTransacao). 
        De acordo com o código abaixo:*/
        public string NumeroTransacao { get; set; }
        public abstract string Debitar(decimal valor, string conta);

        public string FormatarTransacao()
        {
            const string chars = "ABCasDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            //numero de transacao formatado
            return NumeroTransacao;

        }
    }

    /*Criaremos classes como DebitoContaCorrente e DebitoPoupança que irão 
     * herdar as características da classe pai que será DebitoConta. 
     * De acordo com código abaixo:*/

    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //debita conta corrente
            return FormatarTransacao();
        }
    }

    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //Valida Aniversario da Conta
            //Debita conta corrente
            return FormatarTransacao();
        }
    }

    /*Com isso, conseguimos enxugar a classe DebitoConta 
     * e fazer com que ela não precise conhecer o comportamento das diversas contas. 
     * Ou seja, vamos FECHAR as classes DebitoContaCorrente e DebitoPoupança para mudanças 
     * e caso outras regras surjam para serem utilizadas na classe DebitoConta.*/
}
