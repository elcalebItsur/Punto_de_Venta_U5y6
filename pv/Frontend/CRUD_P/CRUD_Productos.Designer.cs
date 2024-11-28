namespace pv.Frontend
{
    partial class CRUD_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Productos));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.btnBorrarProd = new System.Windows.Forms.PictureBox();
            this.btnModificarProd = new System.Windows.Forms.PictureBox();
            this.btnAniadirProd = new System.Windows.Forms.PictureBox();
            this.Productos = new System.Windows.Forms.Label();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAniadirProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(25, 85);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1132, 459);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnActualizarTabla);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnBorrarProd);
            this.panel1.Controls.Add(this.btnModificarProd);
            this.panel1.Controls.Add(this.btnAniadirProd);
            this.panel1.Controls.Add(this.Productos);
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 680);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 637);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 124;
            this.label4.Text = "Regresar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(985, 637);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 123;
            this.label3.Text = "Eliminar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 122;
            this.label2.Text = "Modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 121;
            this.label1.Text = "Añadir";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(25, 605);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(82, 30);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 120;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnBorrarProd
            // 
            this.btnBorrarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarProd.Image")));
            this.btnBorrarProd.Location = new System.Drawing.Point(985, 569);
            this.btnBorrarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarProd.Name = "btnBorrarProd";
            this.btnBorrarProd.Size = new System.Drawing.Size(82, 66);
            this.btnBorrarProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBorrarProd.TabIndex = 119;
            this.btnBorrarProd.TabStop = false;
            this.btnBorrarProd.Click += new System.EventHandler(this.btnBorrarProd_Click);
            // 
            // btnModificarProd
            // 
            this.btnModificarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarProd.Image")));
            this.btnModificarProd.Location = new System.Drawing.Point(614, 569);
            this.btnModificarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarProd.Name = "btnModificarProd";
            this.btnModificarProd.Size = new System.Drawing.Size(82, 66);
            this.btnModificarProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnModificarProd.TabIndex = 118;
            this.btnModificarProd.TabStop = false;
            this.btnModificarProd.Click += new System.EventHandler(this.btnModificarProd_Click);
            // 
            // btnAniadirProd
            // 
            this.btnAniadirProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAniadirProd.Image = ((System.Drawing.Image)(resources.GetObject("btnAniadirProd.Image")));
            this.btnAniadirProd.Location = new System.Drawing.Point(252, 569);
            this.btnAniadirProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAniadirProd.Name = "btnAniadirProd";
            this.btnAniadirProd.Size = new System.Drawing.Size(82, 66);
            this.btnAniadirProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAniadirProd.TabIndex = 117;
            this.btnAniadirProd.TabStop = false;
            this.btnAniadirProd.Click += new System.EventHandler(this.btnAniadirProd_Click);
            // 
            // Productos
            // 
            this.Productos.AccessibleName = "Productos";
            this.Productos.AutoSize = true;
            this.Productos.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.Location = new System.Drawing.Point(15, 10);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(319, 73);
            this.Productos.TabIndex = 1;
            this.Productos.Text = "Productos";
            this.Productos.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizarTabla.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTabla.Location = new System.Drawing.Point(953, 50);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(204, 33);
            this.btnActualizarTabla.TabIndex = 125;
            this.btnActualizarTabla.Text = "Actualizar Tabla";
            this.btnActualizarTabla.UseVisualStyleBackColor = false;
            this.btnActualizarTabla.Click += new System.EventHandler(this.btnActualizarTabla_Click);
            // 
            // CRUD_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CRUD_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOLA!";
            this.Load += new System.EventHandler(this.CRUD_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAniadirProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Productos;
        private System.Windows.Forms.PictureBox btnAniadirProd;
        private System.Windows.Forms.PictureBox btnModificarProd;
        private System.Windows.Forms.PictureBox btnBorrarProd;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizarTabla;
    }
}