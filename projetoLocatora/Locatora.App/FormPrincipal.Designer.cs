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
            this.mlblNome = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSair = new ReaLTaiizor.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMeusCarros = new ReaLTaiizor.Controls.MaterialButton();
            this.btnCadastrarCarro = new ReaLTaiizor.Controls.MaterialButton();
            this.btnProcurarCarro = new ReaLTaiizor.Controls.MaterialButton();
            this.btnExibirReservas = new ReaLTaiizor.Controls.MaterialButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlblNome
            // 
            this.mlblNome.AutoSize = true;
            this.mlblNome.Depth = 0;
            this.mlblNome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mlblNome.Location = new System.Drawing.Point(115, 74);
            this.mlblNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.mlblNome.Name = "mlblNome";
            this.mlblNome.Size = new System.Drawing.Size(1, 0);
            this.mlblNome.TabIndex = 14;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(77, 74);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(32, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Olá, ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Location = new System.Drawing.Point(105, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 83);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = false;
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSair.Depth = 0;
            this.btnSair.HighEmphasis = true;
            this.btnSair.Icon = null;
            this.btnSair.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSair.Location = new System.Drawing.Point(28, 25);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSair.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSair.Size = new System.Drawing.Size(239, 36);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSair.UseAccentColor = false;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMeusCarros);
            this.groupBox1.Controls.Add(this.btnCadastrarCarro);
            this.groupBox1.Controls.Add(this.btnProcurarCarro);
            this.groupBox1.Controls.Add(this.btnExibirReservas);
            this.groupBox1.Location = new System.Drawing.Point(105, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 227);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnMeusCarros
            // 
            this.btnMeusCarros.AutoSize = false;
            this.btnMeusCarros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMeusCarros.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMeusCarros.Depth = 0;
            this.btnMeusCarros.HighEmphasis = true;
            this.btnMeusCarros.Icon = null;
            this.btnMeusCarros.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnMeusCarros.Location = new System.Drawing.Point(28, 73);
            this.btnMeusCarros.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMeusCarros.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnMeusCarros.Name = "btnMeusCarros";
            this.btnMeusCarros.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMeusCarros.Size = new System.Drawing.Size(239, 36);
            this.btnMeusCarros.TabIndex = 5;
            this.btnMeusCarros.Text = "Meus carros";
            this.btnMeusCarros.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMeusCarros.UseAccentColor = false;
            this.btnMeusCarros.UseVisualStyleBackColor = true;
            this.btnMeusCarros.Click += new System.EventHandler(this.btnMeusCarros_Click);
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.AutoSize = false;
            this.btnCadastrarCarro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrarCarro.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastrarCarro.Depth = 0;
            this.btnCadastrarCarro.HighEmphasis = true;
            this.btnCadastrarCarro.Icon = null;
            this.btnCadastrarCarro.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCadastrarCarro.Location = new System.Drawing.Point(28, 25);
            this.btnCadastrarCarro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrarCarro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastrarCarro.Size = new System.Drawing.Size(239, 36);
            this.btnCadastrarCarro.TabIndex = 2;
            this.btnCadastrarCarro.Text = "Cadastrar carro";
            this.btnCadastrarCarro.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastrarCarro.UseAccentColor = false;
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // btnProcurarCarro
            // 
            this.btnProcurarCarro.AutoSize = false;
            this.btnProcurarCarro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcurarCarro.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProcurarCarro.Depth = 0;
            this.btnProcurarCarro.HighEmphasis = true;
            this.btnProcurarCarro.Icon = null;
            this.btnProcurarCarro.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnProcurarCarro.Location = new System.Drawing.Point(28, 121);
            this.btnProcurarCarro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcurarCarro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnProcurarCarro.Name = "btnProcurarCarro";
            this.btnProcurarCarro.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProcurarCarro.Size = new System.Drawing.Size(239, 36);
            this.btnProcurarCarro.TabIndex = 3;
            this.btnProcurarCarro.Text = "Reservar carro";
            this.btnProcurarCarro.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProcurarCarro.UseAccentColor = false;
            this.btnProcurarCarro.UseVisualStyleBackColor = true;
            this.btnProcurarCarro.Click += new System.EventHandler(this.btnProcurarCarro_Click);
            // 
            // btnExibirReservas
            // 
            this.btnExibirReservas.AutoSize = false;
            this.btnExibirReservas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExibirReservas.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExibirReservas.Depth = 0;
            this.btnExibirReservas.HighEmphasis = true;
            this.btnExibirReservas.Icon = null;
            this.btnExibirReservas.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnExibirReservas.Location = new System.Drawing.Point(28, 169);
            this.btnExibirReservas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExibirReservas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnExibirReservas.Name = "btnExibirReservas";
            this.btnExibirReservas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExibirReservas.Size = new System.Drawing.Size(239, 36);
            this.btnExibirReservas.TabIndex = 4;
            this.btnExibirReservas.Text = "Minhas Reservas";
            this.btnExibirReservas.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExibirReservas.UseAccentColor = false;
            this.btnExibirReservas.UseVisualStyleBackColor = true;
            this.btnExibirReservas.Click += new System.EventHandler(this.btnExibirReservas_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Locatora.App.Properties.Resources.locatora;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.mlblNome);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "Locatora - Tela Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ReaLTaiizor.Controls.MaterialButton btnMeusCarros;
    }
}