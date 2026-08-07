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
            atualizaAtividadesExecucaoDTOBindingSource = new BindingSource(components);
            groupExecutando = new DevExpress.XtraEditors.GroupControl();
            dataGridExecutando = new DevExpress.XtraGrid.GridControl();
            gridExecutando = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeIdExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeAtividadeExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeProjetoExecutando = new DevExpress.XtraGrid.Columns.GridColumn();
            colButtonActionExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonActionExecucao = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            groupPausado = new DevExpress.XtraEditors.GroupControl();
            dataGridPausado = new DevExpress.XtraGrid.GridControl();
            gridPausado = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeIdPausado = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeAtividadePausado = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeProjetoPausado = new DevExpress.XtraGrid.Columns.GridColumn();
            colButtonActionPausado = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonActionPausado = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            groupPendente = new DevExpress.XtraEditors.GroupControl();
            dataGridPendentes = new DevExpress.XtraGrid.GridControl();
            gridPendentes = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeAtividade = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeProjeto = new DevExpress.XtraGrid.Columns.GridColumn();
            colButtonActionPendente = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonActionPendentes = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            panelButtonsExecucao = new DevExpress.XtraEditors.PanelControl();
            btnFinalizar = new DevExpress.XtraEditors.SimpleButton();
            btnPausar = new DevExpress.XtraEditors.SimpleButton();
            btnExecutar = new DevExpress.XtraEditors.SimpleButton();
            btnVoltaPendente = new DevExpress.XtraEditors.SimpleButton();
            panelAtividadesExecucao = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)atualizaAtividadesExecucaoDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupExecutando).BeginInit();
            groupExecutando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridExecutando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridExecutando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonActionExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupPausado).BeginInit();
            groupPausado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPausado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPausado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonActionPausado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupPendente).BeginInit();
            groupPendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPendentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPendentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonActionPendentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelButtonsExecucao).BeginInit();
            panelButtonsExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelAtividadesExecucao).BeginInit();
            panelAtividadesExecucao.SuspendLayout();
            SuspendLayout();
            // 
            // atualizaAtividadesExecucaoDTOBindingSource
            // 
            atualizaAtividadesExecucaoDTOBindingSource.DataSource = typeof(DTO.AtualizaAtividadesExecucaoDTO);
            // 
            // groupExecutando
            // 
            groupExecutando.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupExecutando.AppearanceCaption.Font = new Font("Courier New", 12F);
            groupExecutando.AppearanceCaption.Options.UseFont = true;
            groupExecutando.Controls.Add(dataGridExecutando);
            groupExecutando.Location = new Point(523, 17);
            groupExecutando.Margin = new Padding(15);
            groupExecutando.Name = "groupExecutando";
            groupExecutando.Size = new Size(720, 280);
            groupExecutando.TabIndex = 4;
            groupExecutando.Text = "Em execução";
            // 
            // dataGridExecutando
            // 
            dataGridExecutando.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridExecutando.DataSource = atualizaAtividadesExecucaoDTOBindingSource;
            dataGridExecutando.Location = new Point(12, 39);
            dataGridExecutando.MainView = gridExecutando;
            dataGridExecutando.Margin = new Padding(10);
            dataGridExecutando.Name = "dataGridExecutando";
            dataGridExecutando.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryButtonActionExecucao });
            dataGridExecutando.Size = new Size(696, 229);
            dataGridExecutando.TabIndex = 4;
            dataGridExecutando.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridExecutando });
            // 
            // gridExecutando
            // 
            gridExecutando.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAtividadeIdExecutando, colNomeAtividadeExecutando, colNomeProjetoExecutando, colButtonActionExecucao });
            gridExecutando.GridControl = dataGridExecutando;
            gridExecutando.Name = "gridExecutando";
            gridExecutando.RowClick += gridExecutando_RowClick;
            // 
            // colAtividadeIdExecutando
            // 
            colAtividadeIdExecutando.FieldName = "AtividadeId";
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
            colNomeAtividadeExecutando.FieldName = "NomeAtividade";
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
            colNomeProjetoExecutando.FieldName = "NomeProjeto";
            colNomeProjetoExecutando.Name = "colNomeProjetoExecutando";
            colNomeProjetoExecutando.OptionsColumn.AllowEdit = false;
            colNomeProjetoExecutando.OptionsColumn.AllowMove = false;
            colNomeProjetoExecutando.OptionsColumn.AllowSize = false;
            colNomeProjetoExecutando.OptionsColumn.ReadOnly = true;
            colNomeProjetoExecutando.Visible = true;
            colNomeProjetoExecutando.VisibleIndex = 2;
            // 
            // colButtonActionExecucao
            // 
            colButtonActionExecucao.Caption = "Ação";
            colButtonActionExecucao.ColumnEdit = repositoryButtonActionExecucao;
            colButtonActionExecucao.Name = "colButtonActionExecucao";
            colButtonActionExecucao.Visible = true;
            colButtonActionExecucao.VisibleIndex = 3;
            // 
            // repositoryButtonActionExecucao
            // 
            repositoryButtonActionExecucao.AutoHeight = false;
            repositoryButtonActionExecucao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryButtonActionExecucao.Name = "repositoryButtonActionExecucao";
            repositoryButtonActionExecucao.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupPausado
            // 
            groupPausado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupPausado.AppearanceCaption.Font = new Font("Courier New", 12F);
            groupPausado.AppearanceCaption.Options.UseFont = true;
            groupPausado.Controls.Add(dataGridPausado);
            groupPausado.Location = new Point(523, 310);
            groupPausado.Margin = new Padding(15, 15, 15, 10);
            groupPausado.Name = "groupPausado";
            groupPausado.Size = new Size(720, 297);
            groupPausado.TabIndex = 5;
            groupPausado.Text = "Pausado";
            // 
            // dataGridPausado
            // 
            dataGridPausado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPausado.DataSource = atualizaAtividadesExecucaoDTOBindingSource;
            dataGridPausado.Location = new Point(12, 39);
            dataGridPausado.MainView = gridPausado;
            dataGridPausado.Margin = new Padding(10);
            dataGridPausado.Name = "dataGridPausado";
            dataGridPausado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryButtonActionPausado });
            dataGridPausado.Size = new Size(696, 246);
            dataGridPausado.TabIndex = 3;
            dataGridPausado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridPausado });
            // 
            // gridPausado
            // 
            gridPausado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAtividadeIdPausado, colNomeAtividadePausado, colNomeProjetoPausado, colButtonActionPausado });
            gridPausado.GridControl = dataGridPausado;
            gridPausado.Name = "gridPausado";
            gridPausado.RowClick += gridPausado_RowClick;
            // 
            // colAtividadeIdPausado
            // 
            colAtividadeIdPausado.FieldName = "AtividadeId";
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
            colNomeAtividadePausado.FieldName = "NomeAtividade";
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
            colNomeProjetoPausado.FieldName = "NomeProjeto";
            colNomeProjetoPausado.Name = "colNomeProjetoPausado";
            colNomeProjetoPausado.OptionsColumn.AllowEdit = false;
            colNomeProjetoPausado.OptionsColumn.AllowMove = false;
            colNomeProjetoPausado.OptionsColumn.AllowSize = false;
            colNomeProjetoPausado.OptionsColumn.ReadOnly = true;
            colNomeProjetoPausado.Visible = true;
            colNomeProjetoPausado.VisibleIndex = 2;
            // 
            // colButtonActionPausado
            // 
            colButtonActionPausado.Caption = "Ação";
            colButtonActionPausado.ColumnEdit = repositoryButtonActionPausado;
            colButtonActionPausado.Name = "colButtonActionPausado";
            colButtonActionPausado.Visible = true;
            colButtonActionPausado.VisibleIndex = 3;
            // 
            // repositoryButtonActionPausado
            // 
            repositoryButtonActionPausado.AutoHeight = false;
            repositoryButtonActionPausado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryButtonActionPausado.Name = "repositoryButtonActionPausado";
            repositoryButtonActionPausado.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupPendente
            // 
            groupPendente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupPendente.AppearanceCaption.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupPendente.AppearanceCaption.Options.UseFont = true;
            groupPendente.Controls.Add(dataGridPendentes);
            groupPendente.Location = new Point(17, 17);
            groupPendente.Margin = new Padding(15, 15, 15, 10);
            groupPendente.Name = "groupPendente";
            groupPendente.Size = new Size(500, 590);
            groupPendente.TabIndex = 3;
            groupPendente.Text = "Pendentes";
            // 
            // dataGridPendentes
            // 
            dataGridPendentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPendentes.DataSource = atualizaAtividadesExecucaoDTOBindingSource;
            dataGridPendentes.Location = new Point(12, 39);
            dataGridPendentes.MainView = gridPendentes;
            dataGridPendentes.Margin = new Padding(10);
            dataGridPendentes.Name = "dataGridPendentes";
            dataGridPendentes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryButtonActionPendentes });
            dataGridPendentes.Size = new Size(476, 539);
            dataGridPendentes.TabIndex = 6;
            dataGridPendentes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridPendentes });
            // 
            // gridPendentes
            // 
            gridPendentes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAtividadeId, colNomeAtividade, colNomeProjeto, colButtonActionPendente });
            gridPendentes.GridControl = dataGridPendentes;
            gridPendentes.Name = "gridPendentes";
            gridPendentes.RowClick += gridPendentes_RowClick;
            // 
            // colAtividadeId
            // 
            colAtividadeId.FieldName = "AtividadeId";
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
            colNomeAtividade.FieldName = "NomeAtividade";
            colNomeAtividade.Name = "colNomeAtividade";
            colNomeAtividade.OptionsColumn.AllowEdit = false;
            colNomeAtividade.OptionsColumn.AllowMove = false;
            colNomeAtividade.OptionsColumn.ReadOnly = true;
            colNomeAtividade.Visible = true;
            colNomeAtividade.VisibleIndex = 1;
            // 
            // colNomeProjeto
            // 
            colNomeProjeto.FieldName = "NomeProjeto";
            colNomeProjeto.Name = "colNomeProjeto";
            colNomeProjeto.OptionsColumn.AllowEdit = false;
            colNomeProjeto.OptionsColumn.AllowSize = false;
            colNomeProjeto.OptionsColumn.ReadOnly = true;
            colNomeProjeto.Visible = true;
            colNomeProjeto.VisibleIndex = 2;
            // 
            // colButtonActionPendente
            // 
            colButtonActionPendente.Caption = "Ação";
            colButtonActionPendente.ColumnEdit = repositoryButtonActionPendentes;
            colButtonActionPendente.Name = "colButtonActionPendente";
            colButtonActionPendente.Visible = true;
            colButtonActionPendente.VisibleIndex = 3;
            // 
            // repositoryButtonActionPendentes
            // 
            repositoryButtonActionPendentes.AutoHeight = false;
            repositoryButtonActionPendentes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryButtonActionPendentes.Name = "repositoryButtonActionPendentes";
            repositoryButtonActionPendentes.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelButtonsExecucao
            // 
            panelButtonsExecucao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelButtonsExecucao.Controls.Add(btnFinalizar);
            panelButtonsExecucao.Controls.Add(btnPausar);
            panelButtonsExecucao.Controls.Add(btnExecutar);
            panelButtonsExecucao.Controls.Add(btnVoltaPendente);
            panelButtonsExecucao.Location = new Point(22, 620);
            panelButtonsExecucao.Name = "panelButtonsExecucao";
            panelButtonsExecucao.Size = new Size(1216, 70);
            panelButtonsExecucao.TabIndex = 6;
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
            // btnVoltaPendente
            // 
            btnVoltaPendente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVoltaPendente.Appearance.Font = new Font("Courier New", 8.25F);
            btnVoltaPendente.Appearance.Options.UseFont = true;
            btnVoltaPendente.Location = new Point(101, 10);
            btnVoltaPendente.Margin = new Padding(8);
            btnVoltaPendente.Name = "btnVoltaPendente";
            btnVoltaPendente.Size = new Size(165, 23);
            btnVoltaPendente.TabIndex = 1;
            btnVoltaPendente.Text = "Voltar para Pendente";
            btnVoltaPendente.Click += btnVoltaPendente_Click;
            // 
            // panelAtividadesExecucao
            // 
            panelAtividadesExecucao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelAtividadesExecucao.Controls.Add(panelButtonsExecucao);
            panelAtividadesExecucao.Controls.Add(groupPendente);
            panelAtividadesExecucao.Controls.Add(groupPausado);
            panelAtividadesExecucao.Controls.Add(groupExecutando);
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
            Load += HomeUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)atualizaAtividadesExecucaoDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupExecutando).EndInit();
            groupExecutando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExecutando).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridExecutando).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonActionExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupPausado).EndInit();
            groupPausado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPausado).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPausado).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonActionPausado).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupPendente).EndInit();
            groupPendente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPendentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPendentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonActionPendentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelButtonsExecucao).EndInit();
            panelButtonsExecucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelAtividadesExecucao).EndInit();
            panelAtividadesExecucao.ResumeLayout(false);
            ResumeLayout(false);

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
        private DevExpress.XtraGrid.Columns.GridColumn colButtonActionPendente;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonActionPendentes;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonActionExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colButtonActionExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colButtonActionPausado;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonActionPausado;
    }
}
