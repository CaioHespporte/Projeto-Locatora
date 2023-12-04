namespace Locatora.App.Models
{
    public class OfertaModel
    {
        public OfertaModel()
        {
            Items = new List<Ofertas_reservaModel>();
        }
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public List<Ofertas_reservaModel> Items { get; set; }
    }

    public class Ofertas_reservaModel
    {
        public int Id { get; set; }
        public float Preco { get; set; }
        public int IdUsuario { get; set; }
        public required string Usuario { get; set; }
        public int IdCadastrar_Carro { get; set; }
        public required string Cadastrar_carro { get; set; }
    }
}
