﻿using System;
using System.Windows.Forms;
using pv.Backend;
using pv.Frontend;

namespace pv
{
    public partial class CRUD_Employees : Form
    {
        private Connection c = new Connection();
        private Employees e;
        private int id;
        private string nombre;
        private string usuario;
        private string correo;
        private string telefono;
        public CRUD_Employees()
        {
            Console.WriteLine("Bienvenido al CRUD de empleados!");
            InitializeComponent();
            e = new Employees();
            LoadData();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CRUD_Employees_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtemployees.DataSource = e.select_employees();
        }

        private void dtemployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dtemployees.Rows.Count)
                {
                    DataGridViewRow selectedRow = dtemployees.Rows[e.RowIndex];
                    id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    nombre = selectedRow.Cells["Nombre"].Value.ToString();
                    usuario = selectedRow.Cells["Usuario"].Value.ToString();
                    correo = selectedRow.Cells["Correo"].Value.ToString();
                    telefono = selectedRow.Cells["Telefono"].Value.ToString();

                    btnBorrarEmp.Enabled = true;
                    btnModificarEmp.Enabled = true;
                }
                else
                {
                    btnBorrarEmp.Enabled = false;
                    btnModificarEmp.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmed = Confirmar.Show("¿Estás seguro de que quieres eliminar el usuario?\nUna vez hecho, no podrás deshacer la acción.");
                if (confirmed)
                {
                    Employees ee = new Employees();
                    ee.delete_employees(id);
                    LoadData();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAniadir_Click(object sender, EventArgs e)
        {
            Create_Employee f = new Create_Employee();
            f.Show();
        }

        private void btnModificarEmp_Click(object sender, EventArgs e)
        {
            Update_Employee ue = new Update_Employee(id, nombre, usuario, correo, telefono);
            ue.Show();
        }

        private void btnBorrarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmed = Confirmar.Show("¿Estás seguro de que quieres eliminar el usuario?\nUna vez hecho, no podrás deshacer la acción.");
                if (confirmed)
                {
                    Employees ee = new Employees();
                    ee.delete_employees(id);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            VentanaPrincipal m = new VentanaPrincipal();
            m.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRecargarVentana_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
