namespace Locatora.App.Listas
{
    partial class ListaMeusCarros
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
            this.cadastrarcarroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCarros = new System.Windows.Forms.DataGridView();
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
            this.btnVoltar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnAlterar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            this.groupBoxCarro = new System.Windows.Forms.GroupBox();
            this.txtValorDiaria = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtCarro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.chbSeguro = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.chbAlugado = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.btnVerReservas = new ReaLTaiizor.Controls.MaterialButton();
            this.dataGridViewReserva = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAndamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarcarroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarros)).BeginInit();
            this.groupBoxCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastrarcarroBindingSource
            // 
            this.cadastrarcarroBindingSource.DataSource = typeof(Locatora.Domain.Entities.Carro);
            // 
            // dataGridViewCarros
            // 
            this.dataGridViewCarros.AllowUserToAddRows = false;
            this.dataGridViewCarros.AllowUserToDeleteRows = false;
            this.dataGridViewCarros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewCarros.Location = new System.Drawing.Point(42, 81);
            this.dataGridViewCarros.Name = "dataGridViewCarros";
            this.dataGridViewCarros.ReadOnly = true;
            this.dataGridViewCarros.RowTemplate.Height = 25;
            this.dataGridViewCarros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarros.Size = new System.Drawing.Size(705, 149);
            this.dataGridViewCarros.TabIndex = 6;
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
            // 
            // clnUsuario
            // 
            this.clnUsuario.DataPropertyName = "Usuario";
            this.clnUsuario.HeaderText = "Proprietário";
            this.clnUsuario.Name = "clnUsuario";
            this.clnUsuario.ReadOnly = true;
            this.clnUsuario.Visible = false;
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
            // btnVoltar
            // 
            this.btnVoltar.AutoSize = false;
            this.btnVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoltar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.HighEmphasis = true;
            this.btnVoltar.Icon = null;
            this.btnVoltar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVoltar.Location = new System.Drawing.Point(42, 563);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoltar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVoltar.Size = new System.Drawing.Size(137, 36);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar Ao Inicio";
            this.btnVoltar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVoltar.UseAccentColor = false;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlterar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAlterar.Depth = 0;
            this.btnAlterar.HighEmphasis = true;
            this.btnAlterar.Icon = null;
            this.btnAlterar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnAlterar.Location = new System.Drawing.Point(415, 563);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAlterar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAlterar.Size = new System.Drawing.Size(136, 36);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar Carro";
            this.btnAlterar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAlterar.UseAccentColor = false;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnExcluir.Location = new System.Drawing.Point(234, 563);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcluir.Size = new System.Drawing.Size(131, 36);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir Carro";
            this.btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBoxCarro
            // 
            this.groupBoxCarro.Controls.Add(this.txtValorDiaria);
            this.groupBoxCarro.Controls.Add(this.txtCarro);
            this.groupBoxCarro.Controls.Add(this.btnCancelar);
            this.groupBoxCarro.Controls.Add(this.btnSalvar);
            this.groupBoxCarro.Controls.Add(this.chbSeguro);
            this.groupBoxCarro.Controls.Add(this.chbAlugado);
            this.groupBoxCarro.Location = new System.Drawing.Point(42, 405);
            this.groupBoxCarro.Name = "groupBoxCarro";
            this.groupBoxCarro.Size = new System.Drawing.Size(705, 149);
            this.groupBoxCarro.TabIndex = 8;
            this.groupBoxCarro.TabStop = false;
            this.groupBoxCarro.Visible = false;
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.AnimateReadOnly = false;
            this.txtValorDiaria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtValorDiaria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtValorDiaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtValorDiaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValorDiaria.Depth = 0;
            this.txtValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorDiaria.HideSelection = true;
            this.txtValorDiaria.Hint = "Valor da Diária";
            this.txtValorDiaria.LeadingIcon = null;
            this.txtValorDiaria.Location = new System.Drawing.Point(322, 43);
            this.txtValorDiaria.MaxLength = 32767;
            this.txtValorDiaria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.PasswordChar = '\0';
            this.txtValorDiaria.PrefixSuffixText = null;
            this.txtValorDiaria.ReadOnly = false;
            this.txtValorDiaria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValorDiaria.SelectedText = "";
            this.txtValorDiaria.SelectionLength = 0;
            this.txtValorDiaria.SelectionStart = 0;
            this.txtValorDiaria.ShortcutsEnabled = true;
            this.txtValorDiaria.Size = new System.Drawing.Size(154, 48);
            this.txtValorDiaria.TabIndex = 10;
            this.txtValorDiaria.TabStop = false;
            this.txtValorDiaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValorDiaria.TrailingIcon = null;
            this.txtValorDiaria.UseSystemPasswordChar = false;
            // 
            // txtCarro
            // 
            this.txtCarro.AnimateReadOnly = false;
            this.txtCarro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCarro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCarro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCarro.Depth = 0;
            this.txtCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCarro.HideSelection = true;
            this.txtCarro.Hint = "Modelo";
            this.txtCarro.LeadingIcon = null;
            this.txtCarro.Location = new System.Drawing.Point(16, 43);
            this.txtCarro.MaxLength = 32767;
            this.txtCarro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCarro.Name = "txtCarro";
            this.txtCarro.PasswordChar = '\0';
            this.txtCarro.PrefixSuffixText = null;
            this.txtCarro.ReadOnly = true;
            this.txtCarro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCarro.SelectedText = "";
            this.txtCarro.SelectionLength = 0;
            this.txtCarro.SelectionStart = 0;
            this.txtCarro.ShortcutsEnabled = true;
            this.txtCarro.Size = new System.Drawing.Size(297, 48);
            this.txtCarro.TabIndex = 9;
            this.txtCarro.TabStop = false;
            this.txtCarro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCarro.TrailingIcon = null;
            this.txtCarro.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelar.Location = new System.Drawing.Point(514, 100);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.HighEmphasis = true;
            this.btnSalvar.Icon = null;
            this.btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSalvar.Location = new System.Drawing.Point(618, 100);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(76, 36);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chbSeguro
            // 
            this.chbSeguro.AutoSize = true;
            this.chbSeguro.Depth = 0;
            this.chbSeguro.Location = new System.Drawing.Point(487, 54);
            this.chbSeguro.Margin = new System.Windows.Forms.Padding(0);
            this.chbSeguro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbSeguro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.chbSeguro.Name = "chbSeguro";
            this.chbSeguro.ReadOnly = false;
            this.chbSeguro.Ripple = true;
            this.chbSeguro.Size = new System.Drawing.Size(85, 37);
            this.chbSeguro.TabIndex = 5;
            this.chbSeguro.Text = "Seguro";
            this.chbSeguro.UseAccentColor = false;
            this.chbSeguro.UseVisualStyleBackColor = true;
            // 
            // chbAlugado
            // 
            this.chbAlugado.AutoSize = true;
            this.chbAlugado.Depth = 0;
            this.chbAlugado.Location = new System.Drawing.Point(589, 54);
            this.chbAlugado.Margin = new System.Windows.Forms.Padding(0);
            this.chbAlugado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbAlugado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.chbAlugado.Name = "chbAlugado";
            this.chbAlugado.ReadOnly = false;
            this.chbAlugado.Ripple = true;
            this.chbAlugado.Size = new System.Drawing.Size(94, 37);
            this.chbAlugado.TabIndex = 2;
            this.chbAlugado.Text = "Alugado";
            this.chbAlugado.UseAccentColor = false;
            this.chbAlugado.UseVisualStyleBackColor = true;
            // 
            // btnVerReservas
            // 
            this.btnVerReservas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerReservas.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerReservas.Depth = 0;
            this.btnVerReservas.HighEmphasis = true;
            this.btnVerReservas.Icon = null;
            this.btnVerReservas.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnVerReservas.Location = new System.Drawing.Point(623, 563);
            this.btnVerReservas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerReservas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnVerReservas.Name = "btnVerReservas";
            this.btnVerReservas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVerReservas.Size = new System.Drawing.Size(124, 36);
            this.btnVerReservas.TabIndex = 9;
            this.btnVerReservas.Text = "Ver Reservas";
            this.btnVerReservas.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerReservas.UseAccentColor = false;
            this.btnVerReservas.UseVisualStyleBackColor = true;
            this.btnVerReservas.Click += new System.EventHandler(this.btnVerReservas_Click);
            // 
            // dataGridViewReserva
            // 
            this.dataGridViewReserva.AllowUserToAddRows = false;
            this.dataGridViewReserva.AllowUserToDeleteRows = false;
            this.dataGridViewReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clnCarro,
            this.clnProprietario,
            this.dataGridViewTextBoxColumn2,
            this.clnDataInicio,
            this.clnDataFinal,
            this.clnValorTotal,
            this.clnAndamento,
            this.dataGridViewTextBoxColumn3,
            this.clnIdCarro});
            this.dataGridViewReserva.Location = new System.Drawing.Point(42, 250);
            this.dataGridViewReserva.Name = "dataGridViewReserva";
            this.dataGridViewReserva.ReadOnly = true;
            this.dataGridViewReserva.RowTemplate.Height = 25;
            this.dataGridViewReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReserva.Size = new System.Drawing.Size(705, 149);
            this.dataGridViewReserva.TabIndex = 10;
            this.dataGridViewReserva.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // clnCarro
            // 
            this.clnCarro.DataPropertyName = "Carro";
            this.clnCarro.HeaderText = "Carro";
            this.clnCarro.Name = "clnCarro";
            this.clnCarro.ReadOnly = true;
            this.clnCarro.Visible = false;
            this.clnCarro.Width = 150;
            // 
            // clnProprietario
            // 
            this.clnProprietario.DataPropertyName = "Proprietario";
            this.clnProprietario.HeaderText = "Nome do Proprietario";
            this.clnProprietario.Name = "clnProprietario";
            this.clnProprietario.ReadOnly = true;
            this.clnProprietario.Visible = false;
            this.clnProprietario.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Locatario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // clnIdCarro
            // 
            this.clnIdCarro.DataPropertyName = "IdCarro";
            this.clnIdCarro.HeaderText = "IdCarro";
            this.clnIdCarro.Name = "clnIdCarro";
            this.clnIdCarro.ReadOnly = true;
            this.clnIdCarro.Visible = false;
            // 
            // ListaMeusCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 608);
            this.Controls.Add(this.dataGridViewReserva);
            this.Controls.Add(this.btnVerReservas);
            this.Controls.Add(this.groupBoxCarro);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dataGridViewCarros);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlterar);
            this.Name = "ListaMeusCarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locatora - Meus Carros";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarcarroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarros)).EndInit();
            this.groupBoxCarro.ResumeLayout(false);
            this.groupBoxCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource cadastrarcarroBindingSource;
        private DataGridView dataGridViewCarros;
        private ReaLTaiizor.Controls.MaterialButton btnVoltar;
        private ReaLTaiizor.Controls.MaterialButton btnAlterar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
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
        private GroupBox groupBoxCarro;
        private ReaLTaiizor.Controls.MaterialCheckBox chbAlugado;
        private ReaLTaiizor.Controls.MaterialCheckBox chbSeguro;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCarro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorDiaria;
        private ReaLTaiizor.Controls.MaterialButton btnVerReservas;
        private DataGridView dataGridViewReserva;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn clnCarro;
        private DataGridViewTextBoxColumn clnProprietario;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn clnDataInicio;
        private DataGridViewTextBoxColumn clnDataFinal;
        private DataGridViewTextBoxColumn clnValorTotal;
        private DataGridViewTextBoxColumn clnAndamento;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn clnIdCarro;
    }
}