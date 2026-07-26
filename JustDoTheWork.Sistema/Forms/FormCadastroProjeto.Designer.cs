namespace JustDoTheWork.Sistema.Forms
{
    partial class FormCadastroProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProjeto));
            txtNomeProjeto = new DevExpress.XtraEditors.TextEdit();
            btnIncluirProjeto = new DevExpress.XtraEditors.SimpleButton();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            lblNomeProjeto = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtNomeProjeto.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeProjeto
            // 
            txtNomeProjeto.Location = new Point(76, 19);
            txtNomeProjeto.Margin = new Padding(4, 3, 4, 3);
            txtNomeProjeto.Name = "txtNomeProjeto";
            txtNomeProjeto.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeProjeto.Properties.Appearance.Options.UseFont = true;
            txtNomeProjeto.Properties.MaxLength = 50;
            txtNomeProjeto.Size = new Size(237, 32);
            txtNomeProjeto.TabIndex = 1;
            // 
            // btnIncluirProjeto
            // 
            btnIncluirProjeto.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncluirProjeto.Appearance.Options.UseFont = true;
            btnIncluirProjeto.Location = new Point(15, 127);
            btnIncluirProjeto.Margin = new Padding(4, 3, 4, 3);
            btnIncluirProjeto.Name = "btnIncluirProjeto";
            btnIncluirProjeto.Size = new Size(88, 25);
            btnIncluirProjeto.TabIndex = 2;
            btnIncluirProjeto.Text = "Incluir";
            btnIncluirProjeto.Click += btnIncluirProjeto_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Appearance.Options.UseFont = true;
            btnCancelar.Location = new Point(118, 127);
            btnCancelar.Margin = new Padding(12, 11, 12, 11);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 25);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(lblNomeProjeto);
            panelControl1.Controls.Add(txtNomeProjeto);
            panelControl1.Controls.Add(btnIncluirProjeto);
            panelControl1.Controls.Add(btnCancelar);
            panelControl1.Location = new Point(12, 11);
            panelControl1.Margin = new Padding(1);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(324, 159);
            panelControl1.TabIndex = 4;
            // 
            // lblNomeProjeto
            // 
            lblNomeProjeto.Appearance.Font = new Font("Courier New", 12F);
            lblNomeProjeto.Appearance.Options.UseFont = true;
            lblNomeProjeto.Location = new Point(15, 23);
            lblNomeProjeto.Margin = new Padding(4, 3, 4, 3);
            lblNomeProjeto.Name = "lblNomeProjeto";
            lblNomeProjeto.Size = new Size(40, 18);
            lblNomeProjeto.TabIndex = 4;
            lblNomeProjeto.Text = "Nome";
            // 
            // FormCadastroProjeto
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 181);
            Controls.Add(panelControl1);
            Font = new Font("Courier New", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Image = (Image)resources.GetObject("FormCadastroProjeto.IconOptions.Image");
            IconOptions.LargeImage = (Image)resources.GetObject("FormCadastroProjeto.IconOptions.LargeImage");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProjeto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inclusão de Projeto";
            Load += FormAdicionaProjeto_Load;
            ((System.ComponentModel.ISupportInitialize)txtNomeProjeto.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNomeProjeto;
        private DevExpress.XtraEditors.SimpleButton btnIncluirProjeto;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblNomeProjeto;
    }
}