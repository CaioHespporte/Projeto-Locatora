namespace Locatora.App.Models
{
    public class CarroModel
    {
        public int Id { get; set; }
        public string? Modelo { get; set; }
        public string? Placa { get; set; }
        public string? Ano { get; set; }
        public string? Valor_dia { get; set; }
        public bool? Seguro { get; set; }
        public bool? Alugado { get; set; }

        public int idCidade { get; set; }
        public string? Cidade { get; set; }

        public int idEstado { get; set; }
        public string? Estado { get; set; }

        public int IdUsuario { get; set; }
        public string? Usuario { get; set; }

    }
}
