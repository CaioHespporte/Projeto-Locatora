using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;

namespace Locatora.App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsAlteracao = false;
        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente cancelar o cadastro e sair?", @"Locatora", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                LimpaCampos();
                Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Salvar();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Deseja realmente limpar todos os campos?", @"Locatora", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                LimpaCampos();
            }
        }

        #endregion
        protected void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (Control control in Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        protected virtual void Salvar()
        {

        }

        protected virtual void Deletar()
        {

        }

    }
}