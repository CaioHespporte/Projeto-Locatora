using Locatora.App.Models;
using Locatora.Domain.Base;
using Locatora.Domain.Entities;
using ReaLTaiizor.Forms;

namespace Locatora.App.Listas
{
    public partial class ListaExibirReservas : MaterialForm
    {
        public static Usuario usuario { get; set; }

        private readonly IBaseService<Carro> _carroService;
        private readonly IBaseService<Reserva> _reservaService;

        private List<ReservaModel>? reservas;

        public ListaExibirReservas(IBaseService<Reserva> reservaService, IBaseService<Carro> carroService)
        {
            _reservaService = reservaService;
            _carroService = carroService;
            InitializeComponent();
            CarregaGrid();            
        }

        protected void CarregaGrid()
        {
            reservas = _reservaService.Get<ReservaModel>(new[] { "Carro", "Usuario" }).Where<ReservaModel>(reserva => reserva.IdUsuario == usuario.Id).ToList();
            reservas.ForEach(reserva =>
            {
                reserva.Proprietario = _carroService.GetById<CarroModel>(reserva.IdCarro, new[] { "Usuario" }).Usuario;
            });
            dataGridViewReserva.DataSource = reservas;
            dataGridViewReserva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReserva.MultiSelect = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente excluir esta reserva?", @"Locatora", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(dataGridViewReserva.SelectedRows[0].Cells[0].Value.ToString());
                    _reservaService.Delete(id);
                    CarregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }           

        }
    }
}
