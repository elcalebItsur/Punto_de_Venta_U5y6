﻿namespace pv.Frontend.Vistas
{
    partial class VentaHecha
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
            this.dtticket = new System.Windows.Forms.DataGridView();
            this.tbid = new System.Windows.Forms.TextBox();
            this.cbopcion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtticket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dtticket);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.cbopcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 629);
            this.panel1.TabIndex = 0;
            // 
            // dtticket
            // 
            this.dtticket.AllowUserToAddRows = false;
            this.dtticket.AllowUserToDeleteRows = false;
            this.dtticket.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtticket.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtticket.Location = new System.Drawing.Point(215, 37);
            this.dtticket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtticket.Name = "dtticket";
            this.dtticket.ReadOnly = true;
            this.dtticket.RowHeadersWidth = 62;
            this.dtticket.RowTemplate.Height = 28;
            this.dtticket.Size = new System.Drawing.Size(889, 538);
            this.dtticket.TabIndex = 4;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(59, 120);
            this.tbid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(89, 22);
            this.tbid.TabIndex = 3;
            this.tbid.Visible = false;
            this.tbid.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // cbopcion
            // 
            this.cbopcion.FormattingEnabled = true;
            this.cbopcion.Items.AddRange(new object[] {
            "ID"});
            this.cbopcion.Location = new System.Drawing.Point(23, 74);
            this.cbopcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbopcion.Name = "cbopcion";
            this.cbopcion.Size = new System.Drawing.Size(168, 24);
            this.cbopcion.TabIndex = 1;
            this.cbopcion.SelectedIndexChanged += new System.EventHandler(this.cbopcion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por...";
            // 
            // VentaHecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 629);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentaHecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VentaHecha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtticket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtticket;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.ComboBox cbopcion;
        private System.Windows.Forms.Label label1;
    }
}