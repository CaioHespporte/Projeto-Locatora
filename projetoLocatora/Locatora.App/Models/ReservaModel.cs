namespace Locatora.App.Models
{
    public class ReservaModel
    {
        public int Id { get; set; }
        public string? Andamento { get; set; }
        public float? Valor_total { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }

        public int IdUsuario { get; set; }
        public required string Usuario { get; set; }
        public int IdCarro { get; set; }
        public required string Carro{ get; set; }

        public string? Proprietario { get; set; }
    }
}
