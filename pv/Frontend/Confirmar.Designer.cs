﻿namespace pv.Frontend
{
    partial class Confirmar
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
            this.lbmessage = new System.Windows.Forms.Label();
            this.btnNoo = new System.Windows.Forms.Button();
            this.btnSI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbmessage
            // 
            this.lbmessage.AutoSize = true;
            this.lbmessage.Location = new System.Drawing.Point(273, 9);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.Size = new System.Drawing.Size(42, 20);
            this.lbmessage.TabIndex = 2;
            this.lbmessage.Text = "aaaaa";
            this.lbmessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbmessage.UseCompatibleTextRendering = true;
            this.lbmessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNoo
            // 
            this.btnNoo.BackColor = System.Drawing.Color.Lime;
            this.btnNoo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoo.Location = new System.Drawing.Point(454, 110);
            this.btnNoo.Name = "btnNoo";
            this.btnNoo.Size = new System.Drawing.Size(70, 50);
            this.btnNoo.TabIndex = 42;
            this.btnNoo.Text = "NO";
            this.btnNoo.UseVisualStyleBackColor = false;
            this.btnNoo.Click += new System.EventHandler(this.btnNoEliminar_Click);
            // 
            // btnSI
            // 
            this.btnSI.BackColor = System.Drawing.Color.Red;
            this.btnSI.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSI.Location = new System.Drawing.Point(107, 110);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(70, 50);
            this.btnSI.TabIndex = 13;
            this.btnSI.Text = "SI";
            this.btnSI.UseVisualStyleBackColor = false;
            this.btnSI.Click += new System.EventHandler(this.btnSiEliminar_Click);
            // 
            // Confirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 206);
            this.Controls.Add(this.btnNoo);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.lbmessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Confirmar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación";
            this.Load += new System.EventHandler(this.Confirmar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbmessage;
        private System.Windows.Forms.Button btnNoo;
        private System.Windows.Forms.Button btnSI;
    }
}