
namespace InterfazEmplames
{
    partial class Reporte_SaldoVencimientos
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
            this.pnlAgencia = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTipoReporteSal = new System.Windows.Forms.Button();
            this.btnTipoReporteVenc = new System.Windows.Forms.Button();
            this.lstAgencia = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlAgencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgencia
            // 
            this.pnlAgencia.Controls.Add(this.lstAgencia);
            this.pnlAgencia.Controls.Add(this.btnTipoReporteVenc);
            this.pnlAgencia.Controls.Add(this.btnTipoReporteSal);
            this.pnlAgencia.Controls.Add(this.label1);
            this.pnlAgencia.Location = new System.Drawing.Point(12, 12);
            this.pnlAgencia.Name = "pnlAgencia";
            this.pnlAgencia.Size = new System.Drawing.Size(621, 138);
            this.pnlAgencia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciones el tipo de Reporte y Agencia";
            // 
            // btnTipoReporteSal
            // 
            this.btnTipoReporteSal.Location = new System.Drawing.Point(15, 39);
            this.btnTipoReporteSal.Name = "btnTipoReporteSal";
            this.btnTipoReporteSal.Size = new System.Drawing.Size(204, 37);
            this.btnTipoReporteSal.TabIndex = 1;
            this.btnTipoReporteSal.Text = "Reporte de Saldos";
            this.btnTipoReporteSal.UseVisualStyleBackColor = true;
            // 
            // btnTipoReporteVenc
            // 
            this.btnTipoReporteVenc.Location = new System.Drawing.Point(15, 82);
            this.btnTipoReporteVenc.Name = "btnTipoReporteVenc";
            this.btnTipoReporteVenc.Size = new System.Drawing.Size(204, 37);
            this.btnTipoReporteVenc.TabIndex = 1;
            this.btnTipoReporteVenc.Text = "Reporte de Vencimientos";
            this.btnTipoReporteVenc.UseVisualStyleBackColor = true;
            // 
            // lstAgencia
            // 
            this.lstAgencia.FormattingEnabled = true;
            this.lstAgencia.ItemHeight = 20;
            this.lstAgencia.Location = new System.Drawing.Point(246, 39);
            this.lstAgencia.Name = "lstAgencia";
            this.lstAgencia.Size = new System.Drawing.Size(355, 84);
            this.lstAgencia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(621, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione una Agencia.";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(219, 213);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(204, 37);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(429, 213);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(204, 37);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // Reporte_SaldoVencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlAgencia);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reporte_SaldoVencimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.pnlAgencia.ResumeLayout(false);
            this.pnlAgencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgencia;
        private System.Windows.Forms.Button btnTipoReporteVenc;
        private System.Windows.Forms.Button btnTipoReporteSal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAgencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnImprimir;
    }
}