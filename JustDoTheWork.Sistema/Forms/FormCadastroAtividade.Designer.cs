namespace JustDoTheWork.Sistema.Forms
{
    partial class FormCadastroAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAtividade));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnEditaTextoAtividade = new DevExpress.XtraEditors.SimpleButton();
            btnFecharAtividade = new DevExpress.XtraEditors.SimpleButton();
            btnSalvarIncluirAtividade = new DevExpress.XtraEditors.SimpleButton();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            txtEditorAtividade = new DevExpress.XtraRichEdit.RichEditControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            comboProjeto = new DevExpress.XtraEditors.LookUpEdit();
            btnAdicionarProjeto = new DevExpress.XtraEditors.SimpleButton();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboProjeto.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnEditaTextoAtividade);
            panelControl1.Controls.Add(btnFecharAtividade);
            panelControl1.Controls.Add(btnSalvarIncluirAtividade);
            panelControl1.Controls.Add(groupControl2);
            panelControl1.Controls.Add(groupControl1);
            panelControl1.Location = new Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(974, 644);
            panelControl1.TabIndex = 0;
            // 
            // btnEditaTextoAtividade
            // 
            btnEditaTextoAtividade.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditaTextoAtividade.Appearance.Options.UseFont = true;
            btnEditaTextoAtividade.Location = new Point(220, 605);
            btnEditaTextoAtividade.Margin = new Padding(8);
            btnEditaTextoAtividade.Name = "btnEditaTextoAtividade";
            btnEditaTextoAtividade.Size = new Size(181, 23);
            btnEditaTextoAtividade.TabIndex = 4;
            btnEditaTextoAtividade.Text = "Editar Texto Atividade";
            btnEditaTextoAtividade.Click += btnEditaTextoAtividade_Click;
            // 
            // btnFecharAtividade
            // 
            btnFecharAtividade.Location = new Point(122, 604);
            btnFecharAtividade.Margin = new Padding(15);
            btnFecharAtividade.Name = "btnFecharAtividade";
            btnFecharAtividade.Size = new Size(75, 23);
            btnFecharAtividade.TabIndex = 5;
            btnFecharAtividade.Text = "Fechar";
            btnFecharAtividade.Click += btnFecharAtividade_Click;
            // 
            // btnSalvarIncluirAtividade
            // 
            btnSalvarIncluirAtividade.Location = new Point(17, 604);
            btnSalvarIncluirAtividade.Margin = new Padding(15);
            btnSalvarIncluirAtividade.Name = "btnSalvarIncluirAtividade";
            btnSalvarIncluirAtividade.Size = new Size(75, 23);
            btnSalvarIncluirAtividade.TabIndex = 4;
            btnSalvarIncluirAtividade.Text = "Incluir";
            btnSalvarIncluirAtividade.Click += btnIncluirAtividade_Click;
            // 
            // groupControl2
            // 
            groupControl2.Appearance.BackColor = Color.FromArgb(240, 240, 240);
            groupControl2.Appearance.Options.UseBackColor = true;
            groupControl2.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            groupControl2.AppearanceCaption.Options.UseFont = true;
            groupControl2.Controls.Add(txtEditorAtividade);
            groupControl2.Location = new Point(17, 115);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(940, 479);
            groupControl2.TabIndex = 3;
            groupControl2.Text = "Informações da atividade";
            // 
            // txtEditorAtividade
            // 
            txtEditorAtividade.Location = new Point(12, 33);
            txtEditorAtividade.Margin = new Padding(10);
            txtEditorAtividade.Name = "txtEditorAtividade";
            txtEditorAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            txtEditorAtividade.ReadOnly = true;
            txtEditorAtividade.Size = new Size(916, 431);
            txtEditorAtividade.TabIndex = 19;
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(comboProjeto);
            groupControl1.Controls.Add(btnAdicionarProjeto);
            groupControl1.Controls.Add(lblProjeto);
            groupControl1.Controls.Add(lblNomeAtividade);
            groupControl1.Controls.Add(txtNomeAtividade);
            groupControl1.Location = new Point(17, 17);
            groupControl1.Margin = new Padding(15);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(940, 80);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "Dados da atividade";
            // 
            // comboProjeto
            // 
            comboProjeto.Location = new Point(590, 37);
            comboProjeto.Name = "comboProjeto";
            comboProjeto.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjeto.Properties.Appearance.Options.UseFont = true;
            comboProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboProjeto.Properties.NullText = "";
            comboProjeto.Size = new Size(302, 32);
            comboProjeto.TabIndex = 9;
            // 
            // btnAdicionarProjeto
            // 
            btnAdicionarProjeto.ImageOptions.Image = (Image)resources.GetObject("btnAdicionarProjeto.ImageOptions.Image");
            btnAdicionarProjeto.Location = new Point(898, 38);
            btnAdicionarProjeto.Name = "btnAdicionarProjeto";
            btnAdicionarProjeto.Size = new Size(24, 23);
            btnAdicionarProjeto.TabIndex = 8;
            btnAdicionarProjeto.Click += btnAdicionarProjeto_Click;
            // 
            // lblProjeto
            // 
            lblProjeto.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProjeto.Appearance.Options.UseFont = true;
            lblProjeto.Location = new Point(507, 43);
            lblProjeto.Margin = new Padding(20);
            lblProjeto.Name = "lblProjeto";
            lblProjeto.Size = new Size(70, 18);
            lblProjeto.TabIndex = 5;
            lblProjeto.Text = "Projeto";
            // 
            // lblNomeAtividade
            // 
            lblNomeAtividade.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeAtividade.Appearance.Options.UseFont = true;
            lblNomeAtividade.Location = new Point(22, 43);
            lblNomeAtividade.Margin = new Padding(20);
            lblNomeAtividade.Name = "lblNomeAtividade";
            lblNomeAtividade.Size = new Size(40, 18);
            lblNomeAtividade.TabIndex = 1;
            lblNomeAtividade.Text = "Nome";
            // 
            // txtNomeAtividade
            // 
            txtNomeAtividade.Location = new Point(85, 40);
            txtNomeAtividade.Name = "txtNomeAtividade";
            txtNomeAtividade.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            txtNomeAtividade.Properties.MaxLength = 50;
            txtNomeAtividade.Size = new Size(322, 32);
            txtNomeAtividade.TabIndex = 0;
            // 
            // FormCadastroAtividade
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 668);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Image = (Image)resources.GetObject("FormCadastroAtividade.IconOptions.Image");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroAtividade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Atividade";
            Load += FormRegister_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboProjeto.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.LabelControl lblNomeAtividade;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnFecharAtividade;
        private DevExpress.XtraEditors.SimpleButton btnSalvarIncluirAtividade;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarProjeto;
        private DevExpress.XtraEditors.LookUpEdit comboProjeto;
        private DevExpress.XtraRichEdit.RichEditControl txtEditorAtividade;
        private DevExpress.XtraEditors.SimpleButton btnEditaTextoAtividade;
    }
}