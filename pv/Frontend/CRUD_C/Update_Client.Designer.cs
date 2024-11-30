namespace pv.Frontend
{
    partial class Update_Clients
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbage;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblgender;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Clients));
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbage = new System.Windows.Forms.TextBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.f = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(169, 20);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(200, 28);
            this.tbname.TabIndex = 0;
            // 
            // tbphone
            // 
            this.tbphone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbphone.Location = new System.Drawing.Point(169, 75);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(200, 28);
            this.tbphone.TabIndex = 1;
            // 
            // tbage
            // 
            this.tbage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbage.Location = new System.Drawing.Point(169, 126);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(200, 28);
            this.tbage.TabIndex = 2;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.Location = new System.Drawing.Point(140, 177);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(114, 23);
            this.rbmale.TabIndex = 3;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Masculino";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(251, 177);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(111, 23);
            this.rbfemale.TabIndex = 4;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Femenino";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Lime;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdate.Location = new System.Drawing.Point(282, 206);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(80, 40);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Modificar";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(54, 26);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(81, 19);
            this.lblname.TabIndex = 7;
            this.lblname.Text = "Nombre:";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(48, 78);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(84, 19);
            this.lblphone.TabIndex = 8;
            this.lblphone.Text = "Teléfono:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(72, 135);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(56, 19);
            this.lblage.TabIndex = 9;
            this.lblage.Text = "Edad:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(72, 177);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(55, 19);
            this.lblgender.TabIndex = 10;
            this.lblgender.Text = "Sexo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.f);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 351);
            this.panel1.TabIndex = 11;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.Location = new System.Drawing.Point(80, 22);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(369, 40);
            this.f.TabIndex = 118;
            this.f.Text = "Modificar de Clientes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Controls.Add(this.tbname);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.lblgender);
            this.panel2.Controls.Add(this.rbfemale);
            this.panel2.Controls.Add(this.lblphone);
            this.panel2.Controls.Add(this.rbmale);
            this.panel2.Controls.Add(this.tbphone);
            this.panel2.Controls.Add(this.lblage);
            this.panel2.Controls.Add(this.tbage);
            this.panel2.Location = new System.Drawing.Point(45, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 263);
            this.panel2.TabIndex = 11;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(40, 221);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(80, 25);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 135;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Update_Clients
            // 
            this.ClientSize = new System.Drawing.Size(539, 351);
            this.Controls.Add(this.panel1);
            this.Name = "Update_Clients";
            this.Text = "Actualizar Cliente";
            this.Load += new System.EventHandler(this.Update_Clients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.PictureBox btnRegresar;
    }
}
