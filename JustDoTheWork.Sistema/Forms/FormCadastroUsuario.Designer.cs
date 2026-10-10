namespace JustDoTheWork.Sistema.Forms
{
    partial class FormCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
            bindingSourceUsuario = new BindingSource(components);
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            groupInfoUsuario = new DevExpress.XtraEditors.GroupControl();
            lblNomeUsuario = new DevExpress.XtraEditors.LabelControl();
            txtNomeUsuario = new DevExpress.XtraEditors.TextEdit();
            lblLogon = new DevExpress.XtraEditors.LabelControl();
            txtLogon = new DevExpress.XtraEditors.TextEdit();
            lblSenha = new DevExpress.XtraEditors.LabelControl();
            txtSenha = new DevExpress.XtraEditors.TextEdit();
            lblTipoUsuario = new DevExpress.XtraEditors.LabelControl();
            comboTipoUsuario = new DevExpress.XtraEditors.LookUpEdit();
            panelAcoes = new DevExpress.XtraEditors.PanelControl();
            btnSalvarCadastroUsuario = new DevExpress.XtraEditors.SimpleButton();
            btnFecharCadastroUsuario = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupInfoUsuario).BeginInit();
            groupInfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtNomeUsuario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLogon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboTipoUsuario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).BeginInit();
            panelAcoes.SuspendLayout();
            SuspendLayout();
            //
            // bindingSourceUsuario
            //
            bindingSourceUsuario.DataSource = typeof(DTO.UsuarioDTO);
            //
            // panelBackground
            //
            panelBackground.Controls.Add(groupInfoUsuario);
            panelBackground.Controls.Add(panelAcoes);
            panelBackground.Location = new Point(12, 12);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(596, 330);
            panelBackground.TabIndex = 0;
            //
            // groupInfoUsuario
            //
            groupInfoUsuario.Controls.Add(lblNomeUsuario);
            groupInfoUsuario.Controls.Add(txtNomeUsuario);
            groupInfoUsuario.Controls.Add(lblLogon);
            groupInfoUsuario.Controls.Add(txtLogon);
            groupInfoUsuario.Controls.Add(lblSenha);
            groupInfoUsuario.Controls.Add(txtSenha);
            groupInfoUsuario.Controls.Add(lblTipoUsuario);
            groupInfoUsuario.Controls.Add(comboTipoUsuario);
            groupInfoUsuario.Location = new Point(7, 7);
            groupInfoUsuario.Margin = new Padding(5);
            groupInfoUsuario.Name = "groupInfoUsuario";
            groupInfoUsuario.Size = new Size(582, 246);
            groupInfoUsuario.TabIndex = 0;
            groupInfoUsuario.Text = "Informações do Usuário";
            //
            // lblNomeUsuario
            //
            lblNomeUsuario.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeUsuario.Appearance.ForeColor = Color.White;
            lblNomeUsuario.Appearance.Options.UseFont = true;
            lblNomeUsuario.Appearance.Options.UseForeColor = true;
            lblNomeUsuario.Location = new Point(17, 44);
            lblNomeUsuario.Margin = new Padding(15);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(32, 16);
            lblNomeUsuario.TabIndex = 4;
            lblNomeUsuario.Text = "Nome";
            //
            // txtNomeUsuario
            //
            txtNomeUsuario.DataBindings.Add(new Binding("EditValue", bindingSourceUsuario, "Nome", true, DataSourceUpdateMode.OnPropertyChanged));
            txtNomeUsuario.Location = new Point(145, 37);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeUsuario.Properties.Appearance.Options.UseFont = true;
            txtNomeUsuario.Properties.MaxLength = 30;
            txtNomeUsuario.Size = new Size(420, 30);
            txtNomeUsuario.TabIndex = 0;
            //
            // lblLogon
            //
            lblLogon.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogon.Appearance.ForeColor = Color.White;
            lblLogon.Appearance.Options.UseFont = true;
            lblLogon.Appearance.Options.UseForeColor = true;
            lblLogon.Location = new Point(17, 94);
            lblLogon.Margin = new Padding(15);
            lblLogon.Name = "lblLogon";
            lblLogon.Size = new Size(40, 16);
            lblLogon.TabIndex = 5;
            lblLogon.Text = "Logon";
            //
            // txtLogon
            //
            txtLogon.DataBindings.Add(new Binding("EditValue", bindingSourceUsuario, "Logon", true, DataSourceUpdateMode.OnPropertyChanged));
            txtLogon.Location = new Point(145, 87);
            txtLogon.Name = "txtLogon";
            txtLogon.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogon.Properties.Appearance.Options.UseFont = true;
            txtLogon.Properties.MaxLength = 30;
            txtLogon.Size = new Size(420, 30);
            txtLogon.TabIndex = 1;
            //
            // lblSenha
            //
            lblSenha.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Appearance.ForeColor = Color.White;
            lblSenha.Appearance.Options.UseFont = true;
            lblSenha.Appearance.Options.UseForeColor = true;
            lblSenha.Location = new Point(17, 144);
            lblSenha.Margin = new Padding(15);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(40, 16);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            //
            // txtSenha
            //
            txtSenha.DataBindings.Add(new Binding("EditValue", bindingSourceUsuario, "Senha", true, DataSourceUpdateMode.OnPropertyChanged));
            txtSenha.Location = new Point(145, 137);
            txtSenha.Name = "txtSenha";
            txtSenha.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Properties.Appearance.Options.UseFont = true;
            txtSenha.Properties.UseSystemPasswordChar = true;
            txtSenha.Size = new Size(420, 30);
            txtSenha.TabIndex = 2;
            //
            // lblTipoUsuario
            //
            lblTipoUsuario.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.Appearance.ForeColor = Color.White;
            lblTipoUsuario.Appearance.Options.UseFont = true;
            lblTipoUsuario.Appearance.Options.UseForeColor = true;
            lblTipoUsuario.Location = new Point(17, 196);
            lblTipoUsuario.Margin = new Padding(15);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(96, 16);
            lblTipoUsuario.TabIndex = 7;
            lblTipoUsuario.Text = "Tipo usuário";
            //
            // comboTipoUsuario
            //
            comboTipoUsuario.Location = new Point(145, 187);
            comboTipoUsuario.Name = "comboTipoUsuario";
            comboTipoUsuario.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTipoUsuario.Properties.Appearance.Options.UseFont = true;
            comboTipoUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboTipoUsuario.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tipo", "Tipo de usuário") });
            comboTipoUsuario.Properties.DisplayMember = "Tipo";
            comboTipoUsuario.Properties.NullText = "Selecione um tipo de usuário";
            comboTipoUsuario.Properties.PopupSizeable = false;
            comboTipoUsuario.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboTipoUsuario.Properties.ValueMember = "Id";
            comboTipoUsuario.Size = new Size(420, 32);
            comboTipoUsuario.TabIndex = 3;
            //
            // panelAcoes
            //
            panelAcoes.Controls.Add(btnSalvarCadastroUsuario);
            panelAcoes.Controls.Add(btnFecharCadastroUsuario);
            panelAcoes.Location = new Point(7, 263);
            panelAcoes.Margin = new Padding(5);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(582, 57);
            panelAcoes.TabIndex = 1;
            //
            // btnSalvarCadastroUsuario
            //
            btnSalvarCadastroUsuario.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarCadastroUsuario.Appearance.Options.UseFont = true;
            btnSalvarCadastroUsuario.Location = new Point(17, 17);
            btnSalvarCadastroUsuario.Margin = new Padding(15);
            btnSalvarCadastroUsuario.Name = "btnSalvarCadastroUsuario";
            btnSalvarCadastroUsuario.Size = new Size(88, 23);
            btnSalvarCadastroUsuario.TabIndex = 0;
            btnSalvarCadastroUsuario.Text = "Salvar";
            btnSalvarCadastroUsuario.Click += btnSalvarCadastroUsuario_Click;
            //
            // btnFecharCadastroUsuario
            //
            btnFecharCadastroUsuario.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFecharCadastroUsuario.Appearance.Options.UseFont = true;
            btnFecharCadastroUsuario.Location = new Point(135, 17);
            btnFecharCadastroUsuario.Margin = new Padding(15);
            btnFecharCadastroUsuario.Name = "btnFecharCadastroUsuario";
            btnFecharCadastroUsuario.Size = new Size(88, 23);
            btnFecharCadastroUsuario.TabIndex = 1;
            btnFecharCadastroUsuario.Text = "Fechar";
            btnFecharCadastroUsuario.Click += btnFecharCadastroUsuario_Click;
            //
            // FormCadastroUsuario
            //
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 354);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.LargeImage = (Image)resources.GetObject("FormCadastroUsuario.IconOptions.LargeImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            Load += FormCadastroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSourceUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupInfoUsuario).EndInit();
            groupInfoUsuario.ResumeLayout(false);
            groupInfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtNomeUsuario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLogon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboTipoUsuario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).EndInit();
            panelAcoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSourceUsuario;
        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraEditors.GroupControl groupInfoUsuario;
        private DevExpress.XtraEditors.LabelControl lblNomeUsuario;
        private DevExpress.XtraEditors.TextEdit txtNomeUsuario;
        private DevExpress.XtraEditors.LabelControl lblLogon;
        private DevExpress.XtraEditors.TextEdit txtLogon;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LabelControl lblTipoUsuario;
        private DevExpress.XtraEditors.LookUpEdit comboTipoUsuario;
        private DevExpress.XtraEditors.PanelControl panelAcoes;
        private DevExpress.XtraEditors.SimpleButton btnSalvarCadastroUsuario;
        private DevExpress.XtraEditors.SimpleButton btnFecharCadastroUsuario;
    }
}
