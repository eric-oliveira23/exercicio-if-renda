using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_rendaFamilia
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                double rendaf, alim, farm, vest, outro, total;

                Console.WriteLine("Informe a renda familiar: ");
                rendaf = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor gasto com alimentação: ");
                alim = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor gasto com farmácia: ");
                farm = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor gasto com vestuário: ");
                vest = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor de outros gastos: ");
                outro = double.Parse(Console.ReadLine());

                total = rendaf - alim - farm - vest - outro;

                if (total >= 1)
                {
                    Console.WriteLine("AINDA BEM! Esse mês sobrou dinheiro. e foi a quantida de: " + total.ToString("C"));
                }
                else
                {
                    Console.WriteLine("FUDEU ! :( Esse mês faltou dinheiro, e foi a quantida de: " + total.ToString("C"));
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("O valor digitado não corresponde ao contexto atual.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro, tente novamente mais tarde.");
            }
            Console.ReadKey();
        }
    }
}
