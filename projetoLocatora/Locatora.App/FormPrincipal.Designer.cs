namespace Locatora.App
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(22, 131);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(250, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "LOGIN";
            materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(materialButton1);
            groupBox1.Location = new Point(89, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 188);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialButton2);
            groupBox2.Location = new Point(89, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 76);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton2.Location = new Point(22, 25);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(250, 36);
            materialButton2.TabIndex = 0;
            materialButton2.Text = "CADASTRAR NOVO USUÁRIO";
            materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "E-mail";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(22, 22);
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
            txtEmail.TabIndex = 3;
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
            txtSenha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(22, 76);
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
            txtSenha.TabIndex = 4;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            Text = "Locatora - Tela Inicial";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
    }
}