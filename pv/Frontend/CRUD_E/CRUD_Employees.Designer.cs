namespace pv
{
    partial class CRUD_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Employees));
            this.dtemployees = new System.Windows.Forms.DataGridView();
            this.lblhello = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarEmp = new System.Windows.Forms.PictureBox();
            this.btnModificarEmp = new System.Windows.Forms.PictureBox();
            this.btnAniadir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtemployees)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAniadir)).BeginInit();
            this.SuspendLayout();
            // 
            // dtemployees
            // 
            this.dtemployees.AllowUserToAddRows = false;
            this.dtemployees.AllowUserToDeleteRows = false;
            this.dtemployees.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtemployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtemployees.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtemployees.Location = new System.Drawing.Point(145, 75);
            this.dtemployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtemployees.Name = "dtemployees";
            this.dtemployees.ReadOnly = true;
            this.dtemployees.RowHeadersWidth = 62;
            this.dtemployees.RowTemplate.Height = 28;
            this.dtemployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtemployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtemployees.Size = new System.Drawing.Size(951, 453);
            this.dtemployees.TabIndex = 0;
            this.dtemployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtemployees_CellClick);
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblhello.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhello.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblhello.Location = new System.Drawing.Point(201, 9);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(645, 47);
            this.lblhello.TabIndex = 5;
            this.lblhello.Text = "Bienvenido al CRUD EMPLEADOS";
            this.lblhello.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnActualizarTabla);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBorrarEmp);
            this.panel1.Controls.Add(this.btnModificarEmp);
            this.panel1.Controls.Add(this.btnAniadir);
            this.panel1.Controls.Add(this.lblhello);
            this.panel1.Controls.Add(this.dtemployees);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 677);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.BackColor = System.Drawing.Color.Yellow;
            this.btnActualizarTabla.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTabla.Location = new System.Drawing.Point(946, 491);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(150, 37);
            this.btnActualizarTabla.TabIndex = 127;
            this.btnActualizarTabla.Text = "Actualizar Tabla";
            this.btnActualizarTabla.UseVisualStyleBackColor = false;
            this.btnActualizarTabla.Click += new System.EventHandler(this.btnActualizarTabla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(36, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 126;
            this.label4.Text = "Regresar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(942, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 118;
            this.label3.Text = "Eliminar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(37, 595);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(82, 30);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 125;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(595, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 117;
            this.label2.Text = "Modificar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(230, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 116;
            this.label1.Text = "Añadir";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnBorrarEmp
            // 
            this.btnBorrarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarEmp.Image")));
            this.btnBorrarEmp.Location = new System.Drawing.Point(941, 559);
            this.btnBorrarEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarEmp.Name = "btnBorrarEmp";
            this.btnBorrarEmp.Size = new System.Drawing.Size(82, 66);
            this.btnBorrarEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBorrarEmp.TabIndex = 115;
            this.btnBorrarEmp.TabStop = false;
            this.btnBorrarEmp.Click += new System.EventHandler(this.btnBorrarEmp_Click);
            // 
            // btnModificarEmp
            // 
            this.btnModificarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarEmp.Image")));
            this.btnModificarEmp.Location = new System.Drawing.Point(599, 559);
            this.btnModificarEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarEmp.Name = "btnModificarEmp";
            this.btnModificarEmp.Size = new System.Drawing.Size(82, 66);
            this.btnModificarEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnModificarEmp.TabIndex = 114;
            this.btnModificarEmp.TabStop = false;
            this.btnModificarEmp.Click += new System.EventHandler(this.btnModificarEmp_Click);
            // 
            // btnAniadir
            // 
            this.btnAniadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAniadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAniadir.Image")));
            this.btnAniadir.Location = new System.Drawing.Point(227, 559);
            this.btnAniadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(82, 66);
            this.btnAniadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAniadir.TabIndex = 113;
            this.btnAniadir.TabStop = false;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // CRUD_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 677);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CRUD_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOLA!";
            this.Load += new System.EventHandler(this.CRUD_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtemployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAniadir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtemployees;
        private System.Windows.Forms.Label lblhello;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBorrarEmp;
        private System.Windows.Forms.PictureBox btnModificarEmp;
        private System.Windows.Forms.PictureBox btnAniadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Button btnActualizarTabla;
    }
}

