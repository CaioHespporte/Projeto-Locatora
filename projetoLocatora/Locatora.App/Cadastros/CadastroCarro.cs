using Locatora.App.Outros;
using Locatora.Domain.Entities;
using Locatora.Service.Validators;
using Locatora.App.Base;
using ReaLTaiizor.Forms;
using Locatora.Domain.Base;
using ReaLTaiizor.Controls;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Locatora.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;


namespace Locatora.App.Cadastros
{
    public partial class CadastroCarro : CadastroBase
    {

        public static Usuario usuario { get; set; }


        private readonly IBaseService<Carro> _carroService;
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Estado> _estadoService;
        private readonly IBaseService<Cidade> _cidadeService;


        //private List<Cadastrar_carro>? Cadastrar_carros;

        public CadastroCarro(IBaseService<Carro> cadastrar_carroService,
                             IBaseService<Usuario> usuarioService,
                             IBaseService<Estado> estadoService,
                             IBaseService<Cidade> cidadeService)
        {
            _usuarioService = usuarioService;
            _carroService = cadastrar_carroService;
            _estadoService = estadoService;
            _cidadeService = cidadeService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboEstado.ValueMember = "Id";
            cboEstado.DisplayMember = "Nome";
            cboEstado.DataSource = _estadoService.Get<Estado>().ToList();
            cboEstado.SelectedIndex = 1;
            cboEstado.SelectedIndex = 0;
        }

        private void PreencheObjeto(Carro carro)
        {
            carro.Modelo = txtModelo.Text;
            carro.Placa = txtPlaca.Text;
            carro.Ano = int.Parse(txtAno.Text);

            string valorDiaSemMascara = new string(mmtbValor_dia.Text.Where(char.IsDigit).ToArray());
            if (int.TryParse(valorDiaSemMascara, out var valorDia))
            {
                carro.Valor_dia = (float)valorDia / 100.0f;
            }
            else
            {
                MessageBox.Show("Não foi possível converter o valor diário para um número!");
            }

            if (int.TryParse(cboEstado.SelectedValue.ToString(), out var idEstado))
            {
                var estado = _estadoService.GetById<Estado>(idEstado);                
                carro.Estado = estado;
            }

            if(cboCidade.SelectedValue != null)
            {
                if (int.TryParse(cboCidade.SelectedValue.ToString(), out var idCidade))
                {
                    var cidade = _cidadeService.GetById<Cidade>(idCidade);
                    carro.Cidade = cidade;
                }
            }

            carro.Alugado = false;
            carro.Seguro = cbSeguro.Checked;
            carro.Usuario = usuario;

        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var carro = _carroService.GetById<Carro>(id);
                        PreencheObjeto(carro);
                        carro = _carroService.Update<Carro, Carro, CarroValidator>(carro);
                    }
                }
                else
                {
                    var carro = new Carro();
                    PreencheObjeto(carro);
                    _carroService.Add<Carro, Carro, CarroValidator>((Carro)carro);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Locatora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idEstado = int.Parse(cboEstado.SelectedValue.ToString());
            var estado = _estadoService.GetById<Estado>(idEstado, new[] {"Cidades"});
            
            cboCidade.ValueMember = "Id";
            cboCidade.DisplayMember = "Nome";
            cboCidade.DataSource = estado.Cidades.ToList();
        }
    }
}
