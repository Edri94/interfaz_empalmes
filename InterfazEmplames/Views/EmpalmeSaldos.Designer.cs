
namespace InterfazEmplames
{
    partial class EmpalmeSaldos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaKapiti = new System.Windows.Forms.Label();
            this.lblFechaServidor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstvwEmpalmeSaldos = new System.Windows.Forms.ListView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnReproceso = new System.Windows.Forms.Button();
            this.txtCuentasDiferencias = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblFechaKapiti);
            this.panel1.Controls.Add(this.lblFechaServidor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1188, 115);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(758, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ultima dia habil en HOU:";
            // 
            // lblFechaKapiti
            // 
            this.lblFechaKapiti.AutoSize = true;
            this.lblFechaKapiti.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblFechaKapiti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaKapiti.Location = new System.Drawing.Point(946, 80);
            this.lblFechaKapiti.Name = "lblFechaKapiti";
            this.lblFechaKapiti.Size = new System.Drawing.Size(93, 22);
            this.lblFechaKapiti.TabIndex = 0;
            this.lblFechaKapiti.Text = "00-00-0000";
            // 
            // lblFechaServidor
            // 
            this.lblFechaServidor.AutoSize = true;
            this.lblFechaServidor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblFechaServidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaServidor.Location = new System.Drawing.Point(946, 44);
            this.lblFechaServidor.Name = "lblFechaServidor";
            this.lblFechaServidor.Size = new System.Drawing.Size(93, 22);
            this.lblFechaServidor.TabIndex = 0;
            this.lblFechaServidor.Text = "00-00-0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1045, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "(DD-MM-AAAA)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1045, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "(DD-MM-AAAA)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha en Servidor TKT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empalme de Saldos";
            // 
            // lstvwEmpalmeSaldos
            // 
            this.lstvwEmpalmeSaldos.HideSelection = false;
            this.lstvwEmpalmeSaldos.Location = new System.Drawing.Point(12, 153);
            this.lstvwEmpalmeSaldos.Name = "lstvwEmpalmeSaldos";
            this.lstvwEmpalmeSaldos.Size = new System.Drawing.Size(1188, 336);
            this.lstvwEmpalmeSaldos.TabIndex = 1;
            this.lstvwEmpalmeSaldos.UseCompatibleStateImageBehavior = false;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblStatus.Location = new System.Drawing.Point(12, 514);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(1188, 35);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Preparando datos...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1081, 571);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 35);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(956, 571);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(119, 35);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(805, 571);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(145, 35);
            this.btnExtraer.TabIndex = 3;
            this.btnExtraer.Text = "Obtener Informe";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnReproceso
            // 
            this.btnReproceso.Location = new System.Drawing.Point(643, 571);
            this.btnReproceso.Name = "btnReproceso";
            this.btnReproceso.Size = new System.Drawing.Size(156, 35);
            this.btnReproceso.TabIndex = 3;
            this.btnReproceso.Text = "Reproceso Saldo";
            this.btnReproceso.UseVisualStyleBackColor = true;
            // 
            // txtCuentasDiferencias
            // 
            this.txtCuentasDiferencias.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCuentasDiferencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtCuentasDiferencias.ForeColor = System.Drawing.Color.Lime;
            this.txtCuentasDiferencias.Location = new System.Drawing.Point(453, 571);
            this.txtCuentasDiferencias.Name = "txtCuentasDiferencias";
            this.txtCuentasDiferencias.Size = new System.Drawing.Size(117, 35);
            this.txtCuentasDiferencias.TabIndex = 2;
            this.txtCuentasDiferencias.Text = "0";
            this.txtCuentasDiferencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(420, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total de Cuentas con Diferencias : Saldo Equation - Ticket";
            // 
            // EmpalmeSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 625);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnReproceso);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCuentasDiferencias);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstvwEmpalmeSaldos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmpalmeSaldos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpalmeSaldos";
            this.Load += new System.EventHandler(this.EmpalmeSaldos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaKapiti;
        private System.Windows.Forms.Label lblFechaServidor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstvwEmpalmeSaldos;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnReproceso;
        private System.Windows.Forms.Label txtCuentasDiferencias;
        private System.Windows.Forms.Label label10;
    }
}