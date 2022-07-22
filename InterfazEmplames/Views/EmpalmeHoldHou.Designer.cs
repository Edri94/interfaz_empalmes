
namespace InterfazEmplames
{
    partial class EmpalmeHoldHou
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDiferencias = new System.Windows.Forms.ListBox();
            this.btnFaltantesKap = new System.Windows.Forms.Button();
            this.btnFaltantesTicket = new System.Windows.Forms.Button();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empalme de Hold\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Datos:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(544, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "00-00-0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "(dd-mm-aaaa)";
            // 
            // lstDiferencias
            // 
            this.lstDiferencias.FormattingEnabled = true;
            this.lstDiferencias.ItemHeight = 20;
            this.lstDiferencias.Location = new System.Drawing.Point(13, 133);
            this.lstDiferencias.Name = "lstDiferencias";
            this.lstDiferencias.Size = new System.Drawing.Size(775, 244);
            this.lstDiferencias.TabIndex = 1;
            // 
            // btnFaltantesKap
            // 
            this.btnFaltantesKap.Location = new System.Drawing.Point(13, 397);
            this.btnFaltantesKap.Name = "btnFaltantesKap";
            this.btnFaltantesKap.Size = new System.Drawing.Size(169, 34);
            this.btnFaltantesKap.TabIndex = 2;
            this.btnFaltantesKap.Text = "Faltantes en Kapiti";
            this.btnFaltantesKap.UseVisualStyleBackColor = true;
            // 
            // btnFaltantesTicket
            // 
            this.btnFaltantesTicket.Location = new System.Drawing.Point(12, 437);
            this.btnFaltantesTicket.Name = "btnFaltantesTicket";
            this.btnFaltantesTicket.Size = new System.Drawing.Size(170, 34);
            this.btnFaltantesTicket.TabIndex = 2;
            this.btnFaltantesTicket.Text = "Faltantes en Ticket";
            this.btnFaltantesTicket.UseVisualStyleBackColor = true;
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(198, 397);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(170, 34);
            this.btnDiff.TabIndex = 2;
            this.btnDiff.Text = "Diferiencias";
            this.btnDiff.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(198, 437);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(170, 34);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(618, 437);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 34);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Black;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(13, 486);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(775, 22);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Preparando datos...";
            // 
            // EmpalmeHoldHou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnFaltantesTicket);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.btnFaltantesKap);
            this.Controls.Add(this.lstDiferencias);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmpalmeHoldHou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empalmes Hold\'s";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstDiferencias;
        private System.Windows.Forms.Button btnFaltantesKap;
        private System.Windows.Forms.Button btnFaltantesTicket;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblStatus;
    }
}