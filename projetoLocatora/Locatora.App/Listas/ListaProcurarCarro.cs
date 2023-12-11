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

namespace Locatora.App.Listas
{
    public partial class ListaProcurarCarro : MaterialForm
    {



        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Cadastrar_carro> _cadastrar_carroService;

        public static Usuario Usuario { get; set; }
        public static Cadastrar_carro Cadastrar_carro { get; set; }

        private List<Cadastrar_carroModel>? carros;


        public ListaProcurarCarro(IBaseService<Usuario> usuarioService,
                                  IBaseService<Cadastrar_carro> cadastrar_carroService)
        {
            _usuarioService = usuarioService;
            _cadastrar_carroService = cadastrar_carroService;
            InitializeComponent();
            txtTeste.Text = $"{Usuario.Nome}";
            CarregaGrid();
        }

        protected void CarregaGrid()
        {
            carros = _cadastrar_carroService.Get<Cadastrar_carroModel>().ToList();
            dataGridViewProcurar.DataSource = carros;
            dataGridViewProcurar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            /////dataGridViewProcurar.Columns["Seguro"]!.Visible = false;
            //carros = _cadastrar_carroService.Get<Cadastrar_carroModel>().ToList();
            //dataGridViewProcurar.DataSource = carros;
            //dataGridViewProcurar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
