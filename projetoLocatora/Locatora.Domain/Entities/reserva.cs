﻿using Locatora.Domain.Base;

namespace Locatora.Domain.Entities
{
    public class Reserva : BaseEntity<int>
    {
        public Reserva()
        {

        }

        public Reserva(int id, string? andamento, float? valor_total, DateTime? data_inicio, DateTime? data_fim, Usuario? usuario, Carro? carro) : base(id)
        {
            Andamento = andamento;
            Valor_total = valor_total;
            Data_Inicio = data_inicio;
            Data_Fim = data_fim;
            Usuario = usuario;
            Carro = carro;
        }

        public string? Andamento { get; set; }
        public float? Valor_total { get; set; }
        public DateTime? Data_Inicio { get; set; }
        public DateTime? Data_Fim { get; set; }
        public Usuario? Usuario { get; set; }
        public Carro? Carro { get; set; }
    }
}
