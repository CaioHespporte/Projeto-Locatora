using Locatora.Domain.Base;

namespace Locatora.Domain.Entities
{
    public class Oferta : BaseEntity<int>
    {
        public Oferta()
        {
            Ofertas = new List<Ofertas_reserva>();
        }

        public Oferta(int id, DateTime data, float valorTotal, Usuario? usuario, List<Ofertas_reserva> ofertas) : base(id)
        {

            Data = data;
            ValorTotal = valorTotal;
            Usuario = usuario;
            Ofertas = ofertas;
        }

        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public Usuario? Usuario { get; set; }
        public List<Ofertas_reserva> Ofertas { get; set; }
    }
    public class Ofertas_reserva : BaseEntity<int>
    {
        public Ofertas_reserva()
        {

        }

        public Ofertas_reserva(int id, float? preco, Usuario? usuario, Cadastrar_carro? cadastrar_carro, Oferta? oferta) : base(id)
        {
            Preco = preco;
            Usuario = usuario;
            Cadastrar_carro = cadastrar_carro;
            Oferta = oferta;
        }

        public float? Preco { get; set; }
        public Usuario? Usuario { get; set; }
        public Cadastrar_carro? Cadastrar_carro { get; set; }
        public Oferta? Oferta { get; set; }
    }
}
