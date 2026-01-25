namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class ReportUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportUserControl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFiltroPesquisa = new DevExpress.XtraEditors.PanelControl();
            this.btnSalvarRelatorio = new DevExpress.XtraEditors.SimpleButton();
            this.DataCriacao = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxProjeto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnPesquisarRelatorio = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFiltroPesquisa)).BeginInit();
            this.panelFiltroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProjeto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 184);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1250, 521);
            this.dataGridView1.TabIndex = 11;
            // 
            // panelFiltroPesquisa
            // 
            this.panelFiltroPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltroPesquisa.Appearance.BackColor = System.Drawing.Color.White;
            this.panelFiltroPesquisa.Appearance.Options.UseBackColor = true;
            this.panelFiltroPesquisa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelFiltroPesquisa.Controls.Add(this.btnSalvarRelatorio);
            this.panelFiltroPesquisa.Controls.Add(this.DataCriacao);
            this.panelFiltroPesquisa.Controls.Add(this.labelControl4);
            this.panelFiltroPesquisa.Controls.Add(this.comboBoxProjeto);
            this.panelFiltroPesquisa.Controls.Add(this.labelControl3);
            this.panelFiltroPesquisa.Controls.Add(this.comboBoxStatus);
            this.panelFiltroPesquisa.Controls.Add(this.labelControl2);
            this.panelFiltroPesquisa.Controls.Add(this.btnPesquisarRelatorio);
            this.panelFiltroPesquisa.Location = new System.Drawing.Point(15, 15);
            this.panelFiltroPesquisa.Margin = new System.Windows.Forms.Padding(15);
            this.panelFiltroPesquisa.Name = "panelFiltroPesquisa";
            this.panelFiltroPesquisa.Size = new System.Drawing.Size(1250, 139);
            this.panelFiltroPesquisa.TabIndex = 10;
            // 
            // btnSalvarRelatorio
            // 
            this.btnSalvarRelatorio.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnSalvarRelatorio.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarRelatorio.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarRelatorio.Appearance.Options.UseBorderColor = true;
            this.btnSalvarRelatorio.Appearance.Options.UseFont = true;
            this.btnSalvarRelatorio.Appearance.Options.UseForeColor = true;
            this.btnSalvarRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvarRelatorio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarRelatorio.ImageOptions.Image")));
            this.btnSalvarRelatorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvarRelatorio.Location = new System.Drawing.Point(438, 82);
            this.btnSalvarRelatorio.Name = "btnSalvarRelatorio";
            this.btnSalvarRelatorio.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSalvarRelatorio.Size = new System.Drawing.Size(107, 23);
            this.btnSalvarRelatorio.TabIndex = 9;
            this.btnSalvarRelatorio.Text = "Salvar";
            // 
            // DataCriacao
            // 
            this.DataCriacao.EditValue = null;
            this.DataCriacao.Location = new System.Drawing.Point(83, 54);
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataCriacao.Properties.Appearance.Options.UseFont = true;
            this.DataCriacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataCriacao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DataCriacao.Size = new System.Drawing.Size(297, 22);
            this.DataCriacao.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 57);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Data";
            // 
            // comboBoxProjeto
            // 
            this.comboBoxProjeto.Location = new System.Drawing.Point(83, 11);
            this.comboBoxProjeto.Name = "comboBoxProjeto";
            this.comboBoxProjeto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxProjeto.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProjeto.Properties.Appearance.Options.UseFont = true;
            this.comboBoxProjeto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxProjeto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxProjeto.Size = new System.Drawing.Size(297, 22);
            this.comboBoxProjeto.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 17);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Projeto";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Location = new System.Drawing.Point(83, 97);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.comboBoxStatus.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStatus.Properties.Appearance.Options.UseFont = true;
            this.comboBoxStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxStatus.Properties.Items.AddRange(new object[] {
            "Em análise",
            "Pendente",
            "Executando",
            "Pausado",
            "Finalizado",
            "Cancelado"});
            this.comboBoxStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxStatus.Size = new System.Drawing.Size(297, 22);
            this.comboBoxStatus.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 103);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Status";
            // 
            // btnPesquisarRelatorio
            // 
            this.btnPesquisarRelatorio.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnPesquisarRelatorio.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarRelatorio.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisarRelatorio.Appearance.Options.UseBorderColor = true;
            this.btnPesquisarRelatorio.Appearance.Options.UseFont = true;
            this.btnPesquisarRelatorio.Appearance.Options.UseForeColor = true;
            this.btnPesquisarRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisarRelatorio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarRelatorio.ImageOptions.Image")));
            this.btnPesquisarRelatorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisarRelatorio.Location = new System.Drawing.Point(438, 53);
            this.btnPesquisarRelatorio.Name = "btnPesquisarRelatorio";
            this.btnPesquisarRelatorio.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPesquisarRelatorio.Size = new System.Drawing.Size(107, 23);
            this.btnPesquisarRelatorio.TabIndex = 2;
            this.btnPesquisarRelatorio.Text = "Pesquisar";
            // 
            // ReportUserControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelFiltroPesquisa);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFiltroPesquisa)).EndInit();
            this.panelFiltroPesquisa.ResumeLayout(false);
            this.panelFiltroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataCriacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProjeto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.PanelControl panelFiltroPesquisa;
        private DevExpress.XtraEditors.DateEdit DataCriacao;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxProjeto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxStatus;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPesquisarRelatorio;
        private DevExpress.XtraEditors.SimpleButton btnSalvarRelatorio;
    }
}
