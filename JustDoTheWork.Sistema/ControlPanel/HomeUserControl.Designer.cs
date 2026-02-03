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
            this.atualizaAtividadesExecucaoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupExecutando = new DevExpress.XtraEditors.GroupControl();
            this.dataGridExecutando = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPausado = new DevExpress.XtraEditors.GroupControl();
            this.dataGridPausado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPendente = new DevExpress.XtraEditors.GroupControl();
            this.dataGridPendentes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButtonsExecucao = new DevExpress.XtraEditors.PanelControl();
            this.btnVisualizaAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinalizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPausar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExecutar = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltaPendente = new DevExpress.XtraEditors.SimpleButton();
            this.panelAtividadesExecucao = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.atualizaAtividadesExecucaoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupExecutando)).BeginInit();
            this.groupExecutando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExecutando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPausado)).BeginInit();
            this.groupPausado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPausado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendente)).BeginInit();
            this.groupPendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtonsExecucao)).BeginInit();
            this.panelButtonsExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAtividadesExecucao)).BeginInit();
            this.panelAtividadesExecucao.SuspendLayout();
            this.SuspendLayout();
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
            this.groupExecutando.Controls.Add(this.dataGridExecutando);
            this.groupExecutando.Location = new System.Drawing.Point(523, 17);
            this.groupExecutando.Margin = new System.Windows.Forms.Padding(15);
            this.groupExecutando.Name = "groupExecutando";
            this.groupExecutando.Size = new System.Drawing.Size(720, 280);
            this.groupExecutando.TabIndex = 4;
            this.groupExecutando.Text = "Em execução";
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
            this.dataGridExecutando.Name = "dataGridExecutando";
            this.dataGridExecutando.ReadOnly = true;
            this.dataGridExecutando.Size = new System.Drawing.Size(710, 249);
            this.dataGridExecutando.TabIndex = 1;
            this.dataGridExecutando.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridExecutando_CellDoubleClick);
            this.dataGridExecutando.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridExecutando_DataBindingComplete);
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
            this.groupPausado.Controls.Add(this.dataGridPausado);
            this.groupPausado.Location = new System.Drawing.Point(523, 310);
            this.groupPausado.Margin = new System.Windows.Forms.Padding(15);
            this.groupPausado.Name = "groupPausado";
            this.groupPausado.Size = new System.Drawing.Size(720, 297);
            this.groupPausado.TabIndex = 5;
            this.groupPausado.Text = "Pausado";
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
            this.dataGridPausado.Name = "dataGridPausado";
            this.dataGridPausado.ReadOnly = true;
            this.dataGridPausado.Size = new System.Drawing.Size(710, 266);
            this.dataGridPausado.TabIndex = 2;
            this.dataGridPausado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPausado_CellDoubleClick);
            this.dataGridPausado.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridPausado_DataBindingComplete);
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
            this.groupPendente.Location = new System.Drawing.Point(17, 17);
            this.groupPendente.Margin = new System.Windows.Forms.Padding(15);
            this.groupPendente.Name = "groupPendente";
            this.groupPendente.Size = new System.Drawing.Size(500, 590);
            this.groupPendente.TabIndex = 3;
            this.groupPendente.Text = "Pendentes";
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
            this.dataGridPendentes.Name = "dataGridPendentes";
            this.dataGridPendentes.ReadOnly = true;
            this.dataGridPendentes.Size = new System.Drawing.Size(490, 559);
            this.dataGridPendentes.TabIndex = 5;
            this.dataGridPendentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPendentes_CellDoubleClick);
            this.dataGridPendentes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridPendentes_DataBindingComplete);
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
            // panelButtonsExecucao
            // 
            this.panelButtonsExecucao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtonsExecucao.Controls.Add(this.btnVisualizaAtividade);
            this.panelButtonsExecucao.Controls.Add(this.btnFinalizar);
            this.panelButtonsExecucao.Controls.Add(this.btnPausar);
            this.panelButtonsExecucao.Controls.Add(this.btnExecutar);
            this.panelButtonsExecucao.Controls.Add(this.btnVoltaPendente);
            this.panelButtonsExecucao.Location = new System.Drawing.Point(22, 625);
            this.panelButtonsExecucao.Name = "panelButtonsExecucao";
            this.panelButtonsExecucao.Size = new System.Drawing.Size(1216, 70);
            this.panelButtonsExecucao.TabIndex = 6;
            // 
            // btnVisualizaAtividade
            // 
            this.btnVisualizaAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVisualizaAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnVisualizaAtividade.Appearance.Options.UseFont = true;
            this.btnVisualizaAtividade.Location = new System.Drawing.Point(282, 10);
            this.btnVisualizaAtividade.Margin = new System.Windows.Forms.Padding(8);
            this.btnVisualizaAtividade.Name = "btnVisualizaAtividade";
            this.btnVisualizaAtividade.Size = new System.Drawing.Size(165, 23);
            this.btnVisualizaAtividade.TabIndex = 5;
            this.btnVisualizaAtividade.Text = "Visualizar Atividade";
            this.btnVisualizaAtividade.Click += new System.EventHandler(this.btnVisualizaAtividade_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFinalizar.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnFinalizar.Appearance.Options.UseFont = true;
            this.btnFinalizar.Location = new System.Drawing.Point(10, 42);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(8);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPausar.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnPausar.Appearance.Options.UseFont = true;
            this.btnPausar.Location = new System.Drawing.Point(10, 10);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(8);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 23);
            this.btnPausar.TabIndex = 4;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExecutar.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnExecutar.Appearance.Options.UseFont = true;
            this.btnExecutar.Location = new System.Drawing.Point(101, 42);
            this.btnExecutar.Margin = new System.Windows.Forms.Padding(8);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(133, 23);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnVoltaPendente
            // 
            this.btnVoltaPendente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltaPendente.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnVoltaPendente.Appearance.Options.UseFont = true;
            this.btnVoltaPendente.Location = new System.Drawing.Point(101, 10);
            this.btnVoltaPendente.Margin = new System.Windows.Forms.Padding(8);
            this.btnVoltaPendente.Name = "btnVoltaPendente";
            this.btnVoltaPendente.Size = new System.Drawing.Size(165, 23);
            this.btnVoltaPendente.TabIndex = 3;
            this.btnVoltaPendente.Text = "Voltar para Pendente";
            this.btnVoltaPendente.Click += new System.EventHandler(this.btnVoltaPendente_Click);
            // 
            // panelAtividadesExecucao
            // 
            this.panelAtividadesExecucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAtividadesExecucao.Controls.Add(this.panelButtonsExecucao);
            this.panelAtividadesExecucao.Controls.Add(this.groupPendente);
            this.panelAtividadesExecucao.Controls.Add(this.groupPausado);
            this.panelAtividadesExecucao.Controls.Add(this.groupExecutando);
            this.panelAtividadesExecucao.Location = new System.Drawing.Point(10, 10);
            this.panelAtividadesExecucao.Margin = new System.Windows.Forms.Padding(10);
            this.panelAtividadesExecucao.Name = "panelAtividadesExecucao";
            this.panelAtividadesExecucao.Size = new System.Drawing.Size(1260, 700);
            this.panelAtividadesExecucao.TabIndex = 7;
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
            this.Controls.Add(this.panelAtividadesExecucao);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.HomeUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atualizaAtividadesExecucaoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupExecutando)).EndInit();
            this.groupExecutando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExecutando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPausado)).EndInit();
            this.groupPausado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPausado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendente)).EndInit();
            this.groupPendente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtonsExecucao)).EndInit();
            this.panelButtonsExecucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAtividadesExecucao)).EndInit();
            this.panelAtividadesExecucao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn atividadeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource atualizaAtividadesExecucaoDTOBindingSource;
        private DevExpress.XtraEditors.GroupControl groupExecutando;
        private System.Windows.Forms.DataGridView dataGridExecutando;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevExpress.XtraEditors.GroupControl groupPausado;
        private System.Windows.Forms.DataGridView dataGridPausado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DevExpress.XtraEditors.GroupControl groupPendente;
        private System.Windows.Forms.DataGridView dataGridPendentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevExpress.XtraEditors.PanelControl panelButtonsExecucao;
        private DevExpress.XtraEditors.SimpleButton btnVisualizaAtividade;
        private DevExpress.XtraEditors.SimpleButton btnFinalizar;
        private DevExpress.XtraEditors.SimpleButton btnPausar;
        private DevExpress.XtraEditors.SimpleButton btnExecutar;
        private DevExpress.XtraEditors.SimpleButton btnVoltaPendente;
        private DevExpress.XtraEditors.PanelControl panelAtividadesExecucao;
    }
}
