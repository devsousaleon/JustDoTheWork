namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class CadastroUsuarioUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuarioUserControl));
            panelFiltroPesquisa = new DevExpress.XtraEditors.PanelControl();
            lblNomeUsuario = new DevExpress.XtraEditors.LabelControl();
            txtNomeUsuario = new DevExpress.XtraEditors.TextEdit();
            lblLogon = new DevExpress.XtraEditors.LabelControl();
            txtLogon = new DevExpress.XtraEditors.TextEdit();
            btnPesquisarUsuario = new DevExpress.XtraEditors.SimpleButton();
            panelAcoes = new DevExpress.XtraEditors.PanelControl();
            btnIncluirUsuario = new DevExpress.XtraEditors.SimpleButton();
            btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            gridControlUsuario = new DevExpress.XtraGrid.GridControl();
            bindingSourceResultadoPesquisaUsuario = new BindingSource(components);
            gridUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            colLogon = new DevExpress.XtraGrid.Columns.GridColumn();
            colTipoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            colAcao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryButtonAcao = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).BeginInit();
            panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNomeUsuario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLogon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).BeginInit();
            panelAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceResultadoPesquisaUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcao).BeginInit();
            SuspendLayout();
            //
            // panelFiltroPesquisa
            //
            panelFiltroPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltroPesquisa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelFiltroPesquisa.Controls.Add(lblNomeUsuario);
            panelFiltroPesquisa.Controls.Add(txtNomeUsuario);
            panelFiltroPesquisa.Controls.Add(lblLogon);
            panelFiltroPesquisa.Controls.Add(txtLogon);
            panelFiltroPesquisa.Controls.Add(btnPesquisarUsuario);
            panelFiltroPesquisa.Location = new Point(15, 15);
            panelFiltroPesquisa.Margin = new Padding(15);
            panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            panelFiltroPesquisa.Size = new Size(1250, 140);
            panelFiltroPesquisa.TabIndex = 0;
            //
            // lblNomeUsuario
            //
            lblNomeUsuario.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.Appearance.ForeColor = Color.White;
            lblNomeUsuario.Appearance.Options.UseFont = true;
            lblNomeUsuario.Appearance.Options.UseForeColor = true;
            lblNomeUsuario.Location = new Point(17, 27);
            lblNomeUsuario.Margin = new Padding(15);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(32, 16);
            lblNomeUsuario.TabIndex = 3;
            lblNomeUsuario.Text = "Nome";
            //
            // txtNomeUsuario
            //
            txtNomeUsuario.Location = new Point(107, 20);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Properties.Appearance.Options.UseFont = true;
            txtNomeUsuario.Properties.MaxLength = 30;
            txtNomeUsuario.Size = new Size(329, 30);
            txtNomeUsuario.TabIndex = 0;
            //
            // lblLogon
            //
            lblLogon.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogon.Appearance.ForeColor = Color.White;
            lblLogon.Appearance.Options.UseFont = true;
            lblLogon.Appearance.Options.UseForeColor = true;
            lblLogon.Location = new Point(17, 82);
            lblLogon.Margin = new Padding(15);
            lblLogon.Name = "lblLogon";
            lblLogon.Size = new Size(40, 16);
            lblLogon.TabIndex = 4;
            lblLogon.Text = "Logon";
            //
            // txtLogon
            //
            txtLogon.Location = new Point(107, 75);
            txtLogon.Name = "txtLogon";
            txtLogon.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogon.Properties.Appearance.Options.UseFont = true;
            txtLogon.Properties.MaxLength = 30;
            txtLogon.Size = new Size(329, 30);
            txtLogon.TabIndex = 1;
            //
            // btnPesquisarUsuario
            //
            btnPesquisarUsuario.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisarUsuario.Appearance.Options.UseFont = true;
            btnPesquisarUsuario.BackgroundImageLayout = ImageLayout.None;
            btnPesquisarUsuario.ImageOptions.Image = (Image)resources.GetObject("btnPesquisarUsuario.ImageOptions.Image");
            btnPesquisarUsuario.ImeMode = ImeMode.NoControl;
            btnPesquisarUsuario.Location = new Point(450, 40);
            btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            btnPesquisarUsuario.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnPesquisarUsuario.Size = new Size(107, 23);
            btnPesquisarUsuario.TabIndex = 2;
            btnPesquisarUsuario.Text = "Pesquisar";
            btnPesquisarUsuario.Click += btnPesquisarUsuario_Click;
            //
            // panelAcoes
            //
            panelAcoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelAcoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelAcoes.Controls.Add(btnIncluirUsuario);
            panelAcoes.Controls.Add(btnLimpar);
            panelAcoes.Location = new Point(15, 185);
            panelAcoes.Margin = new Padding(15);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(150, 520);
            panelAcoes.TabIndex = 1;
            //
            // btnIncluirUsuario
            //
            btnIncluirUsuario.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncluirUsuario.Appearance.Options.UseFont = true;
            btnIncluirUsuario.Location = new Point(17, 32);
            btnIncluirUsuario.Margin = new Padding(15, 30, 15, 30);
            btnIncluirUsuario.Name = "btnIncluirUsuario";
            btnIncluirUsuario.Size = new Size(116, 23);
            btnIncluirUsuario.TabIndex = 0;
            btnIncluirUsuario.Text = "Incluir";
            btnIncluirUsuario.Click += btnIncluirUsuario_Click;
            //
            // btnLimpar
            //
            btnLimpar.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Appearance.Options.UseFont = true;
            btnLimpar.Location = new Point(17, 115);
            btnLimpar.Margin = new Padding(15, 30, 15, 30);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(116, 23);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.Click += btnLimpar_Click;
            //
            // gridControlUsuario
            //
            gridControlUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControlUsuario.DataSource = bindingSourceResultadoPesquisaUsuario;
            gridControlUsuario.Location = new Point(183, 185);
            gridControlUsuario.MainView = gridUsuario;
            gridControlUsuario.Name = "gridControlUsuario";
            gridControlUsuario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryButtonAcao });
            gridControlUsuario.Size = new Size(1082, 520);
            gridControlUsuario.TabIndex = 2;
            gridControlUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridUsuario });
            //
            // bindingSourceResultadoPesquisaUsuario
            //
            bindingSourceResultadoPesquisaUsuario.DataSource = typeof(DTO.ResultadoPesquisaUsuarioDTO);
            //
            // gridUsuario
            //
            gridUsuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colNome, colLogon, colTipoUsuario, colAcao });
            gridUsuario.GridControl = gridControlUsuario;
            gridUsuario.Name = "gridUsuario";
            gridUsuario.OptionsBehavior.Editable = true;
            gridUsuario.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            gridUsuario.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            //
            // colNome
            //
            colNome.Caption = "Nome";
            colNome.FieldName = "Nome";
            colNome.Name = "colNome";
            colNome.OptionsColumn.AllowEdit = false;
            colNome.OptionsColumn.ReadOnly = true;
            colNome.Visible = true;
            colNome.VisibleIndex = 0;
            colNome.Width = 480;
            //
            // colLogon
            //
            colLogon.Caption = "Logon";
            colLogon.FieldName = "Logon";
            colLogon.Name = "colLogon";
            colLogon.OptionsColumn.AllowEdit = false;
            colLogon.OptionsColumn.ReadOnly = true;
            colLogon.Visible = true;
            colLogon.VisibleIndex = 1;
            colLogon.Width = 300;
            //
            // colTipoUsuario
            //
            colTipoUsuario.Caption = "Tipo de usuário";
            colTipoUsuario.FieldName = "TipoUsuario";
            colTipoUsuario.Name = "colTipoUsuario";
            colTipoUsuario.OptionsColumn.AllowEdit = false;
            colTipoUsuario.OptionsColumn.ReadOnly = true;
            colTipoUsuario.Visible = true;
            colTipoUsuario.VisibleIndex = 2;
            colTipoUsuario.Width = 280;
            //
            // colAcao
            //
            colAcao.Caption = "Ação";
            colAcao.ColumnEdit = repositoryButtonAcao;
            colAcao.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            colAcao.MaxWidth = 90;
            colAcao.MinWidth = 70;
            colAcao.Name = "colAcao";
            colAcao.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            colAcao.Visible = true;
            colAcao.VisibleIndex = 3;
            colAcao.Width = 80;
            //
            // repositoryButtonAcao
            //
            repositoryButtonAcao.AutoHeight = false;
            repositoryButtonAcao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search) });
            repositoryButtonAcao.Name = "repositoryButtonAcao";
            repositoryButtonAcao.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryButtonAcao.ButtonClick += repositoryButtonAcao_ButtonClick;
            //
            // CadastroUsuarioUserControl
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControlUsuario);
            Controls.Add(panelAcoes);
            Controls.Add(panelFiltroPesquisa);
            Name = "CadastroUsuarioUserControl";
            Size = new Size(1280, 720);
            Load += CadastroUsuarioUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).EndInit();
            panelFiltroPesquisa.ResumeLayout(false);
            panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtNomeUsuario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLogon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).EndInit();
            panelAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceResultadoPesquisaUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryButtonAcao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelFiltroPesquisa;
        private DevExpress.XtraEditors.LabelControl lblNomeUsuario;
        private DevExpress.XtraEditors.TextEdit txtNomeUsuario;
        private DevExpress.XtraEditors.LabelControl lblLogon;
        private DevExpress.XtraEditors.TextEdit txtLogon;
        private DevExpress.XtraEditors.SimpleButton btnPesquisarUsuario;
        private DevExpress.XtraEditors.PanelControl panelAcoes;
        private DevExpress.XtraEditors.SimpleButton btnIncluirUsuario;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraGrid.GridControl gridControlUsuario;
        private BindingSource bindingSourceResultadoPesquisaUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colLogon;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colAcao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryButtonAcao;
    }
}
