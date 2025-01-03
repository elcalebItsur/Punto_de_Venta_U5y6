﻿using pv.Backend;
using pv.Frontend.Login;
using System;
using System.Windows.Forms;

namespace pv.Frontend.Registro
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            tbname.KeyUp += new KeyEventHandler(tbname_KeyUp);
            tbuser.KeyUp += new KeyEventHandler(tbuser_KeyUp);
            tbpass.KeyUp += new KeyEventHandler(tbpass_KeyUp);
            tbpassc.KeyUp += new KeyEventHandler(tbpassc_KeyUp);
            tbmail.KeyUp += new KeyEventHandler(tbmail_KeyUp);
            tbphone.KeyUp += new KeyEventHandler(tbphone_KeyUp);
            tbname.Focus();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            bool confirmed = Confirmar.Show("¿Estás seguro de que quieres retroceder?\nNo se guardarán los cambios realizados.");
            if (confirmed)
            {
                this.Hide();
                Ingreso ingreso = new Ingreso();
                ingreso.Show();
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Employees empleado = new Employees();

                string nombre = tbname.Text.Trim();
                string user = tbuser.Text.Trim();
                string pass = tbpass.Text.Trim();
                string passc = tbpassc.Text.Trim();
                string correo = tbmail.Text.Trim();
                string tel = tbphone.Text.Trim();

                string res = empleado.validar_insersion(0, nombre, user, pass, passc, correo, tel);
                if (res == "OK")
                {
                    bool x = empleado.insert_employees(nombre, user, pass, correo, tel);

                    if (x)
                    {
                        this.Hide();
                        Ingreso ingreso = new Ingreso();
                        ingreso.Show();
                        res = "Usuario creado correctamente.";
                    }
                    else
                    {
                        res = "Hubo un problema en la base de datos. Inténtelo más tarde.";
                    }

                }

                MessageBox.Show(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool confirmed = Confirmar.Show("¿Estás seguro de que quieres regresar a la página anterior?\nSe perderá la información no guardada.");
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

        private void tbname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbmail.Focus();
            }
        }

        private void tbuser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbpass.Focus();
            }
        }

        private void tbpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbpassc.Focus();
            }
        }

        private void tbpassc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistrar.Focus();
            }
        }

        private void tbmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbphone.Focus();
            }
        }

        private void tbphone_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbuser.Focus(); // Opcionalmente, enfocar el botón "Crear" al final
            }
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            tbname.Focus();
        }

        private void lblNombreMenu_Click(object sender, EventArgs e)
        {

        }


        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Employees ee = new Employees();

                string nombre = tbname.Text.Trim();
                string user = tbuser.Text.Trim();
                string pass = tbpass.Text.Trim();
                string passc = tbpassc.Text.Trim();
                string correo = tbmail.Text.Trim();
                string tel = tbphone.Text.Trim();

                string res = ee.validar_insersion(0, nombre, user, pass, passc, correo, tel);
                if (res == "OK")
                {
                    bool x = ee.insert_employees(nombre, user, pass, correo, tel);

                    if (x)
                    {
                        this.Hide();
                        Ingreso ingreso = new Ingreso();
                        ingreso.Show();
                        res = "Usuario creado correctamente.";
                    }
                    else
                    {
                        res = "Hubo un problema en la base de datos. Inténtelo más tarde.";
                    }

                }

                MessageBox.Show(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
