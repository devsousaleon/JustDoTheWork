namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class CadastroAtividadeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAtividadeUserControl));
            panelAcoes = new DevExpress.XtraEditors.PanelControl();
            btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            btnIncluirAtividade = new DevExpress.XtraEditors.SimpleButton();
            panelFiltroPesquisa = new DevExpress.XtraEditors.PanelControl();
            comboStatusPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            bindingSourceFiltroPesquisaAtividade = new BindingSource(components);
            comboProjetoPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            dataCriacaoPesquisa = new DevExpress.XtraEditors.DateEdit();
            lblDataCriacao = new DevExpress.XtraEditors.LabelControl();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            btnPesquisarAtividade = new DevExpress.XtraEditors.SimpleButton();
            txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            gridProjetoPesquisa = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControlAtividade = new DevExpress.XtraGrid.GridControl();
            gridAtividade = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colAtividade = new DevExpress.XtraGrid.Columns.GridColumn();
            colProjeto = new DevExpress.XtraGrid.Columns.GridColumn();
            colAcao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonAcao = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).BeginInit();
            panelAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).BeginInit();
            panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFiltroPesquisaAtividade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridProjetoPesquisa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlAtividade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridAtividade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcao).BeginInit();
            SuspendLayout();
            // 
            // panelAcoes
            // 
            panelAcoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelAcoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelAcoes.Controls.Add(btnLimpar);
            panelAcoes.Controls.Add(btnIncluirAtividade);
            panelAcoes.Location = new Point(15, 184);
            panelAcoes.Margin = new Padding(15);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(150, 520);
            panelAcoes.TabIndex = 3;
            // 
            // btnLimpar
            // 
            btnLimpar.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Appearance.Options.UseFont = true;
            btnLimpar.Location = new Point(17, 115);
            btnLimpar.Margin = new Padding(15, 30, 15, 30);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(116, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnIncluirAtividade
            // 
            btnIncluirAtividade.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncluirAtividade.Appearance.Options.UseFont = true;
            btnIncluirAtividade.Location = new Point(17, 32);
            btnIncluirAtividade.Margin = new Padding(15, 30, 15, 30);
            btnIncluirAtividade.Name = "btnIncluirAtividade";
            btnIncluirAtividade.Size = new Size(116, 23);
            btnIncluirAtividade.TabIndex = 4;
            btnIncluirAtividade.Text = "Incluir";
            btnIncluirAtividade.Click += btnIncluirAtividade_Click;
            // 
            // panelFiltroPesquisa
            // 
            panelFiltroPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltroPesquisa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelFiltroPesquisa.Controls.Add(comboStatusPesquisa);
            panelFiltroPesquisa.Controls.Add(comboProjetoPesquisa);
            panelFiltroPesquisa.Controls.Add(dataCriacaoPesquisa);
            panelFiltroPesquisa.Controls.Add(lblDataCriacao);
            panelFiltroPesquisa.Controls.Add(lblProjeto);
            panelFiltroPesquisa.Controls.Add(lblStatus);
            panelFiltroPesquisa.Controls.Add(btnPesquisarAtividade);
            panelFiltroPesquisa.Controls.Add(txtNomeAtividade);
            panelFiltroPesquisa.Controls.Add(lblNomeAtividade);
            panelFiltroPesquisa.Location = new Point(15, 15);
            panelFiltroPesquisa.Margin = new Padding(15);
            panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            panelFiltroPesquisa.Size = new Size(1250, 140);
            panelFiltroPesquisa.TabIndex = 4;
            // 
            // comboStatusPesquisa
            // 
            comboStatusPesquisa.DataBindings.Add(new Binding("EditValue", bindingSourceFiltroPesquisaAtividade, "Status", true));
            comboStatusPesquisa.EnterMoveNextControl = true;
            comboStatusPesquisa.Location = new Point(84, 58);
            comboStatusPesquisa.Name = "comboStatusPesquisa";
            comboStatusPesquisa.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatusPesquisa.Properties.Appearance.Options.UseFont = true;
            comboStatusPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatusPesquisa.Properties.NullText = "";
            comboStatusPesquisa.Properties.PopupSizeable = false;
            comboStatusPesquisa.Size = new Size(296, 32);
            comboStatusPesquisa.TabIndex = 2;
            // 
            // bindingSourceFiltroPesquisaAtividade
            // 
            bindingSourceFiltroPesquisaAtividade.DataSource = typeof(DTO.FiltroPesquisaAtividadeDTO);
            // 
            // comboProjetoPesquisa
            // 
            comboProjetoPesquisa.DataBindings.Add(new Binding("EditValue", bindingSourceFiltroPesquisaAtividade, "ProjetoId", true));
            comboProjetoPesquisa.EnterMoveNextControl = true;
            comboProjetoPesquisa.Location = new Point(567, 13);
            comboProjetoPesquisa.Name = "comboProjetoPesquisa";
            comboProjetoPesquisa.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjetoPesquisa.Properties.Appearance.Options.UseFont = true;
            comboProjetoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboProjetoPesquisa.Properties.NullText = "";
            comboProjetoPesquisa.Size = new Size(312, 32);
            comboProjetoPesquisa.TabIndex = 1;
            // 
            // dataCriacaoPesquisa
            // 
            dataCriacaoPesquisa.DataBindings.Add(new Binding("EditValue", bindingSourceFiltroPesquisaAtividade, "DataCriacao", true));
            dataCriacaoPesquisa.EditValue = null;
            dataCriacaoPesquisa.Location = new Point(567, 56);
            dataCriacaoPesquisa.Name = "dataCriacaoPesquisa";
            dataCriacaoPesquisa.Properties.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataCriacaoPesquisa.Properties.Appearance.Options.UseFont = true;
            dataCriacaoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dataCriacaoPesquisa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dataCriacaoPesquisa.Size = new Size(312, 30);
            dataCriacaoPesquisa.TabIndex = 3;
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataCriacao.Appearance.Options.UseFont = true;
            lblDataCriacao.Location = new Point(429, 63);
            lblDataCriacao.Margin = new Padding(15);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(120, 16);
            lblDataCriacao.TabIndex = 7;
            lblDataCriacao.Text = "Data de criação";
            // 
            // lblProjeto
            // 
            lblProjeto.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProjeto.Appearance.Options.UseFont = true;
            lblProjeto.Location = new Point(429, 17);
            lblProjeto.Margin = new Padding(15);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(120, 16);
            lblProjeto.TabIndex = 5;
            lblProjeto.Text = "Nome do Projeto";
            // 
            // lblStatus
            // 
            lblStatus.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Appearance.Options.UseFont = true;
            lblStatus.Location = new Point(17, 63);
            lblStatus.Margin = new Padding(15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(48, 16);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // btnPesquisarAtividade
            // 
            btnPesquisarAtividade.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisarAtividade.Appearance.Options.UseFont = true;
            btnPesquisarAtividade.BackgroundImageLayout = ImageLayout.None;
            btnPesquisarAtividade.ImageOptions.Image = (Image)resources.GetObject("btnPesquisarAtividade.ImageOptions.Image");
            btnPesquisarAtividade.ImeMode = ImeMode.NoControl;
            btnPesquisarAtividade.Location = new Point(378, 97);
            btnPesquisarAtividade.Name = "btnPesquisarAtividade";
            btnPesquisarAtividade.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnPesquisarAtividade.Size = new Size(107, 23);
            btnPesquisarAtividade.TabIndex = 2;
            btnPesquisarAtividade.Text = "Pesquisar";
            btnPesquisarAtividade.Click += btnPesquisarAtividade_Click;
            // 
            // txtNomeAtividade
            // 
            txtNomeAtividade.DataBindings.Add(new Binding("EditValue", bindingSourceFiltroPesquisaAtividade, "Nome", true));
            txtNomeAtividade.EnterMoveNextControl = true;
            txtNomeAtividade.Location = new Point(84, 13);
            txtNomeAtividade.Name = "txtNomeAtividade";
            txtNomeAtividade.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            txtNomeAtividade.Properties.MaxLength = 50;
            txtNomeAtividade.Size = new Size(296, 30);
            txtNomeAtividade.TabIndex = 0;
            // 
            // lblNomeAtividade
            // 
            lblNomeAtividade.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeAtividade.Appearance.Options.UseFont = true;
            lblNomeAtividade.Location = new Point(17, 17);
            lblNomeAtividade.Margin = new Padding(15);
            lblNomeAtividade.Name = "lblNomeAtividade";
            lblNomeAtividade.Size = new Size(32, 16);
            lblNomeAtividade.TabIndex = 0;
            lblNomeAtividade.Text = "Nome";
            // 
            // gridProjetoPesquisa
            // 
            gridProjetoPesquisa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridProjetoPesquisa.Name = "gridProjetoPesquisa";
            gridProjetoPesquisa.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridProjetoPesquisa.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlAtividade
            // 
            gridControlAtividade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControlAtividade.Location = new Point(183, 184);
            gridControlAtividade.MainView = gridAtividade;
            gridControlAtividade.Name = "gridControlAtividade";
            gridControlAtividade.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryButtonAcao });
            gridControlAtividade.Size = new Size(1082, 520);
            gridControlAtividade.TabIndex = 6;
            gridControlAtividade.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridAtividade });
            // 
            // gridAtividade
            // 
            gridAtividade.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colAtividade, colProjeto, colAcao });
            gridAtividade.GridControl = gridControlAtividade;
            gridAtividade.Name = "gridAtividade";
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.OptionsColumn.AllowMove = false;
            colId.OptionsColumn.ReadOnly = true;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colAtividade
            // 
            colAtividade.FieldName = "Atividade";
            colAtividade.Name = "colAtividade";
            colAtividade.OptionsColumn.AllowEdit = false;
            colAtividade.OptionsColumn.AllowMove = false;
            colAtividade.OptionsColumn.ReadOnly = true;
            colAtividade.Visible = true;
            colAtividade.VisibleIndex = 1;
            // 
            // colProjeto
            // 
            colProjeto.FieldName = "Projeto";
            colProjeto.Name = "colProjeto";
            colProjeto.OptionsColumn.AllowEdit = false;
            colProjeto.OptionsColumn.AllowMove = false;
            colProjeto.OptionsColumn.ReadOnly = true;
            colProjeto.Visible = true;
            colProjeto.VisibleIndex = 2;
            // 
            // colAcao
            // 
            colAcao.Caption = "Ação";
            colAcao.ColumnEdit = repositoryButtonAcao;
            colAcao.Name = "colAcao";
            colAcao.Visible = true;
            colAcao.VisibleIndex = 3;
            // 
            // repositoryButtonAcao
            // 
            repositoryButtonAcao.AutoHeight = false;
            repositoryButtonAcao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryButtonAcao.Name = "repositoryButtonAcao";
            repositoryButtonAcao.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // CadastroAtividadeUserControl
            // 
            Appearance.BackColor = Color.FromArgb(32, 32, 32);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(gridControlAtividade);
            Controls.Add(panelFiltroPesquisa);
            Controls.Add(panelAcoes);
            Name = "CadastroAtividadeUserControl";
            Size = new Size(1280, 720);
            Load += CadastroAtividadeUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)panelAcoes).EndInit();
            panelAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).EndInit();
            panelFiltroPesquisa.ResumeLayout(false);
            panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFiltroPesquisaAtividade).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridProjetoPesquisa).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlAtividade).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridAtividade).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcao).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelAcoes;
        private DevExpress.XtraEditors.PanelControl panelFiltroPesquisa;
        private DevExpress.XtraEditors.SimpleButton btnIncluirAtividade;
        private DevExpress.XtraEditors.LabelControl lblNomeAtividade;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.SimpleButton btnPesquisarAtividade;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LabelControl lblDataCriacao;
        private DevExpress.XtraEditors.DateEdit dataCriacaoPesquisa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridProjetoPesquisa;
        private System.Windows.Forms.BindingSource bindingSourceFiltroPesquisaAtividade;
        private DevExpress.XtraEditors.LookUpEdit comboProjetoPesquisa;
        private DevExpress.XtraEditors.LookUpEdit comboStatusPesquisa;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraGrid.GridControl gridControlAtividade;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAtividade;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividade;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeto;
        private DevExpress.XtraGrid.Columns.GridColumn colAcao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonAcao;
    }
}
