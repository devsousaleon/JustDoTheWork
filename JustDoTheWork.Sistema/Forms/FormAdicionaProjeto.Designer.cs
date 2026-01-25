namespace JustDoTheWork.Sistema.Forms
{
    partial class FormAdicionaProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionaProjeto));
            this.txtNomeProjeto = new DevExpress.XtraEditors.TextEdit();
            this.btnIncluirProjeto = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblNomeProjeto = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Location = new System.Drawing.Point(65, 18);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProjeto.Properties.Appearance.Options.UseFont = true;
            this.txtNomeProjeto.Size = new System.Drawing.Size(203, 24);
            this.txtNomeProjeto.TabIndex = 1;
            // 
            // btnIncluirProjeto
            // 
            this.btnIncluirProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirProjeto.Appearance.Options.UseFont = true;
            this.btnIncluirProjeto.Location = new System.Drawing.Point(13, 118);
            this.btnIncluirProjeto.Name = "btnIncluirProjeto";
            this.btnIncluirProjeto.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirProjeto.TabIndex = 2;
            this.btnIncluirProjeto.Text = "Incluir";
            this.btnIncluirProjeto.Click += new System.EventHandler(this.btnIncluirProjeto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Location = new System.Drawing.Point(101, 118);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.DarkSlateBlue;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Controls.Add(this.lblNomeProjeto);
            this.panelControl1.Controls.Add(this.txtNomeProjeto);
            this.panelControl1.Controls.Add(this.btnIncluirProjeto);
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Location = new System.Drawing.Point(10, 10);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(278, 148);
            this.panelControl1.TabIndex = 4;
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblNomeProjeto.Appearance.Options.UseFont = true;
            this.lblNomeProjeto.Location = new System.Drawing.Point(13, 21);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(40, 18);
            this.lblNomeProjeto.TabIndex = 4;
            this.lblNomeProjeto.Text = "Nome";
            // 
            // FormAdicionaProjeto
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 168);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormAdicionaProjeto.IconOptions.Image")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormAdicionaProjeto.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdicionaProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão de Projeto";
            this.Load += new System.EventHandler(this.FormAdicionaProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNomeProjeto;
        private DevExpress.XtraEditors.SimpleButton btnIncluirProjeto;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblNomeProjeto;
    }
}