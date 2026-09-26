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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizaCadastro));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            tabControlVisualizaAtividade = new DevExpress.XtraTab.XtraTabControl();
            tabControlInfoAtividade = new DevExpress.XtraTab.XtraTabPage();
            txtEditorAtividade = new DevExpress.XtraRichEdit.RichEditControl();
            bindingSourceAtividade = new BindingSource(components);
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnEditaTextoAtividade = new DevExpress.XtraEditors.SimpleButton();
            lblDataFinalizacao = new DevExpress.XtraEditors.LabelControl();
            dataFinalizacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            lblDataCriacao = new DevExpress.XtraEditors.LabelControl();
            dataCriacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            comboStatusPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            comboProjetoPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            lblNome = new DevExpress.XtraEditors.LabelControl();
            txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            tabControlHistoricoExecucao = new DevExpress.XtraTab.XtraTabPage();
            dataGridHistoricoExecucao = new DevExpress.XtraGrid.GridControl();
            execucaoDTOBindingSource = new BindingSource(components);
            gridHistoricoExecucao = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDataFimExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemDateTimeOffsetEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            colDataInicioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemDateTimeOffsetEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnCancelarAtividade = new DevExpress.XtraEditors.SimpleButton();
            btnAvancar = new DevExpress.XtraEditors.SimpleButton();
            btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            btnFechar = new DevExpress.XtraEditors.SimpleButton();
            btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControlVisualizaAtividade).BeginInit();
            tabControlVisualizaAtividade.SuspendLayout();
            tabControlInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAtividade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFinalizacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).BeginInit();
            tabControlHistoricoExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHistoricoExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)execucaoDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateTimeOffsetEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateTimeOffsetEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControl1.Controls.Add(tabControlVisualizaAtividade);
            panelControl1.Location = new Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1254, 601);
            panelControl1.TabIndex = 0;
            // 
            // tabControlVisualizaAtividade
            // 
            tabControlVisualizaAtividade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlVisualizaAtividade.Location = new Point(5, 5);
            tabControlVisualizaAtividade.Name = "tabControlVisualizaAtividade";
            tabControlVisualizaAtividade.SelectedTabPage = tabControlInfoAtividade;
            tabControlVisualizaAtividade.Size = new Size(1244, 591);
            tabControlVisualizaAtividade.TabIndex = 2;
            tabControlVisualizaAtividade.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabControlInfoAtividade, tabControlHistoricoExecucao });
            // 
            // tabControlInfoAtividade
            // 
            tabControlInfoAtividade.Controls.Add(txtEditorAtividade);
            tabControlInfoAtividade.Controls.Add(groupControl1);
            tabControlInfoAtividade.Name = "tabControlInfoAtividade";
            tabControlInfoAtividade.Size = new Size(1242, 560);
            tabControlInfoAtividade.Text = "Dados Atividade";
            // 
            // txtEditorAtividade
            // 
            txtEditorAtividade.DataBindings.Add(new Binding("DocxBytes", bindingSourceAtividade, "Descricao", true));
            txtEditorAtividade.Location = new Point(4, 173);
            txtEditorAtividade.Margin = new Padding(10);
            txtEditorAtividade.Name = "txtEditorAtividade";
            txtEditorAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            txtEditorAtividade.ReadOnly = true;
            txtEditorAtividade.Size = new Size(1235, 391);
            txtEditorAtividade.TabIndex = 18;
            // 
            // bindingSourceAtividade
            // 
            bindingSourceAtividade.DataSource = typeof(DTO.AtividadeDTO);
            // 
            // groupControl1
            // 
            groupControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupControl1.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(btnEditaTextoAtividade);
            groupControl1.Controls.Add(lblDataFinalizacao);
            groupControl1.Controls.Add(dataFinalizacao);
            groupControl1.Controls.Add(lblDataCriacao);
            groupControl1.Controls.Add(dataCriacao);
            groupControl1.Controls.Add(comboStatusPesquisa);
            groupControl1.Controls.Add(lblStatus);
            groupControl1.Controls.Add(comboProjetoPesquisa);
            groupControl1.Controls.Add(lblProjeto);
            groupControl1.Controls.Add(lblNome);
            groupControl1.Controls.Add(txtNomeAtividade);
            groupControl1.Location = new Point(3, 3);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1236, 157);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Dados da atividade";
            // 
            // btnEditaTextoAtividade
            // 
            btnEditaTextoAtividade.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditaTextoAtividade.Appearance.Options.UseFont = true;
            btnEditaTextoAtividade.Location = new Point(1045, 124);
            btnEditaTextoAtividade.Margin = new Padding(8);
            btnEditaTextoAtividade.Name = "btnEditaTextoAtividade";
            btnEditaTextoAtividade.Size = new Size(181, 23);
            btnEditaTextoAtividade.TabIndex = 5;
            btnEditaTextoAtividade.Text = "Editar Texto Atividade";
            btnEditaTextoAtividade.Click += btnEditaTextoAtividade_Click;
            // 
            // lblDataFinalizacao
            // 
            lblDataFinalizacao.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataFinalizacao.Appearance.Options.UseFont = true;
            lblDataFinalizacao.Location = new Point(443, 82);
            lblDataFinalizacao.Margin = new Padding(10);
            lblDataFinalizacao.Name = "lblDataFinalizacao";
            lblDataFinalizacao.Size = new Size(190, 18);
            lblDataFinalizacao.TabIndex = 17;
            lblDataFinalizacao.Text = "Data de Finalização";
            // 
            // dataFinalizacao
            // 
            dataFinalizacao.DataBindings.Add(new Binding("EditValue", bindingSourceAtividade, "DataFinalizacao", true));
            dataFinalizacao.EditValue = null;
            dataFinalizacao.Enabled = false;
            dataFinalizacao.EnterMoveNextControl = true;
            dataFinalizacao.Location = new Point(646, 76);
            dataFinalizacao.Name = "dataFinalizacao";
            dataFinalizacao.Properties.Appearance.Font = new Font("Courier New", 12F);
            dataFinalizacao.Properties.Appearance.Options.UseFont = true;
            dataFinalizacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dataFinalizacao.Size = new Size(213, 32);
            dataFinalizacao.TabIndex = 3;
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataCriacao.Appearance.Options.UseFont = true;
            lblDataCriacao.Location = new Point(483, 45);
            lblDataCriacao.Margin = new Padding(10);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(150, 18);
            lblDataCriacao.TabIndex = 15;
            lblDataCriacao.Text = "Data de Criação";
            // 
            // dataCriacao
            // 
            dataCriacao.DataBindings.Add(new Binding("EditValue", bindingSourceAtividade, "DataCriacao", true));
            dataCriacao.EditValue = null;
            dataCriacao.Enabled = false;
            dataCriacao.EnterMoveNextControl = true;
            dataCriacao.Location = new Point(646, 39);
            dataCriacao.Name = "dataCriacao";
            dataCriacao.Properties.Appearance.Font = new Font("Courier New", 12F);
            dataCriacao.Properties.Appearance.Options.UseFont = true;
            dataCriacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dataCriacao.Size = new Size(213, 32);
            dataCriacao.TabIndex = 1;
            // 
            // comboStatusPesquisa
            // 
            comboStatusPesquisa.DataBindings.Add(new Binding("EditValue", bindingSourceAtividade, "Status", true));
            comboStatusPesquisa.EditValue = "";
            comboStatusPesquisa.Enabled = false;
            comboStatusPesquisa.EnterMoveNextControl = true;
            comboStatusPesquisa.Location = new Point(105, 114);
            comboStatusPesquisa.Name = "comboStatusPesquisa";
            comboStatusPesquisa.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatusPesquisa.Properties.Appearance.Options.UseFont = true;
            comboStatusPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatusPesquisa.Properties.NullText = "";
            comboStatusPesquisa.Size = new Size(302, 32);
            comboStatusPesquisa.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Appearance.Options.UseFont = true;
            lblStatus.Location = new Point(12, 122);
            lblStatus.Margin = new Padding(20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 18);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            // 
            // comboProjetoPesquisa
            // 
            comboProjetoPesquisa.DataBindings.Add(new Binding("EditValue", bindingSourceAtividade, "ProjetoId", true));
            comboProjetoPesquisa.EnterMoveNextControl = true;
            comboProjetoPesquisa.Location = new Point(105, 75);
            comboProjetoPesquisa.Name = "comboProjetoPesquisa";
            comboProjetoPesquisa.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjetoPesquisa.Properties.Appearance.Options.UseFont = true;
            comboProjetoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboProjetoPesquisa.Properties.NullText = "";
            comboProjetoPesquisa.Size = new Size(302, 32);
            comboProjetoPesquisa.TabIndex = 2;
            // 
            // lblProjeto
            // 
            lblProjeto.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProjeto.Appearance.Options.UseFont = true;
            lblProjeto.Location = new Point(12, 82);
            lblProjeto.Margin = new Padding(20);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(70, 18);
            lblProjeto.TabIndex = 10;
            lblProjeto.Text = "Projeto";
            // 
            // lblNome
            // 
            lblNome.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Appearance.Options.UseFont = true;
            lblNome.Location = new Point(12, 46);
            lblNome.Margin = new Padding(10);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 18);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNomeAtividade
            // 
            txtNomeAtividade.DataBindings.Add(new Binding("EditValue", bindingSourceAtividade, "Nome", true));
            txtNomeAtividade.EnterMoveNextControl = true;
            txtNomeAtividade.Location = new Point(105, 38);
            txtNomeAtividade.Name = "txtNomeAtividade";
            txtNomeAtividade.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            txtNomeAtividade.Properties.MaxLength = 50;
            txtNomeAtividade.Size = new Size(302, 32);
            txtNomeAtividade.TabIndex = 0;
            // 
            // tabControlHistoricoExecucao
            // 
            tabControlHistoricoExecucao.Controls.Add(dataGridHistoricoExecucao);
            tabControlHistoricoExecucao.Name = "tabControlHistoricoExecucao";
            tabControlHistoricoExecucao.Size = new Size(1242, 560);
            tabControlHistoricoExecucao.Text = "Histórico de execução";
            // 
            // dataGridHistoricoExecucao
            // 
            dataGridHistoricoExecucao.DataSource = execucaoDTOBindingSource;
            dataGridHistoricoExecucao.Location = new Point(10, 10);
            dataGridHistoricoExecucao.MainView = gridHistoricoExecucao;
            dataGridHistoricoExecucao.Margin = new Padding(10);
            dataGridHistoricoExecucao.Name = "dataGridHistoricoExecucao";
            dataGridHistoricoExecucao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemDateTimeOffsetEdit1, repositoryItemDateTimeOffsetEdit2 });
            dataGridHistoricoExecucao.Size = new Size(1222, 544);
            dataGridHistoricoExecucao.TabIndex = 2;
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
            colDataFimExecucao.ColumnEdit = repositoryItemDateTimeOffsetEdit1;
            colDataFimExecucao.FieldName = "DataFimExecucao";
            colDataFimExecucao.Name = "colDataFimExecucao";
            colDataFimExecucao.OptionsColumn.AllowEdit = false;
            colDataFimExecucao.OptionsColumn.AllowMove = false;
            colDataFimExecucao.OptionsColumn.AllowSize = false;
            colDataFimExecucao.OptionsColumn.ReadOnly = true;
            colDataFimExecucao.UnboundDataType = typeof(DateTime);
            colDataFimExecucao.Visible = true;
            colDataFimExecucao.VisibleIndex = 2;
            // 
            // repositoryItemDateTimeOffsetEdit1
            // 
            repositoryItemDateTimeOffsetEdit1.AutoHeight = false;
            repositoryItemDateTimeOffsetEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateTimeOffsetEdit1.Name = "repositoryItemDateTimeOffsetEdit1";
            // 
            // colDataInicioExecucao
            // 
            colDataInicioExecucao.ColumnEdit = repositoryItemDateTimeOffsetEdit2;
            colDataInicioExecucao.FieldName = "DataInicioExecucao";
            colDataInicioExecucao.Name = "colDataInicioExecucao";
            colDataInicioExecucao.OptionsColumn.AllowEdit = false;
            colDataInicioExecucao.OptionsColumn.AllowMove = false;
            colDataInicioExecucao.OptionsColumn.AllowSize = false;
            colDataInicioExecucao.OptionsColumn.ReadOnly = true;
            colDataInicioExecucao.Visible = true;
            colDataInicioExecucao.VisibleIndex = 1;
            // 
            // repositoryItemDateTimeOffsetEdit2
            // 
            repositoryItemDateTimeOffsetEdit2.AutoHeight = false;
            repositoryItemDateTimeOffsetEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateTimeOffsetEdit2.Name = "repositoryItemDateTimeOffsetEdit2";
            // 
            // panelControl2
            // 
            panelControl2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControl2.Controls.Add(btnCancelarAtividade);
            panelControl2.Controls.Add(btnAvancar);
            panelControl2.Controls.Add(btnExcluir);
            panelControl2.Controls.Add(btnFechar);
            panelControl2.Controls.Add(btnSalvar);
            panelControl2.Location = new Point(12, 629);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1254, 43);
            panelControl2.TabIndex = 1;
            // 
            // btnCancelarAtividade
            // 
            btnCancelarAtividade.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarAtividade.Appearance.Options.UseFont = true;
            btnCancelarAtividade.Location = new Point(192, 10);
            btnCancelarAtividade.Margin = new Padding(8);
            btnCancelarAtividade.Name = "btnCancelarAtividade";
            btnCancelarAtividade.Size = new Size(75, 23);
            btnCancelarAtividade.TabIndex = 10;
            btnCancelarAtividade.Text = "Cancelar";
            btnCancelarAtividade.Visible = false;
            btnCancelarAtividade.Click += btnCancelarAtividade_Click;
            // 
            // btnAvancar
            // 
            btnAvancar.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancar.Appearance.Options.UseFont = true;
            btnAvancar.Location = new Point(283, 10);
            btnAvancar.Margin = new Padding(8);
            btnAvancar.Name = "btnAvancar";
            btnAvancar.Size = new Size(75, 23);
            btnAvancar.TabIndex = 9;
            btnAvancar.Text = "Avançar";
            btnAvancar.Click += btnAvancar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Appearance.Options.UseFont = true;
            btnExcluir.Location = new Point(192, 10);
            btnExcluir.Margin = new Padding(8);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Appearance.Options.UseFont = true;
            btnFechar.Location = new Point(101, 10);
            btnFechar.Margin = new Padding(8);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "Fechar";
            btnFechar.Click += btnFechar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Appearance.Options.UseFont = true;
            btnSalvar.Location = new Point(10, 10);
            btnSalvar.Margin = new Padding(8);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormVisualizaCadastro
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 684);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("FormVisualizaCadastro.IconOptions.LargeImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVisualizaCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualização da atividade";
            Load += FormVisualizaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabControlVisualizaAtividade).EndInit();
            tabControlVisualizaAtividade.ResumeLayout(false);
            tabControlInfoAtividade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceAtividade).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataFinalizacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).EndInit();
            tabControlHistoricoExecucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridHistoricoExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)execucaoDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateTimeOffsetEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateTimeOffsetEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblNome;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.LookUpEdit comboProjetoPesquisa;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LookUpEdit comboStatusPesquisa;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dataCriacao;
        private DevExpress.XtraEditors.LabelControl lblDataCriacao;
        private DevExpress.XtraEditors.LabelControl lblDataFinalizacao;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dataFinalizacao;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit2;
        private BindingSource bindingSourceAtividade;
        private DevExpress.XtraEditors.SimpleButton btnCancelarAtividade;
    }
}