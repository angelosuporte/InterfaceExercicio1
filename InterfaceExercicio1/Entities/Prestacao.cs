using System;
using System.Globalization;

namespace InterfaceExercicio1.Entities
{
    class Prestacao
    {
        public DateTime DataVencimento { get; private set; }
        public double Quantia { get; private set; }

        public Prestacao(DateTime dataVencimento, double quantia)
        {
            DataVencimento = dataVencimento;
            Quantia = quantia;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Quantia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
