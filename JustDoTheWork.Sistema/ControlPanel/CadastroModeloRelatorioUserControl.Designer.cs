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
            btnPesquisarModeloRelatorio = new DevExpress.XtraEditors.SimpleButton();
            lblTipoModelo = new DevExpress.XtraEditors.LabelControl();
            comboTipoModelo = new DevExpress.XtraEditors.LookUpEdit();
            txtDescricaoModelo = new DevExpress.XtraEditors.TextEdit();
            lblDescricaoModelo = new DevExpress.XtraEditors.LabelControl();
            panelAcoes = new DevExpress.XtraEditors.PanelControl();
            btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            btnIncluirModeloRelatorio = new DevExpress.XtraEditors.SimpleButton();
            gridControlModeloRelatorio = new DevExpress.XtraGrid.GridControl();
            bindingSourceResultadoPesquisaModeloRelatorio = new BindingSource(components);
            gridModeloRelatorio = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            colTipoModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            colAtivo = new DevExpress.XtraGrid.Columns.GridColumn();
            colAcao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonAcao = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).BeginInit();
            panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboTipoModelo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricaoModelo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).BeginInit();
            panelAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlModeloRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceResultadoPesquisaModeloRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridModeloRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcao).BeginInit();
            SuspendLayout();
            // 
            // panelFiltroPesquisa
            // 
            panelFiltroPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltroPesquisa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelFiltroPesquisa.Controls.Add(btnPesquisarModeloRelatorio);
            panelFiltroPesquisa.Controls.Add(lblTipoModelo);
            panelFiltroPesquisa.Controls.Add(comboTipoModelo);
            panelFiltroPesquisa.Controls.Add(txtDescricaoModelo);
            panelFiltroPesquisa.Controls.Add(lblDescricaoModelo);
            panelFiltroPesquisa.Location = new Point(15, 15);
            panelFiltroPesquisa.Margin = new Padding(15);
            panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            panelFiltroPesquisa.Size = new Size(1250, 140);
            panelFiltroPesquisa.TabIndex = 10;
            // 
            // btnPesquisarModeloRelatorio
            //
            btnPesquisarModeloRelatorio.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisarModeloRelatorio.Appearance.Options.UseFont = true;
            btnPesquisarModeloRelatorio.BackgroundImageLayout = ImageLayout.None;
            btnPesquisarModeloRelatorio.ImageOptions.Image = (Image)resources.GetObject("btnPesquisarModeloRelatorio.ImageOptions.Image");
            btnPesquisarModeloRelatorio.ImeMode = ImeMode.NoControl;
            btnPesquisarModeloRelatorio.Location = new Point(450, 40);
            btnPesquisarModeloRelatorio.Name = "btnPesquisarModeloRelatorio";
            btnPesquisarModeloRelatorio.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnPesquisarModeloRelatorio.Size = new Size(107, 23);
            btnPesquisarModeloRelatorio.TabIndex = 7;
            btnPesquisarModeloRelatorio.Text = "Pesquisar";
            btnPesquisarModeloRelatorio.Click += btnPesquisarModeloRelatorio_Click;
            // 
            // lblTipoModelo
            // 
            lblTipoModelo.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoModelo.Appearance.ForeColor = Color.White;
            lblTipoModelo.Appearance.Options.UseFont = true;
            lblTipoModelo.Appearance.Options.UseForeColor = true;
            lblTipoModelo.Location = new Point(17, 78);
            lblTipoModelo.Margin = new Padding(15);
            lblTipoModelo.Name = "lblTipoModelo";
            lblTipoModelo.Size = new Size(88, 16);
            lblTipoModelo.TabIndex = 9;
            lblTipoModelo.Text = "Tipo Modelo";
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
            // panelAcoes
            // 
            panelAcoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelAcoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelAcoes.Controls.Add(btnLimpar);
            panelAcoes.Controls.Add(btnIncluirModeloRelatorio);
            panelAcoes.Location = new Point(15, 185);
            panelAcoes.Margin = new Padding(15);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(150, 520);
            panelAcoes.TabIndex = 11;
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
            // btnIncluirModeloRelatorio
            // 
            btnIncluirModeloRelatorio.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncluirModeloRelatorio.Appearance.Options.UseFont = true;
            btnIncluirModeloRelatorio.Location = new Point(17, 32);
            btnIncluirModeloRelatorio.Margin = new Padding(15, 30, 15, 30);
            btnIncluirModeloRelatorio.Name = "btnIncluirModeloRelatorio";
            btnIncluirModeloRelatorio.Size = new Size(116, 23);
            btnIncluirModeloRelatorio.TabIndex = 5;
            btnIncluirModeloRelatorio.Text = "Incluir";
            btnIncluirModeloRelatorio.Click += btnIncluirModeloRelatorio_Click;
            // 
            // gridControlModeloRelatorio
            // 
            gridControlModeloRelatorio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControlModeloRelatorio.DataSource = bindingSourceResultadoPesquisaModeloRelatorio;
            gridControlModeloRelatorio.Location = new Point(183, 185);
            gridControlModeloRelatorio.MainView = gridModeloRelatorio;
            gridControlModeloRelatorio.Name = "gridControlModeloRelatorio";
            gridControlModeloRelatorio.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryButtonAcao });
            gridControlModeloRelatorio.Size = new Size(1082, 520);
            gridControlModeloRelatorio.TabIndex = 12;
            gridControlModeloRelatorio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridModeloRelatorio });
            // 
            // bindingSourceResultadoPesquisaModeloRelatorio
            // 
            bindingSourceResultadoPesquisaModeloRelatorio.DataSource = typeof(DTO.ResultadoPesquisaModeloRelatorioDTO);
            // 
            // gridModeloRelatorio
            // 
            gridModeloRelatorio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colDescricao, colTipoModelo, colAtivo, colAcao });
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
            // colTipoModelo
            // 
            colTipoModelo.FieldName = "TipoModelo";
            colTipoModelo.Name = "colTipoModelo";
            colTipoModelo.OptionsColumn.AllowEdit = false;
            colTipoModelo.OptionsColumn.ReadOnly = true;
            colTipoModelo.Visible = true;
            colTipoModelo.VisibleIndex = 2;
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
            // colAcao
            // 
            colAcao.Caption = "Ação";
            colAcao.ColumnEdit = repositoryButtonAcao;
            colAcao.Name = "colAcao";
            colAcao.Visible = true;
            colAcao.VisibleIndex = 4;
            // 
            // repositoryButtonAcao
            // 
            repositoryButtonAcao.AutoHeight = false;
            repositoryButtonAcao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryButtonAcao.Name = "repositoryButtonAcao";
            repositoryButtonAcao.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // CadastroModeloRelatorioUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControlModeloRelatorio);
            Controls.Add(panelAcoes);
            Controls.Add(panelFiltroPesquisa);
            Name = "CadastroModeloRelatorioUserControl";
            Size = new Size(1280, 720);
            Load += CadastroModeloRelatorioUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).EndInit();
            panelFiltroPesquisa.ResumeLayout(false);
            panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboTipoModelo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricaoModelo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).EndInit();
            panelAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlModeloRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceResultadoPesquisaModeloRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridModeloRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcao).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelFiltroPesquisa;
        private DevExpress.XtraEditors.PanelControl panelAcoes;
        private DevExpress.XtraEditors.CheckEdit checkAtivo;
        private DevExpress.XtraEditors.LabelControl lblDescricaoModelo;
        private DevExpress.XtraEditors.TextEdit txtDescricaoModelo;
        private DevExpress.XtraEditors.LookUpEdit comboTipoModelo;
        private DevExpress.XtraEditors.LabelControl lblTipoModelo;
        private DevExpress.XtraEditors.SimpleButton btnIncluirModeloRelatorio;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraEditors.SimpleButton btnPesquisarModeloRelatorio;
        private DevExpress.XtraGrid.GridControl gridControlModeloRelatorio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridModeloRelatorio;
        private BindingSource bindingSourceResultadoPesquisaModeloRelatorio;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colAtivo;
        private DevExpress.XtraGrid.Columns.GridColumn colAcao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonAcao;
    }
}
