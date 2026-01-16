namespace JustDoTheWork.Sistema.ControlPanel
{
    partial class HomeUserControl
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
            this.groupPausado = new DevExpress.XtraEditors.GroupControl();
            this.dataGridPausado = new System.Windows.Forms.DataGridView();
            this.groupExecutando = new DevExpress.XtraEditors.GroupControl();
            this.dataGridExecutando = new System.Windows.Forms.DataGridView();
            this.groupPendente = new DevExpress.XtraEditors.GroupControl();
            this.dataGridPendentes = new System.Windows.Forms.DataGridView();
            this.btnExecutar = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinalizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPausar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarAposPausado = new DevExpress.XtraEditors.SimpleButton();
            this.btnExecutarAposPausado = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupPausado)).BeginInit();
            this.groupPausado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPausado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupExecutando)).BeginInit();
            this.groupExecutando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExecutando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendente)).BeginInit();
            this.groupPendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPausado
            // 
            this.groupPausado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPausado.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 12F);
            this.groupPausado.AppearanceCaption.Options.UseFont = true;
            this.groupPausado.Controls.Add(this.btnExecutarAposPausado);
            this.groupPausado.Controls.Add(this.btnCancelarAposPausado);
            this.groupPausado.Controls.Add(this.dataGridPausado);
            this.groupPausado.Location = new System.Drawing.Point(545, 359);
            this.groupPausado.Margin = new System.Windows.Forms.Padding(15);
            this.groupPausado.Name = "groupPausado";
            this.groupPausado.Size = new System.Drawing.Size(720, 346);
            this.groupPausado.TabIndex = 5;
            this.groupPausado.Text = "Pausado";
            // 
            // dataGridPausado
            // 
            this.dataGridPausado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPausado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPausado.Location = new System.Drawing.Point(5, 26);
            this.dataGridPausado.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.dataGridPausado.Name = "dataGridPausado";
            this.dataGridPausado.Size = new System.Drawing.Size(710, 278);
            this.dataGridPausado.TabIndex = 2;
            // 
            // groupExecutando
            // 
            this.groupExecutando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupExecutando.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 12F);
            this.groupExecutando.AppearanceCaption.Options.UseFont = true;
            this.groupExecutando.Controls.Add(this.btnPausar);
            this.groupExecutando.Controls.Add(this.btnCancelar);
            this.groupExecutando.Controls.Add(this.btnFinalizar);
            this.groupExecutando.Controls.Add(this.dataGridExecutando);
            this.groupExecutando.Location = new System.Drawing.Point(545, 15);
            this.groupExecutando.Margin = new System.Windows.Forms.Padding(15);
            this.groupExecutando.Name = "groupExecutando";
            this.groupExecutando.Size = new System.Drawing.Size(720, 314);
            this.groupExecutando.TabIndex = 4;
            this.groupExecutando.Text = "Em execução";
            // 
            // dataGridExecutando
            // 
            this.dataGridExecutando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridExecutando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExecutando.Location = new System.Drawing.Point(5, 26);
            this.dataGridExecutando.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.dataGridExecutando.Name = "dataGridExecutando";
            this.dataGridExecutando.Size = new System.Drawing.Size(710, 246);
            this.dataGridExecutando.TabIndex = 1;
            // 
            // groupPendente
            // 
            this.groupPendente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPendente.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPendente.AppearanceCaption.Options.UseFont = true;
            this.groupPendente.Controls.Add(this.btnExecutar);
            this.groupPendente.Controls.Add(this.dataGridPendentes);
            this.groupPendente.Location = new System.Drawing.Point(15, 15);
            this.groupPendente.Margin = new System.Windows.Forms.Padding(15);
            this.groupPendente.Name = "groupPendente";
            this.groupPendente.Size = new System.Drawing.Size(500, 690);
            this.groupPendente.TabIndex = 3;
            this.groupPendente.Text = "Pendentes";
            // 
            // dataGridPendentes
            // 
            this.dataGridPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPendentes.Location = new System.Drawing.Point(5, 26);
            this.dataGridPendentes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.dataGridPendentes.Name = "dataGridPendentes";
            this.dataGridPendentes.Size = new System.Drawing.Size(490, 622);
            this.dataGridPendentes.TabIndex = 0;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutar.Location = new System.Drawing.Point(415, 657);
            this.btnExecutar.Margin = new System.Windows.Forms.Padding(8);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Location = new System.Drawing.Point(635, 281);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(8);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(544, 281);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnPausar
            // 
            this.btnPausar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPausar.Location = new System.Drawing.Point(453, 281);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(8);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 23);
            this.btnPausar.TabIndex = 4;
            this.btnPausar.Text = "Pausar";
            // 
            // btnCancelarAposPausado
            // 
            this.btnCancelarAposPausado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAposPausado.Location = new System.Drawing.Point(635, 313);
            this.btnCancelarAposPausado.Margin = new System.Windows.Forms.Padding(8);
            this.btnCancelarAposPausado.Name = "btnCancelarAposPausado";
            this.btnCancelarAposPausado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAposPausado.TabIndex = 5;
            this.btnCancelarAposPausado.Text = "Cancelar";
            // 
            // btnExecutarAposPausado
            // 
            this.btnExecutarAposPausado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutarAposPausado.Location = new System.Drawing.Point(544, 313);
            this.btnExecutarAposPausado.Margin = new System.Windows.Forms.Padding(8);
            this.btnExecutarAposPausado.Name = "btnExecutarAposPausado";
            this.btnExecutarAposPausado.Size = new System.Drawing.Size(75, 23);
            this.btnExecutarAposPausado.TabIndex = 2;
            this.btnExecutarAposPausado.Text = "Executar";
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPausado);
            this.Controls.Add(this.groupExecutando);
            this.Controls.Add(this.groupPendente);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.groupPausado)).EndInit();
            this.groupPausado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPausado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupExecutando)).EndInit();
            this.groupExecutando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExecutando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPendente)).EndInit();
            this.groupPendente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPendentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupPausado;
        private DevExpress.XtraEditors.GroupControl groupExecutando;
        private DevExpress.XtraEditors.GroupControl groupPendente;
        private System.Windows.Forms.DataGridView dataGridPendentes;
        private System.Windows.Forms.DataGridView dataGridExecutando;
        private System.Windows.Forms.DataGridView dataGridPausado;
        private DevExpress.XtraEditors.SimpleButton btnExecutar;
        private DevExpress.XtraEditors.SimpleButton btnPausar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnFinalizar;
        private DevExpress.XtraEditors.SimpleButton btnExecutarAposPausado;
        private DevExpress.XtraEditors.SimpleButton btnCancelarAposPausado;
    }
}
