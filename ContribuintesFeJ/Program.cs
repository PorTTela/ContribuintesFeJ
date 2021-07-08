using System;
using ContribuintesFeJ.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ContribuintesFeJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>();

            Console.Write("Entre com o numero de Contribuintes: ");
            int nContribuintes = int.Parse(Console.ReadLine());

            for (int n = 1; n <= nContribuintes; n++)
            {
                Console.WriteLine($"Contribuinte #{n}");
                Console.Write("Pessoa Física ou Pessoa Juridica (F/J): ");
                char tipoContribuinte = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipoContribuinte == 'F')
                {
                    Console.Write("Gastos com Saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                }
                else
                {
                    Console.Write("Quantos funcionarios a Empresa tem: ");
                    int nFuncionarios = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaJuridica(nome, rendaAnual, nFuncionarios));
                }

                
                Console.WriteLine();
                Console.WriteLine("Taxas de Impostos");
                double totalImpostos = 0.0;
                foreach(Contribuintes cont in list)
                {
                    double imposto = cont.Imposto();
                    Console.WriteLine(cont.Nome + ": %" + imposto.ToString("F2", CultureInfo.InvariantCulture));
                    totalImpostos += imposto;
                }

                Console.WriteLine();
                Console.WriteLine("Imposto Total: " + totalImpostos.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
