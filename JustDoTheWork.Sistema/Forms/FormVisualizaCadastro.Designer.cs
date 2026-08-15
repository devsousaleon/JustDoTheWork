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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnEditaTextoAtividade = new DevExpress.XtraEditors.SimpleButton();
            lblDataFinalizacao = new DevExpress.XtraEditors.LabelControl();
            DataFinalizacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            DataCriacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            comboBoxStatus = new DevExpress.XtraEditors.LookUpEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            comboBoxProjeto = new DevExpress.XtraEditors.LookUpEdit();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            btnAvancar = new DevExpress.XtraEditors.SimpleButton();
            btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            btnFechar = new DevExpress.XtraEditors.SimpleButton();
            btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControlVisualizaAtividade).BeginInit();
            tabControlVisualizaAtividade.SuspendLayout();
            tabControlInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataFinalizacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataCriacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxProjeto.Properties).BeginInit();
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
            panelControl1.Size = new Size(1254, 605);
            panelControl1.TabIndex = 0;
            // 
            // tabControlVisualizaAtividade
            // 
            tabControlVisualizaAtividade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlVisualizaAtividade.Location = new Point(5, 5);
            tabControlVisualizaAtividade.Name = "tabControlVisualizaAtividade";
            tabControlVisualizaAtividade.SelectedTabPage = tabControlInfoAtividade;
            tabControlVisualizaAtividade.Size = new Size(1244, 595);
            tabControlVisualizaAtividade.TabIndex = 2;
            tabControlVisualizaAtividade.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabControlInfoAtividade, tabControlHistoricoExecucao });
            // 
            // tabControlInfoAtividade
            // 
            tabControlInfoAtividade.Controls.Add(txtEditorAtividade);
            tabControlInfoAtividade.Controls.Add(groupControl1);
            tabControlInfoAtividade.Name = "tabControlInfoAtividade";
            tabControlInfoAtividade.Size = new Size(1242, 564);
            tabControlInfoAtividade.Text = "Dados Atividade";
            // 
            // txtEditorAtividade
            // 
            txtEditorAtividade.Location = new Point(4, 173);
            txtEditorAtividade.Margin = new Padding(10);
            txtEditorAtividade.Name = "txtEditorAtividade";
            txtEditorAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            txtEditorAtividade.ReadOnly = true;
            txtEditorAtividade.Size = new Size(1235, 391);
            txtEditorAtividade.TabIndex = 18;
            // 
            // groupControl1
            // 
            groupControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupControl1.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(btnEditaTextoAtividade);
            groupControl1.Controls.Add(lblDataFinalizacao);
            groupControl1.Controls.Add(DataFinalizacao);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(DataCriacao);
            groupControl1.Controls.Add(comboBoxStatus);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(comboBoxProjeto);
            groupControl1.Controls.Add(lblProjeto);
            groupControl1.Controls.Add(labelControl1);
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
            // DataFinalizacao
            // 
            DataFinalizacao.EditValue = null;
            DataFinalizacao.Enabled = false;
            DataFinalizacao.Location = new Point(646, 76);
            DataFinalizacao.Name = "DataFinalizacao";
            DataFinalizacao.Properties.Appearance.Font = new Font("Courier New", 12F);
            DataFinalizacao.Properties.Appearance.Options.UseFont = true;
            DataFinalizacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DataFinalizacao.Size = new Size(213, 32);
            DataFinalizacao.TabIndex = 3;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(483, 45);
            labelControl3.Margin = new Padding(10);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(150, 18);
            labelControl3.TabIndex = 15;
            labelControl3.Text = "Data de Criação";
            // 
            // DataCriacao
            // 
            DataCriacao.EditValue = null;
            DataCriacao.Enabled = false;
            DataCriacao.Location = new Point(646, 39);
            DataCriacao.Name = "DataCriacao";
            DataCriacao.Properties.Appearance.Font = new Font("Courier New", 12F);
            DataCriacao.Properties.Appearance.Options.UseFont = true;
            DataCriacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DataCriacao.Size = new Size(213, 32);
            DataCriacao.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Enabled = false;
            comboBoxStatus.Location = new Point(105, 114);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxStatus.Properties.Appearance.Options.UseFont = true;
            comboBoxStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxStatus.Properties.NullText = "";
            comboBoxStatus.Size = new Size(302, 32);
            comboBoxStatus.TabIndex = 4;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(12, 122);
            labelControl2.Margin = new Padding(20);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(60, 18);
            labelControl2.TabIndex = 12;
            labelControl2.Text = "Status";
            // 
            // comboBoxProjeto
            // 
            comboBoxProjeto.Location = new Point(105, 75);
            comboBoxProjeto.Name = "comboBoxProjeto";
            comboBoxProjeto.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxProjeto.Properties.Appearance.Options.UseFont = true;
            comboBoxProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxProjeto.Properties.NullText = "";
            comboBoxProjeto.Size = new Size(302, 32);
            comboBoxProjeto.TabIndex = 2;
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
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(12, 46);
            labelControl1.Margin = new Padding(10);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(40, 18);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Nome";
            // 
            // txtNomeAtividade
            // 
            txtNomeAtividade.Location = new Point(65, 38);
            txtNomeAtividade.Name = "txtNomeAtividade";
            txtNomeAtividade.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            txtNomeAtividade.Properties.MaxLength = 50;
            txtNomeAtividade.Size = new Size(342, 32);
            txtNomeAtividade.TabIndex = 0;
            // 
            // tabControlHistoricoExecucao
            // 
            tabControlHistoricoExecucao.Controls.Add(dataGridHistoricoExecucao);
            tabControlHistoricoExecucao.Name = "tabControlHistoricoExecucao";
            tabControlHistoricoExecucao.Size = new Size(1242, 564);
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
            panelControl2.Controls.Add(btnAvancar);
            panelControl2.Controls.Add(btnExcluir);
            panelControl2.Controls.Add(btnFechar);
            panelControl2.Controls.Add(btnSalvar);
            panelControl2.Location = new Point(12, 633);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(1254, 43);
            panelControl2.TabIndex = 1;
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
            ClientSize = new Size(1278, 688);
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
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataFinalizacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataCriacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxProjeto.Properties).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit2;
    }
}