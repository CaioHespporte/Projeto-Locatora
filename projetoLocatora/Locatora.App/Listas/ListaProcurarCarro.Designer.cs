namespace Locatora.App.Listas
{
    partial class ListaProcurarCarro
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
            this.components = new System.ComponentModel.Container();
            this.btnReservar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.dataGridViewProcurar = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValor_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSeguro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnAlugado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastrarcarroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarcarroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.AutoSize = false;
            this.btnReservar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReservar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReservar.Depth = 0;
            this.btnReservar.HighEmphasis = true;
            this.btnReservar.Icon = null;
            this.btnReservar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnReservar.Location = new System.Drawing.Point(516, 394);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReservar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReservar.Size = new System.Drawing.Size(216, 36);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar Carro";
            this.btnReservar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReservar.UseAccentColor = false;
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(29, 394);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(137, 36);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridViewProcurar
            // 
            this.dataGridViewProcurar.AllowUserToAddRows = false;
            this.dataGridViewProcurar.AllowUserToDeleteRows = false;
            this.dataGridViewProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProcurar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcurar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnModelo,
            this.clnPlaca,
            this.clnAno,
            this.clnValor_dia,
            this.clnSeguro,
            this.clnAlugado,
            this.clnUsuario,
            this.clnCidade,
            this.clnEstado,
            this.clnIdUsuario,
            this.clnIdCidade,
            this.clnIdEstado});
            this.dataGridViewProcurar.Location = new System.Drawing.Point(29, 81);
            this.dataGridViewProcurar.Name = "dataGridViewProcurar";
            this.dataGridViewProcurar.ReadOnly = true;
            this.dataGridViewProcurar.RowTemplate.Height = 25;
            this.dataGridViewProcurar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcurar.Size = new System.Drawing.Size(703, 288);
            this.dataGridViewProcurar.TabIndex = 3;
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "Id";
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Visible = false;
            this.clnId.Width = 30;
            // 
            // clnModelo
            // 
            this.clnModelo.DataPropertyName = "Modelo";
            this.clnModelo.HeaderText = "Modelo";
            this.clnModelo.Name = "clnModelo";
            this.clnModelo.ReadOnly = true;
            // 
            // clnPlaca
            // 
            this.clnPlaca.DataPropertyName = "Placa";
            this.clnPlaca.HeaderText = "Placa";
            this.clnPlaca.Name = "clnPlaca";
            this.clnPlaca.ReadOnly = true;
            // 
            // clnAno
            // 
            this.clnAno.DataPropertyName = "Ano";
            this.clnAno.HeaderText = "Ano";
            this.clnAno.Name = "clnAno";
            this.clnAno.ReadOnly = true;
            // 
            // clnValor_dia
            // 
            this.clnValor_dia.DataPropertyName = "Valor_dia";
            this.clnValor_dia.HeaderText = "Valor Diário";
            this.clnValor_dia.Name = "clnValor_dia";
            this.clnValor_dia.ReadOnly = true;
            // 
            // clnSeguro
            // 
            this.clnSeguro.DataPropertyName = "Seguro";
            this.clnSeguro.HeaderText = "Seguro?";
            this.clnSeguro.Name = "clnSeguro";
            this.clnSeguro.ReadOnly = true;
            this.clnSeguro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnSeguro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnSeguro.Width = 60;
            // 
            // clnAlugado
            // 
            this.clnAlugado.DataPropertyName = "Alugado";
            this.clnAlugado.HeaderText = "Alugado";
            this.clnAlugado.Name = "clnAlugado";
            this.clnAlugado.ReadOnly = true;
            this.clnAlugado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnAlugado.Visible = false;
            // 
            // clnUsuario
            // 
            this.clnUsuario.DataPropertyName = "Usuario";
            this.clnUsuario.HeaderText = "Proprietário";
            this.clnUsuario.Name = "clnUsuario";
            this.clnUsuario.ReadOnly = true;
            // 
            // clnCidade
            // 
            this.clnCidade.DataPropertyName = "Cidade";
            this.clnCidade.HeaderText = "Cidade";
            this.clnCidade.Name = "clnCidade";
            this.clnCidade.ReadOnly = true;
            // 
            // clnEstado
            // 
            this.clnEstado.DataPropertyName = "Estado";
            this.clnEstado.HeaderText = "Estado";
            this.clnEstado.Name = "clnEstado";
            this.clnEstado.ReadOnly = true;
            // 
            // clnIdUsuario
            // 
            this.clnIdUsuario.DataPropertyName = "idUsuario";
            this.clnIdUsuario.HeaderText = "idUsuario";
            this.clnIdUsuario.Name = "clnIdUsuario";
            this.clnIdUsuario.ReadOnly = true;
            this.clnIdUsuario.Visible = false;
            // 
            // clnIdCidade
            // 
            this.clnIdCidade.DataPropertyName = "IdCidade";
            this.clnIdCidade.HeaderText = "idCidade";
            this.clnIdCidade.Name = "clnIdCidade";
            this.clnIdCidade.ReadOnly = true;
            this.clnIdCidade.Visible = false;
            // 
            // clnIdEstado
            // 
            this.clnIdEstado.DataPropertyName = "IdEstado";
            this.clnIdEstado.HeaderText = "idEstado";
            this.clnIdEstado.Name = "clnIdEstado";
            this.clnIdEstado.ReadOnly = true;
            this.clnIdEstado.Visible = false;
            // 
            // cadastrarcarroBindingSource
            // 
            this.cadastrarcarroBindingSource.DataSource = typeof(Locatora.Domain.Entities.Carro);
            // 
            // ListaProcurarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.dataGridViewProcurar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservar);
            this.Name = "ListaProcurarCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locatora - Procurar Carro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarcarroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton btnReservar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private DataGridView dataGridViewProcurar;
        private BindingSource cadastrarcarroBindingSource;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnModelo;
        private DataGridViewTextBoxColumn clnPlaca;
        private DataGridViewTextBoxColumn clnAno;
        private DataGridViewTextBoxColumn clnValor_dia;
        private DataGridViewCheckBoxColumn clnSeguro;
        private DataGridViewCheckBoxColumn clnAlugado;
        private DataGridViewTextBoxColumn clnUsuario;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnEstado;
        private DataGridViewTextBoxColumn clnIdUsuario;
        private DataGridViewTextBoxColumn clnIdCidade;
        private DataGridViewTextBoxColumn clnIdEstado;
    }
}