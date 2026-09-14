namespace JustDoTheWork.Sistema.Forms
{
    partial class FormConfigBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigBanco));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            btnSalvarConfigBanco = new DevExpress.XtraEditors.SimpleButton();
            lblSenhaBanco = new DevExpress.XtraEditors.LabelControl();
            txtSenhaBanco = new DevExpress.XtraEditors.TextEdit();
            bindingSourceBancoDTO = new BindingSource(components);
            lblUsuarioBanco = new DevExpress.XtraEditors.LabelControl();
            txtUsuarioBanco = new DevExpress.XtraEditors.TextEdit();
            lblBanco = new DevExpress.XtraEditors.LabelControl();
            txtBanco = new DevExpress.XtraEditors.TextEdit();
            lblServidor = new DevExpress.XtraEditors.LabelControl();
            txtServidor = new DevExpress.XtraEditors.TextEdit();
            lblTipoBanco = new DevExpress.XtraEditors.LabelControl();
            comboBoxEditTipoBanco = new DevExpress.XtraEditors.ComboBoxEdit();
            btnTestarConexao = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSenhaBanco.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceBancoDTO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuarioBanco.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBanco.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtServidor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEditTipoBanco.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnTestarConexao);
            panelControl1.Controls.Add(btnCancelar);
            panelControl1.Controls.Add(btnSalvarConfigBanco);
            panelControl1.Controls.Add(lblSenhaBanco);
            panelControl1.Controls.Add(txtSenhaBanco);
            panelControl1.Controls.Add(lblUsuarioBanco);
            panelControl1.Controls.Add(txtUsuarioBanco);
            panelControl1.Controls.Add(lblBanco);
            panelControl1.Controls.Add(txtBanco);
            panelControl1.Controls.Add(lblServidor);
            panelControl1.Controls.Add(txtServidor);
            panelControl1.Controls.Add(lblTipoBanco);
            panelControl1.Controls.Add(comboBoxEditTipoBanco);
            panelControl1.Location = new Point(12, 12);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(574, 217);
            panelControl1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(107, 183);
            btnCancelar.Margin = new Padding(10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvarConfigBanco
            // 
            btnSalvarConfigBanco.Location = new Point(12, 182);
            btnSalvarConfigBanco.Margin = new Padding(10);
            btnSalvarConfigBanco.Name = "btnSalvarConfigBanco";
            btnSalvarConfigBanco.Size = new Size(75, 23);
            btnSalvarConfigBanco.TabIndex = 10;
            btnSalvarConfigBanco.Text = "Salvar";
            btnSalvarConfigBanco.Click += btnSalvarConfigBanco_Click;
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
            txtSenhaBanco.DataBindings.Add(new Binding("EditValue", bindingSourceBancoDTO, "Senha", true));
            txtSenhaBanco.Location = new Point(388, 120);
            txtSenhaBanco.Margin = new Padding(10);
            txtSenhaBanco.Name = "txtSenhaBanco";
            txtSenhaBanco.Size = new Size(174, 28);
            txtSenhaBanco.TabIndex = 8;
            // 
            // bindingSourceBancoDTO
            // 
            bindingSourceBancoDTO.DataSource = typeof(DTO.BancoDTO);
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
            txtUsuarioBanco.DataBindings.Add(new Binding("EditValue", bindingSourceBancoDTO, "Usuario", true));
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
            txtBanco.DataBindings.Add(new Binding("EditValue", bindingSourceBancoDTO, "Banco", true));
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
            txtServidor.DataBindings.Add(new Binding("EditValue", bindingSourceBancoDTO, "Servidor", true));
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
            // comboBoxEditTipoBanco
            // 
            comboBoxEditTipoBanco.DataBindings.Add(new Binding("EditValue", bindingSourceBancoDTO, "Tipo", true));
            comboBoxEditTipoBanco.EditValue = "Selecione um banco";
            comboBoxEditTipoBanco.Location = new Point(72, 31);
            comboBoxEditTipoBanco.Name = "comboBoxEditTipoBanco";
            comboBoxEditTipoBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEditTipoBanco.Properties.Items.AddRange(new object[] { "Sql Server", "Postgres" });
            comboBoxEditTipoBanco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            comboBoxEditTipoBanco.Size = new Size(167, 28);
            comboBoxEditTipoBanco.TabIndex = 0;
            comboBoxEditTipoBanco.SelectedIndexChanged += comboBoxEditTipoBanco_SelectedIndexChanged;
            comboBoxEditTipoBanco.KeyDown += comboBoxEditTipoBanco_KeyDown;
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
            // FormConfigBanco
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 235);
            ControlBox = false;
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("FormConfigBanco.IconOptions.SvgImage");
            Name = "FormConfigBanco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração do Banco de Dados";
            Load += FormConfigBanco_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSenhaBanco.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceBancoDTO).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuarioBanco.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBanco.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtServidor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEditTipoBanco.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTipoBanco;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditTipoBanco;
        private DevExpress.XtraEditors.LabelControl lblSenhaBanco;
        private DevExpress.XtraEditors.TextEdit txtSenhaBanco;
        private DevExpress.XtraEditors.LabelControl lblUsuarioBanco;
        private DevExpress.XtraEditors.TextEdit txtUsuarioBanco;
        private DevExpress.XtraEditors.LabelControl lblBanco;
        private DevExpress.XtraEditors.TextEdit txtBanco;
        private DevExpress.XtraEditors.LabelControl lblServidor;
        private DevExpress.XtraEditors.TextEdit txtServidor;
        private DevExpress.XtraEditors.SimpleButton btnSalvarConfigBanco;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private BindingSource bindingSourceBancoDTO;
        private DevExpress.XtraEditors.SimpleButton btnTestarConexao;
    }
}