namespace pv.Frontend
{
    partial class CRUD_Clients
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dtclients;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Clients));
            this.dtclients = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarCli = new System.Windows.Forms.PictureBox();
            this.btnModificarCli = new System.Windows.Forms.PictureBox();
            this.btnAniadir = new System.Windows.Forms.PictureBox();
            this.f = new System.Windows.Forms.Label();
            this.btnRecargarVentana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtclients)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAniadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // dtclients
            // 
            this.dtclients.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtclients.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtclients.Location = new System.Drawing.Point(56, 59);
            this.dtclients.Name = "dtclients";
            this.dtclients.RowHeadersWidth = 62;
            this.dtclients.Size = new System.Drawing.Size(629, 378);
            this.dtclients.TabIndex = 0;
            this.dtclients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtclients_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnRecargarVentana);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBorrarCli);
            this.panel1.Controls.Add(this.btnModificarCli);
            this.panel1.Controls.Add(this.btnAniadir);
            this.panel1.Controls.Add(this.f);
            this.panel1.Controls.Add(this.dtclients);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 599);
            this.panel1.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 134;
            this.label4.Text = "Regresar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 132;
            this.label3.Text = "Eliminar";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(52, 500);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(82, 30);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 133;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 131;
            this.label2.Text = "Modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 130;
            this.label1.Text = "Añadir";
            // 
            // btnBorrarCli
            // 
            this.btnBorrarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarCli.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarCli.Image")));
            this.btnBorrarCli.Location = new System.Drawing.Point(579, 462);
            this.btnBorrarCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarCli.Name = "btnBorrarCli";
            this.btnBorrarCli.Size = new System.Drawing.Size(82, 66);
            this.btnBorrarCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBorrarCli.TabIndex = 129;
            this.btnBorrarCli.TabStop = false;
            this.btnBorrarCli.Click += new System.EventHandler(this.btnBorrarCli_Click);
            // 
            // btnModificarCli
            // 
            this.btnModificarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCli.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarCli.Image")));
            this.btnModificarCli.Location = new System.Drawing.Point(355, 462);
            this.btnModificarCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarCli.Name = "btnModificarCli";
            this.btnModificarCli.Size = new System.Drawing.Size(82, 66);
            this.btnModificarCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnModificarCli.TabIndex = 128;
            this.btnModificarCli.TabStop = false;
            this.btnModificarCli.Click += new System.EventHandler(this.btnModificarCli_Click);
            // 
            // btnAniadir
            // 
            this.btnAniadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAniadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAniadir.Image")));
            this.btnAniadir.Location = new System.Drawing.Point(181, 462);
            this.btnAniadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(82, 66);
            this.btnAniadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAniadir.TabIndex = 127;
            this.btnAniadir.TabStop = false;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.Location = new System.Drawing.Point(48, 9);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(401, 47);
            this.f.TabIndex = 117;
            this.f.Text = "Gestión de Clientes";
            // 
            // btnRecargarVentana
            // 
            this.btnRecargarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargarVentana.Image")));
            this.btnRecargarVentana.Location = new System.Drawing.Point(646, 18);
            this.btnRecargarVentana.Name = "btnRecargarVentana";
            this.btnRecargarVentana.Size = new System.Drawing.Size(39, 38);
            this.btnRecargarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecargarVentana.TabIndex = 135;
            this.btnRecargarVentana.TabStop = false;
            this.btnRecargarVentana.Click += new System.EventHandler(this.btnRecargarVentana_Click);
            // 
            // CRUD_Clients
            // 
            this.ClientSize = new System.Drawing.Size(1161, 599);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUD_Clients";
            this.Text = "Gestión de Clientes";
            this.Load += new System.EventHandler(this.CRUD_Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtclients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificarCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAniadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargarVentana)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBorrarCli;
        private System.Windows.Forms.PictureBox btnModificarCli;
        private System.Windows.Forms.PictureBox btnAniadir;
        private System.Windows.Forms.PictureBox btnRecargarVentana;
    }
}
