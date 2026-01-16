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
            this.ControlMenuBar = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.MenuBar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.HomePage = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.RegisterPage = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.HistoricPage = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ReportPage = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelPrincipal = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ControlMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlMenuBar
            // 
            this.ControlMenuBar.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MenuBar});
            this.ControlMenuBar.Location = new System.Drawing.Point(12, 12);
            this.ControlMenuBar.Name = "ControlMenuBar";
            this.ControlMenuBar.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.ControlMenuBar.Size = new System.Drawing.Size(123, 125);
            this.ControlMenuBar.TabIndex = 0;
            // 
            // MenuBar
            // 
            this.MenuBar.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.HomePage,
            this.RegisterPage,
            this.HistoricPage,
            this.ReportPage});
            this.MenuBar.Expanded = true;
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Text = "Menu";
            // 
            // HomePage
            // 
            this.HomePage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HomePage.ImageOptions.Image")));
            this.HomePage.Name = "HomePage";
            this.HomePage.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.HomePage.Text = "Principal";
            this.HomePage.VisibleInFooter = false;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // RegisterPage
            // 
            this.RegisterPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RegisterPage.ImageOptions.Image")));
            this.RegisterPage.Name = "RegisterPage";
            this.RegisterPage.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.RegisterPage.Text = "Cadastro";
            // 
            // HistoricPage
            // 
            this.HistoricPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HistoricPage.ImageOptions.Image")));
            this.HistoricPage.Name = "HistoricPage";
            this.HistoricPage.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.HistoricPage.Text = "Histórico";
            // 
            // ReportPage
            // 
            this.ReportPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ReportPage.ImageOptions.Image")));
            this.ReportPage.Name = "ReportPage";
            this.ReportPage.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ReportPage.Text = "Relatórios";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelPrincipal.Location = new System.Drawing.Point(141, 37);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1125, 639);
            this.panelPrincipal.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.ControlMenuBar);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormPrincipal.IconOptions.LargeImage")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl ControlMenuBar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MenuBar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement RegisterPage;
        private DevExpress.XtraBars.Navigation.AccordionControlElement HistoricPage;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ReportPage;
        private DevExpress.XtraBars.Navigation.AccordionControlElement HomePage;
        private DevExpress.XtraEditors.PanelControl panelPrincipal;
    }
}