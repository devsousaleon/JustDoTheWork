namespace JustDoTheWork.Sistema.Forms
{
    partial class FormConfiguracaoBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracaoBanco));
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            btnTestarConexao = new DevExpress.XtraEditors.SimpleButton();
            btnFecharConfiguracaoBanco = new DevExpress.XtraEditors.SimpleButton();
            btnSalvarConfiguracaoBanco = new DevExpress.XtraEditors.SimpleButton();
            lblSenhaBanco = new DevExpress.XtraEditors.LabelControl();
            txtSenhaBanco = new DevExpress.XtraEditors.TextEdit();
            bindingSourceBanco = new BindingSource(components);
            lblUsuarioBanco = new DevExpress.XtraEditors.LabelControl();
            txtUsuarioBanco = new DevExpress.XtraEditors.TextEdit();
            lblBanco = new DevExpress.XtraEditors.LabelControl();
            txtBanco = new DevExpress.XtraEditors.TextEdit();
            lblServidor = new DevExpress.XtraEditors.LabelControl();
            txtServidor = new DevExpress.XtraEditors.TextEdit();
            lblTipoBanco = new DevExpress.XtraEditors.LabelControl();
            comboTipoBanco = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSenhaBanco.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceBanco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuarioBanco.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBanco.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtServidor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboTipoBanco.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(btnTestarConexao);
            panelBackground.Controls.Add(btnFecharConfiguracaoBanco);
            panelBackground.Controls.Add(btnSalvarConfiguracaoBanco);
            panelBackground.Controls.Add(lblSenhaBanco);
            panelBackground.Controls.Add(txtSenhaBanco);
            panelBackground.Controls.Add(lblUsuarioBanco);
            panelBackground.Controls.Add(txtUsuarioBanco);
            panelBackground.Controls.Add(lblBanco);
            panelBackground.Controls.Add(txtBanco);
            panelBackground.Controls.Add(lblServidor);
            panelBackground.Controls.Add(txtServidor);
            panelBackground.Controls.Add(lblTipoBanco);
            panelBackground.Controls.Add(comboTipoBanco);
            panelBackground.Location = new Point(12, 12);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(574, 217);
            panelBackground.TabIndex = 0;
            // 
            // btnTestarConexao
            // 
            btnTestarConexao.Location = new Point(202, 183);
            btnTestarConexao.Margin = new Padding(10);
            btnTestarConexao.Name = "btnTestarConexao";
            btnTestarConexao.Size = new Size(110, 23);
            btnTestarConexao.TabIndex = 12;
            btnTestarConexao.Text = "Testar Conexão";
            btnTestarConexao.Click += btnTestarConexao_Click;
            // 
            // btnFecharConfiguracaoBanco
            // 
            btnFecharConfiguracaoBanco.Location = new Point(107, 183);
            btnFecharConfiguracaoBanco.Margin = new Padding(10);
            btnFecharConfiguracaoBanco.Name = "btnFecharConfiguracaoBanco";
            btnFecharConfiguracaoBanco.Size = new Size(75, 23);
            btnFecharConfiguracaoBanco.TabIndex = 11;
            btnFecharConfiguracaoBanco.Text = "Cancelar";
            btnFecharConfiguracaoBanco.Click += btnFecharConfiguracaoBanco_Click;
            // 
            // btnSalvarConfiguracaoBanco
            // 
            btnSalvarConfiguracaoBanco.Location = new Point(12, 182);
            btnSalvarConfiguracaoBanco.Margin = new Padding(10);
            btnSalvarConfiguracaoBanco.Name = "btnSalvarConfiguracaoBanco";
            btnSalvarConfiguracaoBanco.Size = new Size(75, 23);
            btnSalvarConfiguracaoBanco.TabIndex = 10;
            btnSalvarConfiguracaoBanco.Text = "Salvar";
            btnSalvarConfiguracaoBanco.Click += btnSalvarConfiguracaoBanco_Click;
            // 
            // lblSenhaBanco
            // 
            lblSenhaBanco.Location = new Point(332, 127);
            lblSenhaBanco.Margin = new Padding(10);
            lblSenhaBanco.Name = "lblSenhaBanco";
            lblSenhaBanco.Size = new Size(30, 13);
            lblSenhaBanco.TabIndex = 9;
            lblSenhaBanco.Text = "Senha";
            // 
            // txtSenhaBanco
            // 
            txtSenhaBanco.DataBindings.Add(new Binding("EditValue", bindingSourceBanco, "Senha", true));
            txtSenhaBanco.Location = new Point(388, 120);
            txtSenhaBanco.Margin = new Padding(10);
            txtSenhaBanco.Name = "txtSenhaBanco";
            txtSenhaBanco.Properties.UseSystemPasswordChar = true;
            txtSenhaBanco.Size = new Size(174, 28);
            txtSenhaBanco.TabIndex = 8;
            // 
            // bindingSourceBanco
            // 
            bindingSourceBanco.DataSource = typeof(DTO.BancoDTO);
            // 
            // lblUsuarioBanco
            // 
            lblUsuarioBanco.Location = new Point(332, 79);
            lblUsuarioBanco.Margin = new Padding(10);
            lblUsuarioBanco.Name = "lblUsuarioBanco";
            lblUsuarioBanco.Size = new Size(36, 13);
            lblUsuarioBanco.TabIndex = 7;
            lblUsuarioBanco.Text = "Usuário";
            // 
            // txtUsuarioBanco
            // 
            txtUsuarioBanco.DataBindings.Add(new Binding("EditValue", bindingSourceBanco, "Usuario", true));
            txtUsuarioBanco.Location = new Point(388, 72);
            txtUsuarioBanco.Margin = new Padding(10);
            txtUsuarioBanco.Name = "txtUsuarioBanco";
            txtUsuarioBanco.Size = new Size(174, 28);
            txtUsuarioBanco.TabIndex = 6;
            // 
            // lblBanco
            // 
            lblBanco.Location = new Point(12, 127);
            lblBanco.Margin = new Padding(10);
            lblBanco.Name = "lblBanco";
            lblBanco.Size = new Size(29, 13);
            lblBanco.TabIndex = 5;
            lblBanco.Text = "Banco";
            // 
            // txtBanco
            // 
            txtBanco.DataBindings.Add(new Binding("EditValue", bindingSourceBanco, "Banco", true));
            txtBanco.Location = new Point(72, 120);
            txtBanco.Margin = new Padding(10);
            txtBanco.Name = "txtBanco";
            txtBanco.Size = new Size(240, 28);
            txtBanco.TabIndex = 4;
            // 
            // lblServidor
            // 
            lblServidor.Location = new Point(12, 79);
            lblServidor.Margin = new Padding(10);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(40, 13);
            lblServidor.TabIndex = 3;
            lblServidor.Text = "Servidor";
            // 
            // txtServidor
            // 
            txtServidor.DataBindings.Add(new Binding("EditValue", bindingSourceBanco, "Servidor", true));
            txtServidor.Location = new Point(72, 72);
            txtServidor.Margin = new Padding(10);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(240, 28);
            txtServidor.TabIndex = 2;
            // 
            // lblTipoBanco
            // 
            lblTipoBanco.Location = new Point(12, 38);
            lblTipoBanco.Margin = new Padding(10);
            lblTipoBanco.Name = "lblTipoBanco";
            lblTipoBanco.Size = new Size(20, 13);
            lblTipoBanco.TabIndex = 1;
            lblTipoBanco.Text = "Tipo";
            // 
            // comboTipoBanco
            // 
            comboTipoBanco.DataBindings.Add(new Binding("EditValue", bindingSourceBanco, "Tipo", true));
            comboTipoBanco.EditValue = "Selecione um banco";
            comboTipoBanco.Location = new Point(72, 31);
            comboTipoBanco.Name = "comboTipoBanco";
            comboTipoBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboTipoBanco.Properties.Items.AddRange(new object[] { "Sql Server", "Postgres" });
            comboTipoBanco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboTipoBanco.Size = new Size(167, 28);
            comboTipoBanco.TabIndex = 0;
            comboTipoBanco.SelectedIndexChanged += comboTipoBanco_SelectedIndexChanged;
            comboTipoBanco.KeyDown += comboTipoBanco_KeyDown;
            // 
            // FormConfiguracaoBanco
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 235);
            ControlBox = false;
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("FormConfiguracaoBanco.IconOptions.SvgImage");
            Name = "FormConfiguracaoBanco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração do Banco de Dados";
            Load += FormConfiguracaoBanco_Load;
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSenhaBanco.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceBanco).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuarioBanco.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBanco.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtServidor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboTipoBanco.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraEditors.LabelControl lblTipoBanco;
        private DevExpress.XtraEditors.ComboBoxEdit comboTipoBanco;
        private DevExpress.XtraEditors.LabelControl lblSenhaBanco;
        private DevExpress.XtraEditors.TextEdit txtSenhaBanco;
        private DevExpress.XtraEditors.LabelControl lblUsuarioBanco;
        private DevExpress.XtraEditors.TextEdit txtUsuarioBanco;
        private DevExpress.XtraEditors.LabelControl lblBanco;
        private DevExpress.XtraEditors.TextEdit txtBanco;
        private DevExpress.XtraEditors.LabelControl lblServidor;
        private DevExpress.XtraEditors.TextEdit txtServidor;
        private DevExpress.XtraEditors.SimpleButton btnSalvarConfiguracaoBanco;
        private DevExpress.XtraEditors.SimpleButton btnFecharConfiguracaoBanco;
        private BindingSource bindingSourceBanco;
        private DevExpress.XtraEditors.SimpleButton btnTestarConexao;
    }
}