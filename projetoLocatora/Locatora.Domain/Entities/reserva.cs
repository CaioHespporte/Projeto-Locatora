using Locatora.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class reserva : BaseEntity<int>
    {
        public reserva()
        {
            
        }

        public reserva(int id, string? nome) : base(id)
        {
            Nome = nome;
        }

        public string? Nome { get; set; } 
    }
}
