namespace Locatora.App.Outros
{
    partial class Login
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
            this.btnLogin = new ReaLTaiizor.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarNovoUsuario = new ReaLTaiizor.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnLogin.Location = new System.Drawing.Point(28, 132);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(239, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(43, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.AnimateReadOnly = false;
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.HideSelection = true;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.LeadingIcon = null;
            this.txtSenha.Location = new System.Drawing.Point(17, 75);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PrefixSuffixText = null;
            this.txtSenha.ReadOnly = false;
            this.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(250, 48);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.TabStop = false;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.TrailingIcon = null;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "E-mail";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(17, 21);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(250, 48);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCadastrarNovoUsuario);
            this.groupBox2.Location = new System.Drawing.Point(43, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnCadastrarNovoUsuario
            // 
            this.btnCadastrarNovoUsuario.AutoSize = false;
            this.btnCadastrarNovoUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrarNovoUsuario.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastrarNovoUsuario.Depth = 0;
            this.btnCadastrarNovoUsuario.HighEmphasis = true;
            this.btnCadastrarNovoUsuario.Icon = null;
            this.btnCadastrarNovoUsuario.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCadastrarNovoUsuario.Location = new System.Drawing.Point(19, 21);
            this.btnCadastrarNovoUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrarNovoUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCadastrarNovoUsuario.Name = "btnCadastrarNovoUsuario";
            this.btnCadastrarNovoUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastrarNovoUsuario.Size = new System.Drawing.Size(250, 36);
            this.btnCadastrarNovoUsuario.TabIndex = 1;
            this.btnCadastrarNovoUsuario.Text = "CADASTRAR NOVO USUÁRIO";
            this.btnCadastrarNovoUsuario.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastrarNovoUsuario.UseAccentColor = false;
            this.btnCadastrarNovoUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarNovoUsuario.Click += new System.EventHandler(this.btnCadastrarNovoUsuario_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locatora - Efetuar Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton btnLogin;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialButton btnCadastrarNovoUsuario;
    }
}