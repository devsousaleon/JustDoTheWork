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
            XtratabControl = new DevExpress.XtraTab.XtraTabControl();
            tabTarefas = new DevExpress.XtraTab.XtraTabPage();
            tabCadastro = new DevExpress.XtraTab.XtraTabPage();
            tabHistorico = new DevExpress.XtraTab.XtraTabPage();
            tabCadastroModeloRelatorio = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)XtratabControl).BeginInit();
            XtratabControl.SuspendLayout();
            SuspendLayout();
            // 
            // XtratabControl
            // 
            XtratabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            XtratabControl.Location = new Point(12, 12);
            XtratabControl.Name = "XtratabControl";
            XtratabControl.SelectedTabPage = tabTarefas;
            XtratabControl.Size = new Size(1254, 664);
            XtratabControl.TabIndex = 0;
            XtratabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { tabTarefas, tabCadastro, tabHistorico, tabCadastroModeloRelatorio });
            // 
            // tabTarefas
            // 
            tabTarefas.Name = "tabTarefas";
            tabTarefas.Size = new Size(1252, 633);
            tabTarefas.Text = "Execução de Tarefas";
            // 
            // tabCadastro
            // 
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Size = new Size(1252, 639);
            tabCadastro.Text = "Cadastro de Tarefas";
            // 
            // tabHistorico
            // 
            tabHistorico.Name = "tabHistorico";
            tabHistorico.Size = new Size(1252, 639);
            tabHistorico.Text = "Histórico de execuções";
            // 
            // tabCadastroModeloRelatorio
            // 
            tabCadastroModeloRelatorio.Name = "tabCadastroModeloRelatorio";
            tabCadastroModeloRelatorio.Size = new Size(0, 0);
            tabCadastroModeloRelatorio.Text = "Modelos de Relatório";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 688);
            Controls.Add(XtratabControl);
            IconOptions.LargeImage = (Image)resources.GetObject("FormPrincipal.IconOptions.LargeImage");
            MinimumSize = new Size(1280, 722);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)XtratabControl).EndInit();
            XtratabControl.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl XtratabControl;
        private DevExpress.XtraTab.XtraTabPage tabTarefas;
        private DevExpress.XtraTab.XtraTabPage tabCadastro;
        private DevExpress.XtraTab.XtraTabPage tabHistorico;
        private DevExpress.XtraTab.XtraTabPage tabCadastroModeloRelatorio;
    }
}