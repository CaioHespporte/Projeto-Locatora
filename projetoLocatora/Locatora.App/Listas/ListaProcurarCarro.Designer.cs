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
            components = new System.ComponentModel.Container();
            btnReservar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewProcurar = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnModelo = new DataGridViewTextBoxColumn();
            clnPlaca = new DataGridViewTextBoxColumn();
            clnAno = new DataGridViewTextBoxColumn();
            clnValor_dia = new DataGridViewTextBoxColumn();
            clnSeguro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnEstado = new DataGridViewTextBoxColumn();
            clnUsuarioId = new DataGridViewTextBoxColumn();
            cadastrarcarroBindingSource = new BindingSource(components);
            txtTeste = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cadastrarcarroBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnReservar
            // 
            btnReservar.AutoSize = false;
            btnReservar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReservar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReservar.Depth = 0;
            btnReservar.HighEmphasis = true;
            btnReservar.Icon = null;
            btnReservar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnReservar.Location = new Point(455, 394);
            btnReservar.Margin = new Padding(4, 6, 4, 6);
            btnReservar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnReservar.Name = "btnReservar";
            btnReservar.NoAccentTextColor = Color.Empty;
            btnReservar.Size = new Size(216, 36);
            btnReservar.TabIndex = 1;
            btnReservar.Text = "Reservar Carro";
            btnReservar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReservar.UseAccentColor = false;
            btnReservar.UseVisualStyleBackColor = true;
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
            btnCancelar.Location = new Point(142, 394);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(216, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridViewProcurar
            // 
            dataGridViewProcurar.AllowUserToAddRows = false;
            dataGridViewProcurar.AllowUserToDeleteRows = false;
            dataGridViewProcurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProcurar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcurar.Columns.AddRange(new DataGridViewColumn[] { clnId, clnModelo, clnPlaca, clnAno, clnValor_dia, clnSeguro, clnCidade, clnEstado, clnUsuarioId });
            dataGridViewProcurar.Location = new Point(29, 81);
            dataGridViewProcurar.Name = "dataGridViewProcurar";
            dataGridViewProcurar.ReadOnly = true;
            dataGridViewProcurar.RowTemplate.Height = 25;
            dataGridViewProcurar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProcurar.Size = new Size(772, 288);
            dataGridViewProcurar.TabIndex = 3;
            // 
            // clnId
            // 
            clnId.DataPropertyName = "Id";
            clnId.HeaderText = "Id";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnModelo
            // 
            clnModelo.DataPropertyName = "Modelo";
            clnModelo.HeaderText = "Modelo";
            clnModelo.Name = "clnModelo";
            clnModelo.ReadOnly = true;
            // 
            // clnPlaca
            // 
            clnPlaca.DataPropertyName = "Placa";
            clnPlaca.HeaderText = "Placa";
            clnPlaca.Name = "clnPlaca";
            clnPlaca.ReadOnly = true;
            // 
            // clnAno
            // 
            clnAno.DataPropertyName = "Ano";
            clnAno.HeaderText = "Ano";
            clnAno.Name = "clnAno";
            clnAno.ReadOnly = true;
            // 
            // clnValor_dia
            // 
            clnValor_dia.DataPropertyName = "Valor_dia";
            clnValor_dia.HeaderText = "Valor Diário";
            clnValor_dia.Name = "clnValor_dia";
            clnValor_dia.ReadOnly = true;
            // 
            // clnSeguro
            // 
            clnSeguro.DataPropertyName = "Seguro";
            clnSeguro.HeaderText = "Seguro?";
            clnSeguro.Name = "clnSeguro";
            clnSeguro.ReadOnly = true;
            // 
            // clnCidade
            // 
            clnCidade.DataPropertyName = "Cidade";
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            // 
            // clnEstado
            // 
            clnEstado.DataPropertyName = "Estado";
            clnEstado.HeaderText = "Estado";
            clnEstado.Name = "clnEstado";
            clnEstado.ReadOnly = true;
            // 
            // clnUsuarioId
            // 
            clnUsuarioId.DataPropertyName = "UsuarioId";
            clnUsuarioId.HeaderText = "UsuarioId";
            clnUsuarioId.Name = "clnUsuarioId";
            clnUsuarioId.ReadOnly = true;
            // 
            // cadastrarcarroBindingSource
            // 
            cadastrarcarroBindingSource.DataSource = typeof(Domain.Entities.Cadastrar_carro);
            // 
            // txtTeste
            // 
            txtTeste.AnimateReadOnly = false;
            txtTeste.AutoCompleteMode = AutoCompleteMode.None;
            txtTeste.AutoCompleteSource = AutoCompleteSource.None;
            txtTeste.BackgroundImageLayout = ImageLayout.None;
            txtTeste.CharacterCasing = CharacterCasing.Normal;
            txtTeste.Depth = 0;
            txtTeste.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTeste.HideSelection = true;
            txtTeste.Hint = "test";
            txtTeste.LeadingIcon = null;
            txtTeste.Location = new Point(722, 394);
            txtTeste.MaxLength = 32767;
            txtTeste.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTeste.Name = "txtTeste";
            txtTeste.PasswordChar = '\0';
            txtTeste.PrefixSuffixText = null;
            txtTeste.ReadOnly = false;
            txtTeste.RightToLeft = RightToLeft.No;
            txtTeste.SelectedText = "";
            txtTeste.SelectionLength = 0;
            txtTeste.SelectionStart = 0;
            txtTeste.ShortcutsEnabled = true;
            txtTeste.Size = new Size(79, 48);
            txtTeste.TabIndex = 4;
            txtTeste.TabStop = false;
            txtTeste.TextAlign = HorizontalAlignment.Left;
            txtTeste.TrailingIcon = null;
            txtTeste.UseSystemPasswordChar = false;
            // 
            // ListaProcurarCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 450);
            Controls.Add(txtTeste);
            Controls.Add(dataGridViewProcurar);
            Controls.Add(btnCancelar);
            Controls.Add(btnReservar);
            Name = "ListaProcurarCarro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locatora - Procurar Carro";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)cadastrarcarroBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialButton btnReservar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private DataGridView dataGridViewProcurar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTeste;
        private BindingSource cadastrarcarroBindingSource;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnModelo;
        private DataGridViewTextBoxColumn clnPlaca;
        private DataGridViewTextBoxColumn clnAno;
        private DataGridViewTextBoxColumn clnValor_dia;
        private DataGridViewTextBoxColumn clnSeguro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnEstado;
        private DataGridViewTextBoxColumn clnUsuarioId;
    }
}