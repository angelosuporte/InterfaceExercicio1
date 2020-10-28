namespace InterfaceExercicio1.Servico
{
    class PaypalServico : IServicoPagamentoOnline
    {
        private const double TaxaPagamento = 0.02;
        private const double JurosPorMes = 0.01;

        public double Juros(double quantia, int prestacoes)
        {
            return quantia * JurosPorMes * prestacoes;
        }

        public double Taxa(double quantia)
        {
            return quantia * TaxaPagamento;
        }
    }
}
