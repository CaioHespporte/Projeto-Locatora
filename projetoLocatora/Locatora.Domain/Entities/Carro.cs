using Locatora.Domain.Base;

namespace Locatora.Domain.Entities
{
    public class Carro : BaseEntity<int>
    {
        public Carro()
        {

        }

        public Carro(int id, string? modelo, string? placa, int? ano, float? valor_dia, bool? seguro, bool? alugado, Cidade? cidade, Estado? estado, Usuario? usuario) : base(id)
        {
            Modelo = modelo;
            Placa = placa;
            Ano = ano;
            Valor_dia = valor_dia;
            Seguro = seguro;
            Usuario = usuario;
            Cidade = cidade;
            Estado = estado;
            Alugado = alugado;
        }

        public string? Modelo { get; set; }
        public string? Placa { get; set; }
        public int? Ano { get; set; }
        public float? Valor_dia { get; set; }
        public bool? Seguro { get; set; }

        public bool? Alugado { get; set; }
        public Cidade? Cidade { get; set; }
        public Estado? Estado { get; set; }
        public Usuario? Usuario { get; set; }
    }
}