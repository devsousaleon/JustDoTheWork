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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAtividade));
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            btnEditarTextoAtividade = new DevExpress.XtraEditors.SimpleButton();
            btnFecharCadastroAtividade = new DevExpress.XtraEditors.SimpleButton();
            btnSalvarCadastroAtividade = new DevExpress.XtraEditors.SimpleButton();
            groupDescricaoAtividade = new DevExpress.XtraEditors.GroupControl();
            richEditDescricaoAtividade = new DevExpress.XtraRichEdit.RichEditControl();
            groupInfoAtividade = new DevExpress.XtraEditors.GroupControl();
            comboProjeto = new DevExpress.XtraEditors.LookUpEdit();
            bindingSourceAtividade = new BindingSource(components);
            btnAdicionarProjeto = new DevExpress.XtraEditors.SimpleButton();
            lblProjeto = new DevExpress.XtraEditors.LabelControl();
            lblNomeAtividade = new DevExpress.XtraEditors.LabelControl();
            txtNomeAtividade = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupDescricaoAtividade).BeginInit();
            groupDescricaoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupInfoAtividade).BeginInit();
            groupInfoAtividade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboProjeto.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAtividade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            //
            panelBackground.Controls.Add(btnEditarTextoAtividade);
            panelBackground.Controls.Add(btnFecharCadastroAtividade);
            panelBackground.Controls.Add(btnSalvarCadastroAtividade);
            panelBackground.Controls.Add(groupDescricaoAtividade);
            panelBackground.Controls.Add(groupInfoAtividade);
            panelBackground.Location = new Point(12, 12);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(974, 644);
            panelBackground.TabIndex = 0;
            //
            // btnEditarTextoAtividade
            //
            btnEditarTextoAtividade.Appearance.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarTextoAtividade.Appearance.Options.UseFont = true;
            btnEditarTextoAtividade.Location = new Point(220, 605);
            btnEditarTextoAtividade.Margin = new Padding(8);
            btnEditarTextoAtividade.Name = "btnEditarTextoAtividade";
            btnEditarTextoAtividade.Size = new Size(181, 23);
            btnEditarTextoAtividade.TabIndex = 5;
            btnEditarTextoAtividade.Text = "Editar Texto Atividade";
            btnEditarTextoAtividade.Click += btnEditarTextoAtividade_Click;
            //
            // btnFecharCadastroAtividade
            //
            btnFecharCadastroAtividade.Location = new Point(122, 604);
            btnFecharCadastroAtividade.Margin = new Padding(15);
            btnFecharCadastroAtividade.Name = "btnFecharCadastroAtividade";
            btnFecharCadastroAtividade.Size = new Size(75, 23);
            btnFecharCadastroAtividade.TabIndex = 4;
            btnFecharCadastroAtividade.Text = "Fechar";
            btnFecharCadastroAtividade.Click += btnFecharCadastroAtividade_Click;
            //
            // btnSalvarCadastroAtividade
            //
            btnSalvarCadastroAtividade.Location = new Point(17, 604);
            btnSalvarCadastroAtividade.Margin = new Padding(15);
            btnSalvarCadastroAtividade.Name = "btnSalvarCadastroAtividade";
            btnSalvarCadastroAtividade.Size = new Size(75, 23);
            btnSalvarCadastroAtividade.TabIndex = 3;
            btnSalvarCadastroAtividade.Text = "Incluir";
            btnSalvarCadastroAtividade.Click += btnSalvarCadastroAtividade_Click;
            //
            // groupDescricaoAtividade
            //
            groupDescricaoAtividade.Appearance.BackColor = Color.FromArgb(240, 240, 240);
            groupDescricaoAtividade.Appearance.Options.UseBackColor = true;
            groupDescricaoAtividade.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            groupDescricaoAtividade.AppearanceCaption.Options.UseFont = true;
            groupDescricaoAtividade.Controls.Add(richEditDescricaoAtividade);
            groupDescricaoAtividade.Location = new Point(17, 115);
            groupDescricaoAtividade.Name = "groupDescricaoAtividade";
            groupDescricaoAtividade.Size = new Size(940, 479);
            groupDescricaoAtividade.TabIndex = 3;
            groupDescricaoAtividade.Text = "Informações da atividade";
            //
            // richEditDescricaoAtividade
            //
            richEditDescricaoAtividade.Location = new Point(12, 33);
            richEditDescricaoAtividade.Margin = new Padding(10);
            richEditDescricaoAtividade.Name = "richEditDescricaoAtividade";
            richEditDescricaoAtividade.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            richEditDescricaoAtividade.ReadOnly = true;
            richEditDescricaoAtividade.Size = new Size(916, 431);
            richEditDescricaoAtividade.TabIndex = 19;
            //
            // groupInfoAtividade
            //
            groupInfoAtividade.AppearanceCaption.Font = new Font("Courier New", 9.75F, FontStyle.Bold);
            groupInfoAtividade.AppearanceCaption.Options.UseFont = true;
            groupInfoAtividade.Controls.Add(comboProjeto);
            groupInfoAtividade.Controls.Add(btnAdicionarProjeto);
            groupInfoAtividade.Controls.Add(lblProjeto);
            groupInfoAtividade.Controls.Add(lblNomeAtividade);
            groupInfoAtividade.Controls.Add(txtNomeAtividade);
            groupInfoAtividade.Location = new Point(17, 17);
            groupInfoAtividade.Margin = new Padding(15);
            groupInfoAtividade.Name = "groupInfoAtividade";
            groupInfoAtividade.Size = new Size(940, 80);
            groupInfoAtividade.TabIndex = 2;
            groupInfoAtividade.Text = "Dados da atividade";
            //
            // comboProjeto
            //
            comboProjeto.DataBindings.Add(new Binding("EditValue", bindingSourceAtividade, "ProjetoId", true));
            comboProjeto.Location = new Point(590, 37);
            comboProjeto.Name = "comboProjeto";
            comboProjeto.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboProjeto.Properties.Appearance.Options.UseFont = true;
            comboProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboProjeto.Properties.NullText = "";
            comboProjeto.Size = new Size(302, 32);
            comboProjeto.TabIndex = 1;
            //
            // bindingSourceAtividade
            //
            bindingSourceAtividade.DataSource = typeof(DTO.AtividadeDTO);
            // 
            // btnAdicionarProjeto
            // 
            btnAdicionarProjeto.ImageOptions.Image = (Image)resources.GetObject("btnAdicionarProjeto.ImageOptions.Image");
            btnAdicionarProjeto.Location = new Point(898, 38);
            btnAdicionarProjeto.Name = "btnAdicionarProjeto";
            btnAdicionarProjeto.Size = new Size(24, 23);
            btnAdicionarProjeto.TabIndex = 2;
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
            txtNomeAtividade.DataBindings.Add(new Binding("EditValue", bindingSourceAtividade, "Nome", true));
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
            ClientSize = new Size(998, 664);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Image = (Image)resources.GetObject("FormCadastroAtividade.IconOptions.Image");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroAtividade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Atividade";
            Load += FormCadastroAtividade_Load;
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupDescricaoAtividade).EndInit();
            groupDescricaoAtividade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupInfoAtividade).EndInit();
            groupInfoAtividade.ResumeLayout(false);
            groupInfoAtividade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboProjeto.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAtividade).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNomeAtividade.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraEditors.TextEdit txtNomeAtividade;
        private DevExpress.XtraEditors.LabelControl lblNomeAtividade;
        private DevExpress.XtraEditors.GroupControl groupInfoAtividade;
        private DevExpress.XtraEditors.LabelControl lblProjeto;
        private DevExpress.XtraEditors.GroupControl groupDescricaoAtividade;
        private DevExpress.XtraEditors.SimpleButton btnFecharCadastroAtividade;
        private DevExpress.XtraEditors.SimpleButton btnSalvarCadastroAtividade;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarProjeto;
        private DevExpress.XtraEditors.LookUpEdit comboProjeto;
        private DevExpress.XtraRichEdit.RichEditControl richEditDescricaoAtividade;
        private DevExpress.XtraEditors.SimpleButton btnEditarTextoAtividade;
        private BindingSource bindingSourceAtividade;
    }
}