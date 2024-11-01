using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emprestimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //juros 20%
            Console.WriteLine("Digite o valor do empréstimo que você deseja realizar; ");
            double ValEmp = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite em quantas vezes você deseja pagar: ");
            double qtd = double.Parse(Console.ReadLine());
            // Com juros 20%
            double valPagMais = (ValEmp * 0.2);
            double valFin = ValEmp + valPagMais;
            double CadParcela = valFin / qtd;
            Console.WriteLine("Valor total a pagar é de: " + valFin);
            Console.WriteLine("Valor de cada parcela é de: " + CadParcela);

            Console.ReadKey();
        }
    }
}
