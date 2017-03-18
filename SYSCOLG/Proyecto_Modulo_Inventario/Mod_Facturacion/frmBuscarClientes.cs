using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Modulo_Inventario.Mod_Facturacion
{
    public partial class frmBuscarClientes : Form
    {

        Validaciones_y_Mas.Validar_caja_texto cajasTexto;
        Negocios.Constructores.TblClientes tClientes;
        Negocios.Logico.buscarCliente buscarClientes;

        public int idCliente = 0;
        public String descripcion = "", cedula = "", direccion = "", telefono = "";


        public frmBuscarClientes()
        {
            InitializeComponent();
        }

        private void frmBuscarClientes_Load(object sender, EventArgs e)
        {
            txtClienteDescripcion.Focus();
            cargarGrid();
        }

        private void vaciarCajas()
        {
            cajasTexto = new Validaciones_y_Mas.Validar_caja_texto();
            cajasTexto.vaciarCajas(this);
            
            this.txtClienteDescripcion.Focus();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarGrid()
        {
            try
            {
                buscarClientes = new Negocios.Logico.buscarCliente();
                List<Negocios.Constructores.TblClientes> lst = buscarClientes.cargarGrid();

                dgvBuscarCliente.Rows.Clear();
                //dgvEmpresa.DataSource = lst;
                int i = 0;

                foreach (Negocios.Constructores.TblClientes tClientes in lst)
                {
                    dgvBuscarCliente.Rows.Add();

                    dgvBuscarCliente[0, i].Value = tClientes.getIdCliente();
                    dgvBuscarCliente[1, i].Value = tClientes.getCedulaCliente();
                    dgvBuscarCliente[2, i].Value = tClientes.getNombresCliente() + " " + tClientes.getApellidosCliente();
                    dgvBuscarCliente[3, i].Value = tClientes.getDireccion();
                    dgvBuscarCliente[4, i].Value = tClientes.getTelefono();
                    i++;
                }

            }
            catch (Exception err)
            {

            }

        }

        private void dgvBuscarCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tClientes = new Negocios.Constructores.TblClientes();
            idCliente= Convert.ToInt32(dgvBuscarCliente[0, e.RowIndex].Value.ToString());
            cedula = dgvBuscarCliente[1, e.RowIndex].Value.ToString();
            descripcion = dgvBuscarCliente[2, e.RowIndex].Value.ToString();
            direccion = dgvBuscarCliente[3, e.RowIndex].Value.ToString();
            telefono = dgvBuscarCliente[4, e.RowIndex].Value.ToString();
            this.Close();
        }
    }
}
