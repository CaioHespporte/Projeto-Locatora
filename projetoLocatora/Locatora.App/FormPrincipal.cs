using Locatora.App.Cadastros;
using Locatora.App.Infra;
using Locatora.App.Listas;
using Locatora.App.Outros;
using Locatora.Domain.Base;
using Locatora.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace Locatora.App

{
    public partial class FormPrincipal : MaterialForm
    {
        private readonly IBaseService<Usuario> _usuarioService;

        public static Usuario Usuario { get; set; }
        bool logado = false;

        public FormPrincipal(IBaseService<Usuario> usuarioService)
        {
            InitializeComponent();
            CarregaLogin();
            _usuarioService = usuarioService;
            logado = true;
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    mlblNome.Text = $"{Usuario.Nome}";
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            CadastroCarro.Usuario = Usuario;
            ExibeFormulario<CadastroCarro>();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProcurarCarro_Click(object sender, EventArgs e)
        {
            ListaProcurarCarro.Usuario = Usuario;
            ExibeFormulario<ListaProcurarCarro>();
        }

        private void ExibeFormulario<TFormlario>() where TFormlario : Form
        {

            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {

                btnCadastrarCarro.Enabled = false;
                btnProcurarCarro.Enabled = false;
                btnExibirReservas.Enabled = false;
                btnSair.Enabled = false;
                cad.MdiParent = this;
                cad.Show();
                cad.FormClosed += (sender, e) =>
                {
                    btnCadastrarCarro.Enabled = true;
                    btnProcurarCarro.Enabled = true;
                    btnExibirReservas.Enabled = true;
                    btnSair.Enabled = true;
                };
            }
        }

    }
}