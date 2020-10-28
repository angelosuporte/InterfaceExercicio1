namespace InterfaceExercicio1.Servico
{
    interface IServicoPagamentoOnline
    {
        double Taxa(double quantia);
        double Juros(double quantia, int prestacao);
    }
}
