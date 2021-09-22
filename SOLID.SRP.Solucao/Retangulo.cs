using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Solucao
{
    /*
     O princípio de Liskov Substitution Principle nos permite usar 
     o polimorfismo com mais confiança. Podemos chamar nossas classes derivadas 
     referindo-se à sua classe base sem preocupações com resultados inesperados.
    */
    public abstract class Paralelogramo
    {
        protected Paralelogramo(int altura, int largura)
        {
            {
                Altura = altura;
                Largura = largura;
            }
        }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Area { get; set; }
    }
    
    public class Retangulo:Paralelogramo
    {
        public Retangulo(int altura,int largura):base(altura,largura)
        {

        }
    }

    public class Quadrado:Paralelogramo
    {
        public Quadrado(int altura,int largura):base(altura,largura)
        {
            if (largura!=altura)
            {
                throw new ArgumentException("Os dois lados do quadrado precisa ser iguais");
            }
        }
    }

    public class CalculoArea
    {
        private static void ObterAreaParaleloGramo(Paralelogramo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retângulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura+" * "+ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado(5, 5);
            var ret = new Retangulo(10, 5);

            ObterAreaParaleloGramo(quad);
            ObterAreaParaleloGramo(ret);
        }
    }

}
