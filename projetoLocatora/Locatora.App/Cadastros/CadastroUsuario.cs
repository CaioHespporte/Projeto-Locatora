using Locatora.App.Base;
using Locatora.App.Models;
using Locatora.Domain.Base;
using Locatora.Domain.Entities;
using Locatora.Service.Validators;
using ReaLTaiizor.Controls;

namespace Locatora.App.Cadastros
{
    public partial class CadastroUsuario : CadastroBase
    {
        private readonly IBaseService<Usuario> _usuarioService;

        public CadastroUsuario(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }


        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            string numeroRGSemMascara = new string(mmtbRG.Text.Where(char.IsDigit).ToArray());
            if (int.TryParse(numeroRGSemMascara, out var rgNumerico))
            {
                usuario.Rg = rgNumerico;
            }

            string numeroCPFSemMascara = new string(mmtbCPF.Text.Where(char.IsDigit).ToArray());
            usuario.CPF = numeroCPFSemMascara;

            string numeroTelefoneSemMascara = new string(mmtbTelefone.Text.Where(char.IsDigit).ToArray());
            usuario.Telefone = numeroTelefoneSemMascara;


            if (DateTime.TryParse(mmtbDtNascimento.Text, out var dataNascimento))
            {
                usuario.DataNascimento = dataNascimento;
            }

            usuario.DataCadastro = DateTime.Now;

            

        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario);
                    _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Locatora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
