namespace ProjetoLeitorXls.console
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string? UrlImagemCadastro { get; set; }
        public Usuario(string nome, string email, string cpf, DateTime dataNascimento, string senha)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Senha = senha;
        }
        public Usuario(string nome, string email, string cpf, DateTime dataNascimento, string senha, string urlImagemCadastro)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Senha = senha;
            UrlImagemCadastro = urlImagemCadastro;
        }
    }
}