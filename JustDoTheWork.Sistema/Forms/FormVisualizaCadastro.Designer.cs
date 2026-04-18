namespace JustDoTheWork.Sistema.Forms
{
    partial class FormVisualizaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizaCadastro));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tabControlVisualizaAtividade = new DevExpress.XtraTab.XtraTabControl();
            this.tabControlInfoAtividade = new DevExpress.XtraTab.XtraTabPage();
            this.txtEditorAtividade = new DevExpress.XtraRichEdit.RichEditControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnEditaTextoAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.lblDataFinalizacao = new DevExpress.XtraEditors.LabelControl();
            this.DataFinalizacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.DataCriacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.comboBoxStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxProjeto = new DevExpress.XtraEditors.LookUpEdit();
            this.lblProjeto = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            this.tabControlHistoricoExecucao = new DevExpress.XtraTab.XtraTabPage();
            this.dataGridHistoricoExecucao = new DevExpress.XtraGrid.GridControl();
            this.execucaoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridHistoricoExecucao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAtividadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFimExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInicioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnAvancar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlVisualizaAtividade)).BeginInit();
            this.tabControlVisualizaAtividade.SuspendLayout();
            this.tabControlInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFinalizacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).BeginInit();
            this.tabControlHistoricoExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoricoExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.execucaoDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoricoExecucao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.tabControlVisualizaAtividade);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1254, 605);
            this.panelControl1.TabIndex = 0;
            // 
            // tabControlVisualizaAtividade
            // 
            this.tabControlVisualizaAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlVisualizaAtividade.Location = new System.Drawing.Point(5, 5);
            this.tabControlVisualizaAtividade.Name = "tabControlVisualizaAtividade";
            this.tabControlVisualizaAtividade.SelectedTabPage = this.tabControlInfoAtividade;
            this.tabControlVisualizaAtividade.Size = new System.Drawing.Size(1244, 595);
            this.tabControlVisualizaAtividade.TabIndex = 2;
            this.tabControlVisualizaAtividade.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabControlInfoAtividade,
            this.tabControlHistoricoExecucao});
            // 
            // tabControlInfoAtividade
            // 
            this.tabControlInfoAtividade.Controls.Add(this.txtEditorAtividade);
            this.tabControlInfoAtividade.Controls.Add(this.groupControl1);
            this.tabControlInfoAtividade.Name = "tabControlInfoAtividade";
            this.tabControlInfoAtividade.Size = new System.Drawing.Size(1242, 564);
            this.tabControlInfoAtividade.Text = "Dados Atividade";
            // 
            // txtEditorAtividade
            // 
            this.txtEditorAtividade.Location = new System.Drawing.Point(4, 173);
            this.txtEditorAtividade.Margin = new System.Windows.Forms.Padding(10);
            this.txtEditorAtividade.Name = "txtEditorAtividade";
            this.txtEditorAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            this.txtEditorAtividade.ReadOnly = true;
            this.txtEditorAtividade.Size = new System.Drawing.Size(1235, 391);
            this.txtEditorAtividade.TabIndex = 18;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnEditaTextoAtividade);
            this.groupControl1.Controls.Add(this.lblDataFinalizacao);
            this.groupControl1.Controls.Add(this.DataFinalizacao);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.DataCriacao);
            this.groupControl1.Controls.Add(this.comboBoxStatus);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.comboBoxProjeto);
            this.groupControl1.Controls.Add(this.lblProjeto);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtNomeAtividade);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1236, 157);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Dados da atividade";
            // 
            // btnEditaTextoAtividade
            // 
            this.btnEditaTextoAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditaTextoAtividade.Appearance.Options.UseFont = true;
            this.btnEditaTextoAtividade.Location = new System.Drawing.Point(1045, 124);
            this.btnEditaTextoAtividade.Margin = new System.Windows.Forms.Padding(8);
            this.btnEditaTextoAtividade.Name = "btnEditaTextoAtividade";
            this.btnEditaTextoAtividade.Size = new System.Drawing.Size(181, 23);
            this.btnEditaTextoAtividade.TabIndex = 3;
            this.btnEditaTextoAtividade.Text = "Editar Texto Atividade";
            this.btnEditaTextoAtividade.Click += new System.EventHandler(this.btnEditaTextoAtividade_Click);
            // 
            // lblDataFinalizacao
            // 
            this.lblDataFinalizacao.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinalizacao.Appearance.Options.UseFont = true;
            this.lblDataFinalizacao.Location = new System.Drawing.Point(443, 80);
            this.lblDataFinalizacao.Margin = new System.Windows.Forms.Padding(10);
            this.lblDataFinalizacao.Name = "lblDataFinalizacao";
            this.lblDataFinalizacao.Size = new System.Drawing.Size(190, 18);
            this.lblDataFinalizacao.TabIndex = 17;
            this.lblDataFinalizacao.Text = "Data de Finalização";
            // 
            // DataFinalizacao
            // 
            this.DataFinalizacao.EditValue = null;
            this.DataFinalizacao.Enabled = false;
            this.DataFinalizacao.Location = new System.Drawing.Point(646, 76);
            this.DataFinalizacao.Name = "DataFinalizacao";
            this.DataFinalizacao.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F);
            this.DataFinalizacao.Properties.Appearance.Options.UseFont = true;
            this.DataFinalizacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataFinalizacao.Size = new System.Drawing.Size(213, 32);
            this.DataFinalizacao.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(483, 42);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 18);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Data de Criação";
            // 
            // DataCriacao
            // 
            this.DataCriacao.EditValue = null;
            this.DataCriacao.Enabled = false;
            this.DataCriacao.Location = new System.Drawing.Point(646, 39);
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F);
            this.DataCriacao.Properties.Appearance.Options.UseFont = true;
            this.DataCriacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataCriacao.Size = new System.Drawing.Size(213, 32);
            this.DataCriacao.TabIndex = 14;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.Location = new System.Drawing.Point(95, 114);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.Properties.Appearance.Options.UseFont = true;
            this.comboBoxStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxStatus.Properties.NullText = "";
            this.comboBoxStatus.Size = new System.Drawing.Size(312, 32);
            this.comboBoxStatus.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 120);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Status";
            // 
            // comboBoxProjeto
            // 
            this.comboBoxProjeto.Location = new System.Drawing.Point(105, 75);
            this.comboBoxProjeto.Name = "comboBoxProjeto";
            this.comboBoxProjeto.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProjeto.Properties.Appearance.Options.UseFont = true;
            this.comboBoxProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxProjeto.Properties.NullText = "";
            this.comboBoxProjeto.Size = new System.Drawing.Size(302, 32);
            this.comboBoxProjeto.TabIndex = 11;
            // 
            // lblProjeto
            // 
            this.lblProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Appearance.Options.UseFont = true;
            this.lblProjeto.Location = new System.Drawing.Point(12, 81);
            this.lblProjeto.Margin = new System.Windows.Forms.Padding(20);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(70, 18);
            this.lblProjeto.TabIndex = 10;
            this.lblProjeto.Text = "Projeto";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nome";
            // 
            // txtNomeAtividade
            // 
            this.txtNomeAtividade.Location = new System.Drawing.Point(65, 38);
            this.txtNomeAtividade.Name = "txtNomeAtividade";
            this.txtNomeAtividade.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            this.txtNomeAtividade.Properties.MaxLength = 50;
            this.txtNomeAtividade.Size = new System.Drawing.Size(342, 32);
            this.txtNomeAtividade.TabIndex = 0;
            // 
            // tabControlHistoricoExecucao
            // 
            this.tabControlHistoricoExecucao.Controls.Add(this.dataGridHistoricoExecucao);
            this.tabControlHistoricoExecucao.Name = "tabControlHistoricoExecucao";
            this.tabControlHistoricoExecucao.Size = new System.Drawing.Size(1242, 564);
            this.tabControlHistoricoExecucao.Text = "Histórico de execução";
            // 
            // dataGridHistoricoExecucao
            // 
            this.dataGridHistoricoExecucao.DataSource = this.execucaoDTOBindingSource;
            this.dataGridHistoricoExecucao.Location = new System.Drawing.Point(10, 10);
            this.dataGridHistoricoExecucao.MainView = this.gridHistoricoExecucao;
            this.dataGridHistoricoExecucao.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridHistoricoExecucao.Name = "dataGridHistoricoExecucao";
            this.dataGridHistoricoExecucao.Size = new System.Drawing.Size(1222, 544);
            this.dataGridHistoricoExecucao.TabIndex = 2;
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
            this.colDataFimExecucao.UnboundDataType = typeof(System.DateTime);
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
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.btnAvancar);
            this.panelControl2.Controls.Add(this.btnExcluir);
            this.panelControl2.Controls.Add(this.btnFechar);
            this.panelControl2.Controls.Add(this.btnSalvar);
            this.panelControl2.Location = new System.Drawing.Point(12, 633);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1254, 43);
            this.panelControl2.TabIndex = 1;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.Appearance.Options.UseFont = true;
            this.btnAvancar.Location = new System.Drawing.Point(283, 10);
            this.btnAvancar.Margin = new System.Windows.Forms.Padding(8);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 2;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Appearance.Options.UseFont = true;
            this.btnExcluir.Location = new System.Drawing.Point(192, 10);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Appearance.Options.UseFont = true;
            this.btnFechar.Location = new System.Drawing.Point(101, 10);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.Location = new System.Drawing.Point(10, 10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormVisualizaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormVisualizaCadastro.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisualizaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualização da atividade";
            this.Load += new System.EventHandler(this.FormVisualizaCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlVisualizaAtividade)).EndInit();
            this.tabControlVisualizaAtividade.ResumeLayout(false);
            this.tabControlInfoAtividade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFinalizacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).EndInit();
            this.tabControlHistoricoExecucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoricoExecucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.execucaoDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoricoExecucao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.LookUpEdit comboBoxProjeto;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LookUpEdit comboBoxStatus;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateTimeOffsetEdit DataCriacao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblDataFinalizacao;
        private DevExpress.XtraEditors.DateTimeOffsetEdit DataFinalizacao;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnAvancar;
        private DevExpress.XtraTab.XtraTabControl tabControlVisualizaAtividade;
        private DevExpress.XtraTab.XtraTabPage tabControlInfoAtividade;
        private DevExpress.XtraTab.XtraTabPage tabControlHistoricoExecucao;
        private DevExpress.XtraEditors.SimpleButton btnEditaTextoAtividade;
        private System.Windows.Forms.BindingSource execucaoDTOBindingSource;
        private DevExpress.XtraRichEdit.RichEditControl txtEditorAtividade;
        private DevExpress.XtraGrid.GridControl dataGridHistoricoExecucao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHistoricoExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFimExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicioExecucao;
    }
}