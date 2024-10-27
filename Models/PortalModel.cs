namespace CarClinic.Models
{
    public class PortalModel
    {
        public int Id { get; set; }
        public string Proprietario { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string Placa { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public int Ano { get; set; }
        public byte[]? Foto { get; set; }
        public string TipoImagem { get; set; } = string.Empty;
        public DateOnly Cadastro { get; set; }
        public DateTime Atualizacao { get; set; } = DateTime.Now;
        public string Status { get; set; } = string.Empty;
        public string? Observacoes { get; set; } = string.Empty;
    }
}
