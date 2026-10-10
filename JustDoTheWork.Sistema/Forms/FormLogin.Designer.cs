namespace JustDoTheWork.Sistema.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            panelLogin = new DevExpress.XtraEditors.PanelControl();
            separatorSenha = new DevExpress.XtraEditors.SeparatorControl();
            btnEsqueciSenha = new DevExpress.XtraEditors.SimpleButton();
            btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            lblSenha = new DevExpress.XtraEditors.LabelControl();
            txtSenha = new DevExpress.XtraEditors.TextEdit();
            lblLogon = new DevExpress.XtraEditors.LabelControl();
            separatorUsuario = new DevExpress.XtraEditors.SeparatorControl();
            lblCriarExecutarFinalizar = new DevExpress.XtraEditors.LabelControl();
            txtLogon = new DevExpress.XtraEditors.TextEdit();
            lblJustDoTheWork = new DevExpress.XtraEditors.LabelControl();
            panelCabecalho = new DevExpress.XtraEditors.PanelControl();
            lblBoasVindas = new DevExpress.XtraEditors.LabelControl();
            btnMinimizar = new DevExpress.XtraEditors.SimpleButton();
            btnFecharSistema = new DevExpress.XtraEditors.SimpleButton();
            timerBoasVindas = new System.Windows.Forms.Timer(components);
            bindingSourceUsuario = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelLogin).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLogon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelCabecalho).BeginInit();
            panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUsuario).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            //
            panelBackground.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBackground.Controls.Add(panelLogin);
            panelBackground.Controls.Add(panelCabecalho);
            panelBackground.Location = new Point(12, 12);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(760, 558);
            panelBackground.TabIndex = 0;
            //
            // panelLogin
            //
            panelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLogin.Controls.Add(separatorSenha);
            panelLogin.Controls.Add(btnEsqueciSenha);
            panelLogin.Controls.Add(btnEntrar);
            panelLogin.Controls.Add(lblSenha);
            panelLogin.Controls.Add(txtSenha);
            panelLogin.Controls.Add(lblLogon);
            panelLogin.Controls.Add(separatorUsuario);
            panelLogin.Controls.Add(lblCriarExecutarFinalizar);
            panelLogin.Controls.Add(txtLogon);
            panelLogin.Controls.Add(lblJustDoTheWork);
            panelLogin.Location = new Point(12, 82);
            panelLogin.Margin = new Padding(10);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(736, 464);
            panelLogin.TabIndex = 4;
            //
            // separatorSenha
            //
            separatorSenha.Location = new Point(232, 359);
            separatorSenha.Name = "separatorSenha";
            separatorSenha.Size = new Size(297, 23);
            separatorSenha.TabIndex = 9;
            // 
            // btnEsqueciSenha
            // 
            btnEsqueciSenha.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEsqueciSenha.Appearance.Options.UseFont = true;
            btnEsqueciSenha.Location = new Point(232, 395);
            btnEsqueciSenha.Margin = new Padding(10);
            btnEsqueciSenha.Name = "btnEsqueciSenha";
            btnEsqueciSenha.Size = new Size(297, 30);
            btnEsqueciSenha.TabIndex = 8;
            btnEsqueciSenha.Text = "Esqueci minha senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Appearance.Options.UseFont = true;
            btnEntrar.Location = new Point(232, 315);
            btnEntrar.Margin = new Padding(10);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(297, 30);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblSenha
            // 
            lblSenha.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Appearance.Options.UseFont = true;
            lblSenha.Location = new Point(232, 233);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(50, 19);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.DataBindings.Add(new Binding("EditValue", bindingSourceUsuario, "Senha", true));
            txtSenha.EditValue = "";
            txtSenha.Location = new Point(232, 258);
            txtSenha.Name = "txtSenha";
            txtSenha.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSenha.Properties.Appearance.Options.UseFont = true;
            txtSenha.Properties.ContextImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("txtSenha.Properties.ContextImageOptions.SvgImage");
            txtSenha.Properties.NullValuePrompt = "Senha";
            txtSenha.Properties.UseSystemPasswordChar = true;
            txtSenha.Size = new Size(297, 44);
            txtSenha.TabIndex = 5;
            // 
            // lblLogon
            // 
            lblLogon.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogon.Appearance.Options.UseFont = true;
            lblLogon.Location = new Point(232, 158);
            lblLogon.Name = "lblLogon";
            lblLogon.Size = new Size(62, 19);
            lblLogon.TabIndex = 4;
            lblLogon.Text = "Usuário";
            // 
            // separatorUsuario
            // 
            separatorUsuario.Location = new Point(232, 129);
            separatorUsuario.Name = "separatorUsuario";
            separatorUsuario.Size = new Size(297, 23);
            separatorUsuario.TabIndex = 3;
            // 
            // lblCriarExecutarFinalizar
            // 
            lblCriarExecutarFinalizar.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriarExecutarFinalizar.Appearance.Options.UseFont = true;
            lblCriarExecutarFinalizar.Location = new Point(299, 110);
            lblCriarExecutarFinalizar.Name = "lblCriarExecutarFinalizar";
            lblCriarExecutarFinalizar.Size = new Size(163, 13);
            lblCriarExecutarFinalizar.TabIndex = 2;
            lblCriarExecutarFinalizar.Text = "Criar.     Executar.     Finalizar.";
            // 
            // txtLogon
            // 
            txtLogon.DataBindings.Add(new Binding("EditValue", bindingSourceUsuario, "Logon", true));
            txtLogon.EditValue = "";
            txtLogon.Location = new Point(232, 183);
            txtLogon.Name = "txtLogon";
            txtLogon.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLogon.Properties.Appearance.Options.UseFont = true;
            txtLogon.Properties.ContextImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("txtLogon.Properties.ContextImageOptions.SvgImage");
            txtLogon.Properties.NullValuePrompt = "Usuário";
            txtLogon.Size = new Size(297, 44);
            txtLogon.TabIndex = 1;
            // 
            // lblJustDoTheWork
            // 
            lblJustDoTheWork.Appearance.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJustDoTheWork.Appearance.Options.UseFont = true;
            lblJustDoTheWork.Location = new Point(232, 59);
            lblJustDoTheWork.Name = "lblJustDoTheWork";
            lblJustDoTheWork.Size = new Size(297, 45);
            lblJustDoTheWork.TabIndex = 0;
            lblJustDoTheWork.Text = "JustDoTheWork";
            // 
            // panelCabecalho
            // 
            panelCabecalho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCabecalho.Controls.Add(lblBoasVindas);
            panelCabecalho.Controls.Add(btnMinimizar);
            panelCabecalho.Controls.Add(btnFecharSistema);
            panelCabecalho.Location = new Point(12, 12);
            panelCabecalho.Margin = new Padding(10);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(736, 50);
            panelCabecalho.TabIndex = 3;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.Appearance.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVindas.Appearance.Options.UseFont = true;
            lblBoasVindas.Location = new Point(12, 12);
            lblBoasVindas.Margin = new Padding(10);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(163, 25);
            lblBoasVindas.TabIndex = 3;
            lblBoasVindas.Text = "Seja Bem Vindo";
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Appearance.BorderColor = Color.Transparent;
            btnMinimizar.Appearance.Options.UseBorderColor = true;
            btnMinimizar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnMinimizar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnMinimizar.ImageOptions.SvgImage");
            btnMinimizar.Location = new Point(644, 8);
            btnMinimizar.Margin = new Padding(10);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnFecharSistema
            // 
            btnFecharSistema.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFecharSistema.Appearance.BorderColor = Color.Transparent;
            btnFecharSistema.Appearance.Options.UseBorderColor = true;
            btnFecharSistema.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnFecharSistema.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnFecharSistema.ImageOptions.SvgImage");
            btnFecharSistema.Location = new Point(694, 8);
            btnFecharSistema.Margin = new Padding(10);
            btnFecharSistema.Name = "btnFecharSistema";
            btnFecharSistema.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnFecharSistema.Size = new Size(30, 30);
            btnFecharSistema.TabIndex = 0;
            btnFecharSistema.Click += btnFecharSistema_Click;
            // 
            // timerBoasVindas
            // 
            timerBoasVindas.Enabled = true;
            timerBoasVindas.Interval = 1000;
            timerBoasVindas.Tick += timerBoasVindas_Tick;
            // 
            // bindingSourceUsuario
            // 
            bindingSourceUsuario.DataSource = typeof(DTO.UsuarioDTO);
            // 
            // FormLogin
            // 
            Appearance.ForeColor = Color.Transparent;
            Appearance.Options.UseForeColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 582);
            ControlBox = false;
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.None;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("FormLogin.IconOptions.SvgImage");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelLogin).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLogon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelCabecalho).EndInit();
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraEditors.SimpleButton btnFecharSistema;
        private DevExpress.XtraEditors.SimpleButton btnMinimizar;
        private DevExpress.XtraEditors.PanelControl panelCabecalho;
        private DevExpress.XtraEditors.PanelControl panelLogin;
        private DevExpress.XtraEditors.LabelControl lblCriarExecutarFinalizar;
        private DevExpress.XtraEditors.TextEdit txtLogon;
        private DevExpress.XtraEditors.LabelControl lblJustDoTheWork;
        private DevExpress.XtraEditors.LabelControl lblLogon;
        private DevExpress.XtraEditors.SeparatorControl separatorUsuario;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.SeparatorControl separatorSenha;
        private DevExpress.XtraEditors.SimpleButton btnEsqueciSenha;
        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.XtraEditors.LabelControl lblBoasVindas;
        private System.Windows.Forms.Timer timerBoasVindas;
        private BindingSource bindingSourceUsuario;
    }
}