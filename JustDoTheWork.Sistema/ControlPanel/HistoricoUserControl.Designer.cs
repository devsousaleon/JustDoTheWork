namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class HistoricoUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoUserControl));
            panelFiltroPesquisa = new DevExpress.XtraEditors.PanelControl();
            comboProjetoPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            comboStatusPesquisa = new DevExpress.XtraEditors.LookUpEdit();
            dataCriacaoPesquisa = new DevExpress.XtraEditors.DateEdit();
            lblDataCriacao = new DevExpress.XtraEditors.LabelControl();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            btnPesquisarHistorico = new DevExpress.XtraEditors.SimpleButton();
            panelAcoes = new DevExpress.XtraEditors.PanelControl();
            btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            btnImprimirHistorico = new DevExpress.XtraEditors.SimpleButton();
            gridControlHistorico = new DevExpress.XtraGrid.GridControl();
            gridHistorico = new DevExpress.XtraGrid.Views.Grid.GridView();
            colNomeAtividade = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeProjeto = new DevExpress.XtraGrid.Columns.GridColumn();
            colDataInicioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryDataFimExecucao = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            colDataFimExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryDataInicioExecucao = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            bindingSourceResultadoPesquisaHistorico = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).BeginInit();
            panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).BeginInit();
            panelAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlHistorico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridHistorico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataFimExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataInicioExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceResultadoPesquisaHistorico).BeginInit();
            SuspendLayout();
            // 
            // panelFiltroPesquisa
            // 
            panelFiltroPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltroPesquisa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelFiltroPesquisa.Controls.Add(comboProjetoPesquisa);
            panelFiltroPesquisa.Controls.Add(comboStatusPesquisa);
            panelFiltroPesquisa.Controls.Add(dataCriacaoPesquisa);
            panelFiltroPesquisa.Controls.Add(lblDataCriacao);
            panelFiltroPesquisa.Controls.Add(lblProjeto);
            panelFiltroPesquisa.Controls.Add(lblStatus);
            panelFiltroPesquisa.Controls.Add(btnPesquisarHistorico);
            panelFiltroPesquisa.Location = new Point(15, 15);
            panelFiltroPesquisa.Margin = new Padding(15);
            panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            panelFiltroPesquisa.Size = new Size(1250, 140);
            panelFiltroPesquisa.TabIndex = 7;
            // 
            // comboProjetoPesquisa
            // 
            comboProjetoPesquisa.Location = new Point(83, 8);
            comboProjetoPesquisa.Name = "comboProjetoPesquisa";
            comboProjetoPesquisa.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjetoPesquisa.Properties.Appearance.Options.UseFont = true;
            comboProjetoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboProjetoPesquisa.Properties.NullText = "";
            comboProjetoPesquisa.Size = new Size(296, 32);
            comboProjetoPesquisa.TabIndex = 10;
            // 
            // comboStatusPesquisa
            // 
            comboStatusPesquisa.Location = new Point(83, 56);
            comboStatusPesquisa.Name = "comboStatusPesquisa";
            comboStatusPesquisa.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboStatusPesquisa.Properties.Appearance.Options.UseFont = true;
            comboStatusPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboStatusPesquisa.Properties.NullText = "";
            comboStatusPesquisa.Properties.PopupSizeable = false;
            comboStatusPesquisa.Size = new Size(296, 32);
            comboStatusPesquisa.TabIndex = 9;
            // 
            // dataCriacaoPesquisa
            //
            dataCriacaoPesquisa.EditValue = null;
            dataCriacaoPesquisa.Location = new Point(451, 10);
            dataCriacaoPesquisa.Name = "dataCriacaoPesquisa";
            dataCriacaoPesquisa.Properties.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataCriacaoPesquisa.Properties.Appearance.Options.UseFont = true;
            dataCriacaoPesquisa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dataCriacaoPesquisa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dataCriacaoPesquisa.Size = new Size(336, 30);
            dataCriacaoPesquisa.TabIndex = 8;
            //
            // lblDataCriacao
            //
            lblDataCriacao.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataCriacao.Appearance.ForeColor = Color.White;
            lblDataCriacao.Appearance.Options.UseFont = true;
            lblDataCriacao.Appearance.Options.UseForeColor = true;
            lblDataCriacao.Location = new Point(401, 17);
            lblDataCriacao.Margin = new Padding(15);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(32, 16);
            lblDataCriacao.TabIndex = 7;
            lblDataCriacao.Text = "Data";
            // 
            // lblProjeto
            // 
            lblProjeto.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProjeto.Appearance.ForeColor = Color.White;
            lblProjeto.Appearance.Options.UseFont = true;
            lblProjeto.Appearance.Options.UseForeColor = true;
            lblProjeto.Location = new Point(17, 17);
            lblProjeto.Margin = new Padding(15);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(56, 16);
            lblProjeto.TabIndex = 5;
            lblProjeto.Text = "Projeto";
            // 
            // lblStatus
            // 
            lblStatus.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Appearance.ForeColor = Color.White;
            lblStatus.Appearance.Options.UseFont = true;
            lblStatus.Appearance.Options.UseForeColor = true;
            lblStatus.Location = new Point(17, 63);
            lblStatus.Margin = new Padding(15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(48, 16);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // btnPesquisarHistorico
            // 
            btnPesquisarHistorico.Appearance.BorderColor = Color.Transparent;
            btnPesquisarHistorico.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisarHistorico.Appearance.ForeColor = Color.White;
            btnPesquisarHistorico.Appearance.Options.UseBorderColor = true;
            btnPesquisarHistorico.Appearance.Options.UseFont = true;
            btnPesquisarHistorico.Appearance.Options.UseForeColor = true;
            btnPesquisarHistorico.BackgroundImageLayout = ImageLayout.None;
            btnPesquisarHistorico.ImageOptions.Image = (Image)resources.GetObject("btnPesquisarHistorico.ImageOptions.Image");
            btnPesquisarHistorico.ImeMode = ImeMode.NoControl;
            btnPesquisarHistorico.Location = new Point(378, 97);
            btnPesquisarHistorico.Name = "btnPesquisarHistorico";
            btnPesquisarHistorico.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnPesquisarHistorico.Size = new Size(107, 23);
            btnPesquisarHistorico.TabIndex = 2;
            btnPesquisarHistorico.Text = "Pesquisar";
            btnPesquisarHistorico.Click += btnPesquisarHistorico_Click;
            // 
            // panelAcoes
            //
            panelAcoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelAcoes.Appearance.BackColor = Color.DarkSlateBlue;
            panelAcoes.Appearance.BackColor2 = Color.DarkSlateBlue;
            panelAcoes.Appearance.BorderColor = Color.DarkSlateBlue;
            panelAcoes.Appearance.Options.UseBackColor = true;
            panelAcoes.Appearance.Options.UseBorderColor = true;
            panelAcoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelAcoes.Controls.Add(btnLimpar);
            panelAcoes.Controls.Add(btnImprimirHistorico);
            panelAcoes.Location = new Point(15, 184);
            panelAcoes.Margin = new Padding(15);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(150, 520);
            panelAcoes.TabIndex = 6;
            // 
            // btnLimpar
            // 
            btnLimpar.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Appearance.Options.UseFont = true;
            btnLimpar.Location = new Point(17, 115);
            btnLimpar.Margin = new Padding(15, 30, 15, 30);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(116, 23);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnImprimirHistorico
            // 
            btnImprimirHistorico.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImprimirHistorico.Appearance.Options.UseFont = true;
            btnImprimirHistorico.Location = new Point(17, 32);
            btnImprimirHistorico.Margin = new Padding(15, 30, 15, 30);
            btnImprimirHistorico.Name = "btnImprimirHistorico";
            btnImprimirHistorico.Size = new Size(116, 23);
            btnImprimirHistorico.TabIndex = 1;
            btnImprimirHistorico.Text = "Imprimir";
            btnImprimirHistorico.Click += btnImprimirHistorico_Click;
            // 
            // gridControlHistorico
            // 
            gridControlHistorico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControlHistorico.Location = new Point(183, 184);
            gridControlHistorico.MainView = gridHistorico;
            gridControlHistorico.Name = "gridControlHistorico";
            gridControlHistorico.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryDataFimExecucao, repositoryDataInicioExecucao });
            gridControlHistorico.Size = new Size(1082, 520);
            gridControlHistorico.TabIndex = 8;
            gridControlHistorico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridHistorico });
            // 
            // gridHistorico
            // 
            gridHistorico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colNomeAtividade, colNomeProjeto, colDataInicioExecucao, colDataFimExecucao });
            gridHistorico.GridControl = gridControlHistorico;
            gridHistorico.Name = "gridHistorico";
            // 
            // colNomeAtividade
            // 
            colNomeAtividade.FieldName = "NomeAtividade";
            colNomeAtividade.Name = "colNomeAtividade";
            colNomeAtividade.OptionsColumn.AllowEdit = false;
            colNomeAtividade.OptionsColumn.ReadOnly = true;
            colNomeAtividade.Visible = true;
            colNomeAtividade.VisibleIndex = 0;
            // 
            // colNomeProjeto
            // 
            colNomeProjeto.FieldName = "NomeProjeto";
            colNomeProjeto.Name = "colNomeProjeto";
            colNomeProjeto.OptionsColumn.AllowEdit = false;
            colNomeProjeto.OptionsColumn.ReadOnly = true;
            colNomeProjeto.Visible = true;
            colNomeProjeto.VisibleIndex = 1;
            // 
            // colDataInicioExecucao
            // 
            colDataInicioExecucao.ColumnEdit = repositoryDataInicioExecucao;
            colDataInicioExecucao.FieldName = "DataInicioExecucao";
            colDataInicioExecucao.Name = "colDataInicioExecucao";
            colDataInicioExecucao.OptionsColumn.AllowEdit = false;
            colDataInicioExecucao.OptionsColumn.ReadOnly = true;
            colDataInicioExecucao.Visible = true;
            colDataInicioExecucao.VisibleIndex = 2;
            // 
            // repositoryDataFimExecucao
            // 
            repositoryDataFimExecucao.AutoHeight = false;
            repositoryDataFimExecucao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryDataFimExecucao.Name = "repositoryDataFimExecucao";
            // 
            // colDataFimExecucao
            // 
            colDataFimExecucao.ColumnEdit = repositoryDataFimExecucao;
            colDataFimExecucao.FieldName = "DataFimExecucao";
            colDataFimExecucao.Name = "colDataFimExecucao";
            colDataFimExecucao.OptionsColumn.AllowEdit = false;
            colDataFimExecucao.OptionsColumn.ReadOnly = true;
            colDataFimExecucao.Visible = true;
            colDataFimExecucao.VisibleIndex = 3;
            // 
            // repositoryDataInicioExecucao
            // 
            repositoryDataInicioExecucao.AutoHeight = false;
            repositoryDataInicioExecucao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryDataInicioExecucao.Name = "repositoryDataInicioExecucao";
            // 
            // HistoricoUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(gridControlHistorico);
            Controls.Add(panelFiltroPesquisa);
            Controls.Add(panelAcoes);
            Name = "HistoricoUserControl";
            Size = new Size(1280, 720);
            Load += HistoricoUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).EndInit();
            panelFiltroPesquisa.ResumeLayout(false);
            panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCriacaoPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).EndInit();
            panelAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlHistorico).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridHistorico).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataFimExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryDataInicioExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceResultadoPesquisaHistorico).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelFiltroPesquisa;
        private DevExpress.XtraEditors.DateEdit dataCriacaoPesquisa;
        private DevExpress.XtraEditors.LabelControl lblDataCriacao;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.SimpleButton btnPesquisarHistorico;
        private DevExpress.XtraEditors.PanelControl panelAcoes;
        private DevExpress.XtraEditors.SimpleButton btnImprimirHistorico;
        private DevExpress.XtraGrid.GridControl gridControlHistorico;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHistorico;
        private DevExpress.XtraEditors.LookUpEdit comboStatusPesquisa;
        private DevExpress.XtraEditors.LookUpEdit comboProjetoPesquisa;
        private BindingSource bindingSourceResultadoPesquisaHistorico;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeAtividade;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProjeto;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicioExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFimExecucao;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryDataFimExecucao;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryDataInicioExecucao;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
    }
}
