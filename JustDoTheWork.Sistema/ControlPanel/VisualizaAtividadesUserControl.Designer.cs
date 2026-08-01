namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class VisualizaAtividadesUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizaAtividadesUserControl));
            panelBotoes = new DevExpress.XtraEditors.PanelControl();
            btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            btnIncluirAtividade = new DevExpress.XtraEditors.SimpleButton();
            panelFiltroPesquisa = new DevExpress.XtraEditors.PanelControl();
            comboStatusPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            comboProjetoPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            dataCriacaoPesquisa = new DevExpress.XtraEditors.DateEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            btnPesquisarAtividade = new DevExpress.XtraEditors.SimpleButton();
            txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            atualizaGridAtividadeDTOBindingSource = new BindingSource(components);
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            GridCadastroAtividade = new DevExpress.XtraGrid.GridControl();
            gridAtividadesCadastradas = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colAtividade = new DevExpress.XtraGrid.Columns.GridColumn();
            colProjeto = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnVisualizaAtividade = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonAtividades = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)panelBotoes).BeginInit();
            panelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).BeginInit();
            panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atualizaGridAtividadeDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridCadastroAtividade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridAtividadesCadastradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonAtividades).BeginInit();
            SuspendLayout();
            // 
            // panelBotoes
            // 
            panelBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelBotoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelBotoes.Controls.Add(btnLimpar);
            panelBotoes.Controls.Add(btnIncluirAtividade);
            panelBotoes.Location = new Point(15, 184);
            panelBotoes.Margin = new Padding(15);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(123, 521);
            panelBotoes.TabIndex = 3;
            // 
            // btnLimpar
            // 
            btnLimpar.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Appearance.Options.UseFont = true;
            btnLimpar.Location = new Point(17, 115);
            btnLimpar.Margin = new Padding(15, 30, 15, 30);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(89, 23);
            btnLimpar.TabIndex = 1;
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
            btnIncluirAtividade.Size = new Size(89, 23);
            btnIncluirAtividade.TabIndex = 0;
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
            panelFiltroPesquisa.Controls.Add(labelControl4);
            panelFiltroPesquisa.Controls.Add(labelControl3);
            panelFiltroPesquisa.Controls.Add(labelControl2);
            panelFiltroPesquisa.Controls.Add(btnPesquisarAtividade);
            panelFiltroPesquisa.Controls.Add(txtNomeAtividade);
            panelFiltroPesquisa.Controls.Add(labelControl1);
            panelFiltroPesquisa.Location = new Point(15, 15);
            panelFiltroPesquisa.Margin = new Padding(15);
            panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            panelFiltroPesquisa.Size = new Size(1250, 139);
            panelFiltroPesquisa.TabIndex = 4;
            // 
            // comboStatusPesquisa
            // 
            comboStatusPesquisa.Location = new Point(84, 58);
            comboStatusPesquisa.Name = "comboStatusPesquisa";
            comboStatusPesquisa.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatusPesquisa.Properties.Appearance.Options.UseFont = true;
            comboStatusPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatusPesquisa.Properties.NullText = "";
            comboStatusPesquisa.Properties.PopupSizeable = false;
            comboStatusPesquisa.Size = new Size(296, 32);
            comboStatusPesquisa.TabIndex = 10;
            // 
            // comboProjetoPesquisa
            // 
            comboProjetoPesquisa.Location = new Point(503, 12);
            comboProjetoPesquisa.Name = "comboProjetoPesquisa";
            comboProjetoPesquisa.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjetoPesquisa.Properties.Appearance.Options.UseFont = true;
            comboProjetoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboProjetoPesquisa.Properties.NullText = "";
            comboProjetoPesquisa.Size = new Size(312, 32);
            comboProjetoPesquisa.TabIndex = 9;
            // 
            // dataCriacaoPesquisa
            // 
            dataCriacaoPesquisa.EditValue = null;
            dataCriacaoPesquisa.Location = new Point(479, 57);
            dataCriacaoPesquisa.Name = "dataCriacaoPesquisa";
            dataCriacaoPesquisa.Properties.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataCriacaoPesquisa.Properties.Appearance.Options.UseFont = true;
            dataCriacaoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dataCriacaoPesquisa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dataCriacaoPesquisa.Size = new Size(336, 30);
            dataCriacaoPesquisa.TabIndex = 8;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(429, 63);
            labelControl4.Margin = new Padding(15);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(32, 16);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Data";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(429, 17);
            labelControl3.Margin = new Padding(15);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(56, 16);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Projeto";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(17, 63);
            labelControl2.Margin = new Padding(15);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(48, 16);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Status";
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
            txtNomeAtividade.Location = new Point(67, 13);
            txtNomeAtividade.Name = "txtNomeAtividade";
            txtNomeAtividade.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            txtNomeAtividade.Properties.MaxLength = 50;
            txtNomeAtividade.Size = new Size(313, 30);
            txtNomeAtividade.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(17, 17);
            labelControl1.Margin = new Padding(15);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(32, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Nome";
            // 
            // atualizaGridAtividadeDTOBindingSource
            // 
            atualizaGridAtividadeDTOBindingSource.DataSource = typeof(DTO.AtualizaGridAtividadeDTO);
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // GridCadastroAtividade
            // 
            GridCadastroAtividade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridCadastroAtividade.DataSource = atualizaGridAtividadeDTOBindingSource;
            GridCadastroAtividade.Location = new Point(168, 184);
            GridCadastroAtividade.MainView = gridAtividadesCadastradas;
            GridCadastroAtividade.Name = "GridCadastroAtividade";
            GridCadastroAtividade.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonAtividades });
            GridCadastroAtividade.Size = new Size(1097, 521);
            GridCadastroAtividade.TabIndex = 6;
            GridCadastroAtividade.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridAtividadesCadastradas });
            // 
            // gridAtividadesCadastradas
            // 
            gridAtividadesCadastradas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colAtividade, colProjeto, gridColumnVisualizaAtividade });
            gridAtividadesCadastradas.GridControl = GridCadastroAtividade;
            gridAtividadesCadastradas.Name = "gridAtividadesCadastradas";
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
            // gridColumnVisualizaAtividade
            // 
            gridColumnVisualizaAtividade.Caption = "Ação";
            gridColumnVisualizaAtividade.ColumnEdit = repositoryItemButtonAtividades;
            gridColumnVisualizaAtividade.Name = "gridColumnVisualizaAtividade";
            gridColumnVisualizaAtividade.Visible = true;
            gridColumnVisualizaAtividade.VisibleIndex = 3;
            // 
            // repositoryItemButtonAtividades
            // 
            repositoryItemButtonAtividades.AutoHeight = false;
            repositoryItemButtonAtividades.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryItemButtonAtividades.Name = "repositoryItemButtonAtividades";
            repositoryItemButtonAtividades.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // VisualizaAtividadesUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(GridCadastroAtividade);
            Controls.Add(panelFiltroPesquisa);
            Controls.Add(panelBotoes);
            Name = "VisualizaAtividadesUserControl";
            Size = new Size(1280, 720);
            Load += RegisterUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)panelBotoes).EndInit();
            panelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).EndInit();
            panelFiltroPesquisa.ResumeLayout(false);
            panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)atualizaGridAtividadeDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridCadastroAtividade).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridAtividadesCadastradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonAtividades).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBotoes;
        private DevExpress.XtraEditors.PanelControl panelFiltroPesquisa;
        private DevExpress.XtraEditors.SimpleButton btnIncluirAtividade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.SimpleButton btnPesquisarAtividade;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dataCriacaoPesquisa;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource atualizaGridAtividadeDTOBindingSource;
        private DevExpress.XtraEditors.LookUpEdit comboProjetoPesquisa;
        private DevExpress.XtraEditors.LookUpEdit comboStatusPesquisa;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraGrid.GridControl GridCadastroAtividade;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAtividadesCadastradas;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAtividade;
        private DevExpress.XtraGrid.Columns.GridColumn colProjeto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnVisualizaAtividade;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonAtividades;
    }
}
