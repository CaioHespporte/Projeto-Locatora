using Locatora.Domain.Base;
using Locatora.Domain.Entities;
using Locatora.App.Base;
using Locatora.App.Models;
using Locatora.Service.Validators;
using System.Globalization;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;
using Locatora.App.Cadastros;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;
using Locatora.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using Locatora.App.Outros;
using System.Windows.Forms.VisualStyles;

namespace Locatora.App.Listas
{
    public partial class ListaMeusCarros : MaterialForm
    {
        private readonly IBaseService<Carro> _carroService;
        private readonly IBaseService<Reserva> _reservaService;
        public static Usuario usuario { get; set; }

        public ListaMeusCarros(IBaseService<Carro> carroService, IBaseService<Reserva> reservaService)
        {
            _carroService = carroService;
            _reservaService = reservaService;
            InitializeComponent();
            CarregaGrid();            
        }

        protected void CarregaGrid()
        {
            var carros = _carroService.Get<CarroModel>(new[] { "Usuario", "Cidade", "Estado" }).ToList();
            var meusCarros = carros.Where<CarroModel>(carro => carro.IdUsuario == usuario.Id).ToList();
            dataGridViewCarros.DataSource = meusCarros;
            dataGridViewCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCarros.MultiSelect = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(dataGridViewCarros.SelectedRows.Count > 0) {
                int id = int.Parse(dataGridViewCarros.SelectedRows[0].Cells[0].Value.ToString());
                var carro = _carroService.GetById<Carro>(id);
                txtCarro.Text = carro.Modelo + " " + carro.Ano + " " + carro.Placa;
                txtValorDiaria.Text = carro.Valor_dia.ToString();
                chbAlugado.Checked = (bool)carro.Alugado;
                chbSeguro.Checked = (bool)carro.Seguro;
                groupBoxCarro.Visible = true;
                btnAlterar.Enabled = false;
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente excluir este carro?", @"Locatora", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(dataGridViewCarros.SelectedRows[0].Cells[0].Value.ToString());
                    _carroService.Delete(id);
                    CarregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void PreencheObjeto(Carro carro)
        {
            if(float.TryParse(txtValorDiaria.Text, out var valorDiaria)){
                carro.Valor_dia = valorDiaria;
            }
            carro.Alugado = chbAlugado.Checked;
            carro.Seguro = chbSeguro.Checked;
        }

        protected void Salvar()
        {
            try
            {
                int id = int.Parse(dataGridViewCarros.SelectedRows[0].Cells[0].Value.ToString());
                var carro = _carroService.GetById<Carro>(id, new[] {"Estado", "Cidade"});
                PreencheObjeto(carro);
                carro = _carroService.Update<Carro, Carro, CarroValidator>(carro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Locatora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxCarro.Visible = false;
            btnAlterar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            CarregaGrid();
            groupBoxCarro.Visible = false;
            btnAlterar.Enabled = true;
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewCarros.SelectedRows[0].Cells[0].Value.ToString());
            var reservas = _reservaService.Get<ReservaModel>(new[] { "Carro", "Usuario" }).Where<ReservaModel>(reserva => reserva.IdCarro == id).ToList();
            dataGridViewReserva.DataSource = reservas;
            dataGridViewReserva.Visible = !dataGridViewReserva.Visible;

        }
    }
}
