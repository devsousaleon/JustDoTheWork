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
            this.lblNomeProjeto = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeProjeto = new DevExpress.XtraEditors.TextEdit();
            this.btnIncluirProjeto = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProjeto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProjeto.Appearance.Options.UseFont = true;
            this.lblNomeProjeto.Location = new System.Drawing.Point(24, 24);
            this.lblNomeProjeto.Margin = new System.Windows.Forms.Padding(15);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(40, 18);
            this.lblNomeProjeto.TabIndex = 0;
            this.lblNomeProjeto.Text = "Nome";
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Location = new System.Drawing.Point(83, 21);
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
            this.btnIncluirProjeto.Location = new System.Drawing.Point(12, 133);
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
            this.btnCancelar.Location = new System.Drawing.Point(100, 133);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormAdicionaProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 168);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluirProjeto);
            this.Controls.Add(this.txtNomeProjeto);
            this.Controls.Add(this.lblNomeProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdicionaProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão de Projeto";
            this.Load += new System.EventHandler(this.FormAdicionaProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProjeto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblNomeProjeto;
        private DevExpress.XtraEditors.TextEdit txtNomeProjeto;
        private DevExpress.XtraEditors.SimpleButton btnIncluirProjeto;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}