using System;
using InterfaceExercicio1.Entities;
using System.Globalization;
using InterfaceExercicio1.Servico;

namespace InterfaceExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do contrato");
            Console.Write("Número: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dia/mês/ano): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Informe o valor do contrato: ");
            double valorTotalContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o número de prestações: ");
            int months = int.Parse(Console.ReadLine());

            Contrato novoContrato = new Contrato(numeroContrato, dataContrato, valorTotalContrato);

            ServicoDoContrato servicoDoContrato = new ServicoDoContrato(new PaypalServico());
            servicoDoContrato.ProcessamentoDoContrato(novoContrato, months);

            Console.WriteLine("Prestações: ");
            foreach(Prestacao prestacao in novoContrato.Prestacoes)
            {
                Console.WriteLine(prestacao);
            }

            Console.ReadKey();
        }
    }
}
