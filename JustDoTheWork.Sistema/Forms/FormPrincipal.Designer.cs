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
            tabControlPrincipal = new DevExpress.XtraTab.XtraTabControl();
            tabTarefas = new DevExpress.XtraTab.XtraTabPage();
            colTarefas = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            accordionControlMenu = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionElementCadastro = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionSeparatorCadastro = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            accordionElementAtividades = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionElementModeloRelatorio = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionElementUsuarios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionElementRelatorio = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionSeparatorRelatorio = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            accordionElementRelatorioExecucao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            accordionElementAdicional = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)tabControlPrincipal).BeginInit();
            tabControlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accordionControlMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            tabControlPrincipal.Location = new Point(60, 9);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedTabPage = tabTarefas;
            tabControlPrincipal.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            tabControlPrincipal.Size = new Size(1188, 659);
            tabControlPrincipal.TabIndex = 0;
            tabControlPrincipal.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabTarefas });
            tabControlPrincipal.CloseButtonClick += tabControlPrincipal_CloseButtonClick;
            // 
            // tabTarefas
            // 
            tabTarefas.Name = "tabTarefas";
            tabTarefas.Size = new Size(1186, 628);
            tabTarefas.Text = "Execução de Tarefas";
            // 
            // colTarefas
            // 
            colTarefas.Caption = "Rotinas";
            colTarefas.FieldName = "Rotinas";
            colTarefas.Name = "colTarefas";
            colTarefas.Visible = true;
            colTarefas.VisibleIndex = 0;
            // 
            // accordionControlMenu
            // 
            accordionControlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            accordionControlMenu.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Spline;
            accordionControlMenu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionElementCadastro, accordionElementRelatorio });
            accordionControlMenu.Location = new Point(5, 9);
            accordionControlMenu.Name = "accordionControlMenu";
            accordionControlMenu.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Overlay;
            accordionControlMenu.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            accordionControlMenu.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            accordionControlMenu.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            accordionControlMenu.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            accordionControlMenu.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            accordionControlMenu.Size = new Size(49, 658);
            accordionControlMenu.TabIndex = 1;
            accordionControlMenu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionElementCadastro
            // 
            accordionElementCadastro.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionSeparatorCadastro, accordionElementAtividades, accordionElementModeloRelatorio, accordionElementUsuarios });
            accordionElementCadastro.Expanded = true;
            accordionElementCadastro.Hint = "Cadastros";
            accordionElementCadastro.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionElementCadastro.ImageOptions.SvgImage");
            accordionElementCadastro.Name = "accordionElementCadastro";
            accordionElementCadastro.Text = "Cadastro";
            // 
            // accordionSeparatorCadastro
            // 
            accordionSeparatorCadastro.Name = "accordionSeparatorCadastro";
            // 
            // accordionElementAtividades
            // 
            accordionElementAtividades.Hint = "Cadastro de Atividades";
            accordionElementAtividades.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionElementAtividades.ImageOptions.SvgImage");
            accordionElementAtividades.Name = "accordionElementAtividades";
            accordionElementAtividades.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionElementAtividades.Tag = "Atividades";
            accordionElementAtividades.Text = "Atividades";
            accordionElementAtividades.Click += AbreNovaJanela_Click;
            // 
            // accordionElementModeloRelatorio
            // 
            accordionElementModeloRelatorio.Hint = "Cadastrar Modelos para Relatórios";
            accordionElementModeloRelatorio.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionElementModeloRelatorio.ImageOptions.SvgImage");
            accordionElementModeloRelatorio.Name = "accordionElementModeloRelatorio";
            accordionElementModeloRelatorio.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionElementModeloRelatorio.Tag = "ModelosRelatorio";
            accordionElementModeloRelatorio.Text = "Modelos de Relatório";
            accordionElementModeloRelatorio.Click += AbreNovaJanela_Click;
            // 
            // accordionElementUsuarios
            //
            accordionElementUsuarios.Hint = "Cadastro de Usuários";
            accordionElementUsuarios.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionElementUsuarios.ImageOptions.SvgImage");
            accordionElementUsuarios.Name = "accordionElementUsuarios";
            accordionElementUsuarios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionElementUsuarios.Tag = "Usuarios";
            accordionElementUsuarios.Text = "Usuários";
            accordionElementUsuarios.Click += AbreNovaJanela_Click;
            //
            // accordionElementRelatorio
            // 
            accordionElementRelatorio.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionSeparatorRelatorio, accordionElementRelatorioExecucao });
            accordionElementRelatorio.Expanded = true;
            accordionElementRelatorio.Hint = "Relatórios";
            accordionElementRelatorio.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionElementRelatorio.ImageOptions.SvgImage");
            accordionElementRelatorio.Name = "accordionElementRelatorio";
            accordionElementRelatorio.Text = "Relatorio";
            // 
            // accordionSeparatorRelatorio
            // 
            accordionSeparatorRelatorio.Name = "accordionSeparatorRelatorio";
            // 
            // accordionElementRelatorioExecucao
            // 
            accordionElementRelatorioExecucao.Hint = "Relatório de execuções de tarefas";
            accordionElementRelatorioExecucao.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionElementRelatorioExecucao.ImageOptions.SvgImage");
            accordionElementRelatorioExecucao.Name = "accordionElementRelatorioExecucao";
            accordionElementRelatorioExecucao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionElementRelatorioExecucao.Tag = "RelatorioExecucao";
            accordionElementRelatorioExecucao.Text = "Relatório de Execuções";
            accordionElementRelatorioExecucao.Click += AbreNovaJanela_Click;
            // 
            // panelBackground
            // 
            panelBackground.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBackground.Controls.Add(accordionControlMenu);
            panelBackground.Controls.Add(tabControlPrincipal);
            panelBackground.Location = new Point(12, 3);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(1253, 673);
            panelBackground.TabIndex = 2;
            // 
            // accordionElementAdicional
            // 
            accordionElementAdicional.Expanded = true;
            accordionElementAdicional.Name = "accordionElementAdicional";
            accordionElementAdicional.Text = "Element1";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 688);
            Controls.Add(panelBackground);
            IconOptions.LargeImage = (Image)resources.GetObject("FormPrincipal.IconOptions.LargeImage");
            MinimumSize = new Size(1280, 722);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)tabControlPrincipal).EndInit();
            tabControlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)accordionControlMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabControlPrincipal;
        private DevExpress.XtraTab.XtraTabPage tabTarefas;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTarefas;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControlMenu;
        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionElementAdicional;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionElementCadastro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionElementAtividades;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionElementModeloRelatorio;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionElementUsuarios;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionSeparatorCadastro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionElementRelatorio;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionSeparatorRelatorio;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionElementRelatorioExecucao;
    }
}
