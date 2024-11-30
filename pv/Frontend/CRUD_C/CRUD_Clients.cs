using System;
using System.Windows.Forms;
using pv.Backend;

namespace pv.Frontend
{
    public partial class CRUD_Clients : Form
    {
        private Clients c;
        private int id;
        private string nombre;
        private string telefono;
        private int edad;
        private string sexo;

        public CRUD_Clients()
        {
            InitializeComponent();
            c = new Clients();
            LoadData(); 
        }

        private void CRUD_Clients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // cargar datos
        private void LoadData()
        {
            try
            {
                var clientsList = c.SelectClients();
                dtclients.DataSource = clientsList; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // evento para habilitar el boton de borrar y eliminar al presionar una celda valida
        private void dtclients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dtclients.Rows.Count)
                {
                    DataGridViewRow selectedRow = dtclients.Rows[e.RowIndex];
                    id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    nombre = selectedRow.Cells["Nombre"].Value.ToString();
                    telefono = selectedRow.Cells["Telefono"].Value.ToString();
                    edad = Convert.ToInt32(selectedRow.Cells["Edad"].Value);
                    sexo = selectedRow.Cells["Sexo"].Value.ToString();

                    btnBorrarCli.Enabled = true;
                    btnModificarCli.Enabled = true;
                }
                else
                {
                    btnBorrarCli.Enabled = false;
                    btnModificarCli.Enabled = false;
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
        // cambiar a crear cliente
        private void btnAniadir_Click(object sender, EventArgs e)
        {
            Create_Clients f = new Create_Clients();
            f.Show();
        }
        // cambiar a actualizar cliente
        private void btnModificarCli_Click(object sender, EventArgs e)
        {
            Update_Clients ue = new Update_Clients(id, nombre, telefono, edad, sexo);
            ue.Show();
        }
        // para borrar, primero salta un mensaje de confitmación, y en base a la decision, se borra o no, con el metodo deleteclient
        private void btnBorrarCli_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmed = Confirmar.Show("¿Estás seguro de que quieres eliminar el cliente?\nUna vez hecho, no podrás deshacer la acción.");
                if (confirmed)
                {
                    bool success = c.DeleteClient(id);
                    if (success)
                    {
                        MessageBox.Show("Cliente eliminado correctamente.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al eliminar el cliente.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
