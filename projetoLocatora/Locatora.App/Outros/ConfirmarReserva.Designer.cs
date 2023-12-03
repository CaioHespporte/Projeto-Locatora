namespace Locatora.App.Outros
{
    partial class ConfirmarReserva
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
            groupBox1 = new GroupBox();
            materialTextBoxEdit1 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnConfirmar = new ReaLTaiizor.Controls.MaterialButton();
            listViewProcurarCarro = new ListView();
            colunaModelo = new ColumnHeader();
            colunaPlaca = new ColumnHeader();
            colunaAno = new ColumnHeader();
            colunaSeguro = new ColumnHeader();
            colunaValor_dia = new ColumnHeader();
            colunaCidade = new ColumnHeader();
            colunaEstado = new ColumnHeader();
            colunaTelefone = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialCheckBox1);
            groupBox1.Controls.Add(materialTextBoxEdit1);
            groupBox1.Location = new Point(33, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // materialTextBoxEdit1
            // 
            materialTextBoxEdit1.AnimateReadOnly = false;
            materialTextBoxEdit1.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit1.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit1.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit1.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit1.Depth = 0;
            materialTextBoxEdit1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxEdit1.HideSelection = true;
            materialTextBoxEdit1.Hint = "Duração da Reserva (Dias)";
            materialTextBoxEdit1.LeadingIcon = null;
            materialTextBoxEdit1.Location = new Point(43, 34);
            materialTextBoxEdit1.MaxLength = 32767;
            materialTextBoxEdit1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit1.Name = "materialTextBoxEdit1";
            materialTextBoxEdit1.PasswordChar = '\0';
            materialTextBoxEdit1.PrefixSuffixText = null;
            materialTextBoxEdit1.ReadOnly = false;
            materialTextBoxEdit1.RightToLeft = RightToLeft.No;
            materialTextBoxEdit1.SelectedText = "";
            materialTextBoxEdit1.SelectionLength = 0;
            materialTextBoxEdit1.SelectionStart = 0;
            materialTextBoxEdit1.ShortcutsEnabled = true;
            materialTextBoxEdit1.Size = new Size(250, 48);
            materialTextBoxEdit1.TabIndex = 0;
            materialTextBoxEdit1.TabStop = false;
            materialTextBoxEdit1.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit1.TrailingIcon = null;
            materialTextBoxEdit1.UseSystemPasswordChar = false;
            // 
            // materialCheckBox1
            // 
            materialCheckBox1.AutoSize = true;
            materialCheckBox1.Depth = 0;
            materialCheckBox1.Location = new Point(379, 37);
            materialCheckBox1.Margin = new Padding(0);
            materialCheckBox1.MouseLocation = new Point(-1, -1);
            materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox1.Name = "materialCheckBox1";
            materialCheckBox1.ReadOnly = false;
            materialCheckBox1.Ripple = true;
            materialCheckBox1.Size = new Size(288, 37);
            materialCheckBox1.TabIndex = 1;
            materialCheckBox1.Text = "Já conversou com o dono do carro?";
            materialCheckBox1.UseAccentColor = false;
            materialCheckBox1.UseVisualStyleBackColor = true;
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
            btnCancelar.Location = new Point(129, 386);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(197, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSize = false;
            btnConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmar.Depth = 0;
            btnConfirmar.HighEmphasis = true;
            btnConfirmar.Icon = null;
            btnConfirmar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnConfirmar.Location = new Point(455, 386);
            btnConfirmar.Margin = new Padding(4, 6, 4, 6);
            btnConfirmar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.NoAccentTextColor = Color.Empty;
            btnConfirmar.Size = new Size(197, 36);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar Reserva";
            btnConfirmar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmar.UseAccentColor = false;
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // listViewProcurarCarro
            // 
            listViewProcurarCarro.Columns.AddRange(new ColumnHeader[] { colunaModelo, colunaPlaca, colunaAno, colunaSeguro, colunaValor_dia, colunaCidade, colunaEstado, colunaTelefone });
            listViewProcurarCarro.GridLines = true;
            listViewProcurarCarro.Location = new Point(16, 83);
            listViewProcurarCarro.MultiSelect = false;
            listViewProcurarCarro.Name = "listViewProcurarCarro";
            listViewProcurarCarro.Size = new Size(768, 120);
            listViewProcurarCarro.TabIndex = 6;
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
            // ConfirmarReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewProcurarCarro);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Name = "ConfirmarReserva";
            Text = "Locatora - Confirmar Reserva";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit1;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnConfirmar;
        private ListView listViewProcurarCarro;
        private ColumnHeader colunaModelo;
        private ColumnHeader colunaPlaca;
        private ColumnHeader colunaAno;
        private ColumnHeader colunaSeguro;
        private ColumnHeader colunaValor_dia;
        private ColumnHeader colunaCidade;
        private ColumnHeader colunaEstado;
        private ColumnHeader colunaTelefone;
    }
}