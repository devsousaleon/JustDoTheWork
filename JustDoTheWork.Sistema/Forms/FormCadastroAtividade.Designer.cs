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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEditaTextoAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.btnFecharAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvarIncluirAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtEditorAtividade = new DevExpress.XtraRichEdit.RichEditControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboProjeto = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAdicionarProjeto = new DevExpress.XtraEditors.SimpleButton();
            this.lblProjeto = new DevExpress.XtraEditors.LabelControl();
            this.lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEditaTextoAtividade);
            this.panelControl1.Controls.Add(this.btnFecharAtividade);
            this.panelControl1.Controls.Add(this.btnSalvarIncluirAtividade);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(974, 644);
            this.panelControl1.TabIndex = 0;
            // 
            // btnEditaTextoAtividade
            // 
            this.btnEditaTextoAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditaTextoAtividade.Location = new System.Drawing.Point(220, 605);
            this.btnEditaTextoAtividade.Margin = new System.Windows.Forms.Padding(8);
            this.btnEditaTextoAtividade.Name = "btnEditaTextoAtividade";
            this.btnEditaTextoAtividade.Size = new System.Drawing.Size(181, 23);
            this.btnEditaTextoAtividade.TabIndex = 4;
            this.btnEditaTextoAtividade.Text = "Editar Texto Atividade";
            this.btnEditaTextoAtividade.Click += new System.EventHandler(this.btnEditaTextoAtividade_Click);
            // 
            // btnFecharAtividade
            // 
            this.btnFecharAtividade.Location = new System.Drawing.Point(122, 604);
            this.btnFecharAtividade.Margin = new System.Windows.Forms.Padding(15);
            this.btnFecharAtividade.Name = "btnFecharAtividade";
            this.btnFecharAtividade.Size = new System.Drawing.Size(75, 23);
            this.btnFecharAtividade.TabIndex = 5;
            this.btnFecharAtividade.Text = "Fechar";
            this.btnFecharAtividade.Click += new System.EventHandler(this.btnFecharAtividade_Click);
            // 
            // btnSalvarIncluirAtividade
            // 
            this.btnSalvarIncluirAtividade.Location = new System.Drawing.Point(17, 604);
            this.btnSalvarIncluirAtividade.Margin = new System.Windows.Forms.Padding(15);
            this.btnSalvarIncluirAtividade.Name = "btnSalvarIncluirAtividade";
            this.btnSalvarIncluirAtividade.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarIncluirAtividade.TabIndex = 4;
            this.btnSalvarIncluirAtividade.Text = "Incluir";
            this.btnSalvarIncluirAtividade.Click += new System.EventHandler(this.btnIncluirAtividade_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl2.Controls.Add(this.txtEditorAtividade);
            this.groupControl2.Location = new System.Drawing.Point(17, 115);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(940, 479);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Informações da atividade";
            // 
            // txtEditorAtividade
            // 
            this.txtEditorAtividade.Location = new System.Drawing.Point(12, 33);
            this.txtEditorAtividade.Margin = new System.Windows.Forms.Padding(10);
            this.txtEditorAtividade.Name = "txtEditorAtividade";
            this.txtEditorAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            this.txtEditorAtividade.ReadOnly = true;
            this.txtEditorAtividade.Size = new System.Drawing.Size(916, 431);
            this.txtEditorAtividade.TabIndex = 19;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.Controls.Add(this.comboProjeto);
            this.groupControl1.Controls.Add(this.btnAdicionarProjeto);
            this.groupControl1.Controls.Add(this.lblProjeto);
            this.groupControl1.Controls.Add(this.lblNomeAtividade);
            this.groupControl1.Controls.Add(this.txtNomeAtividade);
            this.groupControl1.Location = new System.Drawing.Point(17, 17);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(15);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(940, 80);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Dados da atividade";
            // 
            // comboProjeto
            // 
            this.comboProjeto.Location = new System.Drawing.Point(590, 37);
            this.comboProjeto.Name = "comboProjeto";
            this.comboProjeto.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboProjeto.Properties.NullText = "";
            this.comboProjeto.Size = new System.Drawing.Size(302, 24);
            this.comboProjeto.TabIndex = 9;
            // 
            // btnAdicionarProjeto
            // 
            this.btnAdicionarProjeto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProjeto.ImageOptions.Image")));
            this.btnAdicionarProjeto.Location = new System.Drawing.Point(898, 38);
            this.btnAdicionarProjeto.Name = "btnAdicionarProjeto";
            this.btnAdicionarProjeto.Size = new System.Drawing.Size(24, 23);
            this.btnAdicionarProjeto.TabIndex = 8;
            this.btnAdicionarProjeto.Click += new System.EventHandler(this.btnAdicionarProjeto_Click);
            // 
            // lblProjeto
            // 
            this.lblProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Location = new System.Drawing.Point(507, 43);
            this.lblProjeto.Margin = new System.Windows.Forms.Padding(20);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(70, 18);
            this.lblProjeto.TabIndex = 5;
            this.lblProjeto.Text = "Projeto";
            // 
            // lblNomeAtividade
            // 
            this.lblNomeAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAtividade.Location = new System.Drawing.Point(22, 43);
            this.lblNomeAtividade.Margin = new System.Windows.Forms.Padding(20);
            this.lblNomeAtividade.Name = "lblNomeAtividade";
            this.lblNomeAtividade.Size = new System.Drawing.Size(40, 18);
            this.lblNomeAtividade.TabIndex = 1;
            this.lblNomeAtividade.Text = "Nome";
            // 
            // txtNomeAtividade
            // 
            this.txtNomeAtividade.Location = new System.Drawing.Point(85, 40);
            this.txtNomeAtividade.Name = "txtNomeAtividade";
            this.txtNomeAtividade.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtividade.Properties.MaxLength = 50;
            this.txtNomeAtividade.Size = new System.Drawing.Size(322, 24);
            this.txtNomeAtividade.TabIndex = 0;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 668);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormCadastro.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Atividade";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).EndInit();
            this.ResumeLayout(false);

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