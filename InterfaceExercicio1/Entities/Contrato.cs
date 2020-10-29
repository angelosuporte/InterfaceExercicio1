using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercicio1.Entities
{
    class Contrato
    {
        public int NumeroDoContrato { get; set; }
        public DateTime DataDoContrato { get; set; }
        public double ValorTotalDoContrato { get; set; }
        public List<Prestacao> Prestacoes { get; private set; }

        public Contrato(int numeroContrato, DateTime dataContrato, double valorTotalContrato)
        {
            NumeroDoContrato = numeroContrato;
            DataDoContrato = dataContrato;
            ValorTotalDoContrato = valorTotalContrato;
            Prestacoes = new List<Prestacao>();
        }

        public void AddPrestacao(Prestacao prestacao)
        {
            Prestacoes.Add(prestacao);
        }
    }
}
