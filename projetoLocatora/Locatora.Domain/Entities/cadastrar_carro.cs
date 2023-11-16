using Locatora.Domain.Base;

namespace Locatora.Domain.Entities
{
    public class cadastrar_carro : BaseEntity<int>
    {
        public cadastrar_carro()
        {
            
        }

        public cadastrar_carro(int id, string? nome, string? estado) : base(id)
        {
            Nome = nome;
            Estado = estado;
        }

        public string? Nome { get; set; }
        public string? Estado { get; set; }
    }
}