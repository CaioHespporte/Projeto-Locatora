using Locatora.App.Cadastros;
using Locatora.App.Infra;
using Locatora.App.Models;
using Locatora.Domain.Base;
using Locatora.Domain.Entities;
using Locatora.Service.Validators;
using ReaLTaiizor.Forms;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Locatora.App.Outros
{
    public partial class Login : MaterialForm
    {
        private readonly IBaseService<Usuario> _usuarioService;
        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
#if DEBUG
            txtEmail.Text = @"admin";
            txtSenha.Text = @"admin";
#endif
        }

        public Login()
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = ObterUsuario(txtEmail.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválido(s)!", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else
            {
                usuario.DataCadastro = DateTime.Now;
                usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                FormPrincipal.Usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private Usuario? ObterUsuario(string email, string senha)
        {
            ChecaExistenciaDeUsuariosCadastrados();

            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Email == email).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }
            return usuario.Senha != senha ? null : usuario;
        }

        private void ChecaExistenciaDeUsuariosCadastrados()
        {
            var usuarios = _usuarioService.Get<UsuarioModel>().ToList();
            if (!usuarios.Any())
            {
                var usuario = new Usuario
                {
                    DataCadastro = DateTime.Now,
                    Nome = "Administrador",
                    Email = "admin",
                    Senha = "admin",
                    Rg = 999999999,
                    CPF = 999999999,
                    Telefone = 999999999,
                    DataNascimento = DateTime.Now,
                };
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void btnCadastrarNovoUsuario_Click(object sender, EventArgs e)
        {
            btnCadastrarNovoUsuario.Enabled = false;
            CadastroUsuario cadastrousuario = new CadastroUsuario();
            cadastrousuario.FormClosed += (s, args) =>
            {
                btnCadastrarNovoUsuario.Enabled = true;
            };
            cadastrousuario.Show();

        }


    }
}
