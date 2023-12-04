using Locatora.Domain.Base;

namespace Locatora.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {

        }

        public Usuario(int id, string? nome, string? email, int? telefone, string? senha, int? rg, int? cpf, DateTime dataNascimento, DateTime dataCadastro) : base(id)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Rg = rg;
            CPF = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            DataCadastro = dataCadastro;
        }

        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public int? Telefone { get; set; }
        public int? Rg { get; set; }
        public int? CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
