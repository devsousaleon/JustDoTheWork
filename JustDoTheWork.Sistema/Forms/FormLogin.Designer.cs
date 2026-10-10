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
            panelControl = new DevExpress.XtraEditors.PanelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            btnEsqueciSenha = new DevExpress.XtraEditors.SimpleButton();
            btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            lblSenha = new DevExpress.XtraEditors.LabelControl();
            txtSenha = new DevExpress.XtraEditors.TextEdit();
            lblUsuario = new DevExpress.XtraEditors.LabelControl();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            lblCriarExecutarFinalizar = new DevExpress.XtraEditors.LabelControl();
            txtUsuario = new DevExpress.XtraEditors.TextEdit();
            lblJustDoTheWork = new DevExpress.XtraEditors.LabelControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            lblBoasVindas = new DevExpress.XtraEditors.LabelControl();
            btnMinimizar = new DevExpress.XtraEditors.SimpleButton();
            btnFecharSistema = new DevExpress.XtraEditors.SimpleButton();
            timer = new System.Windows.Forms.Timer(components);
            bindingSourceUsuario = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)panelControl).BeginInit();
            panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUsuario).BeginInit();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControl.Controls.Add(panelControl2);
            panelControl.Controls.Add(panelControl1);
            panelControl.Location = new Point(12, 12);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(760, 558);
            panelControl.TabIndex = 0;
            // 
            // panelControl2
            // 
            panelControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControl2.Controls.Add(separatorControl2);
            panelControl2.Controls.Add(btnEsqueciSenha);
            panelControl2.Controls.Add(btnEntrar);
            panelControl2.Controls.Add(lblSenha);
            panelControl2.Controls.Add(txtSenha);
            panelControl2.Controls.Add(lblUsuario);
            panelControl2.Controls.Add(separatorControl1);
            panelControl2.Controls.Add(lblCriarExecutarFinalizar);
            panelControl2.Controls.Add(txtUsuario);
            panelControl2.Controls.Add(lblJustDoTheWork);
            panelControl2.Location = new Point(12, 82);
            panelControl2.Margin = new Padding(10);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new Size(736, 464);
            panelControl2.TabIndex = 4;
            // 
            // separatorControl2
            // 
            separatorControl2.Location = new Point(232, 359);
            separatorControl2.Name = "separatorControl2";
            separatorControl2.Size = new Size(297, 23);
            separatorControl2.TabIndex = 9;
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
            txtSenha.Size = new Size(297, 44);
            txtSenha.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Appearance.Options.UseFont = true;
            lblUsuario.Location = new Point(232, 158);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário";
            // 
            // separatorControl1
            // 
            separatorControl1.Location = new Point(232, 129);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Size = new Size(297, 23);
            separatorControl1.TabIndex = 3;
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
            // txtUsuario
            // 
            txtUsuario.DataBindings.Add(new Binding("EditValue", bindingSourceUsuario, "Logon", true));
            txtUsuario.EditValue = "";
            txtUsuario.Location = new Point(232, 183);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Properties.Appearance.Options.UseFont = true;
            txtUsuario.Properties.ContextImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("txtUsuario.Properties.ContextImageOptions.SvgImage");
            txtUsuario.Properties.NullValuePrompt = "Usuário";
            txtUsuario.Size = new Size(297, 44);
            txtUsuario.TabIndex = 1;
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
            // panelControl1
            // 
            panelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelControl1.Controls.Add(lblBoasVindas);
            panelControl1.Controls.Add(btnMinimizar);
            panelControl1.Controls.Add(btnFecharSistema);
            panelControl1.Location = new Point(12, 12);
            panelControl1.Margin = new Padding(10);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(736, 50);
            panelControl1.TabIndex = 3;
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
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
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
            Controls.Add(panelControl);
            FormBorderStyle = FormBorderStyle.None;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("FormLogin.IconOptions.SvgImage");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl).EndInit();
            panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)separatorControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl;
        private DevExpress.XtraEditors.SimpleButton btnFecharSistema;
        private DevExpress.XtraEditors.SimpleButton btnMinimizar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblCriarExecutarFinalizar;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl lblJustDoTheWork;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton btnEsqueciSenha;
        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.XtraEditors.LabelControl lblBoasVindas;
        private System.Windows.Forms.Timer timer;
        private BindingSource bindingSourceUsuario;
    }
}