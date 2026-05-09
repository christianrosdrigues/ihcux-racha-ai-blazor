namespace RachaAiBlazor.Models
{
    public class Grupo
    {
        public string Nome { get; set; } = string.Empty;

        public string Categoria { get; set; } = string.Empty;

        public decimal Valor { get; set; }

        public bool TenhoCredito { get; set; }
    }
}