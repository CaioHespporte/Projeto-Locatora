namespace Locatora.App.Listas
{
    partial class ListaProcurarCarro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewProcurarCarro = new ListView();
            colunaModelo = new ColumnHeader();
            colunaPlaca = new ColumnHeader();
            colunaAno = new ColumnHeader();
            colunaSeguro = new ColumnHeader();
            colunaValor_dia = new ColumnHeader();
            colunaCidade = new ColumnHeader();
            colunaEstado = new ColumnHeader();
            colunaTelefone = new ColumnHeader();
            btnReservar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // listViewProcurarCarro
            // 
            listViewProcurarCarro.Columns.AddRange(new ColumnHeader[] { colunaModelo, colunaPlaca, colunaAno, colunaSeguro, colunaValor_dia, colunaCidade, colunaEstado, colunaTelefone });
            listViewProcurarCarro.FullRowSelect = true;
            listViewProcurarCarro.GridLines = true;
            listViewProcurarCarro.Location = new Point(29, 87);
            listViewProcurarCarro.MultiSelect = false;
            listViewProcurarCarro.Name = "listViewProcurarCarro";
            listViewProcurarCarro.Size = new Size(768, 285);
            listViewProcurarCarro.TabIndex = 0;
            listViewProcurarCarro.UseCompatibleStateImageBehavior = false;
            listViewProcurarCarro.View = View.Details;
            // 
            // colunaModelo
            // 
            colunaModelo.Text = "Modelo";
            colunaModelo.Width = 100;
            // 
            // colunaPlaca
            // 
            colunaPlaca.Text = "Placa";
            colunaPlaca.Width = 80;
            // 
            // colunaAno
            // 
            colunaAno.Text = "Ano";
            colunaAno.Width = 80;
            // 
            // colunaSeguro
            // 
            colunaSeguro.Text = "Seguro?";
            colunaSeguro.Width = 90;
            // 
            // colunaValor_dia
            // 
            colunaValor_dia.Text = "Valor da diária";
            colunaValor_dia.Width = 120;
            // 
            // colunaCidade
            // 
            colunaCidade.Text = "Cidade";
            colunaCidade.Width = 120;
            // 
            // colunaEstado
            // 
            colunaEstado.Text = "Estado";
            colunaEstado.Width = 80;
            // 
            // colunaTelefone
            // 
            colunaTelefone.Text = "Celular";
            colunaTelefone.Width = 120;
            // 
            // btnReservar
            // 
            btnReservar.AutoSize = false;
            btnReservar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReservar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReservar.Depth = 0;
            btnReservar.HighEmphasis = true;
            btnReservar.Icon = null;
            btnReservar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnReservar.Location = new Point(455, 394);
            btnReservar.Margin = new Padding(4, 6, 4, 6);
            btnReservar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnReservar.Name = "btnReservar";
            btnReservar.NoAccentTextColor = Color.Empty;
            btnReservar.Size = new Size(216, 36);
            btnReservar.TabIndex = 1;
            btnReservar.Text = "Reservar Carro";
            btnReservar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReservar.UseAccentColor = false;
            btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(142, 394);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(216, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ListaProcurarCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnReservar);
            Controls.Add(listViewProcurarCarro);
            Name = "ListaProcurarCarro";
            Text = "Locatora - Procurar Carro";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewProcurarCarro;
        private ColumnHeader colunaModelo;
        private ColumnHeader colunaPlaca;
        private ColumnHeader colunaAno;
        private ColumnHeader colunaValor_dia;
        private ColumnHeader colunaSeguro;
        private ColumnHeader colunaCidade;
        private ColumnHeader colunaEstado;
        private ReaLTaiizor.Controls.MaterialButton btnReservar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ColumnHeader colunaTelefone;
    }
}