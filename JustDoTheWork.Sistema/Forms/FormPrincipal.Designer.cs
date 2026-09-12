namespace JustDoTheWork.Sistema.Forms
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            tabTarefas = new DevExpress.XtraTab.XtraTabPage();
            coltreeListColumns = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            accordionControlMenu = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElementCadastro = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            ElementAtividades = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ElementModeloRelatorio = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElementRelatorio = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            ElementRelatorioExecucao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)xtraTabControlMain).BeginInit();
            xtraTabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accordionControlMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // xtraTabControlMain
            // 
            xtraTabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            xtraTabControlMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            xtraTabControlMain.Location = new Point(60, 9);
            xtraTabControlMain.Name = "xtraTabControlMain";
            xtraTabControlMain.SelectedTabPage = tabTarefas;
            xtraTabControlMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            xtraTabControlMain.Size = new Size(1188, 659);
            xtraTabControlMain.TabIndex = 0;
            xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabTarefas });
            xtraTabControlMain.CloseButtonClick += xtraTabControlMain_CloseButtonClick;
            // 
            // tabTarefas
            // 
            tabTarefas.Name = "tabTarefas";
            tabTarefas.Size = new Size(1186, 628);
            tabTarefas.Text = "Execução de Tarefas";
            // 
            // coltreeListColumns
            // 
            coltreeListColumns.Caption = "Rotinas";
            coltreeListColumns.FieldName = "Rotinas";
            coltreeListColumns.Name = "coltreeListColumns";
            coltreeListColumns.Visible = true;
            coltreeListColumns.VisibleIndex = 0;
            // 
            // accordionControlMenu
            // 
            accordionControlMenu.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Spline;
            accordionControlMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElementCadastro, accordionControlElementRelatorio });
            accordionControlMenu.Location = new Point(5, 9);
            accordionControlMenu.Name = "accordionControlMenu";
            accordionControlMenu.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Minimal;
            accordionControlMenu.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            accordionControlMenu.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            accordionControlMenu.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            accordionControlMenu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            accordionControlMenu.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            accordionControlMenu.Size = new Size(49, 658);
            accordionControlMenu.TabIndex = 1;
            accordionControlMenu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementCadastro
            // 
            accordionControlElementCadastro.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlSeparator1, ElementAtividades, ElementModeloRelatorio });
            accordionControlElementCadastro.Expanded = true;
            accordionControlElementCadastro.Hint = "Cadastros";
            accordionControlElementCadastro.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElementCadastro.ImageOptions.SvgImage");
            accordionControlElementCadastro.Name = "accordionControlElementCadastro";
            accordionControlElementCadastro.Text = "Cadastro";
            // 
            // accordionControlSeparator1
            // 
            accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // ElementAtividades
            // 
            ElementAtividades.Hint = "Cadastro de Atividades";
            ElementAtividades.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ElementAtividades.ImageOptions.SvgImage");
            ElementAtividades.Name = "ElementAtividades";
            ElementAtividades.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            ElementAtividades.Tag = "Atividades";
            ElementAtividades.Text = "Atividades";
            ElementAtividades.Click += AbreNovaJanela_Click;
            // 
            // ElementModeloRelatorio
            // 
            ElementModeloRelatorio.Hint = "Cadastrar Modelos para Relatórios";
            ElementModeloRelatorio.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ElementModeloRelatorio.ImageOptions.SvgImage");
            ElementModeloRelatorio.Name = "ElementModeloRelatorio";
            ElementModeloRelatorio.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            ElementModeloRelatorio.Tag = "ModelosRelatorio";
            ElementModeloRelatorio.Text = "Modelos de Relatório";
            ElementModeloRelatorio.Click += AbreNovaJanela_Click;
            // 
            // accordionControlElementRelatorio
            // 
            accordionControlElementRelatorio.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlSeparator2, ElementRelatorioExecucao });
            accordionControlElementRelatorio.Expanded = true;
            accordionControlElementRelatorio.Hint = "Relatórios";
            accordionControlElementRelatorio.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElementRelatorio.ImageOptions.SvgImage");
            accordionControlElementRelatorio.Name = "accordionControlElementRelatorio";
            accordionControlElementRelatorio.Text = "Relatorio";
            // 
            // accordionControlSeparator2
            // 
            accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // ElementRelatorioExecucao
            // 
            ElementRelatorioExecucao.Hint = "Relatório de execuções de tarefas";
            ElementRelatorioExecucao.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ElementRelatorioExecucao.ImageOptions.SvgImage");
            ElementRelatorioExecucao.Name = "ElementRelatorioExecucao";
            ElementRelatorioExecucao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            ElementRelatorioExecucao.Tag = "RelatorioExecucao";
            ElementRelatorioExecucao.Text = "Relatório de Execuções";
            ElementRelatorioExecucao.Click += AbreNovaJanela_Click;
            // 
            // panelControl1
            // 
            panelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControl1.Controls.Add(accordionControlMenu);
            panelControl1.Controls.Add(xtraTabControlMain);
            panelControl1.Location = new Point(12, 3);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1253, 673);
            panelControl1.TabIndex = 2;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Expanded = true;
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Element1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 688);
            Controls.Add(panelControl1);
            IconOptions.LargeImage = (Image)resources.GetObject("FormPrincipal.IconOptions.LargeImage");
            MinimumSize = new Size(1280, 722);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)xtraTabControlMain).EndInit();
            xtraTabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)accordionControlMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage tabTarefas;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coltreeListColumns;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControlMenu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCadastro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ElementAtividades;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ElementModeloRelatorio;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementRelatorio;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ElementRelatorioExecucao;
    }
}
