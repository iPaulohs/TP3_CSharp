namespace _3._4.Modells
{
    internal abstract class PublicacaoBase
    {
        internal virtual int TempoParaEntrega { get; set; }
        internal string? Titulo { get; set; }
        internal DateTime DataAluguel { get; set; }
        internal DateTime DataEntrega { get; set; }

        public abstract string MostraDataEntrega();
    }
}
