namespace JustDoTheWork.Sistema.Forms
{
    partial class FormVisualizaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizaCadastro));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.DataFinalizacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.DataCriacao = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.comboBoxStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxProjeto = new DevExpress.XtraEditors.LookUpEdit();
            this.lblProjeto = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnAvancar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnFechar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFinalizacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.DarkSlateBlue;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Controls.Add(this.txtDescricao);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(874, 544);
            this.panelControl1.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDescricao.Location = new System.Drawing.Point(6, 185);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(863, 354);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Text = "";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.Silver;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.DataFinalizacao);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.DataCriacao);
            this.groupControl1.Controls.Add(this.comboBoxStatus);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.comboBoxProjeto);
            this.groupControl1.Controls.Add(this.lblProjeto);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtNomeAtividade);
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(864, 173);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Dados da atividade";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(443, 71);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(190, 18);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Data de Finalização";
            this.labelControl4.Visible = false;
            // 
            // DataFinalizacao
            // 
            this.DataFinalizacao.EditValue = null;
            this.DataFinalizacao.Enabled = false;
            this.DataFinalizacao.Location = new System.Drawing.Point(646, 67);
            this.DataFinalizacao.Name = "DataFinalizacao";
            this.DataFinalizacao.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F);
            this.DataFinalizacao.Properties.Appearance.Options.UseFont = true;
            this.DataFinalizacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataFinalizacao.Size = new System.Drawing.Size(213, 24);
            this.DataFinalizacao.TabIndex = 16;
            this.DataFinalizacao.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(483, 33);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 18);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Data de Criação";
            // 
            // DataCriacao
            // 
            this.DataCriacao.EditValue = null;
            this.DataCriacao.Enabled = false;
            this.DataCriacao.Location = new System.Drawing.Point(646, 30);
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F);
            this.DataCriacao.Properties.Appearance.Options.UseFont = true;
            this.DataCriacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataCriacao.Size = new System.Drawing.Size(213, 24);
            this.DataCriacao.TabIndex = 14;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.Location = new System.Drawing.Point(95, 103);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.Properties.Appearance.Options.UseFont = true;
            this.comboBoxStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxStatus.Properties.NullText = "";
            this.comboBoxStatus.Size = new System.Drawing.Size(312, 24);
            this.comboBoxStatus.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 109);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 18);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Status";
            // 
            // comboBoxProjeto
            // 
            this.comboBoxProjeto.Location = new System.Drawing.Point(105, 64);
            this.comboBoxProjeto.Name = "comboBoxProjeto";
            this.comboBoxProjeto.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProjeto.Properties.Appearance.Options.UseFont = true;
            this.comboBoxProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxProjeto.Properties.NullText = "";
            this.comboBoxProjeto.Size = new System.Drawing.Size(302, 24);
            this.comboBoxProjeto.TabIndex = 11;
            // 
            // lblProjeto
            // 
            this.lblProjeto.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblProjeto.Appearance.Options.UseFont = true;
            this.lblProjeto.Appearance.Options.UseForeColor = true;
            this.lblProjeto.Location = new System.Drawing.Point(12, 70);
            this.lblProjeto.Margin = new System.Windows.Forms.Padding(20);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(70, 18);
            this.lblProjeto.TabIndex = 10;
            this.lblProjeto.Text = "Projeto";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nome";
            // 
            // txtNomeAtividade
            // 
            this.txtNomeAtividade.Location = new System.Drawing.Point(65, 27);
            this.txtNomeAtividade.Name = "txtNomeAtividade";
            this.txtNomeAtividade.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAtividade.Properties.Appearance.Options.UseFont = true;
            this.txtNomeAtividade.Size = new System.Drawing.Size(342, 24);
            this.txtNomeAtividade.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnAvancar);
            this.panelControl2.Controls.Add(this.btnExcluir);
            this.panelControl2.Controls.Add(this.btnFechar);
            this.panelControl2.Controls.Add(this.btnSalvar);
            this.panelControl2.Location = new System.Drawing.Point(12, 562);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(874, 43);
            this.panelControl2.TabIndex = 1;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.Appearance.Options.UseFont = true;
            this.btnAvancar.Location = new System.Drawing.Point(283, 10);
            this.btnAvancar.Margin = new System.Windows.Forms.Padding(8);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 2;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Appearance.Options.UseFont = true;
            this.btnExcluir.Location = new System.Drawing.Point(192, 10);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Appearance.Options.UseFont = true;
            this.btnFechar.Location = new System.Drawing.Point(101, 10);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.Location = new System.Drawing.Point(10, 10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormVisualizaCadastro
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 618);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormVisualizaCadastro.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisualizaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualização da atividade";
            this.Load += new System.EventHandler(this.FormVisualizaCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFinalizacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeAtividade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.LookUpEdit comboBoxProjeto;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.LookUpEdit comboBoxStatus;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateTimeOffsetEdit DataCriacao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateTimeOffsetEdit DataFinalizacao;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnFechar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private DevExpress.XtraEditors.SimpleButton btnAvancar;
    }
}