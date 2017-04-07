using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Modulo_Inventario.Mod_Inventario
{
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }
        Validaciones_y_Mas.Validar_caja_texto cajasTexto;
        Negocios.Constructores.TblProveedores tProveed;
        Negocios.Constructores.TblProductos tProductos;
        Negocios.Logico.productos productos;
        Negocios.Logico.tProveedores proveedores;
        DataGridViewTextBoxEditingControl dText;//variable para el grid cuando esta en edicion en una columna
        int columnaSeleccionada;
        int fila = 0;
        Point posicionFormulario;
        Boolean accionMouse;
        frmBuscarProveedores frm = null;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            posicionFormulario = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            accionMouse = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (accionMouse)
                Location = new Point(Cursor.Position.X - posicionFormulario.X, Cursor.Position.Y - posicionFormulario.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            accionMouse = false;

        }

        private void lblCerrar_MouseHover(object sender, EventArgs e)
        {
            lblCerrar.BackColor = Color.Red;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.BackColor = Color.Black;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {

            DialogResult msg;
            msg = MessageBox.Show("Desea salir del Módulo de Compras", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            this.txtIdProveedor.Focus();
            cboTipoDoc.SelectedIndex = 0;
        }

        private void frmCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
            {
                guardarCompra();
            }
            if (e.Control && e.KeyCode == Keys.F)//Evento ctrl+F buscar
            {
                buscarCompra();
            }
            if (e.Control && e.KeyCode == Keys.B)//Borrar todos los datos de la factura
            {
                eliminarDatos();
            }
            if (e.KeyCode == Keys.F1)//Nueva Factura
            {
                nuevaCompra();
            }
            if (e.KeyCode == Keys.F3)//Nuevo Proveedor
            {
                nuevoProveedor();
            }
            if (e.KeyCode == Keys.F4)//nuevo producto
            {
                nuevoProducto();
            }
            if (e.Control && e.KeyCode == Keys.L)//buscar Clientes
            {
                buscarProveedores();
            }
        }
        private void nuevoProducto()
        {
            MessageBox.Show("En Mantenimiento nueva Producto", "Mensaje del Sistema");
        }
        private void nuevoProveedor()
        {
            MessageBox.Show("En Mantenimiento nuevo Proveedor", "Mensaje del Sistema");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevaCompra();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCompra();
        }

        private void btnEliminarDatos_Click(object sender, EventArgs e)
        {
            eliminarDatos();
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            guardarCompra();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            buscarProveedores();
        }

        private void btnNuevoProd_Click(object sender, EventArgs e)
        {
            nuevoProducto();
        }
        private void buscarProveedores()
        {
            frm = new frmBuscarProveedores();
            frm.ShowDialog();
            cargarDatProveedores();
            dgvCompra.Focus();
        }
        private void cargarDatProveedores()
        {
            try
            {
                if (frm.idCliente > 0)
                {
                    txtIdProveedor.Text = Convert.ToString(frm.idCliente);
                    txtCedRucProv.Text = frm.cedula;
                    txtNombresProveedor.Text = frm.descripcion;
                }
            }
            catch (Exception err)
            {

            }
            
        }
        private void cargarProveedores(List<Negocios.Constructores.TblProveedores> lst)
        {
            foreach (Negocios.Constructores.TblProveedores tProveed in lst)
            {
                txtCedRucProv.Text = tProveed.getRucProveedor();
                txtIdProveedor.Text = tProveed.getIdProveedor().ToString();
                txtNombresProveedor.Text = tProveed.getApellidoProveed() + " " + tProveed.getNombreProveed();
            }
        }
        private void buscarCompra()
        {
            MessageBox.Show("En Mantenimiento buscar Factura", "Mensaje del Sistema");
        }
        private void guardarCompra()
        {
            MessageBox.Show("En Mantenimiento", "Mensaje del Sistema");
        }
        private void eliminarDatos()
        {
            //Falta la pregunta de seguridad
            if (dgvCompra.Rows.Count > 1)
            {
                if (dgvCompra[0, 0].Value != null)
                {
                    DialogResult msg;
                    msg = MessageBox.Show("Desea vaciar los datos de esta Compra?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (msg == DialogResult.Yes)
                    {
                        vaciarCajas();
                        vaciarTotalCompra();
                        dgvCompra.Rows.Clear();
                        dgvCompra.Focus();
                    }
                }
            }

        }
        private void vaciarTotalCompra()
        {
            txtTotalFactura.Text = "0,0000"; txtDesc.Text = "0,0000"; txtIvaFactura.Text = "0,0000";
            txtSubtotal.Text = "0,0000"; txtTotalBruto.Text = "0,0000";
        }
        private void vaciarCajas()
        {
            cajasTexto = new Validaciones_y_Mas.Validar_caja_texto();
            cajasTexto.vaciarCajas(this);
            cboTipoDoc.SelectedIndex = 0;
            this.txtIdProveedor.Focus();
        }
        private void nuevaCompra()
        {
            MessageBox.Show("En Mantenimiento nueva Compra", "Mensaje del Sistema");
        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscarProductoCodigo();
            if (e.KeyCode == Keys.Escape)
            {
                //cajasTexto = new Validaciones_y_Mas.Validar_caja_texto();
                //cajasTexto.vaciarCajas(this);
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                if (txtIdProveedor.Text != "")
                {
                    txtNombresProveedor.Text = "";
                    txtCedRucProv.Text = "";
                }
            }
        }
        private void buscarProductoCodigo()
        {
            proveedores = new Negocios.Logico.tProveedores();
            List<Negocios.Constructores.TblProveedores> lst = proveedores.buscarProveedores("", txtIdProveedor.Text, 3);
            cargarProveedores(lst);

        }
        private void txtCedRucProv_TextChanged(object sender, EventArgs e)
        {

        }
        private void buscarClienteCedulaRuc()
        {
            proveedores = new Negocios.Logico.tProveedores();
            List<Negocios.Constructores.TblProveedores> lst = proveedores.buscarProveedores(txtCedRucProv.Text, "", 3);
            cargarProveedores(lst);
        }

        private void txtCedRucProv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscarClienteCedulaRuc();
            if (e.KeyCode == Keys.Escape)
            {
                //cajasTexto = new Validaciones_y_Mas.Validar_caja_texto();
                //cajasTexto.vaciarCajas(this);
            }
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                if (txtCedRucProv.Text != "")
                {
                    txtNombresProveedor.Text = "";
                    txtIdProveedor.Text = "";
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            buscarProveedores();
        }

        private void dgvCompra_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvCompra.Columns[dgvCompra.CurrentCell.ColumnIndex].Name == "colCodigo" || dgvCompra.Columns[dgvCompra.CurrentCell.ColumnIndex].Name == "colDescripcion")
            {
                dgvCompra[2, dgvCompra.CurrentCell.RowIndex].Value = "";
                dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value = "";
                dgvCompra[4, dgvCompra.CurrentCell.RowIndex].Value = "";
                dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = "";
                dgvCompra[6, dgvCompra.CurrentCell.RowIndex].Value = "";
                dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value = null;
                //lblPrecioItem.Text = "0.00";
                dgvCompra[8, dgvCompra.CurrentCell.RowIndex].Value = "";
                //dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value = "";
                //dgvCompra[10, dgvCompra.CurrentCell.RowIndex].Value = "";
            }
        }

        private void dgvCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dText.KeyPress -= new KeyPressEventHandler(soloNumerosDecimales_KeyPress);
                cajasTexto = new Validaciones_y_Mas.Validar_caja_texto();
                cajasTexto.setEstado("");


                //Busqueda por codigo de Productos
                if (dgvCompra[1, dgvCompra.CurrentCell.RowIndex].Value != null && dgvCompra.Columns[dgvCompra.CurrentCell.ColumnIndex].Name == "colCodigo")
                {
                    // Envio el dato de la columna 1                    envio la fila que lo afecta
                    buscarProductoxCodigo(dgvCompra[1, dgvCompra.CurrentCell.RowIndex].Value.ToString(), dgvCompra.CurrentCell.RowIndex);
                }
                //Busqueda por descripcion de Productos
                else if (dgvCompra[2, dgvCompra.CurrentCell.RowIndex].Value != null && dgvCompra.Columns[dgvCompra.CurrentCell.ColumnIndex].Name == "colDescripcion")
                {

                    Mod_Facturacion.frmSubfBusqProdocuctos frm = new Mod_Facturacion.frmSubfBusqProdocuctos();
                    frm.fila = dgvCompra.CurrentCell.RowIndex;
                    frm.descripcion = dgvCompra[2, dgvCompra.CurrentCell.RowIndex].Value.ToString();
                    frm.ShowDialog();
                    Negocios.Constructores.TblBodegaProductos tProductos = frm.tProductos;
                    if (tProductos != null)
                    {
                        cargarProductoCodigo(tProductos);

                    }
                    else
                    {
                        dgvCompra[2, dgvCompra.CurrentCell.RowIndex].Value = "";
                        MessageBox.Show("El producto no existe, desea buscarlo?", "Evenezer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    //busqAvanzProductosdescripcion();
                    //MessageBox.Show("sa","xxx");
                }
                else if (dgvCompra.Columns[dgvCompra.CurrentCell.RowIndex].Name != "colSubtotal")
                {
                    obtenerTotalxProducto();
                }
                //Validacion para saber los precios segun los volumenes
                if (dgvCompra.Columns[dgvCompra.CurrentCell.ColumnIndex].Name == "colCantidad")
                {
                    if (dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value.ToString() == "" && dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value.ToString() == "")
                    {
                        dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = 1;
                        precioxVolumenes(dgvCompra.CurrentCell.RowIndex);
                        return;
                    }
                    else if (dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value.ToString() == "" && Convert.ToDouble(dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value) >= 0)
                    {
                        precioxVolumenes(dgvCompra.CurrentCell.RowIndex);
                        return;
                    }
                    else if (Convert.ToDouble(dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value) <= 0 && Convert.ToDouble(dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value) <= 0)
                    {
                        dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = 1;
                        precioxVolumenes(dgvCompra.CurrentCell.RowIndex);
                        return;
                    }
                    else if (Convert.ToDouble(dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value) > 0 && Convert.ToDouble(dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value) >= 0)
                    {
                        precioVolumenesxCajas();
                        return;
                    }
                    else if (Convert.ToDouble(dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value) > 0 && dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value.ToString() == "")
                    {
                        dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = 0;
                        precioVolumenesxCajas();
                        return;
                    }
                    precioxVolumenes(dgvCompra.CurrentCell.RowIndex);
                }
                else if (dgvCompra.Columns[dgvCompra.CurrentCell.ColumnIndex].Name == "uxcj")
                {

                    if (dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value.ToString() == "" && dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value.ToString() == "")
                    {
                        dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = 1;
                        precioxVolumenes(dgvCompra.CurrentCell.RowIndex);
                        return;
                    }
                    else if (dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value.ToString() == "" && Convert.ToDouble(dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value) >= 0)
                    {
                        precioxVolumenes(dgvCompra.CurrentCell.RowIndex);
                        return;
                    }
                    else if (Convert.ToDouble(dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value) <= 0 && Convert.ToDouble(dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value) <= 0)
                    {
                        dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = 1;
                        precioxVolumenes(dgvCompra.CurrentCell.RowIndex);
                        return;
                    }
                    else if (Convert.ToDouble(dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value) > 0 && dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value.ToString() == "")
                    {
                        dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = 0;
                        precioVolumenesxCajas();
                        return;
                    }

                    precioVolumenesxCajas();
                }
            }
            catch (Exception err)
            {
                //SendKeys.Send("{up}");
                //SendKeys.Send("{ENTER}");
            }
            finally
            {
                //SendKeys.Send("{up}");
                //SendKeys.Send("{ENTER}");
            }
        }

        private void dgvCompra_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dgvCompra_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            dText = (DataGridViewTextBoxEditingControl)e.Control;//Obteniendo el caracter que se esta editando
            dText.KeyPress -= new KeyPressEventHandler(soloNumerosDecimales_KeyPress);
            dText.KeyPress -= new KeyPressEventHandler(textoMayuscula_KeyPress);//quitando el evento ya agregado
            dText.KeyDown -= new KeyEventHandler(dgvCompra_KeyDown);//quitando el evento ya agregado
            dText.KeyPress -= new KeyPressEventHandler(soloNumeros_KeyPress);//quitando el evento ya agregado

            columnaSeleccionada = dgvCompra.CurrentCell.ColumnIndex; //obteniendo el numero de columna que se esta editando
            fila++;
            //dgvCompra[0, dgvCompra.CurrentCell.RowIndex].Value = fila;

            //Condicion solo para la columna de codigo y descripcion para que el texto este en mayuscula
            if (dgvCompra.Columns[columnaSeleccionada].Name == "colDescripcion" || dgvCompra.Columns[columnaSeleccionada].Name == "colCodigo")//Nombres de las columnas
            {
                dText.KeyPress += new KeyPressEventHandler(textoMayuscula_KeyPress);
            }
            if (dgvCompra.Columns[columnaSeleccionada].Name == "colDescripcion")//Nombres de las columnas
            {

                dText.KeyDown += new KeyEventHandler(dgvCompra_KeyDown);
            }
            if (dgvCompra.Columns[columnaSeleccionada].Name == "colCantidad")//Nombres de las columnas
            {
                dText.KeyPress -= new KeyPressEventHandler(soloNumerosDecimales_KeyPress);
                dText.KeyPress += new KeyPressEventHandler(soloNumerosDecimales_KeyPress);
            }
            if (dgvCompra.Columns[columnaSeleccionada].Name == "uxcj")//Nombres de las columnas
            {
                dText.KeyPress -= new KeyPressEventHandler(soloNumeros_KeyPress);
                dText.KeyPress += new KeyPressEventHandler(soloNumeros_KeyPress);
            }
            if (dgvCompra.Columns[columnaSeleccionada].Name == "colPU")//Nombres de las columnas
            {
                dText.KeyPress -= new KeyPressEventHandler(soloNumerosDecimales_KeyPress);
                dText.KeyPress += new KeyPressEventHandler(soloNumerosDecimales_KeyPress);
            }
        }

        private void dgvCompra_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    SendKeys.Send("{TAB}");
                }
                if (e.KeyCode == Keys.Delete)
                {
                    if (dgvCompra[2, dgvCompra.CurrentCell.RowIndex].Value != null)
                    {
                        dgvCompra.Rows.RemoveAt(dgvCompra.CurrentCell.RowIndex);
                        //lblPrecioItem.Text = "0,00";
                        obtenerTotalFactura();
                    }
                }
            }
            catch (Exception err)
            {

            }
        }

        private void dgvCompra_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void soloNumerosDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            cajasTexto = new Validaciones_y_Mas.Validar_caja_texto();
            cajasTexto.Validar_Numeros_Dec(e, dText.TextLength);
        }
        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void buscarProductoxCodigo(String codigo, int fila)
        {
            try
            {
                productos = new Negocios.Logico.productos();
                bool band = false;

                List<Negocios.Constructores.TblBodegaProductos> lst = null;



                //Si el grid esta vacio de una mando a consultar
                if (dgvCompra.Rows.Count <= 2)
                {
                    lst = productos.buscarProductos(codigo, "", 1, 3);
                    productoExiste(lst);
                    cargarProductoCodigo(lst);
                    band = true;
                }

                //Comparo si el producto no esta repetido en mi grid
                else if (dgvCompra.Rows.Count > 2)
                {
                    for (int i = 0; i < dgvCompra.Rows.Count - 1; i++)
                    {
                        if (dgvCompra[1, dgvCompra.CurrentCell.RowIndex].Value.Equals(dgvCompra[1, i].Value) && dgvCompra[7, i].Value != null)
                        {
                            band = true;

                            dgvCompra[5, i].Value = Convert.ToInt32(dgvCompra[5, i].Value) + 1;
                            dgvCompra[8, i].Value = Convert.ToInt32(dgvCompra[5, i].Value) * Convert.ToDouble(dgvCompra[7, i].Value);
                           // lblPrecioItem.Text = dgvCompra[7, i].Value.ToString();
                            dgvCompra.Rows.RemoveAt(fila);
                            //precioxVolumenes(i);
                            //obtenerTotalxProducto();
                            SendKeys.Send("{DOWN}");
                            return;
                        }
                    }

                }


                if (!band)
                {
                    lst = productos.buscarProductos(codigo, "", 1, 3);
                    productoExiste(lst);
                    cargarProductoCodigo(lst);
                }
            }
            catch (Exception err)
            {

            }
            finally
            {
                obtenerTotalxProducto();
            }

        }
        //Existe o no producto
        private void productoExiste(List<Negocios.Constructores.TblBodegaProductos> lst)
        {
            if (lst != null)
                if (lst.Count <= 0)
                {
                    MessageBox.Show("El código no existe!", "Evenezer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    SendKeys.Send("{UP}");
                    dgvCompra[1, dgvCompra.Rows.Count - 1].Value = "";
                    //dgvCompra[1, dgvCompra.CurrentCell.RowIndex].Value = "";
                    return;
                }
        }
        private void cargarProductoCodigo(List<Negocios.Constructores.TblBodegaProductos> lst)
        {
            try
            {
                foreach (Negocios.Constructores.TblBodegaProductos tProductos in lst)
                {
                    if ((dgvCompra.Rows.Count - 2) <= dgvCompra.CurrentCell.RowIndex)
                        // dgvCompra.Rows.Add();
                        // dgvCompra[0, dgvCompra.CurrentCell.RowIndex].Value = (dgvCompra.CurrentCell.RowIndex + 1);
                    dgvCompra[1, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getCodigoProducto();
                    dgvCompra[2, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getDescripcion();
                    dgvCompra[6, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getIva().Equals(true) ? "Si" : "No";
                    dgvCompra[4, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getTblUndxCajas().getDetalleUnds();
                    //lblPrecioItem.Text = tProductos.getPvp().ToString();
                    dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPvp();
                    dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = 1;
                    //Und Medida
                    dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getTblUndxCajas().getCantidCaja();
                    //Precio1
                    dgvCompra[10, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio1();
                    //Vol1
                    dgvCompra[11, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol1();
                    //precio2
                    dgvCompra[12, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio2();
                    //vol2
                    dgvCompra[13, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol2();
                    //precio3
                    dgvCompra[14, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio3();
                    //vol3
                    dgvCompra[15, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol3();
                    //precio4
                    dgvCompra[16, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio4();
                    //vol4
                    dgvCompra[17, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol4();
                    //precio5
                    dgvCompra[18, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio5();
                    //vol5
                    dgvCompra[19, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol5();
                    // i++;
                }
            }
            catch (Exception err)
            {

            }
        }
        // este metodo es para cargar los productos x la descripcion y luego verifica si hay o no uno repetidos
        private void cargarProductoCodigo(Negocios.Constructores.TblBodegaProductos tProductos)
        {
            try
            {
                Boolean band = false;
                //comparo
                if (dgvCompra.Rows.Count > 2)
                {
                    for (int i = 0; i < dgvCompra.Rows.Count - 1; i++)
                    {
                        if (dgvCompra[7, i].Value != null)
                        {
                            if (tProductos.getTblProductos().getCodigoProducto().Equals(dgvCompra[1, i].Value.ToString()))
                            {
                                band = true;
                                dgvCompra[5, i].Value = Convert.ToInt32(dgvCompra[5, i].Value) + 1;
                                dgvCompra[8, i].Value = Convert.ToInt32(dgvCompra[5, i].Value) * Convert.ToDouble(dgvCompra[7, i].Value);
                                //lblPrecioItem.Text = dgvCompra[7, i].Value.ToString();
                                dgvCompra.Rows.RemoveAt(dgvCompra.CurrentCell.RowIndex);
                                //precioxVolumenes(i);
                                //obtenerTotalxProducto();
                                SendKeys.Send("{DOWN}");
                                return;
                            }
                        }

                    }

                }

                if (!band)
                {
                    dgvCompra[1, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getCodigoProducto();
                    dgvCompra[2, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getDescripcion();
                    dgvCompra[6, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getIva().Equals(true) ? "Si" : "No";
                    dgvCompra[4, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getTblUndxCajas().getDetalleUnds();
                    //lblPrecioItem.Text = tProductos.getPvp().ToString();
                    dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPvp();
                    dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = 1;
                    //Und Medida
                    dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getTblProductos().getTblUndxCajas().getCantidCaja();
                    //Precio1
                    dgvCompra[10, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio1();
                    //Vol1
                    dgvCompra[11, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol1();
                    //precio2
                    dgvCompra[12, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio2();
                    //vol2
                    dgvCompra[13, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol2();
                    //precio3
                    dgvCompra[14, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio3();
                    //vol3
                    dgvCompra[15, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol3();
                    //precio4
                    dgvCompra[16, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio4();
                    //vol4
                    dgvCompra[17, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol4();
                    //precio5
                    dgvCompra[18, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getPrecio5();
                    //vol5
                    dgvCompra[19, dgvCompra.CurrentCell.RowIndex].Value = tProductos.getVol5();
                }
                //dgvCompra.Rows.Add();
                // dgvCompra[0, dgvCompra.CurrentCell.RowIndex].Value = (dgvCompra.CurrentCell.RowIndex + 1);

            }
            catch (Exception err)
            {

            }
            finally
            {
                obtenerTotalxProducto();
            }
        }
        private void busqAvanzProductosdescripcion()
        {
            //Buscando por descripcion productos
            Mod_Facturacion.frmBuscarProducto frm = new Mod_Facturacion.frmBuscarProducto();
            string buscarDescripcion = dgvCompra[2, dgvCompra.CurrentCell.RowIndex].Value.ToString();
            frm.txtProducto.Text = buscarDescripcion;
            //frm.idBodega = cboBodega.SelectedValue.ToString();
            frm.idBodega = "2";
            frm.ShowDialog();
            if (frm.codiProducto != "")
            {
                dgvCompra[1, dgvCompra.CurrentCell.RowIndex].Value = frm.codiProducto;
                dgvCompra[2, dgvCompra.CurrentCell.RowIndex].Value = frm.descripcion;
                dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = "1";
                //dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value = "1,0000";
                dgvCompra[4, dgvCompra.CurrentCell.RowIndex].Value = frm.unidadMed;
                dgvCompra[6, dgvCompra.CurrentCell.RowIndex].Value = frm.iva;
                //dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value = frm.;
                dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value = frm.conversionTipo1;
                dgvCompra[10, dgvCompra.CurrentCell.RowIndex].Value = frm.conversionValor1;
            }
        }
        private void obtenerTotalxProducto()
        {
            try
            {
                double valorCajas = 0, valorUnd = 0;
                if (dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value != null)
                {
                    if (dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value.ToString() != "" && dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value.ToString() != "0")
                    {
                        //Valor unidades x Cajas
                        valorCajas = (Convert.ToDouble(dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value) * Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value)) * Convert.ToDouble(dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value);
                        //Este es el valor unitario
                        valorUnd = Convert.ToDouble(dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value) * Convert.ToDouble(dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value);
                    }
                    else if (dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value.ToString() == "" && dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value.ToString() != "0")
                    {
                        //Este es el valor unitario
                        valorUnd = Convert.ToDouble(dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value) * Convert.ToDouble(dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value);
                    }
                    else if (dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value.ToString() != "" && dgvCompra[5, dgvCompra.CurrentCell.RowIndex].Value.ToString().Equals("0"))
                    {
                        //valor unidades x Cajas
                        valorCajas = (Convert.ToDouble(dgvCompra[3, dgvCompra.CurrentCell.RowIndex].Value) * Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value)) * Convert.ToDouble(dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value);
                    }
                    dgvCompra[8, dgvCompra.CurrentCell.RowIndex].Value = valorUnd + valorCajas;

                    if (dgvCompra.Rows.Count >= 2)
                    {
                        obtenerTotalFactura();
                    }

                }

            }
            catch (Exception err)
            {
            }

        }
        private void obtenerTotalFactura()
        {
            try
            {

                vaciarTotalCompra();
                double sumaTotal = 0, subtotal0 = 0, subtotal12 = 0, totalBruto = 0, descuento = 0;
                string estado = "";
                int items = 0;
                foreach (DataGridViewRow filas in dgvCompra.Rows)
                {
                    if (filas.Cells["colSubtotal"].Value != null)
                    {
                        dgvCompra[0, items].Value = items + 1;
                        sumaTotal += (Double)filas.Cells["colSubtotal"].Value;
                        txtTotalFactura.Text = sumaTotal.ToString("N2");
                        //lblValorPagar.Text = sumaTotal.ToString("N2");

                        if (filas.Cells["colIva"].Value.Equals("Si"))
                        {
                            //Falta configurar el valor del Iva
                            subtotal12 += (((Double)filas.Cells["colSubtotal"].Value) / 1.14);
                            txtIvaFactura.Text = subtotal12.ToString("N4");
                            subtotal0 += ((Double)filas.Cells["colSubtotal"].Value) - (((Double)filas.Cells["colSubtotal"].Value) / 1.14);
                            txtSubtotal.Text = subtotal0.ToString("N4");
                        }
                        else
                        {
                            subtotal0 += ((Double)filas.Cells["colSubtotal"].Value);
                            txtSubtotal.Text = subtotal0.ToString("N4");
                        }

                        //if (filas.Cells["colDescuento"].Value != null)
                        //    if (filas.Cells["colDescuento"].Value.ToString() != "")
                        //    {
                        //        double valor = Convert.ToDouble(filas.Cells["colCantidad"].Value) * Convert.ToDouble(filas.Cells["colCostoU"].Value);
                        //        descuento += valor * (Convert.ToDouble(filas.Cells["colDescuento"].Value) / 100);
                        //        txtDesc.Text = descuento.ToString("N4");
                        //    }


                        totalBruto = subtotal0 + subtotal12;
                        txtTotalBruto.Text = totalBruto.ToString("N2");
                        estado = "ok";
                        items++;
                    }
                }
                if (estado.Equals(""))
                {
                    vaciarTotalCompra();
                }

            }
            catch (Exception err)
            {

            }

        }
        private void precioVolumenesxCajas()
        {
            //Comparacion vol1
            if (Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value) <= Convert.ToDouble(dgvCompra[11, dgvCompra.CurrentCell.RowIndex].Value))
            {
                dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value = Convert.ToDouble(dgvCompra[10, dgvCompra.CurrentCell.RowIndex].Value);
            }
            //Comparacion vol2
            else if ((Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value) >= Convert.ToDouble(dgvCompra[13, dgvCompra.CurrentCell.RowIndex].Value)) && (Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value) < Convert.ToDouble(dgvCompra[15, dgvCompra.CurrentCell.RowIndex].Value)))
            {
                dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value = Convert.ToDouble(dgvCompra[12, dgvCompra.CurrentCell.RowIndex].Value);
            }
            //Comparacion vol3
            else if ((Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value) >= Convert.ToDouble(dgvCompra[15, dgvCompra.CurrentCell.RowIndex].Value)) && (Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value) < Convert.ToDouble(dgvCompra[17, dgvCompra.CurrentCell.RowIndex].Value)))
            {
                dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value = Convert.ToDouble(dgvCompra[14, dgvCompra.CurrentCell.RowIndex].Value);
            }
            //Comparacion vol4
            else if ((Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value) >= Convert.ToDouble(dgvCompra[17, dgvCompra.CurrentCell.RowIndex].Value)) && (Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value) < Convert.ToDouble(dgvCompra[19, dgvCompra.CurrentCell.RowIndex].Value)))
            {
                dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value = Convert.ToDouble(dgvCompra[16, dgvCompra.CurrentCell.RowIndex].Value);
            }
            //Comparacion vol5
            else if (Convert.ToDouble(dgvCompra[9, dgvCompra.CurrentCell.RowIndex].Value) >= Convert.ToDouble(dgvCompra[19, dgvCompra.CurrentCell.RowIndex].Value))
            {
                dgvCompra[7, dgvCompra.CurrentCell.RowIndex].Value = Convert.ToDouble(dgvCompra[18, dgvCompra.CurrentCell.RowIndex].Value);
            }
            obtenerTotalxProducto();
        }
        private void precioxVolumenes(int fila)
        {
            double valorundMedida = 0;
            //Comparacion vol1
            if (Convert.ToDouble(dgvCompra[5, fila].Value) <= Convert.ToDouble(dgvCompra[11, fila].Value))
            {
                dgvCompra[7, fila].Value = Convert.ToDouble(dgvCompra[10, fila].Value);
            }
            //Comparacion vol2
            else if ((Convert.ToDouble(dgvCompra[5, fila].Value) >= Convert.ToDouble(dgvCompra[13, fila].Value)) && (Convert.ToDouble(dgvCompra[5, fila].Value) < Convert.ToDouble(dgvCompra[15, fila].Value)))
            {
                dgvCompra[7, fila].Value = Convert.ToDouble(dgvCompra[12, fila].Value);
            }
            //Comparacion vol3
            else if ((Convert.ToDouble(dgvCompra[5, fila].Value) >= Convert.ToDouble(dgvCompra[15, fila].Value)) && (Convert.ToDouble(dgvCompra[5, fila].Value) < Convert.ToDouble(dgvCompra[17, fila].Value)))
            {
                dgvCompra[7, fila].Value = Convert.ToDouble(dgvCompra[14, fila].Value);
            }
            //Comparacion vol4
            else if ((Convert.ToDouble(dgvCompra[5, fila].Value) >= Convert.ToDouble(dgvCompra[17, fila].Value)) && (Convert.ToDouble(dgvCompra[5, fila].Value) < Convert.ToDouble(dgvCompra[19, fila].Value)))
            {
                dgvCompra[7, fila].Value = Convert.ToDouble(dgvCompra[16, fila].Value);
            }
            //Comparacion vol5
            else if (Convert.ToDouble(dgvCompra[5, fila].Value) >= Convert.ToDouble(dgvCompra[19, fila].Value))
            {
                dgvCompra[7, fila].Value = Convert.ToDouble(dgvCompra[18, fila].Value);
            }
            if (Convert.ToDouble(dgvCompra[5, fila].Value) >= Convert.ToDouble(dgvCompra[9, fila].Value))
            {

                valorundMedida = Convert.ToDouble(dgvCompra[5, fila].Value) / Convert.ToDouble(dgvCompra[9, fila].Value);
                dgvCompra[3, fila].Value = Math.Truncate(valorundMedida);
                bool isInt = valorundMedida % 1 == 0;

                if (!isInt)
                {
                    dgvCompra[5, fila].Value = Convert.ToDouble(dgvCompra[5, fila].Value) - (Math.Truncate(valorundMedida) * Convert.ToDouble(dgvCompra[9, fila].Value));

                }
                else
                {
                    dgvCompra[5, fila].Value = "0";
                }

            }
            obtenerTotalxProducto();
        }
        private void textoMayuscula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
