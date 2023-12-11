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

        public static Usuario Usuario { get; set; }


        private readonly IBaseService<Cadastrar_carro> _cadastrar_carroService;
        private readonly IBaseService<Usuario> _usuarioService;


        //private List<Cadastrar_carro>? Cadastrar_carros;

        public CadastroCarro(IBaseService<Cadastrar_carro> cadastrar_carroService,
                             IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            _cadastrar_carroService = cadastrar_carroService;
            InitializeComponent();
        }


        private void PreencheObjeto(Cadastrar_carro cadastrar_carro)
        {
            cadastrar_carro.Modelo = txtModelo.Text;
            cadastrar_carro.Placa = txtPlaca.Text;
            cadastrar_carro.Ano = int.Parse(txtAno.Text);
            cadastrar_carro.Cidade = txtCidade.Text;
            cadastrar_carro.Estado = cboEstado.Text;
            cadastrar_carro.UsuarioId = Usuario.Id;
            string valorDiaSemMascara = new string(mmtbValor_dia.Text.Where(char.IsDigit).ToArray());
            if (int.TryParse(valorDiaSemMascara, out var valorDia))
            {
                cadastrar_carro.Valor_dia = (float)valorDia/100.0f;
            }
            else
            {
                // Tratar o caso em que a conversão falha
                Console.WriteLine("Não foi possível converter o valor diário para um número inteiro.");
            }

            //cadastrar_carro.Seguro = cbSeguro.Checked;
            cadastrar_carro.Seguro = cbSeguro.Checked;


        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var cadastrar_carro = _cadastrar_carroService.GetById<Cadastrar_carro>(id);
                        PreencheObjeto(cadastrar_carro);
                        cadastrar_carro = _cadastrar_carroService.Update<Cadastrar_carro, Cadastrar_carro, Cadastrar_carroValidator>(cadastrar_carro);
                    }
                }
                else
                {

                    var cadastrar_carro = new Cadastrar_carro();
                    PreencheObjeto(cadastrar_carro);
                    _cadastrar_carroService.Add<Cadastrar_carro, Cadastrar_carro, Cadastrar_carroValidator>(cadastrar_carro);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Locatora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
