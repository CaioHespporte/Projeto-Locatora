using Locatora.Domain.Base;

namespace Locatora.Domain.Entities
{
    public class Estado : BaseEntity<int>
    {
        public Estado()
        {

        }

        public Estado(int id, string? nome, string? uf) : base(id)
        {
            Nome = nome;
            Uf = uf;
        }

        public string? Nome { get; set; }
        public string? Uf { get; set; }
        public ICollection<Cidade> Cidades { get; set; } = new List<Cidade>();
    }
}