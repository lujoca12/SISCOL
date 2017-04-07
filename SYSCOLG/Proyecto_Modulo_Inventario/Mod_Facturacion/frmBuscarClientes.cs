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
        Negocios.Logico.clientes clientes;

        public int idCliente = 0;
        public String descripcion = "", cedula = "", direccion = "", telefono = "", cupo = "";


        public frmBuscarClientes()
        {
            InitializeComponent();
        }

        private void frmBuscarClientes_Load(object sender, EventArgs e)
        {
            cboTipoBusqueda.SelectedIndex = 0;
            txtClienteDescripcion.Focus();
            buscar();
            
        }

        private void vaciarCajas()
        {
            cajasTexto = new Validaciones_y_Mas.Validar_caja_texto();
            cajasTexto.vaciarCajas(this);
            
            this.txtClienteDescripcion.Focus();
        }

        private void dgvBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                clienteSeleccionado(dgvBuscarCliente.CurrentCell.RowIndex);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            busqClientesAvanzada();
        }
        private void busqClientesAvanzada()
        {
            clientes = new Negocios.Logico.clientes();
            if (cboTipoBusqueda.Text.Equals("Al Inicio"))
            {
                if(rbCedRuc.Checked)
                {
                    List<Negocios.Constructores.TblClientes> lst = clientes.buscarClientesAvanzados(txtClienteDescripcion.Text, "", 3, "i");
                    cargarGrid(lst);
                }
                else if (rbDescripcion.Checked)
                {
                    List<Negocios.Constructores.TblClientes> lst = clientes.buscarClientesAvanzados("", txtClienteDescripcion.Text, 3, "i");
                    cargarGrid(lst);
                }
            }
            else if(cboTipoBusqueda.Text.Equals("Que Contenga"))
            {
                if (rbCedRuc.Checked)
                {
                    List<Negocios.Constructores.TblClientes> lst = clientes.buscarClientesAvanzados(txtClienteDescripcion.Text, "", 3, "%");
                    cargarGrid(lst);
                }
                else if (rbDescripcion.Checked)
                {
                    List<Negocios.Constructores.TblClientes> lst = clientes.buscarClientesAvanzados("", txtClienteDescripcion.Text, 3, "%");
                    cargarGrid(lst);
                }
            }
            dgvBuscarCliente.Focus();
        }

        private void txtClienteDescripcion_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                busqClientesAvanzada();
            }
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar()
        {
            try
            {
                buscarClientes = new Negocios.Logico.buscarCliente();
                clientes = new Negocios.Logico.clientes();
                List<Negocios.Constructores.TblClientes> lst = clientes.cargarGrid();
                cargarGrid(lst);
            }
            catch (Exception err)
            {

            }
        }

        private void cargarGrid(List<Negocios.Constructores.TblClientes> lst)
        {
            try
            {
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
                    dgvBuscarCliente[5, i].Value = tClientes.getSaldo();
                    i++;
                }
               

            }
            catch (Exception err)
            {

            }

        }

        private void dgvBuscarCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clienteSeleccionado(e.RowIndex);
        }
        private void clienteSeleccionado(int filaSeleccionada)
        {
            tClientes = new Negocios.Constructores.TblClientes();
            idCliente = Convert.ToInt32(dgvBuscarCliente[0, filaSeleccionada].Value.ToString());
            cedula = dgvBuscarCliente[1, filaSeleccionada].Value.ToString();
            descripcion = dgvBuscarCliente[2, filaSeleccionada].Value.ToString();
            direccion = dgvBuscarCliente[3, filaSeleccionada].Value.ToString();
            telefono = dgvBuscarCliente[4, filaSeleccionada].Value.ToString();
            cupo = dgvBuscarCliente[5, filaSeleccionada].Value.ToString();
            this.Close();
        }
    }
}
