using Locatora.Domain.Base;

namespace Locatora.Domain.Entities
{
    public class Cadastrar_carro : BaseEntity<int>
    {
        public Cadastrar_carro()
        {
            
        }

        public Cadastrar_carro(int id, string? modelo, string? placa, string? ano, string? valor_dia, string? seguro, Usuario? usuario) : base(id)
        {
            Modelo = modelo;
            Placa = placa;
            Ano = ano;
            Valor_dia = valor_dia;
            Seguro = seguro;
            Usuario = usuario;
        }

        public string? Modelo { get; set; }
        public string? Placa { get; set; }
        public string? Ano { get; set; }
        public string? Valor_dia { get; set; }
        public string? Seguro { get; set; }
        public Usuario? Usuario { get; set; }
    }
}