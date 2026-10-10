namespace JustDoTheWork.Sistema.Forms
{
    partial class FormVisualizaAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizaAtividade));
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            tabControlVisualizaAtividade = new DevExpress.XtraTab.XtraTabControl();
            tabInfoAtividade = new DevExpress.XtraTab.XtraTabPage();
            richEditDescricaoAtividade = new DevExpress.XtraRichEdit.RichEditControl();
            bindingSourceAtividade = new BindingSource(components);
            groupInfoAtividade = new DevExpress.XtraEditors.GroupControl();
            btnEditarTextoAtividade = new DevExpress.XtraEditors.SimpleButton();
            lblDataFinalizacao = new DevExpress.XtraEditors.LabelControl();
            dataFinalizacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            lblDataCriacao = new DevExpress.XtraEditors.LabelControl();
            dataCriacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            comboStatus = new DevExpress.XtraEditors.LookUpEdit();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            comboProjeto = new DevExpress.XtraEditors.LookUpEdit();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            tabHistoricoExecucao = new DevExpress.XtraTab.XtraTabPage();
            gridControlHistoricoExecucao = new DevExpress.XtraGrid.GridControl();
            bindingSourceExecucao = new BindingSource(components);
            gridHistoricoExecucao = new DevExpress.XtraGrid.Views.Grid.GridView();
            colAtividadeId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDataFimExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryDataFimExecucao = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            colDataInicioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryDataInicioExecucao = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            panelAcoes = new DevExpress.XtraEditors.PanelControl();
            btnCancelarAtividade = new DevExpress.XtraEditors.SimpleButton();
            btnAvancarAtividade = new DevExpress.XtraEditors.SimpleButton();
            btnExcluirAtividade = new DevExpress.XtraEditors.SimpleButton();
            btnFecharCadastroAtividade = new DevExpress.XtraEditors.SimpleButton();
            btnSalvarCadastroAtividade = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControlVisualizaAtividade).BeginInit();
            tabControlVisualizaAtividade.SuspendLayout();
            tabInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAtividade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupInfoAtividade).BeginInit();
            groupInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFinalizacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboProjeto.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).BeginInit();
            tabHistoricoExecucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlHistoricoExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataFimExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataInicioExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).BeginInit();
            panelAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBackground.Controls.Add(tabControlVisualizaAtividade);
            panelBackground.Location = new Point(12, 12);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(1254, 601);
            panelBackground.TabIndex = 0;
            // 
            // tabControlVisualizaAtividade
            // 
            tabControlVisualizaAtividade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlVisualizaAtividade.Location = new Point(5, 5);
            tabControlVisualizaAtividade.Name = "tabControlVisualizaAtividade";
            tabControlVisualizaAtividade.SelectedTabPage = tabInfoAtividade;
            tabControlVisualizaAtividade.Size = new Size(1244, 591);
            tabControlVisualizaAtividade.TabIndex = 2;
            tabControlVisualizaAtividade.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabInfoAtividade, tabHistoricoExecucao });
            // 
            // tabInfoAtividade
            // 
            tabInfoAtividade.Controls.Add(richEditDescricaoAtividade);
            tabInfoAtividade.Controls.Add(groupInfoAtividade);
            tabInfoAtividade.Name = "tabInfoAtividade";
            tabInfoAtividade.Size = new Size(1242, 560);
            tabInfoAtividade.Text = "Dados Atividade";
            // 
            // richEditDescricaoAtividade
            // 
            richEditDescricaoAtividade.DataBindings.Add(new Binding("DocxBytes", bindingSourceAtividade, "Descricao", true));
            richEditDescricaoAtividade.Location = new Point(4, 173);
            richEditDescricaoAtividade.Margin = new Padding(10);
            richEditDescricaoAtividade.Name = "richEditDescricaoAtividade";
            richEditDescricaoAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            richEditDescricaoAtividade.ReadOnly = true;
            richEditDescricaoAtividade.Size = new Size(1235, 391);
            richEditDescricaoAtividade.TabIndex = 18;
            // 
            // bindingSourceAtividade
            // 
            bindingSourceAtividade.DataSource = typeof(DTO.AtividadeDTO);
            // 
            // groupInfoAtividade
            // 
            groupInfoAtividade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupInfoAtividade.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupInfoAtividade.AppearanceCaption.Options.UseFont = true;
            groupInfoAtividade.Controls.Add(btnEditarTextoAtividade);
            groupInfoAtividade.Controls.Add(lblDataFinalizacao);
            groupInfoAtividade.Controls.Add(dataFinalizacao);
            groupInfoAtividade.Controls.Add(lblDataCriacao);
            groupInfoAtividade.Controls.Add(dataCriacao);
            groupInfoAtividade.Controls.Add(comboStatus);
            groupInfoAtividade.Controls.Add(lblStatus);
            groupInfoAtividade.Controls.Add(comboProjeto);
            groupInfoAtividade.Controls.Add(lblProjeto);
            groupInfoAtividade.Controls.Add(lblNomeAtividade);
            groupInfoAtividade.Controls.Add(txtNomeAtividade);
            groupInfoAtividade.Location = new Point(3, 3);
            groupInfoAtividade.Name = "groupInfoAtividade";
            groupInfoAtividade.Size = new Size(1236, 157);
            groupInfoAtividade.TabIndex = 0;
            groupInfoAtividade.Text = "Dados da atividade";
            // 
            // btnEditarTextoAtividade
            // 
            btnEditarTextoAtividade.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarTextoAtividade.Appearance.Options.UseFont = true;
            btnEditarTextoAtividade.Location = new Point(1045, 124);
            btnEditarTextoAtividade.Margin = new Padding(8);
            btnEditarTextoAtividade.Name = "btnEditarTextoAtividade";
            btnEditarTextoAtividade.Size = new Size(181, 23);
            btnEditarTextoAtividade.TabIndex = 5;
            btnEditarTextoAtividade.Text = "Editar Texto Atividade";
            btnEditarTextoAtividade.Click += btnEditarTextoAtividade_Click;
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
            // comboStatus
            // 
            comboStatus.DataBindings.Add(new Binding("EditValue", bindingSourceAtividade, "Status", true));
            comboStatus.EditValue = "";
            comboStatus.Enabled = false;
            comboStatus.EnterMoveNextControl = true;
            comboStatus.Location = new Point(105, 114);
            comboStatus.Name = "comboStatus";
            comboStatus.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatus.Properties.Appearance.Options.UseFont = true;
            comboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatus.Properties.NullText = "";
            comboStatus.Size = new Size(302, 32);
            comboStatus.TabIndex = 4;
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
            // comboProjeto
            // 
            comboProjeto.DataBindings.Add(new Binding("EditValue", bindingSourceAtividade, "ProjetoId", true));
            comboProjeto.EnterMoveNextControl = true;
            comboProjeto.Location = new Point(105, 75);
            comboProjeto.Name = "comboProjeto";
            comboProjeto.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjeto.Properties.Appearance.Options.UseFont = true;
            comboProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboProjeto.Properties.NullText = "";
            comboProjeto.Size = new Size(302, 32);
            comboProjeto.TabIndex = 2;
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
            // lblNomeAtividade
            // 
            lblNomeAtividade.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeAtividade.Appearance.Options.UseFont = true;
            lblNomeAtividade.Location = new Point(12, 46);
            lblNomeAtividade.Margin = new Padding(10);
            lblNomeAtividade.Name = "lblNomeAtividade";
            lblNomeAtividade.Size = new Size(40, 18);
            lblNomeAtividade.TabIndex = 1;
            lblNomeAtividade.Text = "Nome";
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
            // tabHistoricoExecucao
            // 
            tabHistoricoExecucao.Controls.Add(gridControlHistoricoExecucao);
            tabHistoricoExecucao.Name = "tabHistoricoExecucao";
            tabHistoricoExecucao.Size = new Size(1242, 560);
            tabHistoricoExecucao.Text = "Histórico de execução";
            // 
            // gridControlHistoricoExecucao
            // 
            gridControlHistoricoExecucao.DataSource = bindingSourceExecucao;
            gridControlHistoricoExecucao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControlHistoricoExecucao.Location = new Point(10, 10);
            gridControlHistoricoExecucao.MainView = gridHistoricoExecucao;
            gridControlHistoricoExecucao.Margin = new Padding(10);
            gridControlHistoricoExecucao.Name = "gridControlHistoricoExecucao";
            gridControlHistoricoExecucao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryDataFimExecucao, repositoryDataInicioExecucao });
            gridControlHistoricoExecucao.Size = new Size(1222, 544);
            gridControlHistoricoExecucao.TabIndex = 2;
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
            // repositoryDataFimExecucao
            // 
            repositoryDataFimExecucao.AutoHeight = false;
            repositoryDataFimExecucao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryDataFimExecucao.Name = "repositoryDataFimExecucao";
            // 
            // colDataInicioExecucao
            // 
            colDataInicioExecucao.ColumnEdit = repositoryDataInicioExecucao;
            colDataInicioExecucao.FieldName = "DataInicioExecucao";
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
            // panelAcoes
            // 
            panelAcoes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelAcoes.Controls.Add(btnCancelarAtividade);
            panelAcoes.Controls.Add(btnAvancarAtividade);
            panelAcoes.Controls.Add(btnExcluirAtividade);
            panelAcoes.Controls.Add(btnFecharCadastroAtividade);
            panelAcoes.Controls.Add(btnSalvarCadastroAtividade);
            panelAcoes.Location = new Point(12, 629);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(1254, 43);
            panelAcoes.TabIndex = 1;
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
            // btnAvancarAtividade
            // 
            btnAvancarAtividade.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAvancarAtividade.Appearance.Options.UseFont = true;
            btnAvancarAtividade.Location = new Point(283, 10);
            btnAvancarAtividade.Margin = new Padding(8);
            btnAvancarAtividade.Name = "btnAvancarAtividade";
            btnAvancarAtividade.Size = new Size(75, 23);
            btnAvancarAtividade.TabIndex = 9;
            btnAvancarAtividade.Text = "Avançar";
            btnAvancarAtividade.Click += btnAvancarAtividade_Click;
            // 
            // btnExcluirAtividade
            // 
            btnExcluirAtividade.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluirAtividade.Appearance.Options.UseFont = true;
            btnExcluirAtividade.Location = new Point(192, 10);
            btnExcluirAtividade.Margin = new Padding(8);
            btnExcluirAtividade.Name = "btnExcluirAtividade";
            btnExcluirAtividade.Size = new Size(75, 23);
            btnExcluirAtividade.TabIndex = 8;
            btnExcluirAtividade.Text = "Excluir";
            btnExcluirAtividade.Click += btnExcluirAtividade_Click;
            // 
            // btnFecharCadastroAtividade
            // 
            btnFecharCadastroAtividade.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFecharCadastroAtividade.Appearance.Options.UseFont = true;
            btnFecharCadastroAtividade.Location = new Point(101, 10);
            btnFecharCadastroAtividade.Margin = new Padding(8);
            btnFecharCadastroAtividade.Name = "btnFecharCadastroAtividade";
            btnFecharCadastroAtividade.Size = new Size(75, 23);
            btnFecharCadastroAtividade.TabIndex = 7;
            btnFecharCadastroAtividade.Text = "Fechar";
            btnFecharCadastroAtividade.Click += btnFecharCadastroAtividade_Click;
            // 
            // btnSalvarCadastroAtividade
            // 
            btnSalvarCadastroAtividade.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarCadastroAtividade.Appearance.Options.UseFont = true;
            btnSalvarCadastroAtividade.Location = new Point(10, 10);
            btnSalvarCadastroAtividade.Margin = new Padding(8);
            btnSalvarCadastroAtividade.Name = "btnSalvarCadastroAtividade";
            btnSalvarCadastroAtividade.Size = new Size(75, 23);
            btnSalvarCadastroAtividade.TabIndex = 6;
            btnSalvarCadastroAtividade.Text = "Salvar";
            btnSalvarCadastroAtividade.Click += btnSalvarCadastroAtividade_Click;
            // 
            // FormVisualizaAtividade
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 684);
            Controls.Add(panelAcoes);
            Controls.Add(panelBackground);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("FormVisualizaAtividade.IconOptions.LargeImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVisualizaAtividade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualização da atividade";
            Load += FormVisualizaAtividade_Load;
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabControlVisualizaAtividade).EndInit();
            tabControlVisualizaAtividade.ResumeLayout(false);
            tabInfoAtividade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceAtividade).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupInfoAtividade).EndInit();
            groupInfoAtividade.ResumeLayout(false);
            groupInfoAtividade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataFinalizacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboProjeto.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).EndInit();
            tabHistoricoExecucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlHistoricoExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataFimExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataInicioExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).EndInit();
            panelAcoes.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraEditors.GroupControl groupInfoAtividade;
        private DevExpress.XtraEditors.LabelControl lblNomeAtividade;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.LookUpEdit comboProjeto;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LookUpEdit comboStatus;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dataCriacao;
        private DevExpress.XtraEditors.LabelControl lblDataCriacao;
        private DevExpress.XtraEditors.LabelControl lblDataFinalizacao;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dataFinalizacao;
        private DevExpress.XtraEditors.PanelControl panelAcoes;
        private DevExpress.XtraEditors.SimpleButton btnSalvarCadastroAtividade;
        private DevExpress.XtraEditors.SimpleButton btnFecharCadastroAtividade;
        private DevExpress.XtraEditors.SimpleButton btnExcluirAtividade;
        private DevExpress.XtraEditors.SimpleButton btnAvancarAtividade;
        private DevExpress.XtraTab.XtraTabControl tabControlVisualizaAtividade;
        private DevExpress.XtraTab.XtraTabPage tabInfoAtividade;
        private DevExpress.XtraTab.XtraTabPage tabHistoricoExecucao;
        private DevExpress.XtraEditors.SimpleButton btnEditarTextoAtividade;
        private System.Windows.Forms.BindingSource bindingSourceExecucao;
        private DevExpress.XtraRichEdit.RichEditControl richEditDescricaoAtividade;
        private DevExpress.XtraGrid.GridControl gridControlHistoricoExecucao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHistoricoExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividadeId;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFimExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicioExecucao;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryDataFimExecucao;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryDataInicioExecucao;
        private BindingSource bindingSourceAtividade;
        private DevExpress.XtraEditors.SimpleButton btnCancelarAtividade;
    }
}
