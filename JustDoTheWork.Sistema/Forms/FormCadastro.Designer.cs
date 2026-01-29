namespace JustDoTheWork.Sistema.Forms
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnFecharAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvarIncluirAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
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
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnFecharAtividade);
            this.panelControl1.Controls.Add(this.btnSalvarIncluirAtividade);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(974, 644);
            this.panelControl1.TabIndex = 0;
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
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl2.AppearanceCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl2.AppearanceCaption.BorderColor = System.Drawing.Color.Silver;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.txtDescricao);
            this.groupControl2.Location = new System.Drawing.Point(17, 115);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(940, 479);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Informações da atividade";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDescricao.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtDescricao.Location = new System.Drawing.Point(17, 38);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(15);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(906, 421);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.Silver;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
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
            this.comboProjeto.Properties.Appearance.Options.UseFont = true;
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
            this.btnAdicionarProjeto.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAdicionarProjeto.Size = new System.Drawing.Size(24, 23);
            this.btnAdicionarProjeto.TabIndex = 8;
            this.btnAdicionarProjeto.Click += new System.EventHandler(this.btnAdicionarProjeto_Click);
            // 
            // lblProjeto
            // 
            this.lblProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Appearance.Options.UseFont = true;
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
            this.lblNomeAtividade.Appearance.Options.UseFont = true;
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
            this.txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            this.txtNomeAtividade.Size = new System.Drawing.Size(322, 24);
            this.txtNomeAtividade.TabIndex = 0;
            // 
            // FormCadastro
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
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
        private System.Windows.Forms.RichTextBox txtDescricao;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarProjeto;
        private DevExpress.XtraEditors.LookUpEdit comboProjeto;
    }
}