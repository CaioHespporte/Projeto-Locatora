using Locatora.Domain.Base;

namespace Locatora.Domain.Entities
{
    public class Cidade : BaseEntity<int>
    {
        public Cidade()
        {

        }

        public Cidade(int id, string? nome, Estado? estado) : base(id)
        {
            Nome = nome;
            Estado = estado;
        }

        public string? Nome { get; set; }
        
        public Estado? Estado { get; set; }
    }
}