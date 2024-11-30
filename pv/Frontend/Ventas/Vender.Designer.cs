namespace pv.Frontend.Ventas
{
    partial class Vender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            this.dtventa = new System.Windows.Forms.DataGridView();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tbcod = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpaga = new System.Windows.Forms.Label();
            this.btnventa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblimpuestos = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.lblcajero = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbpago = new System.Windows.Forms.ComboBox();
            this.tbpaga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtventa)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtventa
            // 
            this.dtventa.AllowUserToAddRows = false;
            this.dtventa.AllowUserToDeleteRows = false;
            this.dtventa.AllowUserToOrderColumns = true;
            this.dtventa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtventa.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtventa.Location = new System.Drawing.Point(276, 49);
            this.dtventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtventa.MultiSelect = false;
            this.dtventa.Name = "dtventa";
            this.dtventa.RowHeadersWidth = 62;
            this.dtventa.RowTemplate.Height = 28;
            this.dtventa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtventa.Size = new System.Drawing.Size(880, 484);
            this.dtventa.TabIndex = 2;
            this.dtventa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtventa_CellClick);
            this.dtventa.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtventa_CellValidating);
            this.dtventa.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtventa_RowsAdded);
            this.dtventa.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtventa_RowsRemoved);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblfecha.Location = new System.Drawing.Point(989, 9);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(166, 16);
            this.lblfecha.TabIndex = 3;
            this.lblfecha.Text = "Fecha: 0000-00-00 00:00:00";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(678, 25);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(67, 23);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "TOTAL";
            // 
            // tbcod
            // 
            this.tbcod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcod.Location = new System.Drawing.Point(40, 118);
            this.tbcod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcod.MaxLength = 13;
            this.tbcod.Name = "tbcod";
            this.tbcod.Size = new System.Drawing.Size(175, 26);
            this.tbcod.TabIndex = 6;
            this.tbcod.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnadd.Enabled = false;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(59, 158);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(139, 40);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Añadir";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Enabled = false;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(59, 309);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(139, 40);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "Eliminar";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo de Barras";
            // 
            // lblpaga
            // 
            this.lblpaga.AutoSize = true;
            this.lblpaga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblpaga.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaga.Location = new System.Drawing.Point(21, 25);
            this.lblpaga.Name = "lblpaga";
            this.lblpaga.Size = new System.Drawing.Size(52, 19);
            this.lblpaga.TabIndex = 11;
            this.lblpaga.Text = "Paga";
            // 
            // btnventa
            // 
            this.btnventa.BackColor = System.Drawing.Color.Lime;
            this.btnventa.Enabled = false;
            this.btnventa.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.Location = new System.Drawing.Point(59, 459);
            this.btnventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(139, 59);
            this.btnventa.TabIndex = 13;
            this.btnventa.Text = "Realizar venta";
            this.btnventa.UseVisualStyleBackColor = false;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.lblcajero);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtventa);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.tbcod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbpago);
            this.panel1.Controls.Add(this.tbpaga);
            this.panel1.Controls.Add(this.btnventa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 633);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 126;
            this.label2.Text = "Regresar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblpaga);
            this.panel2.Controls.Add(this.lblsubtotal);
            this.panel2.Controls.Add(this.lblimpuestos);
            this.panel2.Controls.Add(this.lbltotal);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(276, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 71);
            this.panel2.TabIndex = 22;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(238, 27);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(73, 19);
            this.lblsubtotal.TabIndex = 17;
            this.lblsubtotal.Text = "Subtotal";
            // 
            // lblimpuestos
            // 
            this.lblimpuestos.AutoSize = true;
            this.lblimpuestos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimpuestos.Location = new System.Drawing.Point(444, 27);
            this.lblimpuestos.Name = "lblimpuestos";
            this.lblimpuestos.Size = new System.Drawing.Size(93, 19);
            this.lblimpuestos.TabIndex = 18;
            this.lblimpuestos.Text = "Impuestos";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(85, 562);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(82, 30);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 125;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblcajero
            // 
            this.lblcajero.AutoSize = true;
            this.lblcajero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcajero.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcajero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblcajero.Location = new System.Drawing.Point(23, 9);
            this.lblcajero.Name = "lblcajero";
            this.lblcajero.Size = new System.Drawing.Size(102, 29);
            this.lblcajero.TabIndex = 21;
            this.lblcajero.Text = "Cajero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Elige el producto a borrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(393, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 11;
            // 
            // cbpago
            // 
            this.cbpago.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbpago.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpago.FormattingEnabled = true;
            this.cbpago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Crédito",
            "Tarjeta de Débito",
            "Transferencia Bancaria",
            "Otro"});
            this.cbpago.Location = new System.Drawing.Point(40, 389);
            this.cbpago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbpago.Name = "cbpago";
            this.cbpago.Size = new System.Drawing.Size(175, 26);
            this.cbpago.TabIndex = 16;
            this.cbpago.Text = "Método Pago";
            this.cbpago.Visible = false;
            this.cbpago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbpaga
            // 
            this.tbpaga.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbpaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpaga.Location = new System.Drawing.Point(39, 232);
            this.tbpaga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpaga.MaxLength = 11;
            this.tbpaga.Name = "tbpaga";
            this.tbpaga.Size = new System.Drawing.Size(175, 24);
            this.tbpaga.TabIndex = 15;
            this.tbpaga.Text = "Ingrese la cantidad";
            this.tbpaga.Visible = false;
            this.tbpaga.TextChanged += new System.EventHandler(this.tbpaga_TextChanged_1);
            this.tbpaga.Enter += new System.EventHandler(this.tbpaga_Enter);
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 633);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola!";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtventa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtventa;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox tbcod;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpaga;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbpaga;
        private System.Windows.Forms.ComboBox cbpago;
        private System.Windows.Forms.Label lblimpuestos;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblcajero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnRegresar;
    }
}