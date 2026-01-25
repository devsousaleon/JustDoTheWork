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
            this.ControlMenuBar.Appearance.AccordionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ControlMenuBar.Appearance.AccordionControl.Options.UseBackColor = true;
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
            this.MenuBar.Appearance.Default.BorderColor = System.Drawing.Color.Black;
            this.MenuBar.Appearance.Default.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.Appearance.Default.ForeColor = System.Drawing.Color.Black;
            this.MenuBar.Appearance.Default.Options.UseBorderColor = true;
            this.MenuBar.Appearance.Default.Options.UseFont = true;
            this.MenuBar.Appearance.Default.Options.UseForeColor = true;
            this.MenuBar.Appearance.Disabled.ForeColor = System.Drawing.Color.Black;
            this.MenuBar.Appearance.Disabled.Options.UseForeColor = true;
            this.MenuBar.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.HomePage,
            this.RegisterPage,
            this.HistoricPage,
            this.ReportPage});
            this.MenuBar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("MenuBar.ImageOptions.Image")));
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Text = "Menu";
            // 
            // HomePage
            // 
            this.HomePage.Appearance.Default.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePage.Appearance.Default.ForeColor = System.Drawing.Color.Black;
            this.HomePage.Appearance.Default.Options.UseFont = true;
            this.HomePage.Appearance.Default.Options.UseForeColor = true;
            this.HomePage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HomePage.ImageOptions.Image")));
            this.HomePage.Name = "HomePage";
            this.HomePage.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.HomePage.Text = "Principal";
            this.HomePage.VisibleInFooter = false;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // RegisterPage
            // 
            this.RegisterPage.Appearance.Default.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPage.Appearance.Default.ForeColor = System.Drawing.Color.Black;
            this.RegisterPage.Appearance.Default.Options.UseFont = true;
            this.RegisterPage.Appearance.Default.Options.UseForeColor = true;
            this.RegisterPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RegisterPage.ImageOptions.Image")));
            this.RegisterPage.Name = "RegisterPage";
            this.RegisterPage.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.RegisterPage.Text = "Cadastro";
            this.RegisterPage.Click += new System.EventHandler(this.RegisterPage_Click);
            // 
            // HistoricPage
            // 
            this.HistoricPage.Appearance.Default.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoricPage.Appearance.Default.ForeColor = System.Drawing.Color.Black;
            this.HistoricPage.Appearance.Default.Options.UseFont = true;
            this.HistoricPage.Appearance.Default.Options.UseForeColor = true;
            this.HistoricPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HistoricPage.ImageOptions.Image")));
            this.HistoricPage.Name = "HistoricPage";
            this.HistoricPage.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.HistoricPage.Text = "Histórico";
            this.HistoricPage.Visible = false;
            this.HistoricPage.Click += new System.EventHandler(this.HistoricPage_Click);
            // 
            // ReportPage
            // 
            this.ReportPage.Appearance.Default.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportPage.Appearance.Default.ForeColor = System.Drawing.Color.Black;
            this.ReportPage.Appearance.Default.Options.UseFont = true;
            this.ReportPage.Appearance.Default.Options.UseForeColor = true;
            this.ReportPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ReportPage.ImageOptions.Image")));
            this.ReportPage.Name = "ReportPage";
            this.ReportPage.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ReportPage.Text = "Relatórios";
            this.ReportPage.Visible = false;
            this.ReportPage.Click += new System.EventHandler(this.ReportPage_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.Appearance.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelPrincipal.Appearance.Options.UseBackColor = true;
            this.panelPrincipal.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelPrincipal.Location = new System.Drawing.Point(141, 37);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1125, 639);
            this.panelPrincipal.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.ControlMenuBar);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormPrincipal.IconOptions.LargeImage")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
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