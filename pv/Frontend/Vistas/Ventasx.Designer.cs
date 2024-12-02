using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using pv.Backend;

namespace pv.Frontend.Vistas
{
    partial class Ventasx
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventasx));
            this.dtventas = new System.Windows.Forms.DataGridView();
            this.lblhello = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblventas = new System.Windows.Forms.Label();
            this.tbfolio = new System.Windows.Forms.TextBox();
            this.btnnormal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnfiltro = new System.Windows.Forms.Button();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtventas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtventas
            // 
            this.dtventas.AllowUserToAddRows = false;
            this.dtventas.AllowUserToDeleteRows = false;
            this.dtventas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtventas.GridColor = System.Drawing.Color.Black;
            this.dtventas.Location = new System.Drawing.Point(84, 81);
            this.dtventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtventas.Name = "dtventas";
            this.dtventas.ReadOnly = true;
            this.dtventas.RowHeadersWidth = 62;
            this.dtventas.RowTemplate.Height = 28;
            this.dtventas.Size = new System.Drawing.Size(1019, 299);
            this.dtventas.TabIndex = 4;
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Font = new System.Drawing.Font("Algerian", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhello.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblhello.Location = new System.Drawing.Point(386, 30);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(461, 48);
            this.lblhello.TabIndex = 5;
            this.lblhello.Text = "Ventas Realizadas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblventas);
            this.panel1.Controls.Add(this.tbfolio);
            this.panel1.Controls.Add(this.btnnormal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnfiltro);
            this.panel1.Controls.Add(this.dtpfin);
            this.panel1.Controls.Add(this.dtpinicio);
            this.panel1.Controls.Add(this.lblhello);
            this.panel1.Controls.Add(this.dtventas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 553);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(50, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 136;
            this.label4.Text = "Regresar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(50, 492);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(82, 30);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 135;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(563, 432);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblventas
            // 
            this.lblventas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblventas.AutoSize = true;
            this.lblventas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblventas.Location = new System.Drawing.Point(922, 468);
            this.lblventas.Name = "lblventas";
            this.lblventas.Size = new System.Drawing.Size(181, 19);
            this.lblventas.TabIndex = 17;
            this.lblventas.Text = "Productos vendidos: ";
            // 
            // tbfolio
            // 
            this.tbfolio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbfolio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfolio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbfolio.Location = new System.Drawing.Point(926, 494);
            this.tbfolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbfolio.MaxLength = 9;
            this.tbfolio.Name = "tbfolio";
            this.tbfolio.Size = new System.Drawing.Size(177, 28);
            this.tbfolio.TabIndex = 16;
            this.tbfolio.TextChanged += new System.EventHandler(this.tbfolio_TextChanged);
            // 
            // btnnormal
            // 
            this.btnnormal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnnormal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnormal.Location = new System.Drawing.Point(549, 384);
            this.btnnormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnormal.Name = "btnnormal";
            this.btnnormal.Size = new System.Drawing.Size(110, 28);
            this.btnnormal.TabIndex = 11;
            this.btnnormal.Text = "Sin filtro";
            this.btnnormal.UseVisualStyleBackColor = true;
            this.btnnormal.Click += new System.EventHandler(this.btnnormal_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(862, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "FIN";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(277, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "INICIO";
            // 
            // btnfiltro
            // 
            this.btnfiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnfiltro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfiltro.Location = new System.Drawing.Point(549, 498);
            this.btnfiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(110, 28);
            this.btnfiltro.TabIndex = 8;
            this.btnfiltro.Text = "Filtro por fecha";
            this.btnfiltro.UseVisualStyleBackColor = true;
            this.btnfiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpfin
            // 
            this.dtpfin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpfin.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpfin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfin.Location = new System.Drawing.Point(704, 432);
            this.dtpfin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(338, 28);
            this.dtpfin.TabIndex = 7;
            // 
            // dtpinicio
            // 
            this.dtpinicio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpinicio.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpinicio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpinicio.Location = new System.Drawing.Point(141, 432);
            this.dtpinicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(343, 28);
            this.dtpinicio.TabIndex = 6;
            // 
            // Ventasx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ventasx";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventasx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtventas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtventas;
        private System.Windows.Forms.Label lblhello;
        private Panel panel1;
        private DateTimePicker dtpfin;
        private DateTimePicker dtpinicio;
        private Label label2;
        private Label label1;
        private Button btnfiltro;
        private Button btnnormal;
        private Label lblventas;
        private TextBox tbfolio;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox btnRegresar;
    }
}
