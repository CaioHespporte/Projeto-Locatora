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
    public partial class ListaProcurarCarro : MaterialForm
    {
        private readonly IBaseService<Carro> _carroService;
        public static Usuario usuario { get; set; }

        public ListaProcurarCarro(IBaseService<Carro> carroService)
        {
            _carroService = carroService;
            InitializeComponent();
            CarregaGrid();
        }

        protected void CarregaGrid()
        {
            var carros = _carroService.Get<CarroModel>(new[] {"Usuario", "Cidade", "Estado" }).ToList();
            var carrosNaoAlugados = carros.Where<CarroModel>(carro => carro.Alugado == false && carro.IdUsuario != usuario.Id).ToList();
            dataGridViewProcurar.DataSource = carrosNaoAlugados;
            dataGridViewProcurar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProcurar.MultiSelect = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewProcurar.SelectedRows[0].Cells[0].Value.ToString());
            var carro = _carroService.GetById<Carro>(id, new[] {"Usuario", "Cidade", "Estado"});
            ConfirmarReserva.carro = carro;
            ConfirmarReserva.usuario = usuario;
            ExibeFormulario<ConfirmarReserva>();
        }

        private void ExibeFormulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {


                cad.MdiParent = this.ParentForm;
                cad.Show();
                cad.FormClosed += (sender, e) =>
                {
                    Close();
                };
            }
        }

    }
}
