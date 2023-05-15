using GestionClientes.dao;
using GestionClientes.models;

namespace GestionClientes
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void limpiarTextBox()
        {
            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Email = txtEmail.Text;
            cliente.Id = lblId.Text;

            ClienteDao basedeDatos = new ClienteDao();

            if (lblId.Text == "")
            {
                basedeDatos.Guardar(cliente);
                listClientes.Items.Add(cliente);
            } else
            {
                basedeDatos.Actualizar(cliente);
            }

            limpiarTextBox();
            actualizarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedItem != null)
            {
                Cliente cliente = (Cliente)listClientes.SelectedItem;
                ClienteDao basedeDatos = new ClienteDao();
                basedeDatos.Eliminar(cliente);
                limpiarTextBox();
                actualizarLista();
            }
            else
            {
                // Si no se ha seleccionado ningún elemento, puedes mostrar un mensaje de error o simplemente ignorar el evento de eliminación.
                MessageBox.Show("Por favor seleccione un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarLista()
        {
            ClienteDao basedeDatos = new ClienteDao();
            List<Cliente> listaDb = basedeDatos.ObtenerListadoDeClientes();
            listClientes.Items.Clear();

            foreach (Cliente clienteString in listaDb)
            {
                listClientes.Items.Add(clienteString);
            }
        }



        private void GestionClientes_Load(object sender, EventArgs e)
        {

            actualizarLista();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;

            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtEmail.Text = cliente.Email;
            txtTelefono.Text = cliente.Telefono;
            lblId.Text = cliente.Id;

        }


    }
}