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
            this.dataGridExecutando = new DevExpress.XtraGrid.GridControl();
            this.gridExecutando = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAtividadeIdExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeAtividadeExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProjetoExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupPausado = new DevExpress.XtraEditors.GroupControl();
            this.dataGridPausado = new DevExpress.XtraGrid.GridControl();
            this.gridPausado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAtividadeIdPausado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeAtividadePausado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProjetoPausado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupPendente = new DevExpress.XtraEditors.GroupControl();
            this.dataGridPendentes = new DevExpress.XtraGrid.GridControl();
            this.gridPendentes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAtividadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeAtividade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeProjeto = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridExecutando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPausado)).BeginInit();
            this.groupPausado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPausado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPausado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendente)).BeginInit();
            this.groupPendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPendentes)).BeginInit();
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
            this.groupExecutando.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 12F);
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
            this.dataGridExecutando.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridExecutando.DataSource = this.atualizaAtividadesExecucaoDTOBindingSource;
            this.dataGridExecutando.Location = new System.Drawing.Point(12, 39);
            this.dataGridExecutando.MainView = this.gridExecutando;
            this.dataGridExecutando.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridExecutando.Name = "dataGridExecutando";
            this.dataGridExecutando.Size = new System.Drawing.Size(696, 229);
            this.dataGridExecutando.TabIndex = 4;
            this.dataGridExecutando.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridExecutando});
            // 
            // gridExecutando
            // 
            this.gridExecutando.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAtividadeIdExecutando,
            this.colNomeAtividadeExecutando,
            this.colNomeProjetoExecutando});
            this.gridExecutando.GridControl = this.dataGridExecutando;
            this.gridExecutando.Name = "gridExecutando";
            this.gridExecutando.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridExecutando_RowClick);
            // 
            // colAtividadeIdExecutando
            // 
            this.colAtividadeIdExecutando.FieldName = "AtividadeId";
            this.colAtividadeIdExecutando.Name = "colAtividadeIdExecutando";
            this.colAtividadeIdExecutando.OptionsColumn.AllowEdit = false;
            this.colAtividadeIdExecutando.OptionsColumn.AllowMove = false;
            this.colAtividadeIdExecutando.OptionsColumn.AllowSize = false;
            this.colAtividadeIdExecutando.OptionsColumn.ReadOnly = true;
            this.colAtividadeIdExecutando.Visible = true;
            this.colAtividadeIdExecutando.VisibleIndex = 0;
            // 
            // colNomeAtividadeExecutando
            // 
            this.colNomeAtividadeExecutando.FieldName = "NomeAtividade";
            this.colNomeAtividadeExecutando.Name = "colNomeAtividadeExecutando";
            this.colNomeAtividadeExecutando.OptionsColumn.AllowEdit = false;
            this.colNomeAtividadeExecutando.OptionsColumn.AllowMove = false;
            this.colNomeAtividadeExecutando.OptionsColumn.AllowSize = false;
            this.colNomeAtividadeExecutando.OptionsColumn.ReadOnly = true;
            this.colNomeAtividadeExecutando.Visible = true;
            this.colNomeAtividadeExecutando.VisibleIndex = 1;
            // 
            // colNomeProjetoExecutando
            // 
            this.colNomeProjetoExecutando.FieldName = "NomeProjeto";
            this.colNomeProjetoExecutando.Name = "colNomeProjetoExecutando";
            this.colNomeProjetoExecutando.OptionsColumn.AllowEdit = false;
            this.colNomeProjetoExecutando.OptionsColumn.AllowMove = false;
            this.colNomeProjetoExecutando.OptionsColumn.AllowSize = false;
            this.colNomeProjetoExecutando.OptionsColumn.ReadOnly = true;
            this.colNomeProjetoExecutando.Visible = true;
            this.colNomeProjetoExecutando.VisibleIndex = 2;
            // 
            // groupPausado
            // 
            this.groupPausado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPausado.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 12F);
            this.groupPausado.AppearanceCaption.Options.UseFont = true;
            this.groupPausado.Controls.Add(this.dataGridPausado);
            this.groupPausado.Location = new System.Drawing.Point(523, 310);
            this.groupPausado.Margin = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.groupPausado.Name = "groupPausado";
            this.groupPausado.Size = new System.Drawing.Size(720, 297);
            this.groupPausado.TabIndex = 5;
            this.groupPausado.Text = "Pausado";
            // 
            // dataGridPausado
            // 
            this.dataGridPausado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPausado.DataSource = this.atualizaAtividadesExecucaoDTOBindingSource;
            this.dataGridPausado.Location = new System.Drawing.Point(12, 39);
            this.dataGridPausado.MainView = this.gridPausado;
            this.dataGridPausado.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridPausado.Name = "dataGridPausado";
            this.dataGridPausado.Size = new System.Drawing.Size(696, 246);
            this.dataGridPausado.TabIndex = 3;
            this.dataGridPausado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPausado});
            // 
            // gridPausado
            // 
            this.gridPausado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAtividadeIdPausado,
            this.colNomeAtividadePausado,
            this.colNomeProjetoPausado});
            this.gridPausado.GridControl = this.dataGridPausado;
            this.gridPausado.Name = "gridPausado";
            this.gridPausado.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridPausado_RowClick);
            // 
            // colAtividadeIdPausado
            // 
            this.colAtividadeIdPausado.FieldName = "AtividadeId";
            this.colAtividadeIdPausado.Name = "colAtividadeIdPausado";
            this.colAtividadeIdPausado.OptionsColumn.AllowEdit = false;
            this.colAtividadeIdPausado.OptionsColumn.AllowMove = false;
            this.colAtividadeIdPausado.OptionsColumn.AllowSize = false;
            this.colAtividadeIdPausado.OptionsColumn.ReadOnly = true;
            this.colAtividadeIdPausado.Visible = true;
            this.colAtividadeIdPausado.VisibleIndex = 0;
            // 
            // colNomeAtividadePausado
            // 
            this.colNomeAtividadePausado.FieldName = "NomeAtividade";
            this.colNomeAtividadePausado.Name = "colNomeAtividadePausado";
            this.colNomeAtividadePausado.OptionsColumn.AllowEdit = false;
            this.colNomeAtividadePausado.OptionsColumn.AllowMove = false;
            this.colNomeAtividadePausado.OptionsColumn.AllowSize = false;
            this.colNomeAtividadePausado.OptionsColumn.ReadOnly = true;
            this.colNomeAtividadePausado.Visible = true;
            this.colNomeAtividadePausado.VisibleIndex = 1;
            // 
            // colNomeProjetoPausado
            // 
            this.colNomeProjetoPausado.FieldName = "NomeProjeto";
            this.colNomeProjetoPausado.Name = "colNomeProjetoPausado";
            this.colNomeProjetoPausado.OptionsColumn.AllowEdit = false;
            this.colNomeProjetoPausado.OptionsColumn.AllowMove = false;
            this.colNomeProjetoPausado.OptionsColumn.AllowSize = false;
            this.colNomeProjetoPausado.OptionsColumn.ReadOnly = true;
            this.colNomeProjetoPausado.Visible = true;
            this.colNomeProjetoPausado.VisibleIndex = 2;
            // 
            // groupPendente
            // 
            this.groupPendente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPendente.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPendente.AppearanceCaption.Options.UseFont = true;
            this.groupPendente.Controls.Add(this.dataGridPendentes);
            this.groupPendente.Location = new System.Drawing.Point(17, 17);
            this.groupPendente.Margin = new System.Windows.Forms.Padding(15, 15, 15, 10);
            this.groupPendente.Name = "groupPendente";
            this.groupPendente.Size = new System.Drawing.Size(500, 590);
            this.groupPendente.TabIndex = 3;
            this.groupPendente.Text = "Pendentes";
            // 
            // dataGridPendentes
            // 
            this.dataGridPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPendentes.DataSource = this.atualizaAtividadesExecucaoDTOBindingSource;
            this.dataGridPendentes.Location = new System.Drawing.Point(12, 39);
            this.dataGridPendentes.MainView = this.gridPendentes;
            this.dataGridPendentes.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridPendentes.Name = "dataGridPendentes";
            this.dataGridPendentes.Size = new System.Drawing.Size(476, 539);
            this.dataGridPendentes.TabIndex = 6;
            this.dataGridPendentes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPendentes});
            // 
            // gridPendentes
            // 
            this.gridPendentes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAtividadeId,
            this.colNomeAtividade,
            this.colNomeProjeto});
            this.gridPendentes.GridControl = this.dataGridPendentes;
            this.gridPendentes.Name = "gridPendentes";
            this.gridPendentes.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridPendentes_RowClick);
            // 
            // colAtividadeId
            // 
            this.colAtividadeId.FieldName = "AtividadeId";
            this.colAtividadeId.Name = "colAtividadeId";
            this.colAtividadeId.OptionsColumn.AllowEdit = false;
            this.colAtividadeId.OptionsColumn.AllowMove = false;
            this.colAtividadeId.OptionsColumn.AllowSize = false;
            this.colAtividadeId.OptionsColumn.ReadOnly = true;
            this.colAtividadeId.Visible = true;
            this.colAtividadeId.VisibleIndex = 0;
            // 
            // colNomeAtividade
            // 
            this.colNomeAtividade.FieldName = "NomeAtividade";
            this.colNomeAtividade.Name = "colNomeAtividade";
            this.colNomeAtividade.OptionsColumn.AllowEdit = false;
            this.colNomeAtividade.OptionsColumn.AllowMove = false;
            this.colNomeAtividade.OptionsColumn.ReadOnly = true;
            this.colNomeAtividade.Visible = true;
            this.colNomeAtividade.VisibleIndex = 1;
            // 
            // colNomeProjeto
            // 
            this.colNomeProjeto.FieldName = "NomeProjeto";
            this.colNomeProjeto.Name = "colNomeProjeto";
            this.colNomeProjeto.OptionsColumn.AllowEdit = false;
            this.colNomeProjeto.OptionsColumn.AllowSize = false;
            this.colNomeProjeto.OptionsColumn.ReadOnly = true;
            this.colNomeProjeto.Visible = true;
            this.colNomeProjeto.VisibleIndex = 2;
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
            this.panelButtonsExecucao.Location = new System.Drawing.Point(22, 620);
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
            this.btnVisualizaAtividade.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridExecutando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPausado)).EndInit();
            this.groupPausado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPausado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPausado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendente)).EndInit();
            this.groupPendente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPendentes)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupPausado;
        private DevExpress.XtraEditors.GroupControl groupPendente;
        private DevExpress.XtraEditors.PanelControl panelButtonsExecucao;
        private DevExpress.XtraEditors.SimpleButton btnVisualizaAtividade;
        private DevExpress.XtraEditors.SimpleButton btnFinalizar;
        private DevExpress.XtraEditors.SimpleButton btnPausar;
        private DevExpress.XtraEditors.SimpleButton btnExecutar;
        private DevExpress.XtraEditors.SimpleButton btnVoltaPendente;
        private DevExpress.XtraEditors.PanelControl panelAtividadesExecucao;
        private DevExpress.XtraGrid.GridControl dataGridPendentes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPendentes;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeId;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeAtividade;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProjeto;
        private DevExpress.XtraGrid.GridControl dataGridExecutando;
        private DevExpress.XtraGrid.Views.Grid.GridView gridExecutando;
        private DevExpress.XtraGrid.GridControl dataGridPausado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPausado;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeIdExecutando;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeAtividadeExecutando;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProjetoExecutando;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeIdPausado;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeAtividadePausado;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProjetoPausado;
    }
}
