using System;
using System.Windows.Forms;
using pv.Backend;

namespace pv.Frontend
{
    public partial class Create_Clients : Form
    {
        public Create_Clients()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // se validan los datos del tbx y cuando se hace, se decide si insertarse o no el cliente, llamando al método insertclient para lo primero
            try
            {   
                Clients clienteNuevo = new Clients();
                string nombre = tbname.Text.Trim();
                string telefono = tbphone.Text.Trim();
                int edad = Convert.ToInt32(tbage.Text.Trim());
                string sexo = rbmale.Checked ? "M" : "F";

                string val = clienteNuevo.validar_cliente(nombre, telefono, edad.ToString(), sexo);
                if (val == "OK")
                {
                    bool result = clienteNuevo.InsertClient(nombre, telefono, edad, sexo);

                    if (result)
                    {
                        MessageBox.Show("Cliente creado correctamente.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al crear el cliente.");
                    }
                }
                else
                {
                    MessageBox.Show(val);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al crear el cliente.");
            }
        }

        private void Create_Clients_Load(object sender, EventArgs e)
        {

        }
        // cambiar de form
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
