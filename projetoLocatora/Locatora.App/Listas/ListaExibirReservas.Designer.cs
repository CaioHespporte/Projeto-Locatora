namespace Locatora.App.Listas
{
    partial class ListaExibirReservas
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
            colunaAndamento = new ColumnHeader();
            colunaNomeDono = new ColumnHeader();
            colunaDataInicio = new ColumnHeader();
            colunaDataFinal = new ColumnHeader();
            colunaValorTotal = new ColumnHeader();
            btnVoltar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnAlterar = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // listViewProcurarCarro
            // 
            listViewProcurarCarro.Columns.AddRange(new ColumnHeader[] { colunaAndamento, colunaNomeDono, colunaDataInicio, colunaDataFinal, colunaValorTotal });
            listViewProcurarCarro.GridLines = true;
            listViewProcurarCarro.Location = new Point(31, 87);
            listViewProcurarCarro.MultiSelect = false;
            listViewProcurarCarro.Name = "listViewProcurarCarro";
            listViewProcurarCarro.Size = new Size(658, 285);
            listViewProcurarCarro.TabIndex = 1;
            listViewProcurarCarro.UseCompatibleStateImageBehavior = false;
            listViewProcurarCarro.View = View.Details;
            // 
            // colunaAndamento
            // 
            colunaAndamento.Text = "Andamento";
            colunaAndamento.Width = 140;
            // 
            // colunaNomeDono
            // 
            colunaNomeDono.Text = "Nome do Locator";
            colunaNomeDono.Width = 174;
            // 
            // colunaDataInicio
            // 
            colunaDataInicio.Text = "Data de Início";
            colunaDataInicio.Width = 120;
            // 
            // colunaDataFinal
            // 
            colunaDataFinal.Text = "Data Final";
            colunaDataFinal.Width = 120;
            // 
            // colunaValorTotal
            // 
            colunaValorTotal.Text = "Valor Total";
            colunaValorTotal.Width = 100;
            // 
            // btnVoltar
            // 
            btnVoltar.AutoSize = false;
            btnVoltar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVoltar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVoltar.Depth = 0;
            btnVoltar.HighEmphasis = true;
            btnVoltar.Icon = null;
            btnVoltar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVoltar.Location = new Point(55, 394);
            btnVoltar.Margin = new Padding(4, 6, 4, 6);
            btnVoltar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NoAccentTextColor = Color.Empty;
            btnVoltar.Size = new Size(174, 36);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar ao início";
            btnVoltar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVoltar.UseAccentColor = false;
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(493, 394);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(174, 36);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir Reserva";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.AutoSize = false;
            btnAlterar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAlterar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAlterar.Depth = 0;
            btnAlterar.HighEmphasis = true;
            btnAlterar.Icon = null;
            btnAlterar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAlterar.Location = new Point(274, 394);
            btnAlterar.Margin = new Padding(4, 6, 4, 6);
            btnAlterar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAlterar.Name = "btnAlterar";
            btnAlterar.NoAccentTextColor = Color.Empty;
            btnAlterar.Size = new Size(174, 36);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "Alterar Reserva";
            btnAlterar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAlterar.UseAccentColor = false;
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // ListaExibirReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 450);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(btnVoltar);
            Controls.Add(listViewProcurarCarro);
            Name = "ListaExibirReservas";
            Text = "Locatora - Lista de Reservas";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewProcurarCarro;
        private ColumnHeader colunaAndamento;
        private ColumnHeader colunaNomeDono;
        private ColumnHeader colunaDataInicio;
        private ColumnHeader colunaDataFinal;
        private ColumnHeader colunaValorTotal;
        private ReaLTaiizor.Controls.MaterialButton btnVoltar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnAlterar;
    }
}