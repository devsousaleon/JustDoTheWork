namespace JustDoTheWork.Sistema.Forms
{
    partial class FormVisualizaAtividadeExecucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizaAtividadeExecucao));
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            tabControlAtividadeExecucao = new DevExpress.XtraTab.XtraTabControl();
            tabInfoAtividade = new DevExpress.XtraTab.XtraTabPage();
            groupHistoricoExecucao = new DevExpress.XtraEditors.GroupControl();
            gridControlHistoricoExecucao = new DevExpress.XtraGrid.GridControl();
            bindingSourceExecucao = new BindingSource(components);
            gridHistoricoExecucao = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDataFimExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryDataFimExecucao = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            colDataInicioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryDataInicioExecucao = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            groupInfoAtividade = new DevExpress.XtraEditors.GroupControl();
            txtNomeProjeto = new DevExpress.XtraEditors.TextEdit();
            bindingSourceDadosAtividadeExecucao = new BindingSource(components);
            lblDataCriacaoAtividade = new DevExpress.XtraEditors.LabelControl();
            dataCriacaoAtividade = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            tabDescricaoAtividade = new DevExpress.XtraTab.XtraTabPage();
            richEditDescricaoAtividade = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControlAtividadeExecucao).BeginInit();
            tabControlAtividadeExecucao.SuspendLayout();
            tabInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupHistoricoExecucao).BeginInit();
            groupHistoricoExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlHistoricoExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataFimExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataInicioExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupInfoAtividade).BeginInit();
            groupInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNomeProjeto.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceDadosAtividadeExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoAtividade.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).BeginInit();
            tabDescricaoAtividade.SuspendLayout();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(tabControlAtividadeExecucao);
            panelBackground.Location = new Point(12, 12);
            panelBackground.Name = "panelBackground";
            panelBackground.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBackground.Size = new Size(874, 544);
            panelBackground.TabIndex = 0;
            // 
            // tabControlAtividadeExecucao
            // 
            tabControlAtividadeExecucao.Location = new Point(5, 5);
            tabControlAtividadeExecucao.Name = "tabControlAtividadeExecucao";
            tabControlAtividadeExecucao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlAtividadeExecucao.SelectedTabPage = tabInfoAtividade;
            tabControlAtividadeExecucao.Size = new Size(864, 534);
            tabControlAtividadeExecucao.TabIndex = 0;
            tabControlAtividadeExecucao.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabInfoAtividade, tabDescricaoAtividade });
            // 
            // tabInfoAtividade
            // 
            tabInfoAtividade.Appearance.Header.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabInfoAtividade.Appearance.Header.Options.UseFont = true;
            tabInfoAtividade.Controls.Add(groupHistoricoExecucao);
            tabInfoAtividade.Controls.Add(groupInfoAtividade);
            tabInfoAtividade.Name = "tabInfoAtividade";
            tabInfoAtividade.Size = new Size(862, 503);
            tabInfoAtividade.Text = "Detalhamento da atividade";
            // 
            // groupHistoricoExecucao
            // 
            groupHistoricoExecucao.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            groupHistoricoExecucao.AppearanceCaption.Options.UseFont = true;
            groupHistoricoExecucao.Controls.Add(gridControlHistoricoExecucao);
            groupHistoricoExecucao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupHistoricoExecucao.Location = new Point(10, 187);
            groupHistoricoExecucao.Margin = new Padding(10);
            groupHistoricoExecucao.Name = "groupHistoricoExecucao";
            groupHistoricoExecucao.Size = new Size(842, 312);
            groupHistoricoExecucao.TabIndex = 1;
            groupHistoricoExecucao.Text = "Histórico de execuções";
            // 
            // gridControlHistoricoExecucao
            // 
            gridControlHistoricoExecucao.DataSource = bindingSourceExecucao;
            gridControlHistoricoExecucao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControlHistoricoExecucao.Location = new Point(12, 39);
            gridControlHistoricoExecucao.MainView = gridHistoricoExecucao;
            gridControlHistoricoExecucao.Margin = new Padding(10);
            gridControlHistoricoExecucao.Name = "gridControlHistoricoExecucao";
            gridControlHistoricoExecucao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryDataFimExecucao, repositoryDataInicioExecucao });
            gridControlHistoricoExecucao.Size = new Size(818, 261);
            gridControlHistoricoExecucao.TabIndex = 1;
            gridControlHistoricoExecucao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridHistoricoExecucao });
            // 
            // bindingSourceExecucao
            // 
            bindingSourceExecucao.DataSource = typeof(DTO.ExecucaoDTO);
            // 
            // gridHistoricoExecucao
            // 
            gridHistoricoExecucao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAtividadeId, colDataFimExecucao, colDataInicioExecucao });
            gridHistoricoExecucao.GridControl = gridControlHistoricoExecucao;
            gridHistoricoExecucao.Name = "gridHistoricoExecucao";
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
            // colDataFimExecucao
            // 
            colDataFimExecucao.ColumnEdit = repositoryDataFimExecucao;
            colDataFimExecucao.FieldName = "DataFim";
            colDataFimExecucao.Name = "colDataFimExecucao";
            colDataFimExecucao.OptionsColumn.AllowEdit = false;
            colDataFimExecucao.OptionsColumn.AllowMove = false;
            colDataFimExecucao.OptionsColumn.AllowSize = false;
            colDataFimExecucao.OptionsColumn.ReadOnly = true;
            colDataFimExecucao.Visible = true;
            colDataFimExecucao.VisibleIndex = 2;
            // 
            // repositoryDataFimExecucao
            // 
            repositoryDataFimExecucao.AutoHeight = false;
            repositoryDataFimExecucao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryDataFimExecucao.Name = "repositoryDataFimExecucao";
            // 
            // colDataInicioExecucao
            // 
            colDataInicioExecucao.ColumnEdit = repositoryDataInicioExecucao;
            colDataInicioExecucao.FieldName = "DataInicio";
            colDataInicioExecucao.Name = "colDataInicioExecucao";
            colDataInicioExecucao.OptionsColumn.AllowEdit = false;
            colDataInicioExecucao.OptionsColumn.AllowMove = false;
            colDataInicioExecucao.OptionsColumn.AllowSize = false;
            colDataInicioExecucao.OptionsColumn.ReadOnly = true;
            colDataInicioExecucao.Visible = true;
            colDataInicioExecucao.VisibleIndex = 1;
            // 
            // repositoryDataInicioExecucao
            // 
            repositoryDataInicioExecucao.AutoHeight = false;
            repositoryDataInicioExecucao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryDataInicioExecucao.Name = "repositoryDataInicioExecucao";
            // 
            // groupInfoAtividade
            // 
            groupInfoAtividade.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupInfoAtividade.AppearanceCaption.Options.UseFont = true;
            groupInfoAtividade.Controls.Add(txtNomeProjeto);
            groupInfoAtividade.Controls.Add(lblDataCriacaoAtividade);
            groupInfoAtividade.Controls.Add(dataCriacaoAtividade);
            groupInfoAtividade.Controls.Add(lblProjeto);
            groupInfoAtividade.Controls.Add(lblNomeAtividade);
            groupInfoAtividade.Controls.Add(txtNomeAtividade);
            groupInfoAtividade.Location = new Point(10, 10);
            groupInfoAtividade.Margin = new Padding(10);
            groupInfoAtividade.Name = "groupInfoAtividade";
            groupInfoAtividade.Size = new Size(842, 164);
            groupInfoAtividade.TabIndex = 0;
            groupInfoAtividade.Text = "Informações";
            // 
            // txtNomeProjeto
            // 
            txtNomeProjeto.DataBindings.Add(new Binding("EditValue", bindingSourceDadosAtividadeExecucao, "NomeProjeto", true));
            txtNomeProjeto.Enabled = false;
            txtNomeProjeto.Location = new Point(105, 81);
            txtNomeProjeto.Name = "txtNomeProjeto";
            txtNomeProjeto.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeProjeto.Properties.Appearance.Options.UseFont = true;
            txtNomeProjeto.Properties.MaxLength = 50;
            txtNomeProjeto.Size = new Size(302, 32);
            txtNomeProjeto.TabIndex = 2;
            // 
            // bindingSourceDadosAtividadeExecucao
            // 
            bindingSourceDadosAtividadeExecucao.DataSource = typeof(DTO.VisualizaExecucaoAtividadeDTO);
            // 
            // lblDataCriacaoAtividade
            // 
            lblDataCriacaoAtividade.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataCriacaoAtividade.Appearance.Options.UseFont = true;
            lblDataCriacaoAtividade.Location = new Point(420, 50);
            lblDataCriacaoAtividade.Margin = new Padding(10);
            lblDataCriacaoAtividade.Name = "lblDataCriacaoAtividade";
            lblDataCriacaoAtividade.Size = new Size(150, 18);
            lblDataCriacaoAtividade.TabIndex = 21;
            lblDataCriacaoAtividade.Text = "Data de Criação";
            // 
            // dataCriacaoAtividade
            // 
            dataCriacaoAtividade.DataBindings.Add(new Binding("EditValue", bindingSourceDadosAtividadeExecucao, "DataCriacaoAtividade", true));
            dataCriacaoAtividade.EditValue = null;
            dataCriacaoAtividade.Enabled = false;
            dataCriacaoAtividade.Location = new Point(583, 40);
            dataCriacaoAtividade.Name = "dataCriacaoAtividade";
            dataCriacaoAtividade.Properties.Appearance.Font = new Font("Courier New", 12F);
            dataCriacaoAtividade.Properties.Appearance.Options.UseFont = true;
            dataCriacaoAtividade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dataCriacaoAtividade.Size = new Size(254, 32);
            dataCriacaoAtividade.TabIndex = 1;
            // 
            // lblProjeto
            // 
            lblProjeto.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProjeto.Appearance.Options.UseFont = true;
            lblProjeto.Location = new Point(12, 94);
            lblProjeto.Margin = new Padding(20);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(70, 18);
            lblProjeto.TabIndex = 18;
            lblProjeto.Text = "Projeto";
            // 
            // lblNomeAtividade
            // 
            lblNomeAtividade.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeAtividade.Appearance.Options.UseFont = true;
            lblNomeAtividade.Location = new Point(12, 50);
            lblNomeAtividade.Margin = new Padding(10);
            lblNomeAtividade.Name = "lblNomeAtividade";
            lblNomeAtividade.Size = new Size(40, 18);
            lblNomeAtividade.TabIndex = 17;
            lblNomeAtividade.Text = "Nome";
            // 
            // txtNomeAtividade
            // 
            txtNomeAtividade.DataBindings.Add(new Binding("EditValue", bindingSourceDadosAtividadeExecucao, "NomeAtividade", true));
            txtNomeAtividade.Enabled = false;
            txtNomeAtividade.Location = new Point(105, 40);
            txtNomeAtividade.Name = "txtNomeAtividade";
            txtNomeAtividade.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            txtNomeAtividade.Properties.MaxLength = 50;
            txtNomeAtividade.Size = new Size(302, 32);
            txtNomeAtividade.TabIndex = 0;
            // 
            // tabDescricaoAtividade
            // 
            tabDescricaoAtividade.Appearance.Header.Font = new Font("Courier New", 8.25F);
            tabDescricaoAtividade.Appearance.Header.Options.UseFont = true;
            tabDescricaoAtividade.Controls.Add(richEditDescricaoAtividade);
            tabDescricaoAtividade.Name = "tabDescricaoAtividade";
            tabDescricaoAtividade.Size = new Size(862, 503);
            tabDescricaoAtividade.Text = "Descrição da atividade";
            // 
            // richEditDescricaoAtividade
            // 
            richEditDescricaoAtividade.DataBindings.Add(new Binding("DocxBytes", bindingSourceDadosAtividadeExecucao, "DescricaoAtividade", true));
            richEditDescricaoAtividade.Location = new Point(10, 10);
            richEditDescricaoAtividade.Margin = new Padding(10);
            richEditDescricaoAtividade.Name = "richEditDescricaoAtividade";
            richEditDescricaoAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            richEditDescricaoAtividade.ReadOnly = true;
            richEditDescricaoAtividade.Size = new Size(842, 488);
            richEditDescricaoAtividade.TabIndex = 19;
            // 
            // FormVisualizaAtividadeExecucao
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 560);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("FormVisualizaAtividadeExecucao.IconOptions.LargeImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVisualizaAtividadeExecucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualização de andamento da atividade";
            Load += FormVisualizaAtividadeExecucao_Load;
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabControlAtividadeExecucao).EndInit();
            tabControlAtividadeExecucao.ResumeLayout(false);
            tabInfoAtividade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupHistoricoExecucao).EndInit();
            groupHistoricoExecucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlHistoricoExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataFimExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataInicioExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupInfoAtividade).EndInit();
            groupInfoAtividade.ResumeLayout(false);
            groupInfoAtividade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtNomeProjeto.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceDadosAtividadeExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoAtividade.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).EndInit();
            tabDescricaoAtividade.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraTab.XtraTabControl tabControlAtividadeExecucao;
        private DevExpress.XtraTab.XtraTabPage tabInfoAtividade;
        private DevExpress.XtraTab.XtraTabPage tabDescricaoAtividade;
        private DevExpress.XtraEditors.GroupControl groupInfoAtividade;
        private DevExpress.XtraEditors.LabelControl lblDataCriacaoAtividade;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dataCriacaoAtividade;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LabelControl lblNomeAtividade;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.GroupControl groupHistoricoExecucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataInicioHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataFimHistorico;
        private DevExpress.XtraEditors.TextEdit txtNomeProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCriacaoHistorico;
        private System.Windows.Forms.BindingSource bindingSourceExecucao;
        private DevExpress.XtraRichEdit.RichEditControl richEditDescricaoAtividade;
        private DevExpress.XtraGrid.GridControl gridControlHistoricoExecucao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHistoricoExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFimExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicioExecucao;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryDataFimExecucao;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryDataInicioExecucao;
        private BindingSource bindingSourceDadosAtividadeExecucao;
    }
}
