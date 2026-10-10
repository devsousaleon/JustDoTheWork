namespace JustDoTheWork.Sistema.Forms
{
    partial class FormVisualizaModeloRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizaModeloRelatorio));
            panelBackground = new DevExpress.XtraEditors.PanelControl();
            panelAcoes = new DevExpress.XtraEditors.PanelControl();
            btnEditarTextoModelo = new DevExpress.XtraEditors.SimpleButton();
            btnFecharCadastroModeloRelatorio = new DevExpress.XtraEditors.SimpleButton();
            btnSalvarCadastroModeloRelatorio = new DevExpress.XtraEditors.SimpleButton();
            groupTextoModelo = new DevExpress.XtraEditors.GroupControl();
            richEditTextoModelo = new DevExpress.XtraRichEdit.RichEditControl();
            groupInfoModelo = new DevExpress.XtraEditors.GroupControl();
            checkAtivo = new DevExpress.XtraEditors.CheckEdit();
            lblTipoModelo = new DevExpress.XtraEditors.LabelControl();
            comboTipoModelo = new DevExpress.XtraEditors.LookUpEdit();
            txtDescricaoModelo = new DevExpress.XtraEditors.TextEdit();
            lblDescricaoModelo = new DevExpress.XtraEditors.LabelControl();
            btnExcluirModeloRelatorio = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelBackground).BeginInit();
            panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelAcoes).BeginInit();
            panelAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupTextoModelo).BeginInit();
            groupTextoModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupInfoModelo).BeginInit();
            groupInfoModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)checkAtivo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboTipoModelo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricaoModelo.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.Controls.Add(panelAcoes);
            panelBackground.Controls.Add(groupTextoModelo);
            panelBackground.Controls.Add(groupInfoModelo);
            panelBackground.Location = new Point(12, 10);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(974, 640);
            panelBackground.TabIndex = 1;
            // 
            // panelAcoes
            // 
            panelAcoes.Controls.Add(btnExcluirModeloRelatorio);
            panelAcoes.Controls.Add(btnEditarTextoModelo);
            panelAcoes.Controls.Add(btnFecharCadastroModeloRelatorio);
            panelAcoes.Controls.Add(btnSalvarCadastroModeloRelatorio);
            panelAcoes.Location = new Point(7, 576);
            panelAcoes.Margin = new Padding(5);
            panelAcoes.Name = "panelAcoes";
            panelAcoes.Size = new Size(960, 57);
            panelAcoes.TabIndex = 2;
            // 
            // btnEditarTextoModelo
            // 
            btnEditarTextoModelo.Location = new Point(332, 17);
            btnEditarTextoModelo.Margin = new Padding(15);
            btnEditarTextoModelo.Name = "btnEditarTextoModelo";
            btnEditarTextoModelo.Size = new Size(150, 23);
            btnEditarTextoModelo.TabIndex = 6;
            btnEditarTextoModelo.Text = "Abrir Edição de Modelo";
            btnEditarTextoModelo.Click += btnEditarTextoModelo_Click;
            // 
            // btnFecharCadastroModeloRelatorio
            // 
            btnFecharCadastroModeloRelatorio.Location = new Point(122, 17);
            btnFecharCadastroModeloRelatorio.Margin = new Padding(15);
            btnFecharCadastroModeloRelatorio.Name = "btnFecharCadastroModeloRelatorio";
            btnFecharCadastroModeloRelatorio.Size = new Size(75, 23);
            btnFecharCadastroModeloRelatorio.TabIndex = 5;
            btnFecharCadastroModeloRelatorio.Text = "Fechar";
            btnFecharCadastroModeloRelatorio.Click += btnFecharCadastroModeloRelatorio_Click;
            // 
            // btnSalvarCadastroModeloRelatorio
            // 
            btnSalvarCadastroModeloRelatorio.Location = new Point(17, 17);
            btnSalvarCadastroModeloRelatorio.Margin = new Padding(15);
            btnSalvarCadastroModeloRelatorio.Name = "btnSalvarCadastroModeloRelatorio";
            btnSalvarCadastroModeloRelatorio.Size = new Size(75, 23);
            btnSalvarCadastroModeloRelatorio.TabIndex = 4;
            btnSalvarCadastroModeloRelatorio.Text = "Salvar";
            btnSalvarCadastroModeloRelatorio.Click += btnSalvarCadastroModeloRelatorio_Click;
            // 
            // groupTextoModelo
            // 
            groupTextoModelo.Controls.Add(richEditTextoModelo);
            groupTextoModelo.Location = new Point(7, 170);
            groupTextoModelo.Margin = new Padding(5);
            groupTextoModelo.Name = "groupTextoModelo";
            groupTextoModelo.Size = new Size(960, 396);
            groupTextoModelo.TabIndex = 1;
            groupTextoModelo.Text = "Texto";
            // 
            // richEditTextoModelo
            // 
            richEditTextoModelo.Location = new Point(7, 34);
            richEditTextoModelo.Margin = new Padding(5);
            richEditTextoModelo.Name = "richEditTextoModelo";
            richEditTextoModelo.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            richEditTextoModelo.ReadOnly = true;
            richEditTextoModelo.Size = new Size(946, 355);
            richEditTextoModelo.TabIndex = 0;
            // 
            // groupInfoModelo
            // 
            groupInfoModelo.Controls.Add(checkAtivo);
            groupInfoModelo.Controls.Add(lblTipoModelo);
            groupInfoModelo.Controls.Add(comboTipoModelo);
            groupInfoModelo.Controls.Add(txtDescricaoModelo);
            groupInfoModelo.Controls.Add(lblDescricaoModelo);
            groupInfoModelo.Location = new Point(7, 7);
            groupInfoModelo.Margin = new Padding(5);
            groupInfoModelo.Name = "groupInfoModelo";
            groupInfoModelo.Size = new Size(960, 153);
            groupInfoModelo.TabIndex = 0;
            groupInfoModelo.Text = "Informações do Modelo";
            // 
            // checkAtivo
            // 
            checkAtivo.EditValue = true;
            checkAtivo.Location = new Point(442, 41);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Properties.Appearance.Font = new Font("Tahoma", 9.75F);
            checkAtivo.Properties.Appearance.Options.UseFont = true;
            checkAtivo.Properties.Caption = "Ativo?";
            checkAtivo.Size = new Size(75, 22);
            checkAtivo.TabIndex = 14;
            // 
            // lblTipoModelo
            // 
            lblTipoModelo.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoModelo.Appearance.ForeColor = Color.White;
            lblTipoModelo.Appearance.Options.UseFont = true;
            lblTipoModelo.Appearance.Options.UseForeColor = true;
            lblTipoModelo.Location = new Point(17, 96);
            lblTipoModelo.Margin = new Padding(15);
            lblTipoModelo.Name = "lblTipoModelo";
            lblTipoModelo.Size = new Size(88, 16);
            lblTipoModelo.TabIndex = 13;
            lblTipoModelo.Text = "Tipo Modelo";
            // 
            // comboTipoModelo
            // 
            comboTipoModelo.Location = new Point(123, 87);
            comboTipoModelo.Name = "comboTipoModelo";
            comboTipoModelo.Properties.Appearance.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboTipoModelo.Properties.Appearance.Options.UseFont = true;
            comboTipoModelo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboTipoModelo.Properties.NullText = "";
            comboTipoModelo.Properties.PopupSizeable = false;
            comboTipoModelo.Size = new Size(313, 32);
            comboTipoModelo.TabIndex = 12;
            // 
            // txtDescricaoModelo
            // 
            txtDescricaoModelo.Location = new Point(107, 37);
            txtDescricaoModelo.Name = "txtDescricaoModelo";
            txtDescricaoModelo.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricaoModelo.Properties.Appearance.Options.UseFont = true;
            txtDescricaoModelo.Properties.MaxLength = 50;
            txtDescricaoModelo.Size = new Size(329, 30);
            txtDescricaoModelo.TabIndex = 11;
            // 
            // lblDescricaoModelo
            // 
            lblDescricaoModelo.Appearance.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricaoModelo.Appearance.ForeColor = Color.White;
            lblDescricaoModelo.Appearance.Options.UseFont = true;
            lblDescricaoModelo.Appearance.Options.UseForeColor = true;
            lblDescricaoModelo.Location = new Point(17, 44);
            lblDescricaoModelo.Margin = new Padding(15);
            lblDescricaoModelo.Name = "lblDescricaoModelo";
            lblDescricaoModelo.Size = new Size(72, 16);
            lblDescricaoModelo.TabIndex = 10;
            lblDescricaoModelo.Text = "Descrição";
            // 
            // btnExcluirModeloRelatorio
            // 
            btnExcluirModeloRelatorio.Location = new Point(227, 17);
            btnExcluirModeloRelatorio.Margin = new Padding(15);
            btnExcluirModeloRelatorio.Name = "btnExcluirModeloRelatorio";
            btnExcluirModeloRelatorio.Size = new Size(75, 23);
            btnExcluirModeloRelatorio.TabIndex = 7;
            btnExcluirModeloRelatorio.Text = "Excluir";
            btnExcluirModeloRelatorio.Click += btnExcluirModeloRelatorio_Click;
            // 
            // FormVisualizaModeloRelatorio
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 660);
            Controls.Add(panelBackground);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("FormVisualizaModeloRelatorio.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVisualizaModeloRelatorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualização do Modelo para Relatório";
            Load += FormVisualizaModeloRelatorio_Load;
            ((System.ComponentModel.ISupportInitialize)panelBackground).EndInit();
            panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelAcoes).EndInit();
            panelAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupTextoModelo).EndInit();
            groupTextoModelo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupInfoModelo).EndInit();
            groupInfoModelo.ResumeLayout(false);
            groupInfoModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)checkAtivo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboTipoModelo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescricaoModelo.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelBackground;
        private DevExpress.XtraEditors.PanelControl panelAcoes;
        private DevExpress.XtraEditors.SimpleButton btnEditarTextoModelo;
        private DevExpress.XtraEditors.SimpleButton btnFecharCadastroModeloRelatorio;
        private DevExpress.XtraEditors.SimpleButton btnSalvarCadastroModeloRelatorio;
        private DevExpress.XtraEditors.GroupControl groupTextoModelo;
        private DevExpress.XtraRichEdit.RichEditControl richEditTextoModelo;
        private DevExpress.XtraEditors.GroupControl groupInfoModelo;
        private DevExpress.XtraEditors.CheckEdit checkAtivo;
        private DevExpress.XtraEditors.LabelControl lblTipoModelo;
        private DevExpress.XtraEditors.LookUpEdit comboTipoModelo;
        private DevExpress.XtraEditors.TextEdit txtDescricaoModelo;
        private DevExpress.XtraEditors.LabelControl lblDescricaoModelo;
        private DevExpress.XtraEditors.SimpleButton btnExcluirModeloRelatorio;
    }
}