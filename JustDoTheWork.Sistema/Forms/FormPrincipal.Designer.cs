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
            this.XtratabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabTarefas = new DevExpress.XtraTab.XtraTabPage();
            this.tabCadastro = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.XtratabControl)).BeginInit();
            this.XtratabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // XtratabControl
            // 
            this.XtratabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XtratabControl.Location = new System.Drawing.Point(12, 12);
            this.XtratabControl.Name = "XtratabControl";
            this.XtratabControl.SelectedTabPage = this.tabTarefas;
            this.XtratabControl.Size = new System.Drawing.Size(1254, 664);
            this.XtratabControl.TabIndex = 0;
            this.XtratabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabTarefas,
            this.tabCadastro});
            // 
            // tabTarefas
            // 
            this.tabTarefas.Name = "tabTarefas";
            this.tabTarefas.Size = new System.Drawing.Size(1252, 633);
            this.tabTarefas.Text = "Execução de Tarefas";
            // 
            // tabCadastro
            // 
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Size = new System.Drawing.Size(1252, 633);
            this.tabCadastro.Text = "Cadastro de Tarefas";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.XtratabControl);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormPrincipal.IconOptions.LargeImage")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XtratabControl)).EndInit();
            this.XtratabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl XtratabControl;
        private DevExpress.XtraTab.XtraTabPage tabTarefas;
        private DevExpress.XtraTab.XtraTabPage tabCadastro;
    }
}