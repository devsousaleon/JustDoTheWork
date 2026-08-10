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
            DataCriacao = new DevExpress.XtraEditors.DateEdit();
            lblData = new DevExpress.XtraEditors.LabelControl();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            lblStatus = new DevExpress.XtraEditors.LabelControl();
            btnPesquisarHistorico = new DevExpress.XtraEditors.SimpleButton();
            panelBotoes = new DevExpress.XtraEditors.PanelControl();
            btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            btnImprimirHistorico = new DevExpress.XtraEditors.SimpleButton();
            gridControlHistorico = new DevExpress.XtraGrid.GridControl();
            resultadoPesquisaHistoricoDTOBindingSource1 = new BindingSource(components);
            gridHistoricoExecucao = new DevExpress.XtraGrid.Views.Grid.GridView();
            colNomeAtividade = new DevExpress.XtraGrid.Columns.GridColumn();
            colNomeProjeto = new DevExpress.XtraGrid.Columns.GridColumn();
            colDataInicioExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemDateTimeOffsetEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            colDataFimExecucao = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemDateTimeOffsetEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            resultadoPesquisaHistoricoDTOBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).BeginInit();
            panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataCriacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataCriacao.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelBotoes).BeginInit();
            panelBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlHistorico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultadoPesquisaHistoricoDTOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateTimeOffsetEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateTimeOffsetEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultadoPesquisaHistoricoDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelFiltroPesquisa
            // 
            panelFiltroPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltroPesquisa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelFiltroPesquisa.Controls.Add(comboProjetoPesquisa);
            panelFiltroPesquisa.Controls.Add(comboStatusPesquisa);
            panelFiltroPesquisa.Controls.Add(DataCriacao);
            panelFiltroPesquisa.Controls.Add(lblData);
            panelFiltroPesquisa.Controls.Add(lblProjeto);
            panelFiltroPesquisa.Controls.Add(lblStatus);
            panelFiltroPesquisa.Controls.Add(btnPesquisarHistorico);
            panelFiltroPesquisa.Location = new Point(15, 15);
            panelFiltroPesquisa.Margin = new Padding(15);
            panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            panelFiltroPesquisa.Size = new Size(1250, 139);
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
            // DataCriacao
            // 
            DataCriacao.EditValue = null;
            DataCriacao.Location = new Point(451, 10);
            DataCriacao.Name = "DataCriacao";
            DataCriacao.Properties.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataCriacao.Properties.Appearance.Options.UseFont = true;
            DataCriacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DataCriacao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DataCriacao.Size = new Size(336, 30);
            DataCriacao.TabIndex = 8;
            // 
            // lblData
            // 
            lblData.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Appearance.ForeColor = Color.White;
            lblData.Appearance.Options.UseFont = true;
            lblData.Appearance.Options.UseForeColor = true;
            lblData.Location = new Point(401, 17);
            lblData.Margin = new Padding(15);
            lblData.Name = "lblData";
            lblData.Size = new Size(32, 16);
            lblData.TabIndex = 7;
            lblData.Text = "Data";
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
            // panelBotoes
            // 
            panelBotoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelBotoes.Appearance.BackColor = Color.DarkSlateBlue;
            panelBotoes.Appearance.BackColor2 = Color.DarkSlateBlue;
            panelBotoes.Appearance.BorderColor = Color.DarkSlateBlue;
            panelBotoes.Appearance.Options.UseBackColor = true;
            panelBotoes.Appearance.Options.UseBorderColor = true;
            panelBotoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelBotoes.Controls.Add(btnLimpar);
            panelBotoes.Controls.Add(btnImprimirHistorico);
            panelBotoes.Location = new Point(15, 184);
            panelBotoes.Margin = new Padding(15);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Size = new Size(123, 521);
            panelBotoes.TabIndex = 6;
            // 
            // btnLimpar
            // 
            btnLimpar.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Appearance.Options.UseFont = true;
            btnLimpar.Location = new Point(17, 115);
            btnLimpar.Margin = new Padding(15, 30, 15, 30);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(89, 23);
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
            btnImprimirHistorico.Size = new Size(89, 23);
            btnImprimirHistorico.TabIndex = 1;
            btnImprimirHistorico.Text = "Imprimir";
            btnImprimirHistorico.Click += btnImprimirHistorico_Click;
            // 
            // gridControlHistorico
            // 
            gridControlHistorico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridControlHistorico.DataSource = resultadoPesquisaHistoricoDTOBindingSource1;
            gridControlHistorico.Location = new Point(156, 184);
            gridControlHistorico.MainView = gridHistoricoExecucao;
            gridControlHistorico.Name = "gridControlHistorico";
            gridControlHistorico.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemDateTimeOffsetEdit1, repositoryItemDateTimeOffsetEdit2 });
            gridControlHistorico.Size = new Size(1109, 521);
            gridControlHistorico.TabIndex = 8;
            gridControlHistorico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridHistoricoExecucao });
            // 
            // resultadoPesquisaHistoricoDTOBindingSource1
            // 
            resultadoPesquisaHistoricoDTOBindingSource1.DataSource = typeof(DTO.ResultadoPesquisaHistoricoDTO);
            // 
            // gridHistoricoExecucao
            // 
            gridHistoricoExecucao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colNomeAtividade, colNomeProjeto, colDataInicioExecucao, colDataFimExecucao });
            gridHistoricoExecucao.GridControl = gridControlHistorico;
            gridHistoricoExecucao.Name = "gridHistoricoExecucao";
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
            colDataInicioExecucao.ColumnEdit = repositoryItemDateTimeOffsetEdit1;
            colDataInicioExecucao.FieldName = "DataInicioExecucao";
            colDataInicioExecucao.Name = "colDataInicioExecucao";
            colDataInicioExecucao.OptionsColumn.AllowEdit = false;
            colDataInicioExecucao.OptionsColumn.ReadOnly = true;
            colDataInicioExecucao.Visible = true;
            colDataInicioExecucao.VisibleIndex = 2;
            // 
            // repositoryItemDateTimeOffsetEdit1
            // 
            repositoryItemDateTimeOffsetEdit1.AutoHeight = false;
            repositoryItemDateTimeOffsetEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateTimeOffsetEdit1.Name = "repositoryItemDateTimeOffsetEdit1";
            // 
            // colDataFimExecucao
            // 
            colDataFimExecucao.ColumnEdit = repositoryItemDateTimeOffsetEdit2;
            colDataFimExecucao.FieldName = "DataFimExecucao";
            colDataFimExecucao.Name = "colDataFimExecucao";
            colDataFimExecucao.OptionsColumn.AllowEdit = false;
            colDataFimExecucao.OptionsColumn.ReadOnly = true;
            colDataFimExecucao.Visible = true;
            colDataFimExecucao.VisibleIndex = 3;
            // 
            // repositoryItemDateTimeOffsetEdit2
            // 
            repositoryItemDateTimeOffsetEdit2.AutoHeight = false;
            repositoryItemDateTimeOffsetEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemDateTimeOffsetEdit2.Name = "repositoryItemDateTimeOffsetEdit2";
            // 
            // HistoricoUserControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(gridControlHistorico);
            Controls.Add(panelFiltroPesquisa);
            Controls.Add(panelBotoes);
            Name = "HistoricoUserControl";
            Size = new Size(1280, 720);
            Load += HistoricoUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)panelFiltroPesquisa).EndInit();
            panelFiltroPesquisa.ResumeLayout(false);
            panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboProjetoPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboStatusPesquisa.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataCriacao.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataCriacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelBotoes).EndInit();
            panelBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlHistorico).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultadoPesquisaHistoricoDTOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridHistoricoExecucao).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateTimeOffsetEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemDateTimeOffsetEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultadoPesquisaHistoricoDTOBindingSource).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelFiltroPesquisa;
        private DevExpress.XtraEditors.DateEdit DataCriacao;
        private DevExpress.XtraEditors.LabelControl lblData;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.SimpleButton btnPesquisarHistorico;
        private DevExpress.XtraEditors.PanelControl panelBotoes;
        private DevExpress.XtraEditors.SimpleButton btnImprimirHistorico;
        private DevExpress.XtraGrid.GridControl gridControlHistorico;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHistoricoExecucao;
        private DevExpress.XtraEditors.LookUpEdit comboStatusPesquisa;
        private DevExpress.XtraEditors.LookUpEdit comboProjetoPesquisa;
        private BindingSource resultadoPesquisaHistoricoDTOBindingSource;
        private BindingSource resultadoPesquisaHistoricoDTOBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeAtividade;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeProjeto;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicioExecucao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFimExecucao;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit2;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
    }
}
