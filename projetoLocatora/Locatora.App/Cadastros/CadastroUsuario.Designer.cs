namespace Locatora.App.Cadastros
{
    partial class CadastroUsuario
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mmtbDtNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            mmtbRG = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            mmtbCPF = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            mmtbTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnCadastrar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome Completo";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(21, 78);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(520, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "E-mail";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(21, 143);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(250, 48);
            txtEmail.TabIndex = 1;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(291, 143);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(250, 48);
            txtSenha.TabIndex = 2;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // mmtbDtNascimento
            // 
            mmtbDtNascimento.AllowPromptAsInput = true;
            mmtbDtNascimento.AnimateReadOnly = false;
            mmtbDtNascimento.AsciiOnly = false;
            mmtbDtNascimento.BackgroundImageLayout = ImageLayout.None;
            mmtbDtNascimento.BeepOnError = false;
            mmtbDtNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mmtbDtNascimento.Depth = 0;
            mmtbDtNascimento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mmtbDtNascimento.HidePromptOnLeave = false;
            mmtbDtNascimento.HideSelection = true;
            mmtbDtNascimento.Hint = "Data de Nascimento";
            mmtbDtNascimento.InsertKeyMode = InsertKeyMode.Default;
            mmtbDtNascimento.LeadingIcon = null;
            mmtbDtNascimento.Location = new Point(291, 273);
            mmtbDtNascimento.Mask = "99/99/9999";
            mmtbDtNascimento.MaxLength = 32767;
            mmtbDtNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mmtbDtNascimento.Name = "mmtbDtNascimento";
            mmtbDtNascimento.PasswordChar = '\0';
            mmtbDtNascimento.PrefixSuffixText = null;
            mmtbDtNascimento.PromptChar = '_';
            mmtbDtNascimento.ReadOnly = false;
            mmtbDtNascimento.RejectInputOnFirstFailure = false;
            mmtbDtNascimento.ResetOnPrompt = true;
            mmtbDtNascimento.ResetOnSpace = true;
            mmtbDtNascimento.RightToLeft = RightToLeft.No;
            mmtbDtNascimento.SelectedText = "";
            mmtbDtNascimento.SelectionLength = 0;
            mmtbDtNascimento.SelectionStart = 0;
            mmtbDtNascimento.ShortcutsEnabled = true;
            mmtbDtNascimento.Size = new Size(250, 48);
            mmtbDtNascimento.SkipLiterals = true;
            mmtbDtNascimento.TabIndex = 5;
            mmtbDtNascimento.TabStop = false;
            mmtbDtNascimento.Text = "  /  /";
            mmtbDtNascimento.TextAlign = HorizontalAlignment.Left;
            mmtbDtNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            mmtbDtNascimento.TrailingIcon = null;
            mmtbDtNascimento.UseSystemPasswordChar = false;
            mmtbDtNascimento.ValidatingType = null;
            // 
            // mmtbRG
            // 
            mmtbRG.AllowPromptAsInput = true;
            mmtbRG.AnimateReadOnly = false;
            mmtbRG.AsciiOnly = false;
            mmtbRG.BackgroundImageLayout = ImageLayout.None;
            mmtbRG.BeepOnError = false;
            mmtbRG.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mmtbRG.Depth = 0;
            mmtbRG.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mmtbRG.HidePromptOnLeave = false;
            mmtbRG.HideSelection = true;
            mmtbRG.Hint = "RG";
            mmtbRG.InsertKeyMode = InsertKeyMode.Default;
            mmtbRG.LeadingIcon = null;
            mmtbRG.Location = new Point(21, 207);
            mmtbRG.Mask = "99.999.999-9";
            mmtbRG.MaxLength = 32767;
            mmtbRG.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mmtbRG.Name = "mmtbRG";
            mmtbRG.PasswordChar = '\0';
            mmtbRG.PrefixSuffixText = null;
            mmtbRG.PromptChar = '_';
            mmtbRG.ReadOnly = false;
            mmtbRG.RejectInputOnFirstFailure = false;
            mmtbRG.ResetOnPrompt = true;
            mmtbRG.ResetOnSpace = true;
            mmtbRG.RightToLeft = RightToLeft.No;
            mmtbRG.SelectedText = "";
            mmtbRG.SelectionLength = 0;
            mmtbRG.SelectionStart = 0;
            mmtbRG.ShortcutsEnabled = true;
            mmtbRG.Size = new Size(250, 48);
            mmtbRG.SkipLiterals = true;
            mmtbRG.TabIndex = 6;
            mmtbRG.TabStop = false;
            mmtbRG.Text = "  ,   ,   -";
            mmtbRG.TextAlign = HorizontalAlignment.Left;
            mmtbRG.TextMaskFormat = MaskFormat.IncludeLiterals;
            mmtbRG.TrailingIcon = null;
            mmtbRG.UseSystemPasswordChar = false;
            mmtbRG.ValidatingType = null;
            // 
            // mmtbCPF
            // 
            mmtbCPF.AllowPromptAsInput = true;
            mmtbCPF.AnimateReadOnly = false;
            mmtbCPF.AsciiOnly = false;
            mmtbCPF.BackgroundImageLayout = ImageLayout.None;
            mmtbCPF.BeepOnError = false;
            mmtbCPF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mmtbCPF.Depth = 0;
            mmtbCPF.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mmtbCPF.HidePromptOnLeave = false;
            mmtbCPF.HideSelection = true;
            mmtbCPF.Hint = "CPF";
            mmtbCPF.InsertKeyMode = InsertKeyMode.Default;
            mmtbCPF.LeadingIcon = null;
            mmtbCPF.Location = new Point(291, 207);
            mmtbCPF.Mask = "999.999.999-99";
            mmtbCPF.MaxLength = 32767;
            mmtbCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mmtbCPF.Name = "mmtbCPF";
            mmtbCPF.PasswordChar = '\0';
            mmtbCPF.PrefixSuffixText = null;
            mmtbCPF.PromptChar = '_';
            mmtbCPF.ReadOnly = false;
            mmtbCPF.RejectInputOnFirstFailure = false;
            mmtbCPF.ResetOnPrompt = true;
            mmtbCPF.ResetOnSpace = true;
            mmtbCPF.RightToLeft = RightToLeft.No;
            mmtbCPF.SelectedText = "";
            mmtbCPF.SelectionLength = 0;
            mmtbCPF.SelectionStart = 0;
            mmtbCPF.ShortcutsEnabled = true;
            mmtbCPF.Size = new Size(250, 48);
            mmtbCPF.SkipLiterals = true;
            mmtbCPF.TabIndex = 7;
            mmtbCPF.TabStop = false;
            mmtbCPF.Text = "   ,   ,   -";
            mmtbCPF.TextAlign = HorizontalAlignment.Left;
            mmtbCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            mmtbCPF.TrailingIcon = null;
            mmtbCPF.UseSystemPasswordChar = false;
            mmtbCPF.ValidatingType = null;
            // 
            // mmtbTelefone
            // 
            mmtbTelefone.AllowPromptAsInput = true;
            mmtbTelefone.AnimateReadOnly = false;
            mmtbTelefone.AsciiOnly = false;
            mmtbTelefone.BackgroundImageLayout = ImageLayout.None;
            mmtbTelefone.BeepOnError = false;
            mmtbTelefone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mmtbTelefone.Depth = 0;
            mmtbTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mmtbTelefone.HidePromptOnLeave = false;
            mmtbTelefone.HideSelection = true;
            mmtbTelefone.Hint = "Celular";
            mmtbTelefone.InsertKeyMode = InsertKeyMode.Default;
            mmtbTelefone.LeadingIcon = null;
            mmtbTelefone.Location = new Point(21, 273);
            mmtbTelefone.Mask = "(99) 99999-9999";
            mmtbTelefone.MaxLength = 32767;
            mmtbTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mmtbTelefone.Name = "mmtbTelefone";
            mmtbTelefone.PasswordChar = '\0';
            mmtbTelefone.PrefixSuffixText = null;
            mmtbTelefone.PromptChar = '_';
            mmtbTelefone.ReadOnly = false;
            mmtbTelefone.RejectInputOnFirstFailure = false;
            mmtbTelefone.ResetOnPrompt = true;
            mmtbTelefone.ResetOnSpace = true;
            mmtbTelefone.RightToLeft = RightToLeft.No;
            mmtbTelefone.SelectedText = "";
            mmtbTelefone.SelectionLength = 0;
            mmtbTelefone.SelectionStart = 0;
            mmtbTelefone.ShortcutsEnabled = true;
            mmtbTelefone.Size = new Size(250, 48);
            mmtbTelefone.SkipLiterals = true;
            mmtbTelefone.TabIndex = 8;
            mmtbTelefone.TabStop = false;
            mmtbTelefone.Text = "(  )      -";
            mmtbTelefone.TextAlign = HorizontalAlignment.Left;
            mmtbTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            mmtbTelefone.TrailingIcon = null;
            mmtbTelefone.UseSystemPasswordChar = false;
            mmtbTelefone.ValidatingType = null;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSize = false;
            btnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrar.Depth = 0;
            btnCadastrar.HighEmphasis = true;
            btnCadastrar.Icon = null;
            btnCadastrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCadastrar.Location = new Point(291, 344);
            btnCadastrar.Margin = new Padding(4, 6, 4, 6);
            btnCadastrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.NoAccentTextColor = Color.Empty;
            btnCadastrar.Size = new Size(250, 36);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrar.UseAccentColor = false;
            btnCadastrar.UseVisualStyleBackColor = true;
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
            btnCancelar.Location = new Point(21, 344);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(250, 36);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += materialButton2_Click;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 404);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(mmtbTelefone);
            Controls.Add(mmtbCPF);
            Controls.Add(mmtbRG);
            Controls.Add(mmtbDtNascimento);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "CadastroUsuario";
            Text = "Locatora - Cadastro de Usuário";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mmtbDtNascimento;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mmtbRG;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mmtbCPF;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mmtbTelefone;
        private ReaLTaiizor.Controls.MaterialButton btnCadastrar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
    }
}