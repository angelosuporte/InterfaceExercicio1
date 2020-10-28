using System;
using InterfaceExercicio1.Entities;
using System.Globalization;

namespace InterfaceExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do ontrato");
            Console.Write("Número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Data (dia/mês/ano): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Informe o valor do contrato:");
            double valorTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o número de prestações: ");
            int prestacoes = int.Parse(Console.ReadLine());  
            //falta instanciar o contrato

        }
    }
}
