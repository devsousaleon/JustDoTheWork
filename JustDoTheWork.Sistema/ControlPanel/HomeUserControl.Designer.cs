namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupPausado = new DevExpress.XtraEditors.GroupControl();
            this.btnExecutarAposPausado = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarAposPausado = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridPausado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atualizaAtividadesExecucaoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupExecutando = new DevExpress.XtraEditors.GroupControl();
            this.btnPausar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinalizar = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridExecutando = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPendente = new DevExpress.XtraEditors.GroupControl();
            this.dataGridPendentes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExecutar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupPausado)).BeginInit();
            this.groupPausado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPausado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atualizaAtividadesExecucaoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupExecutando)).BeginInit();
            this.groupExecutando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExecutando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendente)).BeginInit();
            this.groupPendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPausado
            // 
            this.groupPausado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPausado.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupPausado.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupPausado.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupPausado.Appearance.Options.UseBackColor = true;
            this.groupPausado.Appearance.Options.UseBorderColor = true;
            this.groupPausado.AppearanceCaption.BorderColor = System.Drawing.Color.Silver;
            this.groupPausado.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 12F);
            this.groupPausado.AppearanceCaption.Options.UseBorderColor = true;
            this.groupPausado.AppearanceCaption.Options.UseFont = true;
            this.groupPausado.Controls.Add(this.btnExecutarAposPausado);
            this.groupPausado.Controls.Add(this.btnCancelarAposPausado);
            this.groupPausado.Controls.Add(this.dataGridPausado);
            this.groupPausado.Location = new System.Drawing.Point(545, 359);
            this.groupPausado.Margin = new System.Windows.Forms.Padding(15);
            this.groupPausado.Name = "groupPausado";
            this.groupPausado.Size = new System.Drawing.Size(720, 346);
            this.groupPausado.TabIndex = 5;
            this.groupPausado.Text = "Pausado";
            // 
            // btnExecutarAposPausado
            // 
            this.btnExecutarAposPausado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutarAposPausado.Location = new System.Drawing.Point(544, 313);
            this.btnExecutarAposPausado.Margin = new System.Windows.Forms.Padding(8);
            this.btnExecutarAposPausado.Name = "btnExecutarAposPausado";
            this.btnExecutarAposPausado.Size = new System.Drawing.Size(75, 23);
            this.btnExecutarAposPausado.TabIndex = 2;
            this.btnExecutarAposPausado.Text = "Executar";
            this.btnExecutarAposPausado.Click += new System.EventHandler(this.btnExecutarAposPausado_Click);
            // 
            // btnCancelarAposPausado
            // 
            this.btnCancelarAposPausado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAposPausado.Location = new System.Drawing.Point(635, 313);
            this.btnCancelarAposPausado.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancelarAposPausado.Name = "btnCancelarAposPausado";
            this.btnCancelarAposPausado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAposPausado.TabIndex = 5;
            this.btnCancelarAposPausado.Text = "Cancelar";
            this.btnCancelarAposPausado.Click += new System.EventHandler(this.btnCancelarAposPausado_Click);
            // 
            // dataGridPausado
            // 
            this.dataGridPausado.AllowUserToAddRows = false;
            this.dataGridPausado.AllowUserToDeleteRows = false;
            this.dataGridPausado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPausado.AutoGenerateColumns = false;
            this.dataGridPausado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPausado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridPausado.DataSource = this.atualizaAtividadesExecucaoDTOBindingSource;
            this.dataGridPausado.Location = new System.Drawing.Point(5, 26);
            this.dataGridPausado.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.dataGridPausado.Name = "dataGridPausado";
            this.dataGridPausado.ReadOnly = true;
            this.dataGridPausado.Size = new System.Drawing.Size(710, 278);
            this.dataGridPausado.TabIndex = 2;
            this.dataGridPausado.SelectionChanged += new System.EventHandler(this.dataGridPausado_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AtividadeId";
            this.dataGridViewTextBoxColumn7.HeaderText = "AtividadeId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 87;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NomeAtividade";
            this.dataGridViewTextBoxColumn8.HeaderText = "NomeAtividade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NomeProjeto";
            this.dataGridViewTextBoxColumn9.HeaderText = "NomeProjeto";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // atualizaAtividadesExecucaoDTOBindingSource
            // 
            this.atualizaAtividadesExecucaoDTOBindingSource.DataSource = typeof(JustDoTheWork.DTO.AtualizaAtividadesExecucaoDTO);
            // 
            // groupExecutando
            // 
            this.groupExecutando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupExecutando.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupExecutando.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupExecutando.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupExecutando.Appearance.Options.UseBackColor = true;
            this.groupExecutando.Appearance.Options.UseBorderColor = true;
            this.groupExecutando.AppearanceCaption.BorderColor = System.Drawing.Color.Silver;
            this.groupExecutando.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 12F);
            this.groupExecutando.AppearanceCaption.Options.UseBorderColor = true;
            this.groupExecutando.AppearanceCaption.Options.UseFont = true;
            this.groupExecutando.Controls.Add(this.btnPausar);
            this.groupExecutando.Controls.Add(this.btnCancelar);
            this.groupExecutando.Controls.Add(this.btnFinalizar);
            this.groupExecutando.Controls.Add(this.dataGridExecutando);
            this.groupExecutando.Location = new System.Drawing.Point(545, 15);
            this.groupExecutando.Margin = new System.Windows.Forms.Padding(15);
            this.groupExecutando.Name = "groupExecutando";
            this.groupExecutando.Size = new System.Drawing.Size(720, 314);
            this.groupExecutando.TabIndex = 4;
            this.groupExecutando.Text = "Em execução";
            // 
            // btnPausar
            // 
            this.btnPausar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPausar.Location = new System.Drawing.Point(453, 281);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(8);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 23);
            this.btnPausar.TabIndex = 4;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(544, 281);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Location = new System.Drawing.Point(635, 281);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(8);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dataGridExecutando
            // 
            this.dataGridExecutando.AllowUserToAddRows = false;
            this.dataGridExecutando.AllowUserToDeleteRows = false;
            this.dataGridExecutando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridExecutando.AutoGenerateColumns = false;
            this.dataGridExecutando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExecutando.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridExecutando.DataSource = this.atualizaAtividadesExecucaoDTOBindingSource;
            this.dataGridExecutando.Location = new System.Drawing.Point(5, 26);
            this.dataGridExecutando.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.dataGridExecutando.Name = "dataGridExecutando";
            this.dataGridExecutando.ReadOnly = true;
            this.dataGridExecutando.Size = new System.Drawing.Size(710, 246);
            this.dataGridExecutando.TabIndex = 1;
            this.dataGridExecutando.SelectionChanged += new System.EventHandler(this.dataGridExecutando_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AtividadeId";
            this.dataGridViewTextBoxColumn4.HeaderText = "AtividadeId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 87;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NomeAtividade";
            this.dataGridViewTextBoxColumn5.HeaderText = "NomeAtividade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NomeProjeto";
            this.dataGridViewTextBoxColumn6.HeaderText = "NomeProjeto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // groupPendente
            // 
            this.groupPendente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPendente.Appearance.BackColor = System.Drawing.Color.Silver;
            this.groupPendente.Appearance.BackColor2 = System.Drawing.Color.Silver;
            this.groupPendente.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.groupPendente.Appearance.Options.UseBackColor = true;
            this.groupPendente.Appearance.Options.UseBorderColor = true;
            this.groupPendente.AppearanceCaption.BackColor = System.Drawing.Color.Silver;
            this.groupPendente.AppearanceCaption.BackColor2 = System.Drawing.Color.Silver;
            this.groupPendente.AppearanceCaption.BorderColor = System.Drawing.Color.Silver;
            this.groupPendente.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPendente.AppearanceCaption.Options.UseBackColor = true;
            this.groupPendente.AppearanceCaption.Options.UseBorderColor = true;
            this.groupPendente.AppearanceCaption.Options.UseFont = true;
            this.groupPendente.Controls.Add(this.dataGridPendentes);
            this.groupPendente.Controls.Add(this.btnExecutar);
            this.groupPendente.Location = new System.Drawing.Point(15, 15);
            this.groupPendente.Margin = new System.Windows.Forms.Padding(15);
            this.groupPendente.Name = "groupPendente";
            this.groupPendente.Size = new System.Drawing.Size(500, 690);
            this.groupPendente.TabIndex = 3;
            this.groupPendente.Text = "Aguardando";
            // 
            // dataGridPendentes
            // 
            this.dataGridPendentes.AllowUserToAddRows = false;
            this.dataGridPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPendentes.AutoGenerateColumns = false;
            this.dataGridPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridPendentes.DataSource = this.atualizaAtividadesExecucaoDTOBindingSource;
            this.dataGridPendentes.Location = new System.Drawing.Point(5, 26);
            this.dataGridPendentes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.dataGridPendentes.Name = "dataGridPendentes";
            this.dataGridPendentes.ReadOnly = true;
            this.dataGridPendentes.Size = new System.Drawing.Size(490, 622);
            this.dataGridPendentes.TabIndex = 5;
            this.dataGridPendentes.SelectionChanged += new System.EventHandler(this.dataGridPendentes_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AtividadeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "AtividadeId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 87;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeAtividade";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeAtividade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeProjeto";
            this.dataGridViewTextBoxColumn3.HeaderText = "NomeProjeto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutar.Location = new System.Drawing.Point(415, 657);
            this.btnExecutar.Margin = new System.Windows.Forms.Padding(8);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // HomeUserControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPausado);
            this.Controls.Add(this.groupExecutando);
            this.Controls.Add(this.groupPendente);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.HomeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupPausado)).EndInit();
            this.groupPausado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPausado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atualizaAtividadesExecucaoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupExecutando)).EndInit();
            this.groupExecutando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExecutando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendente)).EndInit();
            this.groupPendente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupPausado;
        private DevExpress.XtraEditors.GroupControl groupExecutando;
        private DevExpress.XtraEditors.GroupControl groupPendente;
        private System.Windows.Forms.DataGridView dataGridExecutando;
        private System.Windows.Forms.DataGridView dataGridPausado;
        private DevExpress.XtraEditors.SimpleButton btnExecutar;
        private DevExpress.XtraEditors.SimpleButton btnPausar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnFinalizar;
        private DevExpress.XtraEditors.SimpleButton btnExecutarAposPausado;
        private DevExpress.XtraEditors.SimpleButton btnCancelarAposPausado;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividadeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridPendentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource atualizaAtividadesExecucaoDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
