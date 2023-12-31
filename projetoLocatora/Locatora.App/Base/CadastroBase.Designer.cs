﻿namespace Locatora.App.Base
{
    partial class CadastroBase
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
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnCadastrar = new ReaLTaiizor.Controls.MaterialButton();
            btnLimpar = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
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
            btnCancelar.Location = new Point(25, 346);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(134, 36);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            btnCadastrar.Location = new Point(397, 346);
            btnCadastrar.Margin = new Padding(4, 6, 4, 6);
            btnCadastrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.NoAccentTextColor = Color.Empty;
            btnCadastrar.Size = new Size(134, 36);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrar.UseAccentColor = false;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.AutoSize = false;
            btnLimpar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpar.Depth = 0;
            btnLimpar.HighEmphasis = true;
            btnLimpar.Icon = null;
            btnLimpar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLimpar.Location = new Point(217, 346);
            btnLimpar.Margin = new Padding(4, 6, 4, 6);
            btnLimpar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLimpar.Name = "btnLimpar";
            btnLimpar.NoAccentTextColor = Color.Empty;
            btnLimpar.Size = new Size(134, 36);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpar.UseAccentColor = false;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 404);
            Controls.Add(btnLimpar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Name = "CadastroBase";
            Text = "CadastroBase";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnCadastrar;
        private ReaLTaiizor.Controls.MaterialButton btnLimpar;
    }
}