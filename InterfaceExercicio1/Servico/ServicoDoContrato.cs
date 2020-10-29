using System;
using InterfaceExercicio1.Entities;

namespace InterfaceExercicio1.Servico
{
    class ServicoDoContrato
    {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ServicoDoContrato(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ProcessamentoDoContrato(Contrato contrato, int months)
        {
            double cotaBasica = contrato.ValorTotalDoContrato / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime data = contrato.DataDoContrato.AddMonths(i);
                double atualizaCota = cotaBasica + _servicoPagamentoOnline.Juros(cotaBasica, i);
                double cotaTotal = atualizaCota + _servicoPagamentoOnline.Taxa(atualizaCota);
                contrato.AddPrestacao(new Prestacao(data, cotaTotal));
            }
        }
    }
}
