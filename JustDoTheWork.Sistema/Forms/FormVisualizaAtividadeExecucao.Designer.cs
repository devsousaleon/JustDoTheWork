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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizaAtividadeExecucao));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControlAtividadesExecucao = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabInfoAtividade = new DevExpress.XtraTab.XtraTabPage();
            this.groupHistoricoExecucao = new DevExpress.XtraEditors.GroupControl();
            this.dataGridHistoricoExecucao = new System.Windows.Forms.DataGridView();
            this.atividadeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioExecucaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFimExecucaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execucaoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupInfoAtividade = new DevExpress.XtraEditors.GroupControl();
            this.txtNomeProjeto = new DevExpress.XtraEditors.TextEdit();
            this.lblDataCriacaoAtividade = new DevExpress.XtraEditors.LabelControl();
            this.DataCriacaoAtividade = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.lblProjeto = new DevExpress.XtraEditors.LabelControl();
            this.lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            this.xtraPageDescricaoAtividade = new DevExpress.XtraTab.XtraTabPage();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlAtividadesExecucao)).BeginInit();
            this.xtraTabControlAtividadesExecucao.SuspendLayout();
            this.xtraTabInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupHistoricoExecucao)).BeginInit();
            this.groupHistoricoExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoricoExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.execucaoDTOBindingSource)).BeginInit();
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
            this.xtraTabInfoAtividade.Size = new System.Drawing.Size(862, 508);
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
            this.dataGridHistoricoExecucao.AllowUserToAddRows = false;
            this.dataGridHistoricoExecucao.AllowUserToDeleteRows = false;
            this.dataGridHistoricoExecucao.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridHistoricoExecucao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridHistoricoExecucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistoricoExecucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.atividadeIdDataGridViewTextBoxColumn,
            this.dataInicioExecucaoDataGridViewTextBoxColumn,
            this.dataFimExecucaoDataGridViewTextBoxColumn});
            this.dataGridHistoricoExecucao.DataSource = this.execucaoDTOBindingSource;
            this.dataGridHistoricoExecucao.Location = new System.Drawing.Point(12, 33);
            this.dataGridHistoricoExecucao.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridHistoricoExecucao.Name = "dataGridHistoricoExecucao";
            this.dataGridHistoricoExecucao.ReadOnly = true;
            this.dataGridHistoricoExecucao.Size = new System.Drawing.Size(818, 267);
            this.dataGridHistoricoExecucao.TabIndex = 0;
            // 
            // atividadeIdDataGridViewTextBoxColumn
            // 
            this.atividadeIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.atividadeIdDataGridViewTextBoxColumn.DataPropertyName = "AtividadeId";
            this.atividadeIdDataGridViewTextBoxColumn.HeaderText = "AtividadeId";
            this.atividadeIdDataGridViewTextBoxColumn.Name = "atividadeIdDataGridViewTextBoxColumn";
            this.atividadeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.atividadeIdDataGridViewTextBoxColumn.Width = 121;
            // 
            // dataInicioExecucaoDataGridViewTextBoxColumn
            // 
            this.dataInicioExecucaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataInicioExecucaoDataGridViewTextBoxColumn.DataPropertyName = "DataInicioExecucao";
            this.dataInicioExecucaoDataGridViewTextBoxColumn.HeaderText = "Data Inicio da Execução";
            this.dataInicioExecucaoDataGridViewTextBoxColumn.Name = "dataInicioExecucaoDataGridViewTextBoxColumn";
            this.dataInicioExecucaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFimExecucaoDataGridViewTextBoxColumn
            // 
            this.dataFimExecucaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataFimExecucaoDataGridViewTextBoxColumn.DataPropertyName = "DataFimExecucao";
            this.dataFimExecucaoDataGridViewTextBoxColumn.HeaderText = "Data Fim da Execução";
            this.dataFimExecucaoDataGridViewTextBoxColumn.Name = "dataFimExecucaoDataGridViewTextBoxColumn";
            this.dataFimExecucaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // execucaoDTOBindingSource
            // 
            this.execucaoDTOBindingSource.DataSource = typeof(JustDoTheWork.DTO.ExecucaoDTO);
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
            this.txtNomeProjeto.Size = new System.Drawing.Size(302, 24);
            this.txtNomeProjeto.TabIndex = 22;
            // 
            // lblDataCriacaoAtividade
            // 
            this.lblDataCriacaoAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCriacaoAtividade.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblDataCriacaoAtividade.Appearance.Options.UseFont = true;
            this.lblDataCriacaoAtividade.Appearance.Options.UseForeColor = true;
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
            this.DataCriacaoAtividade.Size = new System.Drawing.Size(254, 24);
            this.DataCriacaoAtividade.TabIndex = 20;
            // 
            // lblProjeto
            // 
            this.lblProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblProjeto.Appearance.Options.UseFont = true;
            this.lblProjeto.Appearance.Options.UseForeColor = true;
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
            this.lblNomeAtividade.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblNomeAtividade.Appearance.Options.UseFont = true;
            this.lblNomeAtividade.Appearance.Options.UseForeColor = true;
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
            this.txtNomeAtividade.Size = new System.Drawing.Size(342, 24);
            this.txtNomeAtividade.TabIndex = 16;
            // 
            // xtraPageDescricaoAtividade
            // 
            this.xtraPageDescricaoAtividade.Appearance.Header.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.xtraPageDescricaoAtividade.Appearance.Header.Options.UseFont = true;
            this.xtraPageDescricaoAtividade.Controls.Add(this.txtDescricao);
            this.xtraPageDescricaoAtividade.Name = "xtraPageDescricaoAtividade";
            this.xtraPageDescricaoAtividade.Size = new System.Drawing.Size(862, 508);
            this.xtraPageDescricaoAtividade.Text = "Descrição da atividade";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricao.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtDescricao.Location = new System.Drawing.Point(10, 10);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(842, 489);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "";
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
        private System.Windows.Forms.DataGridView dataGridHistoricoExecucao;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.TextEdit txtNomeProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource execucaoDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividadeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioExecucaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimExecucaoDataGridViewTextBoxColumn;
    }
}