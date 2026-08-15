namespace JustDoTheWork.Sistema.Forms
{
    partial class FormCadastroModeloRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroModeloRelatorio));
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            btnAbreEdicaoModelo = new DevExpress.XtraEditors.SimpleButton();
            btnFecharCadastroModelo = new DevExpress.XtraEditors.SimpleButton();
            btnIncluirCadastroModelo = new DevExpress.XtraEditors.SimpleButton();
            groupTextoModelo = new DevExpress.XtraEditors.GroupControl();
            richEditVisualizaTextoModelo = new DevExpress.XtraRichEdit.RichEditControl();
            groupInfoModelo = new DevExpress.XtraEditors.GroupControl();
            checkAtivo = new DevExpress.XtraEditors.CheckEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            comboTipoModelo = new DevExpress.XtraEditors.LookUpEdit();
            txtDescricaoModelo = new DevExpress.XtraEditors.TextEdit();
            lblDescricaoModelo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupTextoModelo).BeginInit();
            groupTextoModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupInfoModelo).BeginInit();
            groupInfoModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkAtivo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboTipoModelo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricaoModelo.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(panelControl2);
            panelBackground.Controls.Add(groupTextoModelo);
            panelBackground.Controls.Add(groupInfoModelo);
            panelBackground.Location = new Point(12, 12);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(974, 640);
            panelBackground.TabIndex = 0;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(btnAbreEdicaoModelo);
            panelControl2.Controls.Add(btnFecharCadastroModelo);
            panelControl2.Controls.Add(btnIncluirCadastroModelo);
            panelControl2.Location = new Point(7, 576);
            panelControl2.Margin = new Padding(5);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(960, 57);
            panelControl2.TabIndex = 2;
            // 
            // btnAbreEdicaoModelo
            // 
            btnAbreEdicaoModelo.Location = new Point(227, 17);
            btnAbreEdicaoModelo.Margin = new Padding(15);
            btnAbreEdicaoModelo.Name = "btnAbreEdicaoModelo";
            btnAbreEdicaoModelo.Size = new Size(150, 23);
            btnAbreEdicaoModelo.TabIndex = 6;
            btnAbreEdicaoModelo.Text = "Abrir Edição de Modelo";
            btnAbreEdicaoModelo.Click += btnAbreEdicaoModelo_Click;
            // 
            // btnFecharCadastroModelo
            // 
            btnFecharCadastroModelo.Location = new Point(122, 17);
            btnFecharCadastroModelo.Margin = new Padding(15);
            btnFecharCadastroModelo.Name = "btnFecharCadastroModelo";
            btnFecharCadastroModelo.Size = new Size(75, 23);
            btnFecharCadastroModelo.TabIndex = 5;
            btnFecharCadastroModelo.Text = "Fechar";
            btnFecharCadastroModelo.Click += btnFecharCadastroModelo_Click;
            // 
            // btnIncluirCadastroModelo
            // 
            btnIncluirCadastroModelo.Location = new Point(17, 17);
            btnIncluirCadastroModelo.Margin = new Padding(15);
            btnIncluirCadastroModelo.Name = "btnIncluirCadastroModelo";
            btnIncluirCadastroModelo.Size = new Size(75, 23);
            btnIncluirCadastroModelo.TabIndex = 4;
            btnIncluirCadastroModelo.Text = "Incluir";
            btnIncluirCadastroModelo.Click += btnIncluirCadastroModelo_Click;
            // 
            // groupTextoModelo
            // 
            groupTextoModelo.Controls.Add(richEditVisualizaTextoModelo);
            groupTextoModelo.Location = new Point(7, 170);
            groupTextoModelo.Margin = new Padding(5);
            groupTextoModelo.Name = "groupTextoModelo";
            groupTextoModelo.Size = new Size(960, 396);
            groupTextoModelo.TabIndex = 1;
            groupTextoModelo.Text = "Texto";
            // 
            // richEditVisualizaTextoModelo
            // 
            richEditVisualizaTextoModelo.Location = new Point(7, 34);
            richEditVisualizaTextoModelo.Margin = new Padding(5);
            richEditVisualizaTextoModelo.Name = "richEditVisualizaTextoModelo";
            richEditVisualizaTextoModelo.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            richEditVisualizaTextoModelo.ReadOnly = true;
            richEditVisualizaTextoModelo.Size = new Size(946, 355);
            richEditVisualizaTextoModelo.TabIndex = 0;
            // 
            // groupInfoModelo
            // 
            groupInfoModelo.Controls.Add(checkAtivo);
            groupInfoModelo.Controls.Add(labelControl1);
            groupInfoModelo.Controls.Add(comboTipoModelo);
            groupInfoModelo.Controls.Add(txtDescricaoModelo);
            groupInfoModelo.Controls.Add(lblDescricaoModelo);
            groupInfoModelo.Location = new Point(7, 7);
            groupInfoModelo.Margin = new Padding(5);
            groupInfoModelo.Name = "groupInfoModelo";
            groupInfoModelo.Size = new Size(960, 153);
            groupInfoModelo.TabIndex = 0;
            groupInfoModelo.Text = "Informações do Modelo";
            // 
            // checkAtivo
            // 
            checkAtivo.EditValue = true;
            checkAtivo.Location = new Point(442, 41);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            checkAtivo.Properties.Appearance.Options.UseFont = true;
            checkAtivo.Properties.Caption = "Ativo?";
            checkAtivo.Size = new Size(75, 22);
            checkAtivo.TabIndex = 14;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = Color.White;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(17, 96);
            labelControl1.Margin = new Padding(15);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(88, 16);
            labelControl1.TabIndex = 13;
            labelControl1.Text = "Tipo Modelo";
            // 
            // comboTipoModelo
            // 
            comboTipoModelo.Location = new Point(123, 87);
            comboTipoModelo.Name = "comboTipoModelo";
            comboTipoModelo.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTipoModelo.Properties.Appearance.Options.UseFont = true;
            comboTipoModelo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboTipoModelo.Properties.NullText = "";
            comboTipoModelo.Properties.PopupSizeable = false;
            comboTipoModelo.Size = new Size(313, 32);
            comboTipoModelo.TabIndex = 12;
            // 
            // txtDescricaoModelo
            // 
            txtDescricaoModelo.Location = new Point(107, 37);
            txtDescricaoModelo.Name = "txtDescricaoModelo";
            txtDescricaoModelo.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricaoModelo.Properties.Appearance.Options.UseFont = true;
            txtDescricaoModelo.Properties.MaxLength = 50;
            txtDescricaoModelo.Size = new Size(329, 30);
            txtDescricaoModelo.TabIndex = 11;
            // 
            // lblDescricaoModelo
            // 
            lblDescricaoModelo.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricaoModelo.Appearance.ForeColor = Color.White;
            lblDescricaoModelo.Appearance.Options.UseFont = true;
            lblDescricaoModelo.Appearance.Options.UseForeColor = true;
            lblDescricaoModelo.Location = new Point(17, 44);
            lblDescricaoModelo.Margin = new Padding(15);
            lblDescricaoModelo.Name = "lblDescricaoModelo";
            lblDescricaoModelo.Size = new Size(72, 16);
            lblDescricaoModelo.TabIndex = 10;
            lblDescricaoModelo.Text = "Descrição";
            // 
            // FormCadastroModeloRelatorio
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 660);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("FormCadastroModeloRelatorio.IconOptions.LargeImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroModeloRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Modelo Relatório";
            Load += FormCadastroModeloRelatorio_Load;
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupTextoModelo).EndInit();
            groupTextoModelo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupInfoModelo).EndInit();
            groupInfoModelo.ResumeLayout(false);
            groupInfoModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)checkAtivo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboTipoModelo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricaoModelo.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraEditors.GroupControl groupInfoModelo;
        private DevExpress.XtraEditors.GroupControl groupTextoModelo;
        private DevExpress.XtraRichEdit.RichEditControl richEditVisualizaTextoModelo;
        private DevExpress.XtraEditors.CheckEdit checkAtivo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit comboTipoModelo;
        private DevExpress.XtraEditors.TextEdit txtDescricaoModelo;
        private DevExpress.XtraEditors.LabelControl lblDescricaoModelo;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnIncluirCadastroModelo;
        private DevExpress.XtraEditors.SimpleButton btnFecharCadastroModelo;
        private DevExpress.XtraEditors.SimpleButton btnAbreEdicaoModelo;
    }
}