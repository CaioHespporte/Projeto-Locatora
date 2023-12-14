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
            this.btnVoltar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            this.dataGridViewReserva = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAndamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = false;
            this.btnVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoltar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.HighEmphasis = true;
            this.btnVoltar.Icon = null;
            this.btnVoltar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVoltar.Location = new System.Drawing.Point(55, 394);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoltar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVoltar.Size = new System.Drawing.Size(174, 36);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar ao início";
            this.btnVoltar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVoltar.UseAccentColor = false;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = false;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnExcluir.Location = new System.Drawing.Point(493, 394);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcluir.Size = new System.Drawing.Size(174, 36);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir Reserva";
            this.btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataGridViewReserva
            // 
            this.dataGridViewReserva.AllowUserToAddRows = false;
            this.dataGridViewReserva.AllowUserToDeleteRows = false;
            this.dataGridViewReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnCarro,
            this.clnProprietario,
            this.clnDataInicio,
            this.clnDataFinal,
            this.clnValorTotal,
            this.clnAndamento,
            this.clnUsuario,
            this.clnIdUsuario,
            this.clnIdCarro});
            this.dataGridViewReserva.Location = new System.Drawing.Point(31, 96);
            this.dataGridViewReserva.Name = "dataGridViewReserva";
            this.dataGridViewReserva.ReadOnly = true;
            this.dataGridViewReserva.RowTemplate.Height = 25;
            this.dataGridViewReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReserva.Size = new System.Drawing.Size(659, 249);
            this.dataGridViewReserva.TabIndex = 5;
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Visible = false;
            // 
            // clnCarro
            // 
            this.clnCarro.DataPropertyName = "Carro";
            this.clnCarro.HeaderText = "Carro";
            this.clnCarro.Name = "clnCarro";
            this.clnCarro.ReadOnly = true;
            this.clnCarro.Width = 150;
            // 
            // clnProprietario
            // 
            this.clnProprietario.DataPropertyName = "Proprietario";
            this.clnProprietario.HeaderText = "Nome do Proprietario";
            this.clnProprietario.Name = "clnProprietario";
            this.clnProprietario.ReadOnly = true;
            this.clnProprietario.Width = 200;
            // 
            // clnDataInicio
            // 
            this.clnDataInicio.DataPropertyName = "Data_Inicio";
            this.clnDataInicio.HeaderText = "Data de Inicio";
            this.clnDataInicio.Name = "clnDataInicio";
            this.clnDataInicio.ReadOnly = true;
            this.clnDataInicio.Width = 150;
            // 
            // clnDataFinal
            // 
            this.clnDataFinal.DataPropertyName = "Data_Fim";
            this.clnDataFinal.HeaderText = "Data Final";
            this.clnDataFinal.Name = "clnDataFinal";
            this.clnDataFinal.ReadOnly = true;
            this.clnDataFinal.Width = 150;
            // 
            // clnValorTotal
            // 
            this.clnValorTotal.DataPropertyName = "Valor_total";
            this.clnValorTotal.HeaderText = "Valor Total";
            this.clnValorTotal.Name = "clnValorTotal";
            this.clnValorTotal.ReadOnly = true;
            // 
            // clnAndamento
            // 
            this.clnAndamento.DataPropertyName = "Andamento";
            this.clnAndamento.HeaderText = "Andamento";
            this.clnAndamento.Name = "clnAndamento";
            this.clnAndamento.ReadOnly = true;
            this.clnAndamento.Visible = false;
            // 
            // clnUsuario
            // 
            this.clnUsuario.DataPropertyName = "Usuario";
            this.clnUsuario.HeaderText = "Usuario";
            this.clnUsuario.Name = "clnUsuario";
            this.clnUsuario.ReadOnly = true;
            this.clnUsuario.Visible = false;
            // 
            // clnIdUsuario
            // 
            this.clnIdUsuario.DataPropertyName = "idUsuario";
            this.clnIdUsuario.HeaderText = "IdUsuario";
            this.clnIdUsuario.Name = "clnIdUsuario";
            this.clnIdUsuario.ReadOnly = true;
            this.clnIdUsuario.Visible = false;
            // 
            // clnIdCarro
            // 
            this.clnIdCarro.DataPropertyName = "IdCarro";
            this.clnIdCarro.HeaderText = "IdCarro";
            this.clnIdCarro.Name = "clnIdCarro";
            this.clnIdCarro.ReadOnly = true;
            this.clnIdCarro.Visible = false;
            // 
            // ListaExibirReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.dataGridViewReserva);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Name = "ListaExibirReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locatora - Lista de Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton btnVoltar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private DataGridView dataGridViewReserva;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCarro;
        private DataGridViewTextBoxColumn clnProprietario;
        private DataGridViewTextBoxColumn clnDataInicio;
        private DataGridViewTextBoxColumn clnDataFinal;
        private DataGridViewTextBoxColumn clnValorTotal;
        private DataGridViewTextBoxColumn clnAndamento;
        private DataGridViewTextBoxColumn clnUsuario;
        private DataGridViewTextBoxColumn clnIdUsuario;
        private DataGridViewTextBoxColumn clnIdCarro;
    }
}