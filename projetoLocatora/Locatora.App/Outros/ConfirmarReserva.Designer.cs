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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.chkConfirmar = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.txtDias = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnConfirmar = new ReaLTaiizor.Controls.MaterialButton();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.chkConfirmar);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Location = new System.Drawing.Point(33, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AllowPromptAsInput = true;
            this.txtValorTotal.AnimateReadOnly = false;
            this.txtValorTotal.AsciiOnly = false;
            this.txtValorTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtValorTotal.BeepOnError = false;
            this.txtValorTotal.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtValorTotal.Depth = 0;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorTotal.HidePromptOnLeave = false;
            this.txtValorTotal.HideSelection = true;
            this.txtValorTotal.Hint = "Valor Total";
            this.txtValorTotal.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtValorTotal.LeadingIcon = null;
            this.txtValorTotal.Location = new System.Drawing.Point(276, 34);
            this.txtValorTotal.Mask = "";
            this.txtValorTotal.MaxLength = 32767;
            this.txtValorTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.PasswordChar = '\0';
            this.txtValorTotal.PrefixSuffixText = null;
            this.txtValorTotal.PromptChar = '_';
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.RejectInputOnFirstFailure = false;
            this.txtValorTotal.ResetOnPrompt = true;
            this.txtValorTotal.ResetOnSpace = true;
            this.txtValorTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValorTotal.SelectedText = "";
            this.txtValorTotal.SelectionLength = 0;
            this.txtValorTotal.SelectionStart = 0;
            this.txtValorTotal.ShortcutsEnabled = true;
            this.txtValorTotal.Size = new System.Drawing.Size(143, 48);
            this.txtValorTotal.SkipLiterals = true;
            this.txtValorTotal.TabIndex = 24;
            this.txtValorTotal.TabStop = false;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValorTotal.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtValorTotal.TrailingIcon = null;
            this.txtValorTotal.UseSystemPasswordChar = false;
            this.txtValorTotal.ValidatingType = null;
            // 
            // chkConfirmar
            // 
            this.chkConfirmar.AutoSize = true;
            this.chkConfirmar.Depth = 0;
            this.chkConfirmar.Location = new System.Drawing.Point(448, 39);
            this.chkConfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.chkConfirmar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkConfirmar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.chkConfirmar.Name = "chkConfirmar";
            this.chkConfirmar.ReadOnly = false;
            this.chkConfirmar.Ripple = true;
            this.chkConfirmar.Size = new System.Drawing.Size(288, 37);
            this.chkConfirmar.TabIndex = 1;
            this.chkConfirmar.Text = "Já conversou com o dono do carro?";
            this.chkConfirmar.UseAccentColor = false;
            this.chkConfirmar.UseVisualStyleBackColor = true;
            this.chkConfirmar.CheckedChanged += new System.EventHandler(this.chkConfirmar_CheckedChanged);
            // 
            // txtDias
            // 
            this.txtDias.AnimateReadOnly = false;
            this.txtDias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDias.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDias.Depth = 0;
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDias.HideSelection = true;
            this.txtDias.Hint = "Duração da Reserva (Dias)";
            this.txtDias.LeadingIcon = null;
            this.txtDias.Location = new System.Drawing.Point(43, 34);
            this.txtDias.MaxLength = 32767;
            this.txtDias.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDias.Name = "txtDias";
            this.txtDias.PasswordChar = '\0';
            this.txtDias.PrefixSuffixText = null;
            this.txtDias.ReadOnly = false;
            this.txtDias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDias.SelectedText = "";
            this.txtDias.SelectionLength = 0;
            this.txtDias.SelectionStart = 0;
            this.txtDias.ShortcutsEnabled = true;
            this.txtDias.Size = new System.Drawing.Size(216, 48);
            this.txtDias.TabIndex = 0;
            this.txtDias.TabStop = false;
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDias.TrailingIcon = null;
            this.txtDias.UseSystemPasswordChar = false;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelar.Location = new System.Drawing.Point(129, 425);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(197, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = false;
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.HighEmphasis = true;
            this.btnConfirmar.Icon = null;
            this.btnConfirmar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnConfirmar.Location = new System.Drawing.Point(546, 425);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Size = new System.Drawing.Size(197, 36);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar Reserva";
            this.btnConfirmar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmar.UseAccentColor = false;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtModelo.Location = new System.Drawing.Point(104, 127);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(131, 25);
            this.txtModelo.TabIndex = 6;
            this.txtModelo.Tag = "";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(104, 158);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(131, 23);
            this.txtPlaca.TabIndex = 7;
            this.txtPlaca.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Proprietário";
            // 
            // txtProprietario
            // 
            this.txtProprietario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProprietario.Location = new System.Drawing.Point(149, 86);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.ReadOnly = true;
            this.txtProprietario.Size = new System.Drawing.Size(309, 29);
            this.txtProprietario.TabIndex = 11;
            this.txtProprietario.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ano";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(332, 133);
            this.txtAno.Name = "txtAno";
            this.txtAno.ReadOnly = true;
            this.txtAno.Size = new System.Drawing.Size(126, 23);
            this.txtAno.TabIndex = 12;
            this.txtAno.Tag = "";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(332, 163);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(126, 23);
            this.txtValor.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor Diário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(531, 136);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(126, 23);
            this.txtCidade.TabIndex = 18;
            this.txtCidade.Tag = "";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(531, 164);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(126, 23);
            this.txtEstado.TabIndex = 19;
            this.txtEstado.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(531, 92);
            this.txtTelefone.Mask = "(99) 99999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(126, 23);
            this.txtTelefone.TabIndex = 21;
            // 
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(104, 187);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.ReadOnly = true;
            this.txtSeguro.Size = new System.Drawing.Size(131, 23);
            this.txtSeguro.TabIndex = 22;
            this.txtSeguro.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Possui Seguro";
            // 
            // ConfirmarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 489);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtProprietario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfirmarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locatora - Confirmar Reserva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDias;
        private ReaLTaiizor.Controls.MaterialCheckBox chkConfirmar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnConfirmar;
        private TextBox txtModelo;
        private TextBox txtPlaca;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProprietario;
        private Label label4;
        private TextBox txtAno;
        private MaskedTextBox txtValor;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Label label8;
        private MaskedTextBox txtTelefone;
        private TextBox txtSeguro;
        private Label label9;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtValorTotal;
    }
}