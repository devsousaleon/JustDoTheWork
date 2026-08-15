namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class CadastroModeloRelatorioUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroModeloRelatorioUserControl));
            panelFiltroPesquisa = new DevExpress.XtraEditors.PanelControl();
            btnPesquisarModelo = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            comboTipoModelo = new DevExpress.XtraEditors.LookUpEdit();
            txtDescricaoModelo = new DevExpress.XtraEditors.TextEdit();
            lblDescricaoModelo = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            btnIncluirModelo = new DevExpress.XtraEditors.SimpleButton();
            gridControlModeloRelatorio = new DevExpress.XtraGrid.GridControl();
            resultadoPesquisaModeloRelatorioDTOBindingSource = new BindingSource(components);
            gridModeloRelatorio = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            colTipoModeloId = new DevExpress.XtraGrid.Columns.GridColumn();
            colAtivo = new DevExpress.XtraGrid.Columns.GridColumn();
            colAction = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonAction = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).BeginInit();
            panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboTipoModelo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricaoModelo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlModeloRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultadoPesquisaModeloRelatorioDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridModeloRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonAction).BeginInit();
            SuspendLayout();
            // 
            // panelFiltroPesquisa
            // 
            panelFiltroPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltroPesquisa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelFiltroPesquisa.Controls.Add(btnPesquisarModelo);
            panelFiltroPesquisa.Controls.Add(labelControl1);
            panelFiltroPesquisa.Controls.Add(comboTipoModelo);
            panelFiltroPesquisa.Controls.Add(txtDescricaoModelo);
            panelFiltroPesquisa.Controls.Add(lblDescricaoModelo);
            panelFiltroPesquisa.Location = new Point(15, 15);
            panelFiltroPesquisa.Margin = new Padding(15);
            panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            panelFiltroPesquisa.Size = new Size(1250, 140);
            panelFiltroPesquisa.TabIndex = 10;
            // 
            // btnPesquisarModelo
            // 
            btnPesquisarModelo.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisarModelo.Appearance.Options.UseFont = true;
            btnPesquisarModelo.BackgroundImageLayout = ImageLayout.None;
            btnPesquisarModelo.ImageOptions.Image = (Image)resources.GetObject("btnPesquisarModelo.ImageOptions.Image");
            btnPesquisarModelo.ImeMode = ImeMode.NoControl;
            btnPesquisarModelo.Location = new Point(450, 40);
            btnPesquisarModelo.Name = "btnPesquisarModelo";
            btnPesquisarModelo.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnPesquisarModelo.Size = new Size(107, 23);
            btnPesquisarModelo.TabIndex = 7;
            btnPesquisarModelo.Text = "Pesquisar";
            btnPesquisarModelo.Click += btnPesquisarModelo_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = Color.White;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(17, 78);
            labelControl1.Margin = new Padding(15);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(88, 16);
            labelControl1.TabIndex = 9;
            labelControl1.Text = "Tipo Modelo";
            // 
            // comboTipoModelo
            // 
            comboTipoModelo.Location = new Point(123, 69);
            comboTipoModelo.Name = "comboTipoModelo";
            comboTipoModelo.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTipoModelo.Properties.Appearance.Options.UseFont = true;
            comboTipoModelo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboTipoModelo.Properties.NullText = "";
            comboTipoModelo.Properties.PopupSizeable = false;
            comboTipoModelo.Size = new Size(313, 32);
            comboTipoModelo.TabIndex = 8;
            // 
            // txtDescricaoModelo
            // 
            txtDescricaoModelo.Location = new Point(107, 10);
            txtDescricaoModelo.Name = "txtDescricaoModelo";
            txtDescricaoModelo.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricaoModelo.Properties.Appearance.Options.UseFont = true;
            txtDescricaoModelo.Properties.MaxLength = 50;
            txtDescricaoModelo.Size = new Size(329, 30);
            txtDescricaoModelo.TabIndex = 7;
            // 
            // lblDescricaoModelo
            // 
            lblDescricaoModelo.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricaoModelo.Appearance.ForeColor = Color.White;
            lblDescricaoModelo.Appearance.Options.UseFont = true;
            lblDescricaoModelo.Appearance.Options.UseForeColor = true;
            lblDescricaoModelo.Location = new Point(17, 17);
            lblDescricaoModelo.Margin = new Padding(15);
            lblDescricaoModelo.Name = "lblDescricaoModelo";
            lblDescricaoModelo.Size = new Size(72, 16);
            lblDescricaoModelo.TabIndex = 6;
            lblDescricaoModelo.Text = "Descrição";
            // 
            // panelControl1
            // 
            panelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl1.Controls.Add(btnLimpar);
            panelControl1.Controls.Add(btnIncluirModelo);
            panelControl1.Location = new Point(15, 185);
            panelControl1.Margin = new Padding(15);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(150, 520);
            panelControl1.TabIndex = 11;
            // 
            // btnLimpar
            // 
            btnLimpar.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Appearance.Options.UseFont = true;
            btnLimpar.Location = new Point(17, 115);
            btnLimpar.Margin = new Padding(15, 30, 15, 30);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(116, 23);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnIncluirModelo
            // 
            btnIncluirModelo.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncluirModelo.Appearance.Options.UseFont = true;
            btnIncluirModelo.Location = new Point(17, 32);
            btnIncluirModelo.Margin = new Padding(15, 30, 15, 30);
            btnIncluirModelo.Name = "btnIncluirModelo";
            btnIncluirModelo.Size = new Size(116, 23);
            btnIncluirModelo.TabIndex = 5;
            btnIncluirModelo.Text = "Incluir";
            btnIncluirModelo.Click += btnIncluirModelo_Click;
            // 
            // gridControlModeloRelatorio
            // 
            gridControlModeloRelatorio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControlModeloRelatorio.DataSource = resultadoPesquisaModeloRelatorioDTOBindingSource;
            gridControlModeloRelatorio.Location = new Point(183, 185);
            gridControlModeloRelatorio.MainView = gridModeloRelatorio;
            gridControlModeloRelatorio.Name = "gridControlModeloRelatorio";
            gridControlModeloRelatorio.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonAction });
            gridControlModeloRelatorio.Size = new Size(1082, 520);
            gridControlModeloRelatorio.TabIndex = 12;
            gridControlModeloRelatorio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridModeloRelatorio });
            // 
            // resultadoPesquisaModeloRelatorioDTOBindingSource
            // 
            resultadoPesquisaModeloRelatorioDTOBindingSource.DataSource = typeof(DTO.ResultadoPesquisaModeloRelatorioDTO);
            // 
            // gridModeloRelatorio
            // 
            gridModeloRelatorio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colDescricao, colTipoModeloId, colAtivo, colAction });
            gridModeloRelatorio.GridControl = gridControlModeloRelatorio;
            gridModeloRelatorio.Name = "gridModeloRelatorio";
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.OptionsColumn.ReadOnly = true;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colDescricao
            // 
            colDescricao.Caption = "Descrição do Modelo";
            colDescricao.FieldName = "Descricao";
            colDescricao.Name = "colDescricao";
            colDescricao.OptionsColumn.AllowEdit = false;
            colDescricao.OptionsColumn.ReadOnly = true;
            colDescricao.Visible = true;
            colDescricao.VisibleIndex = 1;
            // 
            // colTipoModeloId
            // 
            colTipoModeloId.FieldName = "TipoModelo";
            colTipoModeloId.Name = "colTipoModeloId";
            colTipoModeloId.OptionsColumn.AllowEdit = false;
            colTipoModeloId.OptionsColumn.ReadOnly = true;
            colTipoModeloId.Visible = true;
            colTipoModeloId.VisibleIndex = 2;
            // 
            // colAtivo
            // 
            colAtivo.FieldName = "Ativo";
            colAtivo.Name = "colAtivo";
            colAtivo.OptionsColumn.AllowEdit = false;
            colAtivo.OptionsColumn.ReadOnly = true;
            colAtivo.Visible = true;
            colAtivo.VisibleIndex = 3;
            // 
            // colAction
            // 
            colAction.Caption = "Ação";
            colAction.ColumnEdit = repositoryItemButtonAction;
            colAction.Name = "colAction";
            colAction.Visible = true;
            colAction.VisibleIndex = 4;
            // 
            // repositoryItemButtonAction
            // 
            repositoryItemButtonAction.AutoHeight = false;
            repositoryItemButtonAction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryItemButtonAction.Name = "repositoryItemButtonAction";
            repositoryItemButtonAction.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // CadastroModeloRelatorioUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControlModeloRelatorio);
            Controls.Add(panelControl1);
            Controls.Add(panelFiltroPesquisa);
            Name = "CadastroModeloRelatorioUserControl";
            Size = new Size(1280, 720);
            Load += CadastroModeloRelatorioUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).EndInit();
            panelFiltroPesquisa.ResumeLayout(false);
            panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboTipoModelo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricaoModelo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlModeloRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultadoPesquisaModeloRelatorioDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridModeloRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonAction).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelFiltroPesquisa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl lblDescricaoModelo;
        private DevExpress.XtraEditors.TextEdit txtDescricaoModelo;
        private DevExpress.XtraEditors.LookUpEdit comboTipoModelo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnIncluirModelo;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraEditors.SimpleButton btnPesquisarModelo;
        private DevExpress.XtraGrid.GridControl gridControlModeloRelatorio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridModeloRelatorio;
        private BindingSource resultadoPesquisaModeloRelatorioDTOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoModeloId;
        private DevExpress.XtraGrid.Columns.GridColumn colAtivo;
        private DevExpress.XtraGrid.Columns.GridColumn colAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonAction;
    }
}
