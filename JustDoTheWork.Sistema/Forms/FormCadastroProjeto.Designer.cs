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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProjeto));
            txtNomeProjeto = new DevExpress.XtraEditors.TextEdit();
            btnSalvarCadastroProjeto = new DevExpress.XtraEditors.SimpleButton();
            btnFecharCadastroProjeto = new DevExpress.XtraEditors.SimpleButton();
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            lblNomeProjeto = new DevExpress.XtraEditors.LabelControl();
            bindingSourceProjeto = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)txtNomeProjeto.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProjeto).BeginInit();
            SuspendLayout();
            // 
            // txtNomeProjeto
            // 
            txtNomeProjeto.DataBindings.Add(new Binding("EditValue", bindingSourceProjeto, "Nome", true));
            txtNomeProjeto.Location = new Point(76, 19);
            txtNomeProjeto.Margin = new Padding(4, 3, 4, 3);
            txtNomeProjeto.Name = "txtNomeProjeto";
            txtNomeProjeto.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeProjeto.Properties.Appearance.Options.UseFont = true;
            txtNomeProjeto.Properties.MaxLength = 50;
            txtNomeProjeto.Size = new Size(237, 32);
            txtNomeProjeto.TabIndex = 0;
            // 
            // btnSalvarCadastroProjeto
            // 
            btnSalvarCadastroProjeto.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarCadastroProjeto.Appearance.Options.UseFont = true;
            btnSalvarCadastroProjeto.Location = new Point(12, 122);
            btnSalvarCadastroProjeto.Margin = new Padding(10);
            btnSalvarCadastroProjeto.Name = "btnSalvarCadastroProjeto";
            btnSalvarCadastroProjeto.Size = new Size(88, 25);
            btnSalvarCadastroProjeto.TabIndex = 1;
            btnSalvarCadastroProjeto.Text = "Incluir";
            btnSalvarCadastroProjeto.Click += btnSalvarCadastroProjeto_Click;
            // 
            // btnFecharCadastroProjeto
            // 
            btnFecharCadastroProjeto.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFecharCadastroProjeto.Appearance.Options.UseFont = true;
            btnFecharCadastroProjeto.Location = new Point(120, 122);
            btnFecharCadastroProjeto.Margin = new Padding(10);
            btnFecharCadastroProjeto.Name = "btnFecharCadastroProjeto";
            btnFecharCadastroProjeto.Size = new Size(88, 25);
            btnFecharCadastroProjeto.TabIndex = 2;
            btnFecharCadastroProjeto.Text = "Cancelar";
            btnFecharCadastroProjeto.Click += btnFecharCadastroProjeto_Click;
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(lblNomeProjeto);
            panelBackground.Controls.Add(txtNomeProjeto);
            panelBackground.Controls.Add(btnSalvarCadastroProjeto);
            panelBackground.Controls.Add(btnFecharCadastroProjeto);
            panelBackground.Location = new Point(12, 11);
            panelBackground.Margin = new Padding(1);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(324, 159);
            panelBackground.TabIndex = 4;
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
            // bindingSourceProjeto
            // 
            bindingSourceProjeto.DataSource = typeof(DTO.ProjetoDTO);
            // 
            // FormCadastroProjeto
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 179);
            Controls.Add(panelBackground);
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
            ((System.ComponentModel.ISupportInitialize)txtNomeProjeto.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProjeto).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNomeProjeto;
        private DevExpress.XtraEditors.SimpleButton btnSalvarCadastroProjeto;
        private DevExpress.XtraEditors.SimpleButton btnFecharCadastroProjeto;
        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraEditors.LabelControl lblNomeProjeto;
        private BindingSource bindingSourceProjeto;
    }
}