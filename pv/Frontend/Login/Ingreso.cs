using pv.Backend;
using pv.Frontend.Login;
using pv.Frontend.Registro;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace pv.Frontend.Login
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
            this.txtUsuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso ingreso = new Ingreso();
            ingreso.Show();
        }



        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
        


        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos de texto.");
                }
                // validar contraseña (min 8 caracteres, al menos 1 mayúscula, 1 minúscula, 1 número y 1 carácter especial)
                else if (!Regex.Match(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$").Success)
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluir mayúsculas, minúsculas, números y caracteres especiales.");
                }
                else
                {
                    Employees empleado = new Employees();
                    var empleadoAcceso = empleado.validar_login(txtUsuario.Text, txtPassword.Text);

                    if (empleadoAcceso.Item2 == "Usuario o contraseña incorrectos.")
                    {
                        MessageBox.Show(empleadoAcceso.Item2);
                    }
                    else
                    {
                        Application.UserAppDataRegistry.SetValue("ID", empleadoAcceso.Item1);
                        Application.UserAppDataRegistry.SetValue("User", empleadoAcceso.Item2);
                        this.Hide();
                        VentanaPrincipal m = new VentanaPrincipal();
                        m.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            r.Show();
            this.Hide();
        }
    }
}
