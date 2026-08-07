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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            xtraTabControlAtividadesExecucao = new DevExpress.XtraTab.XtraTabControl();
            xtraTabInfoAtividade = new DevExpress.XtraTab.XtraTabPage();
            groupHistoricoExecucao = new DevExpress.XtraEditors.GroupControl();
            dataGridHistoricoExecucao = new DevExpress.XtraGrid.GridControl();
            execucaoDTOBindingSource = new BindingSource(components);
            gridHistoricoExecucao = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDataFimExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            colDataInicioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            groupInfoAtividade = new DevExpress.XtraEditors.GroupControl();
            txtNomeProjeto = new DevExpress.XtraEditors.TextEdit();
            lblDataCriacaoAtividade = new DevExpress.XtraEditors.LabelControl();
            DataCriacaoAtividade = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            xtraPageDescricaoAtividade = new DevExpress.XtraTab.XtraTabPage();
            txtEditorAtividade = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xtraTabControlAtividadesExecucao).BeginInit();
            xtraTabControlAtividadesExecucao.SuspendLayout();
            xtraTabInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupHistoricoExecucao).BeginInit();
            groupHistoricoExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHistoricoExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)execucaoDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupInfoAtividade).BeginInit();
            groupInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNomeProjeto.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataCriacaoAtividade.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).BeginInit();
            xtraPageDescricaoAtividade.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(xtraTabControlAtividadesExecucao);
            panelControl1.Location = new Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(874, 544);
            panelControl1.TabIndex = 0;
            // 
            // xtraTabControlAtividadesExecucao
            // 
            xtraTabControlAtividadesExecucao.Location = new Point(5, 5);
            xtraTabControlAtividadesExecucao.Name = "xtraTabControlAtividadesExecucao";
            xtraTabControlAtividadesExecucao.SelectedTabPage = xtraTabInfoAtividade;
            xtraTabControlAtividadesExecucao.Size = new Size(864, 534);
            xtraTabControlAtividadesExecucao.TabIndex = 0;
            xtraTabControlAtividadesExecucao.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabInfoAtividade, xtraPageDescricaoAtividade });
            // 
            // xtraTabInfoAtividade
            // 
            xtraTabInfoAtividade.Appearance.Header.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xtraTabInfoAtividade.Appearance.Header.Options.UseFont = true;
            xtraTabInfoAtividade.Controls.Add(groupHistoricoExecucao);
            xtraTabInfoAtividade.Controls.Add(groupInfoAtividade);
            xtraTabInfoAtividade.Name = "xtraTabInfoAtividade";
            xtraTabInfoAtividade.Size = new Size(862, 503);
            xtraTabInfoAtividade.Text = "Detalhamento da atividade";
            // 
            // groupHistoricoExecucao
            // 
            groupHistoricoExecucao.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            groupHistoricoExecucao.AppearanceCaption.Options.UseFont = true;
            groupHistoricoExecucao.Controls.Add(dataGridHistoricoExecucao);
            groupHistoricoExecucao.Location = new Point(10, 187);
            groupHistoricoExecucao.Margin = new Padding(10);
            groupHistoricoExecucao.Name = "groupHistoricoExecucao";
            groupHistoricoExecucao.Size = new Size(842, 312);
            groupHistoricoExecucao.TabIndex = 1;
            groupHistoricoExecucao.Text = "Histórico de execuções";
            // 
            // dataGridHistoricoExecucao
            // 
            dataGridHistoricoExecucao.DataSource = execucaoDTOBindingSource;
            dataGridHistoricoExecucao.Location = new Point(12, 39);
            dataGridHistoricoExecucao.MainView = gridHistoricoExecucao;
            dataGridHistoricoExecucao.Margin = new Padding(10);
            dataGridHistoricoExecucao.Name = "dataGridHistoricoExecucao";
            dataGridHistoricoExecucao.Size = new Size(818, 261);
            dataGridHistoricoExecucao.TabIndex = 1;
            dataGridHistoricoExecucao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridHistoricoExecucao });
            // 
            // execucaoDTOBindingSource
            // 
            execucaoDTOBindingSource.DataSource = typeof(DTO.ExecucaoDTO);
            // 
            // gridHistoricoExecucao
            // 
            gridHistoricoExecucao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colAtividadeId, colDataFimExecucao, colDataInicioExecucao });
            gridHistoricoExecucao.GridControl = dataGridHistoricoExecucao;
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
            colDataFimExecucao.FieldName = "DataFimExecucao";
            colDataFimExecucao.Name = "colDataFimExecucao";
            colDataFimExecucao.OptionsColumn.AllowEdit = false;
            colDataFimExecucao.OptionsColumn.AllowMove = false;
            colDataFimExecucao.OptionsColumn.AllowSize = false;
            colDataFimExecucao.OptionsColumn.ReadOnly = true;
            colDataFimExecucao.Visible = true;
            colDataFimExecucao.VisibleIndex = 2;
            // 
            // colDataInicioExecucao
            // 
            colDataInicioExecucao.FieldName = "DataInicioExecucao";
            colDataInicioExecucao.Name = "colDataInicioExecucao";
            colDataInicioExecucao.OptionsColumn.AllowEdit = false;
            colDataInicioExecucao.OptionsColumn.AllowMove = false;
            colDataInicioExecucao.OptionsColumn.AllowSize = false;
            colDataInicioExecucao.OptionsColumn.ReadOnly = true;
            colDataInicioExecucao.Visible = true;
            colDataInicioExecucao.VisibleIndex = 1;
            // 
            // groupInfoAtividade
            // 
            groupInfoAtividade.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupInfoAtividade.AppearanceCaption.Options.UseFont = true;
            groupInfoAtividade.Controls.Add(txtNomeProjeto);
            groupInfoAtividade.Controls.Add(lblDataCriacaoAtividade);
            groupInfoAtividade.Controls.Add(DataCriacaoAtividade);
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
            txtNomeProjeto.Enabled = false;
            txtNomeProjeto.Location = new Point(105, 81);
            txtNomeProjeto.Name = "txtNomeProjeto";
            txtNomeProjeto.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeProjeto.Properties.Appearance.Options.UseFont = true;
            txtNomeProjeto.Size = new Size(302, 32);
            txtNomeProjeto.TabIndex = 2;
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
            // DataCriacaoAtividade
            // 
            DataCriacaoAtividade.EditValue = null;
            DataCriacaoAtividade.Enabled = false;
            DataCriacaoAtividade.Location = new Point(583, 40);
            DataCriacaoAtividade.Name = "DataCriacaoAtividade";
            DataCriacaoAtividade.Properties.Appearance.Font = new Font("Courier New", 12F);
            DataCriacaoAtividade.Properties.Appearance.Options.UseFont = true;
            DataCriacaoAtividade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DataCriacaoAtividade.Size = new Size(254, 32);
            DataCriacaoAtividade.TabIndex = 1;
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
            txtNomeAtividade.Enabled = false;
            txtNomeAtividade.Location = new Point(65, 40);
            txtNomeAtividade.Name = "txtNomeAtividade";
            txtNomeAtividade.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            txtNomeAtividade.Size = new Size(342, 32);
            txtNomeAtividade.TabIndex = 0;
            // 
            // xtraPageDescricaoAtividade
            // 
            xtraPageDescricaoAtividade.Appearance.Header.Font = new Font("Courier New", 8.25F);
            xtraPageDescricaoAtividade.Appearance.Header.Options.UseFont = true;
            xtraPageDescricaoAtividade.Controls.Add(txtEditorAtividade);
            xtraPageDescricaoAtividade.Name = "xtraPageDescricaoAtividade";
            xtraPageDescricaoAtividade.Size = new Size(862, 503);
            xtraPageDescricaoAtividade.Text = "Descrição da atividade";
            // 
            // txtEditorAtividade
            // 
            txtEditorAtividade.Location = new Point(10, 10);
            txtEditorAtividade.Margin = new Padding(10);
            txtEditorAtividade.Name = "txtEditorAtividade";
            txtEditorAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            txtEditorAtividade.ReadOnly = true;
            txtEditorAtividade.Size = new Size(842, 488);
            txtEditorAtividade.TabIndex = 19;
            // 
            // FormVisualizaAtividadeExecucao
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 564);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("FormVisualizaAtividadeExecucao.IconOptions.LargeImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVisualizaAtividadeExecucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualização de andamento da atividade";
            Load += FormVisualizaAtividadeExecucao_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xtraTabControlAtividadesExecucao).EndInit();
            xtraTabControlAtividadesExecucao.ResumeLayout(false);
            xtraTabInfoAtividade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupHistoricoExecucao).EndInit();
            groupHistoricoExecucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridHistoricoExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)execucaoDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupInfoAtividade).EndInit();
            groupInfoAtividade.ResumeLayout(false);
            groupInfoAtividade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtNomeProjeto.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataCriacaoAtividade.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).EndInit();
            xtraPageDescricaoAtividade.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlAtividadesExecucao;
        private DevExpress.XtraTab.XtraTabPage xtraTabInfoAtividade;
        private DevExpress.XtraTab.XtraTabPage xtraPageDescricaoAtividade;
        private DevExpress.XtraEditors.GroupControl groupInfoAtividade;
        private DevExpress.XtraEditors.LabelControl lblDataCriacaoAtividade;
        private DevExpress.XtraEditors.DateTimeOffsetEdit DataCriacaoAtividade;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LabelControl lblNomeAtividade;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.GroupControl groupHistoricoExecucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.TextEdit txtNomeProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource execucaoDTOBindingSource;
        private DevExpress.XtraRichEdit.RichEditControl txtEditorAtividade;
        private DevExpress.XtraGrid.GridControl dataGridHistoricoExecucao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHistoricoExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFimExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicioExecucao;
    }
}