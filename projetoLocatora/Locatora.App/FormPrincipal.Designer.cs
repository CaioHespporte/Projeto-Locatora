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
            mlblNome = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            groupBox2 = new GroupBox();
            btnSair = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1 = new GroupBox();
            btnCadastrarCarro = new ReaLTaiizor.Controls.MaterialButton();
            btnProcurarCarro = new ReaLTaiizor.Controls.MaterialButton();
            btnExibirReservas = new ReaLTaiizor.Controls.MaterialButton();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mlblNome
            // 
            mlblNome.AutoSize = true;
            mlblNome.Depth = 0;
            mlblNome.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mlblNome.Location = new Point(115, 74);
            mlblNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mlblNome.Name = "mlblNome";
            mlblNome.Size = new Size(1, 0);
            mlblNome.TabIndex = 14;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(77, 74);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(32, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Olá, ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSair);
            groupBox2.Location = new Point(105, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 83);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.AutoSize = false;
            btnSair.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSair.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSair.Depth = 0;
            btnSair.HighEmphasis = true;
            btnSair.Icon = null;
            btnSair.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSair.Location = new Point(28, 25);
            btnSair.Margin = new Padding(4, 6, 4, 6);
            btnSair.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSair.Name = "btnSair";
            btnSair.NoAccentTextColor = Color.Empty;
            btnSair.Size = new Size(239, 36);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSair.UseAccentColor = false;
            btnSair.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCadastrarCarro);
            groupBox1.Controls.Add(btnProcurarCarro);
            groupBox1.Controls.Add(btnExibirReservas);
            groupBox1.Location = new Point(105, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 171);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // btnCadastrarCarro
            // 
            btnCadastrarCarro.AutoSize = false;
            btnCadastrarCarro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrarCarro.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrarCarro.Depth = 0;
            btnCadastrarCarro.HighEmphasis = true;
            btnCadastrarCarro.Icon = null;
            btnCadastrarCarro.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCadastrarCarro.Location = new Point(28, 25);
            btnCadastrarCarro.Margin = new Padding(4, 6, 4, 6);
            btnCadastrarCarro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadastrarCarro.Name = "btnCadastrarCarro";
            btnCadastrarCarro.NoAccentTextColor = Color.Empty;
            btnCadastrarCarro.Size = new Size(239, 36);
            btnCadastrarCarro.TabIndex = 2;
            btnCadastrarCarro.Text = "Cadastrar carro";
            btnCadastrarCarro.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrarCarro.UseAccentColor = false;
            btnCadastrarCarro.UseVisualStyleBackColor = true;
            btnCadastrarCarro.Click += btnCadastrarCarro_Click;
            // 
            // btnProcurarCarro
            // 
            btnProcurarCarro.AutoSize = false;
            btnProcurarCarro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProcurarCarro.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProcurarCarro.Depth = 0;
            btnProcurarCarro.HighEmphasis = true;
            btnProcurarCarro.Icon = null;
            btnProcurarCarro.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnProcurarCarro.Location = new Point(28, 73);
            btnProcurarCarro.Margin = new Padding(4, 6, 4, 6);
            btnProcurarCarro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnProcurarCarro.Name = "btnProcurarCarro";
            btnProcurarCarro.NoAccentTextColor = Color.Empty;
            btnProcurarCarro.Size = new Size(239, 36);
            btnProcurarCarro.TabIndex = 3;
            btnProcurarCarro.Text = "Procurar carro";
            btnProcurarCarro.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProcurarCarro.UseAccentColor = false;
            btnProcurarCarro.UseVisualStyleBackColor = true;
            // 
            // btnExibirReservas
            // 
            btnExibirReservas.AutoSize = false;
            btnExibirReservas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExibirReservas.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExibirReservas.Depth = 0;
            btnExibirReservas.HighEmphasis = true;
            btnExibirReservas.Icon = null;
            btnExibirReservas.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExibirReservas.Location = new Point(28, 121);
            btnExibirReservas.Margin = new Padding(4, 6, 4, 6);
            btnExibirReservas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExibirReservas.Name = "btnExibirReservas";
            btnExibirReservas.NoAccentTextColor = Color.Empty;
            btnExibirReservas.Size = new Size(239, 36);
            btnExibirReservas.TabIndex = 4;
            btnExibirReservas.Text = "Exibir Reservas";
            btnExibirReservas.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExibirReservas.UseAccentColor = false;
            btnExibirReservas.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(mlblNome);
            Controls.Add(materialLabel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            IsMdiContainer = true;
            Name = "FormPrincipal";
            Text = "Locatora - Tela Inicial";
            FormClosing += FormPrincipal_FormClosing;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel mlblNome;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialButton btnSair;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialButton btnCadastrarCarro;
        private ReaLTaiizor.Controls.MaterialButton btnProcurarCarro;
        private ReaLTaiizor.Controls.MaterialButton btnExibirReservas;
    }
}