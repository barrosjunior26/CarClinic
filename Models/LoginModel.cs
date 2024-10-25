namespace CarClinic.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public DateTime Cadastro { get; set; } = DateTime.Now;
    }
}
