using System;
using System.Windows.Forms;
using pv.Frontend.Vistas;
using pv.Frontend.Login;
using pv.Frontend.Registro;
using pv.Frontend.Ventas;

namespace pv.Frontend
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            var xid = Application.UserAppDataRegistry.GetValue("ID");
            var xuser = Application.UserAppDataRegistry.GetValue("User");
            Console.WriteLine($"{xid} {xuser}");
            InitializeComponent();
            this.Text = $"Bienvenido {xuser} :D!";
        }

        private void btnCRUDP_Click(object sender, EventArgs e)
        {
            CRUD_Productos ce = new CRUD_Productos();
            ce.Show();
            this.Hide();
        }

        private void btnCRUDE_Click(object sender, EventArgs e)
        {
            CRUD_Employees ce = new CRUD_Employees();
            ce.Show();
            this.Hide();
        }

        private void btnventasd_Click(object sender, EventArgs e)
        {
            Ventasx vd = new Ventasx();
            vd.Show();
            this.Hide();
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            Vender v = new Vender();
            v.Show();
            this.Hide();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnticket_Click(object sender, EventArgs e)
        {
            VentaHecha v = new VentaHecha();
            v.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool confirmed = Confirmar.Show("¿Estás seguro de que quieres regresar a la ventana principal?.");
                if (confirmed)
                {
                    this.Hide();
                    Ingreso ingreso = new Ingreso();
                    ingreso.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormHoja(new CRUD_Productos());
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            abrirFormHoja(new Vender());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormHoja(new CRUD_Employees());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormHoja(new Ventasx());
            
        }

        private void abrirFormHoja(object formHija)
        {
            if (this.pnlContedor.Controls.Count > 0)
            {
                this.pnlContedor.Controls.Clear();
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContedor.Controls.Add(fh);
            this.pnlContedor.Tag = fh;
            fh.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlContedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
