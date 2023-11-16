using Locatora.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class ofertas_reserva : BaseEntity<int>
    {
        public ofertas_reserva()
        {
            
        }

        public ofertas_reserva(int id, string? nome, string? endereco, string? bairro, cadastrar_carro? cidade) : base(id)
        {
            Nome = nome;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public cadastrar_carro? Cidade { get; set; }
    }
}
