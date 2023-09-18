namespace _3._4.Modells
{
    internal class Jornal : PublicacaoBase
    {
        internal new int TempoParaEntrega = 7;

        public Jornal(string _titulo)
        {
            Titulo = _titulo;
            DataAluguel = DateTime.Now;
            DataEntrega = DataAluguel.AddDays(TempoParaEntrega);
        }

        public override string MostraDataEntrega()
        {
            DateTime dataAtual = DateTime.Now;
            double dataEntrega = DataEntrega.Subtract(dataAtual).TotalDays;
            int dataEntregaFormatado = (int)Math.Round(dataEntrega);


            return $"A data de entrega do seu jornal é {DataEntrega:dd/MM/yyyy}. Faltam {dataEntregaFormatado} dias para a entrega.";
        }
    }
}
