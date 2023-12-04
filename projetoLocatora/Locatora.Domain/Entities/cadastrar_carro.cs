using Locatora.Domain.Base;

namespace Locatora.Domain.Entities
{
    public class Cadastrar_carro : BaseEntity<int>
    {
        public Cadastrar_carro()
        {

        }

        public Cadastrar_carro(int id, string? modelo, string? placa, int? ano, float? valor_dia, string? seguro, string? cidade, string? estado, Usuario? usuario) : base(id)
        {
            Modelo = modelo;
            Placa = placa;
            Ano = ano;
            Valor_dia = valor_dia;
            Seguro = seguro;
            Usuario = usuario;
            Cidade = cidade;
            Estado = estado;
        }

        public string? Modelo { get; set; }
        public string? Placa { get; set; }
        public int? Ano { get; set; }
        public float? Valor_dia { get; set; }
        public string? Seguro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        public Usuario? Usuario { get; set; }
    }
}