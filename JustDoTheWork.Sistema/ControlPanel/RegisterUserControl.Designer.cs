namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class RegisterUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUserControl));
            this.panelBotoes = new DevExpress.XtraEditors.PanelControl();
            this.btnIncluirAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.panelFiltroPesquisa = new DevExpress.XtraEditors.PanelControl();
            this.comboStatusPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            this.comboProjetoPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            this.dataCriacaoPesquisa = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnPesquisarAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GridCadastroAtividade = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atualizaGridAtividadeDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelBotoes)).BeginInit();
            this.panelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFiltroPesquisa)).BeginInit();
            this.panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboStatusPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProjetoPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCriacaoPesquisa.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCriacaoPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCadastroAtividade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atualizaGridAtividadeDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotoes
            // 
            this.panelBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBotoes.Appearance.BackColor = System.Drawing.Color.White;
            this.panelBotoes.Appearance.Options.UseBackColor = true;
            this.panelBotoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelBotoes.Controls.Add(this.btnIncluirAtividade);
            this.panelBotoes.Location = new System.Drawing.Point(15, 184);
            this.panelBotoes.Margin = new System.Windows.Forms.Padding(15);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(123, 521);
            this.panelBotoes.TabIndex = 3;
            // 
            // btnIncluirAtividade
            // 
            this.btnIncluirAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirAtividade.Appearance.Options.UseFont = true;
            this.btnIncluirAtividade.Location = new System.Drawing.Point(17, 32);
            this.btnIncluirAtividade.Margin = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.btnIncluirAtividade.Name = "btnIncluirAtividade";
            this.btnIncluirAtividade.Size = new System.Drawing.Size(89, 23);
            this.btnIncluirAtividade.TabIndex = 0;
            this.btnIncluirAtividade.Text = "Incluir";
            this.btnIncluirAtividade.Click += new System.EventHandler(this.btnIncluirAtividade_Click);
            // 
            // panelFiltroPesquisa
            // 
            this.panelFiltroPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltroPesquisa.Appearance.BackColor = System.Drawing.Color.White;
            this.panelFiltroPesquisa.Appearance.Options.UseBackColor = true;
            this.panelFiltroPesquisa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelFiltroPesquisa.Controls.Add(this.comboStatusPesquisa);
            this.panelFiltroPesquisa.Controls.Add(this.comboProjetoPesquisa);
            this.panelFiltroPesquisa.Controls.Add(this.dataCriacaoPesquisa);
            this.panelFiltroPesquisa.Controls.Add(this.labelControl4);
            this.panelFiltroPesquisa.Controls.Add(this.labelControl3);
            this.panelFiltroPesquisa.Controls.Add(this.labelControl2);
            this.panelFiltroPesquisa.Controls.Add(this.btnPesquisarAtividade);
            this.panelFiltroPesquisa.Controls.Add(this.txtNomeAtividade);
            this.panelFiltroPesquisa.Controls.Add(this.labelControl1);
            this.panelFiltroPesquisa.Location = new System.Drawing.Point(15, 15);
            this.panelFiltroPesquisa.Margin = new System.Windows.Forms.Padding(15);
            this.panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            this.panelFiltroPesquisa.Size = new System.Drawing.Size(1250, 139);
            this.panelFiltroPesquisa.TabIndex = 4;
            // 
            // comboStatusPesquisa
            // 
            this.comboStatusPesquisa.Location = new System.Drawing.Point(84, 58);
            this.comboStatusPesquisa.Name = "comboStatusPesquisa";
            this.comboStatusPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatusPesquisa.Properties.Appearance.Options.UseFont = true;
            this.comboStatusPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboStatusPesquisa.Properties.NullText = "";
            this.comboStatusPesquisa.Properties.PopupSizeable = false;
            this.comboStatusPesquisa.Size = new System.Drawing.Size(296, 24);
            this.comboStatusPesquisa.TabIndex = 10;
            // 
            // comboProjetoPesquisa
            // 
            this.comboProjetoPesquisa.Location = new System.Drawing.Point(503, 12);
            this.comboProjetoPesquisa.Name = "comboProjetoPesquisa";
            this.comboProjetoPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProjetoPesquisa.Properties.Appearance.Options.UseFont = true;
            this.comboProjetoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboProjetoPesquisa.Properties.NullText = "";
            this.comboProjetoPesquisa.Size = new System.Drawing.Size(312, 24);
            this.comboProjetoPesquisa.TabIndex = 9;
            // 
            // dataCriacaoPesquisa
            // 
            this.dataCriacaoPesquisa.EditValue = null;
            this.dataCriacaoPesquisa.Location = new System.Drawing.Point(479, 57);
            this.dataCriacaoPesquisa.Name = "dataCriacaoPesquisa";
            this.dataCriacaoPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCriacaoPesquisa.Properties.Appearance.Options.UseFont = true;
            this.dataCriacaoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataCriacaoPesquisa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataCriacaoPesquisa.Size = new System.Drawing.Size(336, 22);
            this.dataCriacaoPesquisa.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(429, 63);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Data";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(429, 17);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Projeto";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 63);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Status";
            // 
            // btnPesquisarAtividade
            // 
            this.btnPesquisarAtividade.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnPesquisarAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarAtividade.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarAtividade.Appearance.Options.UseBorderColor = true;
            this.btnPesquisarAtividade.Appearance.Options.UseFont = true;
            this.btnPesquisarAtividade.Appearance.Options.UseForeColor = true;
            this.btnPesquisarAtividade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisarAtividade.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarAtividade.ImageOptions.Image")));
            this.btnPesquisarAtividade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisarAtividade.Location = new System.Drawing.Point(378, 97);
            this.btnPesquisarAtividade.Name = "btnPesquisarAtividade";
            this.btnPesquisarAtividade.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPesquisarAtividade.Size = new System.Drawing.Size(107, 23);
            this.btnPesquisarAtividade.TabIndex = 2;
            this.btnPesquisarAtividade.Text = "Pesquisar";
            this.btnPesquisarAtividade.Click += new System.EventHandler(this.btnPesquisarAtividade_Click);
            // 
            // txtNomeAtividade
            // 
            this.txtNomeAtividade.Location = new System.Drawing.Point(67, 13);
            this.txtNomeAtividade.Name = "txtNomeAtividade";
            this.txtNomeAtividade.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            this.txtNomeAtividade.Size = new System.Drawing.Size(313, 22);
            this.txtNomeAtividade.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nome";
            // 
            // GridCadastroAtividade
            // 
            this.GridCadastroAtividade.AllowUserToAddRows = false;
            this.GridCadastroAtividade.AllowUserToDeleteRows = false;
            this.GridCadastroAtividade.AllowUserToOrderColumns = true;
            this.GridCadastroAtividade.AllowUserToResizeColumns = false;
            this.GridCadastroAtividade.AllowUserToResizeRows = false;
            this.GridCadastroAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridCadastroAtividade.AutoGenerateColumns = false;
            this.GridCadastroAtividade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.GridCadastroAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCadastroAtividade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.projetoDataGridViewTextBoxColumn});
            this.GridCadastroAtividade.DataSource = this.atualizaGridAtividadeDTOBindingSource;
            this.GridCadastroAtividade.Location = new System.Drawing.Point(168, 184);
            this.GridCadastroAtividade.Margin = new System.Windows.Forms.Padding(15);
            this.GridCadastroAtividade.MultiSelect = false;
            this.GridCadastroAtividade.Name = "GridCadastroAtividade";
            this.GridCadastroAtividade.ReadOnly = true;
            this.GridCadastroAtividade.Size = new System.Drawing.Size(1097, 521);
            this.GridCadastroAtividade.TabIndex = 5;
            this.GridCadastroAtividade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCadastroAtividade_CellDoubleClick);
            this.GridCadastroAtividade.SelectionChanged += new System.EventHandler(this.GridCadastroAtividade_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Width = 93;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Atividade";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Atividade";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // projetoDataGridViewTextBoxColumn
            // 
            this.projetoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projetoDataGridViewTextBoxColumn.DataPropertyName = "Projeto";
            this.projetoDataGridViewTextBoxColumn.HeaderText = "Projeto";
            this.projetoDataGridViewTextBoxColumn.Name = "projetoDataGridViewTextBoxColumn";
            this.projetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.projetoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // atualizaGridAtividadeDTOBindingSource
            // 
            this.atualizaGridAtividadeDTOBindingSource.DataSource = typeof(JustDoTheWork.DTO.AtualizaGridAtividadeDTO);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // RegisterUserControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.GridCadastroAtividade);
            this.Controls.Add(this.panelFiltroPesquisa);
            this.Controls.Add(this.panelBotoes);
            this.Name = "RegisterUserControl";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.RegisterUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelBotoes)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelFiltroPesquisa)).EndInit();
            this.panelFiltroPesquisa.ResumeLayout(false);
            this.panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboStatusPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProjetoPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCriacaoPesquisa.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCriacaoPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCadastroAtividade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atualizaGridAtividadeDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBotoes;
        private DevExpress.XtraEditors.PanelControl panelFiltroPesquisa;
        private System.Windows.Forms.DataGridView GridCadastroAtividade;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projetoDataGridViewTextBoxColumn;
    }
}
