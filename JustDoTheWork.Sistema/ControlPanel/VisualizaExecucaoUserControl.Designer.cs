namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class VisualizaExecucaoUserControl
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
            components = new System.ComponentModel.Container();
            bindingSourceResultadoPesquisaAtividade = new BindingSource(components);
            groupExecutando = new DevExpress.XtraEditors.GroupControl();
            gridControlExecutando = new DevExpress.XtraGrid.GridControl();
            gridExecutando = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeIdExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeAtividadeExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeProjetoExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            colAcaoExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonAcaoExecutando = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            groupPausado = new DevExpress.XtraEditors.GroupControl();
            gridControlPausado = new DevExpress.XtraGrid.GridControl();
            gridPausado = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeIdPausado = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeAtividadePausado = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeProjetoPausado = new DevExpress.XtraGrid.Columns.GridColumn();
            colAcaoPausado = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonAcaoPausado = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            groupPendente = new DevExpress.XtraEditors.GroupControl();
            gridControlPendentes = new DevExpress.XtraGrid.GridControl();
            gridPendentes = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeAtividade = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeProjeto = new DevExpress.XtraGrid.Columns.GridColumn();
            colAcaoPendente = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonAcaoPendente = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            panelAcoes = new DevExpress.XtraEditors.PanelControl();
            btnFinalizar = new DevExpress.XtraEditors.SimpleButton();
            btnPausar = new DevExpress.XtraEditors.SimpleButton();
            btnExecutar = new DevExpress.XtraEditors.SimpleButton();
            btnVoltarPendente = new DevExpress.XtraEditors.SimpleButton();
            panelAtividadesExecucao = new DevExpress.XtraEditors.PanelControl();
            tableLayoutExecucao = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)bindingSourceResultadoPesquisaAtividade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupExecutando).BeginInit();
            groupExecutando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlExecutando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridExecutando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcaoExecutando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupPausado).BeginInit();
            groupPausado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlPausado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPausado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcaoPausado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupPendente).BeginInit();
            groupPendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlPendentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPendentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcaoPendente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).BeginInit();
            panelAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelAtividadesExecucao).BeginInit();
            panelAtividadesExecucao.SuspendLayout();
            SuspendLayout();
            // 
            // bindingSourceResultadoPesquisaAtividade
            // 
            bindingSourceResultadoPesquisaAtividade.DataSource = typeof(DTO.ResultadoPesquisaAtividadeDTO);
            // 
            // groupExecutando
            // 
            groupExecutando.Dock = DockStyle.Fill;
            groupExecutando.Padding = new Padding(10);
            groupExecutando.AppearanceCaption.Font = new Font("Courier New", 12F);
            groupExecutando.AppearanceCaption.Options.UseFont = true;
            groupExecutando.Controls.Add(gridControlExecutando);
            groupExecutando.Location = new Point(523, 17);
            groupExecutando.Margin = new Padding(8);
            groupExecutando.Name = "groupExecutando";
            groupExecutando.Size = new Size(720, 280);
            groupExecutando.TabIndex = 4;
            groupExecutando.Text = "Em execução";
            // 
            // gridControlExecutando
            // 
            gridControlExecutando.Dock = DockStyle.Fill;
            gridControlExecutando.DataSource = bindingSourceResultadoPesquisaAtividade;
            gridControlExecutando.Location = new Point(12, 39);
            gridControlExecutando.MainView = gridExecutando;
            gridControlExecutando.Margin = new Padding(10);
            gridControlExecutando.Name = "gridControlExecutando";
            gridControlExecutando.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryButtonAcaoExecutando });
            gridControlExecutando.Size = new Size(696, 229);
            gridControlExecutando.TabIndex = 4;
            gridControlExecutando.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridExecutando });
            // 
            // gridExecutando
            // 
            gridExecutando.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAtividadeIdExecutando, colNomeAtividadeExecutando, colNomeProjetoExecutando, colAcaoExecutando });
            gridExecutando.GridControl = gridControlExecutando;
            gridExecutando.Name = "gridExecutando";
            gridExecutando.RowClick += gridExecutando_RowClick;
            // 
            // colAtividadeIdExecutando
            // 
            colAtividadeIdExecutando.FieldName = "Id";
            colAtividadeIdExecutando.Name = "colAtividadeIdExecutando";
            colAtividadeIdExecutando.OptionsColumn.AllowEdit = false;
            colAtividadeIdExecutando.OptionsColumn.AllowMove = false;
            colAtividadeIdExecutando.OptionsColumn.AllowSize = false;
            colAtividadeIdExecutando.OptionsColumn.ReadOnly = true;
            colAtividadeIdExecutando.Visible = true;
            colAtividadeIdExecutando.VisibleIndex = 0;
            // 
            // colNomeAtividadeExecutando
            // 
            colNomeAtividadeExecutando.FieldName = "Atividade";
            colNomeAtividadeExecutando.Name = "colNomeAtividadeExecutando";
            colNomeAtividadeExecutando.OptionsColumn.AllowEdit = false;
            colNomeAtividadeExecutando.OptionsColumn.AllowMove = false;
            colNomeAtividadeExecutando.OptionsColumn.AllowSize = false;
            colNomeAtividadeExecutando.OptionsColumn.ReadOnly = true;
            colNomeAtividadeExecutando.Visible = true;
            colNomeAtividadeExecutando.VisibleIndex = 1;
            // 
            // colNomeProjetoExecutando
            // 
            colNomeProjetoExecutando.FieldName = "Projeto";
            colNomeProjetoExecutando.Name = "colNomeProjetoExecutando";
            colNomeProjetoExecutando.OptionsColumn.AllowEdit = false;
            colNomeProjetoExecutando.OptionsColumn.AllowMove = false;
            colNomeProjetoExecutando.OptionsColumn.AllowSize = false;
            colNomeProjetoExecutando.OptionsColumn.ReadOnly = true;
            colNomeProjetoExecutando.Visible = true;
            colNomeProjetoExecutando.VisibleIndex = 2;
            // 
            // colAcaoExecutando
            // 
            colAcaoExecutando.Caption = "Ação";
            colAcaoExecutando.ColumnEdit = repositoryButtonAcaoExecutando;
            colAcaoExecutando.Name = "colAcaoExecutando";
            colAcaoExecutando.Visible = true;
            colAcaoExecutando.VisibleIndex = 3;
            // 
            // repositoryButtonAcaoExecutando
            // 
            repositoryButtonAcaoExecutando.AutoHeight = false;
            repositoryButtonAcaoExecutando.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryButtonAcaoExecutando.Name = "repositoryButtonAcaoExecutando";
            repositoryButtonAcaoExecutando.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupPausado
            // 
            groupPausado.Dock = DockStyle.Fill;
            groupPausado.Padding = new Padding(10);
            groupPausado.AppearanceCaption.Font = new Font("Courier New", 12F);
            groupPausado.AppearanceCaption.Options.UseFont = true;
            groupPausado.Controls.Add(gridControlPausado);
            groupPausado.Location = new Point(523, 310);
            groupPausado.Margin = new Padding(8);
            groupPausado.Name = "groupPausado";
            groupPausado.Size = new Size(720, 297);
            groupPausado.TabIndex = 5;
            groupPausado.Text = "Pausado";
            // 
            // gridControlPausado
            // 
            gridControlPausado.Dock = DockStyle.Fill;
            gridControlPausado.DataSource = bindingSourceResultadoPesquisaAtividade;
            gridControlPausado.Location = new Point(12, 39);
            gridControlPausado.MainView = gridPausado;
            gridControlPausado.Margin = new Padding(10);
            gridControlPausado.Name = "gridControlPausado";
            gridControlPausado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryButtonAcaoPausado });
            gridControlPausado.Size = new Size(696, 246);
            gridControlPausado.TabIndex = 3;
            gridControlPausado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridPausado });
            // 
            // gridPausado
            // 
            gridPausado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAtividadeIdPausado, colNomeAtividadePausado, colNomeProjetoPausado, colAcaoPausado });
            gridPausado.GridControl = gridControlPausado;
            gridPausado.Name = "gridPausado";
            gridPausado.RowClick += gridPausado_RowClick;
            // 
            // colAtividadeIdPausado
            // 
            colAtividadeIdPausado.FieldName = "Id";
            colAtividadeIdPausado.Name = "colAtividadeIdPausado";
            colAtividadeIdPausado.OptionsColumn.AllowEdit = false;
            colAtividadeIdPausado.OptionsColumn.AllowMove = false;
            colAtividadeIdPausado.OptionsColumn.AllowSize = false;
            colAtividadeIdPausado.OptionsColumn.ReadOnly = true;
            colAtividadeIdPausado.Visible = true;
            colAtividadeIdPausado.VisibleIndex = 0;
            // 
            // colNomeAtividadePausado
            // 
            colNomeAtividadePausado.FieldName = "Atividade";
            colNomeAtividadePausado.Name = "colNomeAtividadePausado";
            colNomeAtividadePausado.OptionsColumn.AllowEdit = false;
            colNomeAtividadePausado.OptionsColumn.AllowMove = false;
            colNomeAtividadePausado.OptionsColumn.AllowSize = false;
            colNomeAtividadePausado.OptionsColumn.ReadOnly = true;
            colNomeAtividadePausado.Visible = true;
            colNomeAtividadePausado.VisibleIndex = 1;
            // 
            // colNomeProjetoPausado
            // 
            colNomeProjetoPausado.FieldName = "Projeto";
            colNomeProjetoPausado.Name = "colNomeProjetoPausado";
            colNomeProjetoPausado.OptionsColumn.AllowEdit = false;
            colNomeProjetoPausado.OptionsColumn.AllowMove = false;
            colNomeProjetoPausado.OptionsColumn.AllowSize = false;
            colNomeProjetoPausado.OptionsColumn.ReadOnly = true;
            colNomeProjetoPausado.Visible = true;
            colNomeProjetoPausado.VisibleIndex = 2;
            // 
            // colAcaoPausado
            // 
            colAcaoPausado.Caption = "Ação";
            colAcaoPausado.ColumnEdit = repositoryButtonAcaoPausado;
            colAcaoPausado.Name = "colAcaoPausado";
            colAcaoPausado.Visible = true;
            colAcaoPausado.VisibleIndex = 3;
            // 
            // repositoryButtonAcaoPausado
            // 
            repositoryButtonAcaoPausado.AutoHeight = false;
            repositoryButtonAcaoPausado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryButtonAcaoPausado.Name = "repositoryButtonAcaoPausado";
            repositoryButtonAcaoPausado.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupPendente
            // 
            groupPendente.Dock = DockStyle.Fill;
            groupPendente.Padding = new Padding(10);
            groupPendente.AppearanceCaption.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupPendente.AppearanceCaption.Options.UseFont = true;
            groupPendente.Controls.Add(gridControlPendentes);
            groupPendente.Location = new Point(17, 17);
            groupPendente.Margin = new Padding(8);
            groupPendente.Name = "groupPendente";
            groupPendente.Size = new Size(500, 590);
            groupPendente.TabIndex = 3;
            groupPendente.Text = "Pendentes";
            // 
            // gridControlPendentes
            // 
            gridControlPendentes.Dock = DockStyle.Fill;
            gridControlPendentes.DataSource = bindingSourceResultadoPesquisaAtividade;
            gridControlPendentes.Location = new Point(12, 39);
            gridControlPendentes.MainView = gridPendentes;
            gridControlPendentes.Margin = new Padding(10);
            gridControlPendentes.Name = "gridControlPendentes";
            gridControlPendentes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryButtonAcaoPendente });
            gridControlPendentes.Size = new Size(476, 539);
            gridControlPendentes.TabIndex = 6;
            gridControlPendentes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridPendentes });
            // 
            // gridPendentes
            // 
            gridPendentes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAtividadeId, colNomeAtividade, colNomeProjeto, colAcaoPendente });
            gridPendentes.GridControl = gridControlPendentes;
            gridPendentes.Name = "gridPendentes";
            gridPendentes.RowClick += gridPendentes_RowClick;
            // 
            // colAtividadeId
            // 
            colAtividadeId.FieldName = "Id";
            colAtividadeId.Name = "colAtividadeId";
            colAtividadeId.OptionsColumn.AllowEdit = false;
            colAtividadeId.OptionsColumn.AllowMove = false;
            colAtividadeId.OptionsColumn.AllowSize = false;
            colAtividadeId.OptionsColumn.ReadOnly = true;
            colAtividadeId.Visible = true;
            colAtividadeId.VisibleIndex = 0;
            // 
            // colNomeAtividade
            // 
            colNomeAtividade.FieldName = "Atividade";
            colNomeAtividade.Name = "colNomeAtividade";
            colNomeAtividade.OptionsColumn.AllowEdit = false;
            colNomeAtividade.OptionsColumn.AllowMove = false;
            colNomeAtividade.OptionsColumn.ReadOnly = true;
            colNomeAtividade.Visible = true;
            colNomeAtividade.VisibleIndex = 1;
            // 
            // colNomeProjeto
            // 
            colNomeProjeto.FieldName = "Projeto";
            colNomeProjeto.Name = "colNomeProjeto";
            colNomeProjeto.OptionsColumn.AllowEdit = false;
            colNomeProjeto.OptionsColumn.AllowSize = false;
            colNomeProjeto.OptionsColumn.ReadOnly = true;
            colNomeProjeto.Visible = true;
            colNomeProjeto.VisibleIndex = 2;
            // 
            // colAcaoPendente
            // 
            colAcaoPendente.Caption = "Ação";
            colAcaoPendente.ColumnEdit = repositoryButtonAcaoPendente;
            colAcaoPendente.Name = "colAcaoPendente";
            colAcaoPendente.Visible = true;
            colAcaoPendente.VisibleIndex = 3;
            // 
            // repositoryButtonAcaoPendente
            // 
            repositoryButtonAcaoPendente.AutoHeight = false;
            repositoryButtonAcaoPendente.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryButtonAcaoPendente.Name = "repositoryButtonAcaoPendente";
            repositoryButtonAcaoPendente.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelAcoes
            // 
            panelAcoes.Dock = DockStyle.Bottom;
            panelAcoes.Controls.Add(btnFinalizar);
            panelAcoes.Controls.Add(btnPausar);
            panelAcoes.Controls.Add(btnExecutar);
            panelAcoes.Controls.Add(btnVoltarPendente);
            panelAcoes.Location = new Point(22, 620);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(1216, 70);
            panelAcoes.TabIndex = 6;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFinalizar.Appearance.Font = new Font("Courier New", 8.25F);
            btnFinalizar.Appearance.Options.UseFont = true;
            btnFinalizar.Location = new Point(10, 42);
            btnFinalizar.Margin = new Padding(8);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 2;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnPausar
            // 
            btnPausar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPausar.Appearance.Font = new Font("Courier New", 8.25F);
            btnPausar.Appearance.Options.UseFont = true;
            btnPausar.Location = new Point(10, 10);
            btnPausar.Margin = new Padding(8);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(75, 23);
            btnPausar.TabIndex = 0;
            btnPausar.Text = "Pausar";
            btnPausar.Click += btnPausar_Click;
            // 
            // btnExecutar
            // 
            btnExecutar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExecutar.Appearance.Font = new Font("Courier New", 8.25F);
            btnExecutar.Appearance.Options.UseFont = true;
            btnExecutar.Location = new Point(101, 42);
            btnExecutar.Margin = new Padding(8);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(165, 23);
            btnExecutar.TabIndex = 3;
            btnExecutar.Text = "Executar";
            btnExecutar.Click += btnExecutar_Click;
            // 
            // btnVoltarPendente
            //
            btnVoltarPendente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltarPendente.Appearance.Font = new Font("Courier New", 8.25F);
            btnVoltarPendente.Appearance.Options.UseFont = true;
            btnVoltarPendente.Location = new Point(101, 10);
            btnVoltarPendente.Margin = new Padding(8);
            btnVoltarPendente.Name = "btnVoltarPendente";
            btnVoltarPendente.Size = new Size(165, 23);
            btnVoltarPendente.TabIndex = 1;
            btnVoltarPendente.Text = "Voltar para Pendente";
            btnVoltarPendente.Click += btnVoltarPendente_Click;
            //
            // tableLayoutExecucao
            //
            tableLayoutExecucao.ColumnCount = 2;
            tableLayoutExecucao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutExecucao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutExecucao.Controls.Add(groupPendente, 0, 0);
            tableLayoutExecucao.Controls.Add(groupExecutando, 1, 0);
            tableLayoutExecucao.Controls.Add(groupPausado, 1, 1);
            tableLayoutExecucao.SetRowSpan(groupPendente, 2);
            tableLayoutExecucao.Dock = DockStyle.Fill;
            tableLayoutExecucao.Name = "tableLayoutExecucao";
            tableLayoutExecucao.RowCount = 2;
            tableLayoutExecucao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutExecucao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutExecucao.TabIndex = 0;
            //
            // panelAtividadesExecucao
            // 
            panelAtividadesExecucao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelAtividadesExecucao.Padding = new Padding(10);
            panelAtividadesExecucao.Controls.Add(tableLayoutExecucao);
            panelAtividadesExecucao.Controls.Add(panelAcoes);
            panelAtividadesExecucao.Location = new Point(10, 10);
            panelAtividadesExecucao.Margin = new Padding(10);
            panelAtividadesExecucao.Name = "panelAtividadesExecucao";
            panelAtividadesExecucao.Size = new Size(1260, 700);
            panelAtividadesExecucao.TabIndex = 7;
            // 
            // VisualizaExecucaoUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAtividadesExecucao);
            Name = "VisualizaExecucaoUserControl";
            Size = new Size(1280, 720);
            Load += VisualizaExecucaoUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSourceResultadoPesquisaAtividade).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupExecutando).EndInit();
            groupExecutando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlExecutando).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridExecutando).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcaoExecutando).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupPausado).EndInit();
            groupPausado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlPausado).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPausado).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcaoPausado).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupPendente).EndInit();
            groupPendente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlPendentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPendentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcaoPendente).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).EndInit();
            panelAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelAtividadesExecucao).EndInit();
            panelAtividadesExecucao.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAtividadeTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeProjetoTabela;
        private System.Windows.Forms.BindingSource bindingSourceResultadoPesquisaAtividade;
        private DevExpress.XtraEditors.GroupControl groupExecutando;
        private DevExpress.XtraEditors.GroupControl groupPausado;
        private DevExpress.XtraEditors.GroupControl groupPendente;
        private DevExpress.XtraEditors.PanelControl panelAcoes;
        private DevExpress.XtraEditors.SimpleButton btnFinalizar;
        private DevExpress.XtraEditors.SimpleButton btnPausar;
        private DevExpress.XtraEditors.SimpleButton btnExecutar;
        private DevExpress.XtraEditors.SimpleButton btnVoltarPendente;
        private DevExpress.XtraEditors.PanelControl panelAtividadesExecucao;
        private TableLayoutPanel tableLayoutExecucao;
        private DevExpress.XtraGrid.GridControl gridControlPendentes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPendentes;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeId;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeAtividade;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProjeto;
        private DevExpress.XtraGrid.GridControl gridControlExecutando;
        private DevExpress.XtraGrid.Views.Grid.GridView gridExecutando;
        private DevExpress.XtraGrid.GridControl gridControlPausado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPausado;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeIdExecutando;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeAtividadeExecutando;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProjetoExecutando;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeIdPausado;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeAtividadePausado;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProjetoPausado;
        private DevExpress.XtraGrid.Columns.GridColumn colAcaoPendente;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonAcaoPendente;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonAcaoExecutando;
        private DevExpress.XtraGrid.Columns.GridColumn colAcaoExecutando;
        private DevExpress.XtraGrid.Columns.GridColumn colAcaoPausado;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonAcaoPausado;
    }
}
