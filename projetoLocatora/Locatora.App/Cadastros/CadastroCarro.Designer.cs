namespace Locatora.App.Cadastros
{
    partial class CadastroCarro
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
            txtModelo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPlaca = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAno = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mmtbValor_dia = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cbSeguro = new ReaLTaiizor.Controls.MaterialCheckBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // txtModelo
            // 
            txtModelo.AnimateReadOnly = false;
            txtModelo.AutoCompleteMode = AutoCompleteMode.None;
            txtModelo.AutoCompleteSource = AutoCompleteSource.None;
            txtModelo.BackgroundImageLayout = ImageLayout.None;
            txtModelo.CharacterCasing = CharacterCasing.Normal;
            txtModelo.Depth = 0;
            txtModelo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtModelo.HideSelection = true;
            txtModelo.Hint = "Modelo";
            txtModelo.LeadingIcon = null;
            txtModelo.Location = new Point(28, 86);
            txtModelo.MaxLength = 32767;
            txtModelo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtModelo.Name = "txtModelo";
            txtModelo.PasswordChar = '\0';
            txtModelo.PrefixSuffixText = null;
            txtModelo.ReadOnly = false;
            txtModelo.RightToLeft = RightToLeft.No;
            txtModelo.SelectedText = "";
            txtModelo.SelectionLength = 0;
            txtModelo.SelectionStart = 0;
            txtModelo.ShortcutsEnabled = true;
            txtModelo.Size = new Size(250, 48);
            txtModelo.TabIndex = 0;
            txtModelo.TabStop = false;
            txtModelo.TextAlign = HorizontalAlignment.Left;
            txtModelo.TrailingIcon = null;
            txtModelo.UseSystemPasswordChar = false;
            // 
            // txtPlaca
            // 
            txtPlaca.AnimateReadOnly = false;
            txtPlaca.AutoCompleteMode = AutoCompleteMode.None;
            txtPlaca.AutoCompleteSource = AutoCompleteSource.None;
            txtPlaca.BackgroundImageLayout = ImageLayout.None;
            txtPlaca.CharacterCasing = CharacterCasing.Normal;
            txtPlaca.Depth = 0;
            txtPlaca.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPlaca.HideSelection = true;
            txtPlaca.Hint = "Placa";
            txtPlaca.LeadingIcon = null;
            txtPlaca.Location = new Point(301, 86);
            txtPlaca.MaxLength = 32767;
            txtPlaca.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPlaca.Name = "txtPlaca";
            txtPlaca.PasswordChar = '\0';
            txtPlaca.PrefixSuffixText = null;
            txtPlaca.ReadOnly = false;
            txtPlaca.RightToLeft = RightToLeft.No;
            txtPlaca.SelectedText = "";
            txtPlaca.SelectionLength = 0;
            txtPlaca.SelectionStart = 0;
            txtPlaca.ShortcutsEnabled = true;
            txtPlaca.Size = new Size(250, 48);
            txtPlaca.TabIndex = 1;
            txtPlaca.TabStop = false;
            txtPlaca.TextAlign = HorizontalAlignment.Left;
            txtPlaca.TrailingIcon = null;
            txtPlaca.UseSystemPasswordChar = false;
            // 
            // txtAno
            // 
            txtAno.AnimateReadOnly = false;
            txtAno.AutoCompleteMode = AutoCompleteMode.None;
            txtAno.AutoCompleteSource = AutoCompleteSource.None;
            txtAno.BackgroundImageLayout = ImageLayout.None;
            txtAno.CharacterCasing = CharacterCasing.Normal;
            txtAno.Depth = 0;
            txtAno.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAno.HideSelection = true;
            txtAno.Hint = "Ano";
            txtAno.LeadingIcon = null;
            txtAno.Location = new Point(28, 156);
            txtAno.MaxLength = 32767;
            txtAno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAno.Name = "txtAno";
            txtAno.PasswordChar = '\0';
            txtAno.PrefixSuffixText = null;
            txtAno.ReadOnly = false;
            txtAno.RightToLeft = RightToLeft.No;
            txtAno.SelectedText = "";
            txtAno.SelectionLength = 0;
            txtAno.SelectionStart = 0;
            txtAno.ShortcutsEnabled = true;
            txtAno.Size = new Size(250, 48);
            txtAno.TabIndex = 2;
            txtAno.TabStop = false;
            txtAno.TextAlign = HorizontalAlignment.Left;
            txtAno.TrailingIcon = null;
            txtAno.UseSystemPasswordChar = false;
            // 
            // mmtbValor_dia
            // 
            mmtbValor_dia.AllowPromptAsInput = true;
            mmtbValor_dia.AnimateReadOnly = false;
            mmtbValor_dia.AsciiOnly = false;
            mmtbValor_dia.BackgroundImageLayout = ImageLayout.None;
            mmtbValor_dia.BeepOnError = false;
            mmtbValor_dia.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mmtbValor_dia.Depth = 0;
            mmtbValor_dia.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mmtbValor_dia.HidePromptOnLeave = false;
            mmtbValor_dia.HideSelection = true;
            mmtbValor_dia.Hint = "Valor da diária";
            mmtbValor_dia.InsertKeyMode = InsertKeyMode.Default;
            mmtbValor_dia.LeadingIcon = null;
            mmtbValor_dia.Location = new Point(301, 156);
            mmtbValor_dia.Mask = "$999.00";
            mmtbValor_dia.MaxLength = 32767;
            mmtbValor_dia.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mmtbValor_dia.Name = "mmtbValor_dia";
            mmtbValor_dia.PasswordChar = '\0';
            mmtbValor_dia.PrefixSuffixText = null;
            mmtbValor_dia.PromptChar = '_';
            mmtbValor_dia.ReadOnly = false;
            mmtbValor_dia.RejectInputOnFirstFailure = false;
            mmtbValor_dia.ResetOnPrompt = true;
            mmtbValor_dia.ResetOnSpace = true;
            mmtbValor_dia.RightToLeft = RightToLeft.No;
            mmtbValor_dia.SelectedText = "";
            mmtbValor_dia.SelectionLength = 0;
            mmtbValor_dia.SelectionStart = 0;
            mmtbValor_dia.ShortcutsEnabled = true;
            mmtbValor_dia.Size = new Size(250, 48);
            mmtbValor_dia.SkipLiterals = true;
            mmtbValor_dia.TabIndex = 3;
            mmtbValor_dia.TabStop = false;
            mmtbValor_dia.Text = "R$   ,";
            mmtbValor_dia.TextAlign = HorizontalAlignment.Left;
            mmtbValor_dia.TextMaskFormat = MaskFormat.IncludeLiterals;
            mmtbValor_dia.TrailingIcon = null;
            mmtbValor_dia.UseSystemPasswordChar = false;
            mmtbValor_dia.ValidatingType = null;
            // 
            // cbSeguro
            // 
            cbSeguro.AutoSize = true;
            cbSeguro.Depth = 0;
            cbSeguro.Location = new Point(28, 286);
            cbSeguro.Margin = new Padding(0);
            cbSeguro.MouseLocation = new Point(-1, -1);
            cbSeguro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cbSeguro.Name = "cbSeguro";
            cbSeguro.ReadOnly = false;
            cbSeguro.Ripple = true;
            cbSeguro.Size = new Size(203, 37);
            cbSeguro.TabIndex = 7;
            cbSeguro.Text = "O veículo possui seguro";
            cbSeguro.UseAccentColor = false;
            cbSeguro.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(28, 221);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(250, 48);
            txtCidade.TabIndex = 5;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(301, 220);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(250, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(592, 334);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(55, 48);
            txtId.TabIndex = 13;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 395);
            Controls.Add(cboEstado);
            Controls.Add(txtCidade);
            Controls.Add(cbSeguro);
            Controls.Add(mmtbValor_dia);
            Controls.Add(txtAno);
            Controls.Add(txtPlaca);
            Controls.Add(txtModelo);
            Controls.Add(txtId);
            Name = "CadastroCarro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locatora - Cadastro de Carro";
            Controls.SetChildIndex(txtId, 0);
            Controls.SetChildIndex(txtModelo, 0);
            Controls.SetChildIndex(txtPlaca, 0);
            Controls.SetChildIndex(txtAno, 0);
            Controls.SetChildIndex(mmtbValor_dia, 0);
            Controls.SetChildIndex(cbSeguro, 0);
            Controls.SetChildIndex(txtCidade, 0);
            Controls.SetChildIndex(cboEstado, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtModelo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPlaca;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAno;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mmtbValor_dia;
        private ReaLTaiizor.Controls.MaterialCheckBox cbSeguro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}