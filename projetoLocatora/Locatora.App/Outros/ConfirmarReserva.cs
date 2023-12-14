using Locatora.Domain.Base;
using Locatora.Domain.Entities;
using Locatora.Service.Validators;
using ReaLTaiizor.Forms;
using System.ComponentModel.Design;
using System.Data;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Locatora.App.Outros
{
    public partial class ConfirmarReserva : MaterialForm
    {
        public static Carro carro { get; set; }
        public static Usuario usuario { get; set; }
        private readonly IBaseService<Reserva> _reservaService;
        private readonly IBaseService<Carro>  _carroService;

        public ConfirmarReserva(IBaseService<Reserva> reservaService, IBaseService<Carro> carroService)
        {
            _reservaService = reservaService;
            _carroService = carroService;
            InitializeComponent();

            txtProprietario.Text = carro?.Usuario?.Nome;
            txtTelefone.Text = carro?.Usuario?.Telefone;

            txtModelo.Text = carro.Modelo;
            txtPlaca.Text = carro.Placa;
            txtAno.Text = carro.Ano.ToString();
            txtValor.Text = carro.Valor_dia.ToString();
            txtCidade.Text = carro.Cidade.Nome;
            txtEstado.Text = carro.Estado.Nome;
            txtSeguro.Text = (bool)carro.Seguro ? "Sim" : "Não";
            btnConfirmar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int diasReserva = int.Parse(txtDias.Text);
            Reserva reserva = new Reserva();
            reserva.Carro = carro;
            reserva.Valor_total = diasReserva * carro.Valor_dia;
            reserva.Usuario = usuario;
            reserva.Data_Inicio = DateTime.Now;
            reserva.Data_Fim = DateTime.Now.AddDays(diasReserva);
            
            _reservaService.Add<Reserva, Reserva, ReservaValidator>(reserva);
            
            carro.Alugado = true;
            _carroService.Update<Carro, Carro, CarroValidator>(carro);

            MessageBox.Show("Reserva confirmada com sucesso!");

            Close();
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if(txtDias.Text.Length > 0 && int.Parse(txtDias.Text) > 0)
            {
                if(txtDias.Text.Length > 0) {
                    int diasReserva = int.Parse(txtDias.Text);
                    txtValorTotal.Text = (diasReserva * carro.Valor_dia).ToString();
                }                
                if (chkConfirmar.Checked)
                {
                    btnConfirmar.Enabled = true;
                }
            } else
            {
                btnConfirmar.Enabled = false;
            }
        }

        private void chkConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDias.Text.Length > 0 && int.Parse(txtDias.Text) > 0 && chkConfirmar.Checked)
            {
                btnConfirmar.Enabled = true;
            } else
            {
                btnConfirmar.Enabled = false;
            }
        }
    }
}
