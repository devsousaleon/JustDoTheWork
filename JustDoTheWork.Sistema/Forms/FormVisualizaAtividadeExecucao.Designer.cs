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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizaAtividadeExecucao));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControlAtividadesExecucao = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabInfoAtividade = new DevExpress.XtraTab.XtraTabPage();
            this.groupHistoricoExecucao = new DevExpress.XtraEditors.GroupControl();
            this.dataGridHistoricoExecucao = new DevExpress.XtraGrid.GridControl();
            this.execucaoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridHistoricoExecucao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAtividadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFimExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInicioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupInfoAtividade = new DevExpress.XtraEditors.GroupControl();
            this.txtNomeProjeto = new DevExpress.XtraEditors.TextEdit();
            this.lblDataCriacaoAtividade = new DevExpress.XtraEditors.LabelControl();
            this.DataCriacaoAtividade = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.lblProjeto = new DevExpress.XtraEditors.LabelControl();
            this.lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            this.xtraPageDescricaoAtividade = new DevExpress.XtraTab.XtraTabPage();
            this.txtEditorAtividade = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlAtividadesExecucao)).BeginInit();
            this.xtraTabControlAtividadesExecucao.SuspendLayout();
            this.xtraTabInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupHistoricoExecucao)).BeginInit();
            this.groupHistoricoExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoricoExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.execucaoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoricoExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfoAtividade)).BeginInit();
            this.groupInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacaoAtividade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).BeginInit();
            this.xtraPageDescricaoAtividade.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xtraTabControlAtividadesExecucao);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(874, 544);
            this.panelControl1.TabIndex = 0;
            // 
            // xtraTabControlAtividadesExecucao
            // 
            this.xtraTabControlAtividadesExecucao.Location = new System.Drawing.Point(5, 5);
            this.xtraTabControlAtividadesExecucao.Name = "xtraTabControlAtividadesExecucao";
            this.xtraTabControlAtividadesExecucao.SelectedTabPage = this.xtraTabInfoAtividade;
            this.xtraTabControlAtividadesExecucao.Size = new System.Drawing.Size(864, 534);
            this.xtraTabControlAtividadesExecucao.TabIndex = 0;
            this.xtraTabControlAtividadesExecucao.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabInfoAtividade,
            this.xtraPageDescricaoAtividade});
            // 
            // xtraTabInfoAtividade
            // 
            this.xtraTabInfoAtividade.Appearance.Header.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabInfoAtividade.Appearance.Header.Options.UseFont = true;
            this.xtraTabInfoAtividade.Controls.Add(this.groupHistoricoExecucao);
            this.xtraTabInfoAtividade.Controls.Add(this.groupInfoAtividade);
            this.xtraTabInfoAtividade.Name = "xtraTabInfoAtividade";
            this.xtraTabInfoAtividade.Size = new System.Drawing.Size(862, 503);
            this.xtraTabInfoAtividade.Text = "Detalhamento da atividade";
            // 
            // groupHistoricoExecucao
            // 
            this.groupHistoricoExecucao.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupHistoricoExecucao.AppearanceCaption.Options.UseFont = true;
            this.groupHistoricoExecucao.Controls.Add(this.dataGridHistoricoExecucao);
            this.groupHistoricoExecucao.Location = new System.Drawing.Point(10, 187);
            this.groupHistoricoExecucao.Margin = new System.Windows.Forms.Padding(10);
            this.groupHistoricoExecucao.Name = "groupHistoricoExecucao";
            this.groupHistoricoExecucao.Size = new System.Drawing.Size(842, 312);
            this.groupHistoricoExecucao.TabIndex = 1;
            this.groupHistoricoExecucao.Text = "Histórico de execuções";
            // 
            // dataGridHistoricoExecucao
            // 
            this.dataGridHistoricoExecucao.DataSource = this.execucaoDTOBindingSource;
            this.dataGridHistoricoExecucao.Location = new System.Drawing.Point(12, 39);
            this.dataGridHistoricoExecucao.MainView = this.gridHistoricoExecucao;
            this.dataGridHistoricoExecucao.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridHistoricoExecucao.Name = "dataGridHistoricoExecucao";
            this.dataGridHistoricoExecucao.Size = new System.Drawing.Size(818, 261);
            this.dataGridHistoricoExecucao.TabIndex = 1;
            this.dataGridHistoricoExecucao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridHistoricoExecucao});
            // 
            // execucaoDTOBindingSource
            // 
            this.execucaoDTOBindingSource.DataSource = typeof(JustDoTheWork.DTO.ExecucaoDTO);
            // 
            // gridHistoricoExecucao
            // 
            this.gridHistoricoExecucao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAtividadeId,
            this.colDataFimExecucao,
            this.colDataInicioExecucao});
            this.gridHistoricoExecucao.GridControl = this.dataGridHistoricoExecucao;
            this.gridHistoricoExecucao.Name = "gridHistoricoExecucao";
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
            // colDataFimExecucao
            // 
            this.colDataFimExecucao.FieldName = "DataFimExecucao";
            this.colDataFimExecucao.Name = "colDataFimExecucao";
            this.colDataFimExecucao.OptionsColumn.AllowEdit = false;
            this.colDataFimExecucao.OptionsColumn.AllowMove = false;
            this.colDataFimExecucao.OptionsColumn.AllowSize = false;
            this.colDataFimExecucao.OptionsColumn.ReadOnly = true;
            this.colDataFimExecucao.Visible = true;
            this.colDataFimExecucao.VisibleIndex = 2;
            // 
            // colDataInicioExecucao
            // 
            this.colDataInicioExecucao.FieldName = "DataInicioExecucao";
            this.colDataInicioExecucao.Name = "colDataInicioExecucao";
            this.colDataInicioExecucao.OptionsColumn.AllowEdit = false;
            this.colDataInicioExecucao.OptionsColumn.AllowMove = false;
            this.colDataInicioExecucao.OptionsColumn.AllowSize = false;
            this.colDataInicioExecucao.OptionsColumn.ReadOnly = true;
            this.colDataInicioExecucao.Visible = true;
            this.colDataInicioExecucao.VisibleIndex = 1;
            // 
            // groupInfoAtividade
            // 
            this.groupInfoAtividade.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfoAtividade.AppearanceCaption.Options.UseFont = true;
            this.groupInfoAtividade.Controls.Add(this.txtNomeProjeto);
            this.groupInfoAtividade.Controls.Add(this.lblDataCriacaoAtividade);
            this.groupInfoAtividade.Controls.Add(this.DataCriacaoAtividade);
            this.groupInfoAtividade.Controls.Add(this.lblProjeto);
            this.groupInfoAtividade.Controls.Add(this.lblNomeAtividade);
            this.groupInfoAtividade.Controls.Add(this.txtNomeAtividade);
            this.groupInfoAtividade.Location = new System.Drawing.Point(10, 10);
            this.groupInfoAtividade.Margin = new System.Windows.Forms.Padding(10);
            this.groupInfoAtividade.Name = "groupInfoAtividade";
            this.groupInfoAtividade.Size = new System.Drawing.Size(842, 164);
            this.groupInfoAtividade.TabIndex = 0;
            this.groupInfoAtividade.Text = "Informações";
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Enabled = false;
            this.txtNomeProjeto.Location = new System.Drawing.Point(105, 81);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProjeto.Properties.Appearance.Options.UseFont = true;
            this.txtNomeProjeto.Size = new System.Drawing.Size(302, 32);
            this.txtNomeProjeto.TabIndex = 22;
            // 
            // lblDataCriacaoAtividade
            // 
            this.lblDataCriacaoAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCriacaoAtividade.Appearance.Options.UseFont = true;
            this.lblDataCriacaoAtividade.Location = new System.Drawing.Point(420, 43);
            this.lblDataCriacaoAtividade.Margin = new System.Windows.Forms.Padding(10);
            this.lblDataCriacaoAtividade.Name = "lblDataCriacaoAtividade";
            this.lblDataCriacaoAtividade.Size = new System.Drawing.Size(150, 18);
            this.lblDataCriacaoAtividade.TabIndex = 21;
            this.lblDataCriacaoAtividade.Text = "Data de Criação";
            // 
            // DataCriacaoAtividade
            // 
            this.DataCriacaoAtividade.EditValue = null;
            this.DataCriacaoAtividade.Enabled = false;
            this.DataCriacaoAtividade.Location = new System.Drawing.Point(583, 40);
            this.DataCriacaoAtividade.Name = "DataCriacaoAtividade";
            this.DataCriacaoAtividade.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F);
            this.DataCriacaoAtividade.Properties.Appearance.Options.UseFont = true;
            this.DataCriacaoAtividade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataCriacaoAtividade.Size = new System.Drawing.Size(254, 32);
            this.DataCriacaoAtividade.TabIndex = 20;
            // 
            // lblProjeto
            // 
            this.lblProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Appearance.Options.UseFont = true;
            this.lblProjeto.Location = new System.Drawing.Point(12, 87);
            this.lblProjeto.Margin = new System.Windows.Forms.Padding(20);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(70, 18);
            this.lblProjeto.TabIndex = 18;
            this.lblProjeto.Text = "Projeto";
            // 
            // lblNomeAtividade
            // 
            this.lblNomeAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAtividade.Appearance.Options.UseFont = true;
            this.lblNomeAtividade.Location = new System.Drawing.Point(12, 43);
            this.lblNomeAtividade.Margin = new System.Windows.Forms.Padding(10);
            this.lblNomeAtividade.Name = "lblNomeAtividade";
            this.lblNomeAtividade.Size = new System.Drawing.Size(40, 18);
            this.lblNomeAtividade.TabIndex = 17;
            this.lblNomeAtividade.Text = "Nome";
            // 
            // txtNomeAtividade
            // 
            this.txtNomeAtividade.Enabled = false;
            this.txtNomeAtividade.Location = new System.Drawing.Point(65, 40);
            this.txtNomeAtividade.Name = "txtNomeAtividade";
            this.txtNomeAtividade.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            this.txtNomeAtividade.Size = new System.Drawing.Size(342, 32);
            this.txtNomeAtividade.TabIndex = 16;
            // 
            // xtraPageDescricaoAtividade
            // 
            this.xtraPageDescricaoAtividade.Appearance.Header.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.xtraPageDescricaoAtividade.Appearance.Header.Options.UseFont = true;
            this.xtraPageDescricaoAtividade.Controls.Add(this.txtEditorAtividade);
            this.xtraPageDescricaoAtividade.Name = "xtraPageDescricaoAtividade";
            this.xtraPageDescricaoAtividade.Size = new System.Drawing.Size(862, 503);
            this.xtraPageDescricaoAtividade.Text = "Descrição da atividade";
            // 
            // txtEditorAtividade
            // 
            this.txtEditorAtividade.Location = new System.Drawing.Point(10, 10);
            this.txtEditorAtividade.Margin = new System.Windows.Forms.Padding(10);
            this.txtEditorAtividade.Name = "txtEditorAtividade";
            this.txtEditorAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            this.txtEditorAtividade.ReadOnly = true;
            this.txtEditorAtividade.Size = new System.Drawing.Size(842, 488);
            this.txtEditorAtividade.TabIndex = 19;
            // 
            // FormVisualizaAtividadeExecucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 568);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormVisualizaAtividadeExecucao.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisualizaAtividadeExecucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualização de andamento da atividade";
            this.Load += new System.EventHandler(this.FormVisualizaAtividadeExecucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlAtividadesExecucao)).EndInit();
            this.xtraTabControlAtividadesExecucao.ResumeLayout(false);
            this.xtraTabInfoAtividade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupHistoricoExecucao)).EndInit();
            this.groupHistoricoExecucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoricoExecucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.execucaoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoricoExecucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInfoAtividade)).EndInit();
            this.groupInfoAtividade.ResumeLayout(false);
            this.groupInfoAtividade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacaoAtividade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).EndInit();
            this.xtraPageDescricaoAtividade.ResumeLayout(false);
            this.ResumeLayout(false);

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