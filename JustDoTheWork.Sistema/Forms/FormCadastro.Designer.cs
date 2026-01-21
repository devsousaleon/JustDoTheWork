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
            this.btnExcluirAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.btnFecharAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvarIncluirAtividade = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAdicionarProjeto = new DevExpress.XtraEditors.SimpleButton();
            this.lblDataCriacao = new DevExpress.XtraEditors.LabelControl();
            this.DataCriacao = new DevExpress.XtraEditors.DateEdit();
            this.lblProjeto = new DevExpress.XtraEditors.LabelControl();
            this.StatusAtividade = new DevExpress.XtraEditors.LabelControl();
            this.comboStatusAtividade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            this.comboProjeto = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboStatusAtividade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProjeto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExcluirAtividade);
            this.panelControl1.Controls.Add(this.btnFecharAtividade);
            this.panelControl1.Controls.Add(this.btnSalvarIncluirAtividade);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(974, 644);
            this.panelControl1.TabIndex = 0;
            // 
            // btnExcluirAtividade
            // 
            this.btnExcluirAtividade.Location = new System.Drawing.Point(227, 604);
            this.btnExcluirAtividade.Margin = new System.Windows.Forms.Padding(15);
            this.btnExcluirAtividade.Name = "btnExcluirAtividade";
            this.btnExcluirAtividade.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAtividade.TabIndex = 6;
            this.btnExcluirAtividade.Text = "Excluir";
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
            this.btnSalvarIncluirAtividade.Text = "Salvar";
            this.btnSalvarIncluirAtividade.Click += new System.EventHandler(this.btnSalvarIncluirAtividade_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtDescricao);
            this.groupControl2.Location = new System.Drawing.Point(17, 214);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(940, 380);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Informações da atividade";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(17, 38);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(15);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(906, 322);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.Text = "";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboProjeto);
            this.groupControl1.Controls.Add(this.btnAdicionarProjeto);
            this.groupControl1.Controls.Add(this.lblDataCriacao);
            this.groupControl1.Controls.Add(this.DataCriacao);
            this.groupControl1.Controls.Add(this.lblProjeto);
            this.groupControl1.Controls.Add(this.StatusAtividade);
            this.groupControl1.Controls.Add(this.comboStatusAtividade);
            this.groupControl1.Controls.Add(this.lblNomeAtividade);
            this.groupControl1.Controls.Add(this.txtNomeAtividade);
            this.groupControl1.Location = new System.Drawing.Point(17, 17);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(15);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(940, 179);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Dados da atividade";
            // 
            // btnAdicionarProjeto
            // 
            this.btnAdicionarProjeto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProjeto.ImageOptions.Image")));
            this.btnAdicionarProjeto.Location = new System.Drawing.Point(413, 134);
            this.btnAdicionarProjeto.Name = "btnAdicionarProjeto";
            this.btnAdicionarProjeto.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAdicionarProjeto.Size = new System.Drawing.Size(24, 23);
            this.btnAdicionarProjeto.TabIndex = 8;
            this.btnAdicionarProjeto.Click += new System.EventHandler(this.btnAdicionarProjeto_Click);
            // 
            // lblDataCriacao
            // 
            this.lblDataCriacao.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCriacao.Appearance.Options.UseFont = true;
            this.lblDataCriacao.Location = new System.Drawing.Point(600, 43);
            this.lblDataCriacao.Margin = new System.Windows.Forms.Padding(20);
            this.lblDataCriacao.Name = "lblDataCriacao";
            this.lblDataCriacao.Size = new System.Drawing.Size(90, 18);
            this.lblDataCriacao.TabIndex = 7;
            this.lblDataCriacao.Text = "Criado em";
            // 
            // DataCriacao
            // 
            this.DataCriacao.EditValue = null;
            this.DataCriacao.Location = new System.Drawing.Point(725, 40);
            this.DataCriacao.Margin = new System.Windows.Forms.Padding(15);
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataCriacao.Properties.Appearance.Options.UseFont = true;
            this.DataCriacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataCriacao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataCriacao.Size = new System.Drawing.Size(198, 24);
            this.DataCriacao.TabIndex = 6;
            // 
            // lblProjeto
            // 
            this.lblProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Appearance.Options.UseFont = true;
            this.lblProjeto.Location = new System.Drawing.Point(22, 139);
            this.lblProjeto.Margin = new System.Windows.Forms.Padding(20);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(70, 18);
            this.lblProjeto.TabIndex = 5;
            this.lblProjeto.Text = "Projeto";
            // 
            // StatusAtividade
            // 
            this.StatusAtividade.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusAtividade.Appearance.Options.UseFont = true;
            this.StatusAtividade.Location = new System.Drawing.Point(22, 97);
            this.StatusAtividade.Margin = new System.Windows.Forms.Padding(20);
            this.StatusAtividade.Name = "StatusAtividade";
            this.StatusAtividade.Size = new System.Drawing.Size(60, 18);
            this.StatusAtividade.TabIndex = 3;
            this.StatusAtividade.Text = "Status";
            // 
            // comboStatusAtividade
            // 
            this.comboStatusAtividade.Location = new System.Drawing.Point(105, 91);
            this.comboStatusAtividade.Name = "comboStatusAtividade";
            this.comboStatusAtividade.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatusAtividade.Properties.Appearance.Options.UseFont = true;
            this.comboStatusAtividade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboStatusAtividade.Size = new System.Drawing.Size(302, 24);
            this.comboStatusAtividade.TabIndex = 2;
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
            // comboProjeto
            // 
            this.comboProjeto.Location = new System.Drawing.Point(105, 133);
            this.comboProjeto.Name = "comboProjeto";
            this.comboProjeto.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProjeto.Properties.Appearance.Options.UseFont = true;
            this.comboProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboProjeto.Properties.NullText = "";
            this.comboProjeto.Size = new System.Drawing.Size(302, 24);
            this.comboProjeto.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboStatusAtividade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboProjeto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.LabelControl lblNomeAtividade;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl StatusAtividade;
        private DevExpress.XtraEditors.ComboBoxEdit comboStatusAtividade;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LabelControl lblDataCriacao;
        private DevExpress.XtraEditors.DateEdit DataCriacao;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnExcluirAtividade;
        private DevExpress.XtraEditors.SimpleButton btnFecharAtividade;
        private DevExpress.XtraEditors.SimpleButton btnSalvarIncluirAtividade;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarProjeto;
        private DevExpress.XtraEditors.LookUpEdit comboProjeto;
    }
}