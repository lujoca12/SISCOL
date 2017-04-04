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
    public partial class frmSubfBusqProdocuctos : Form
    {
        public frmSubfBusqProdocuctos()
        {
            InitializeComponent();
            
        }
        Negocios.Logico.productos productos;
        public int fila = 0;
        public string descripcion = "";
        public Negocios.Constructores.TblBodegaProductos tProductos;
        private void frmSubfBusqProdocuctos_Load(object sender, EventArgs e)
        {
            
            buscarProductoxDescripcion();
            
        }
        private void buscarProductoxDescripcion()
        {
            try
            {
                productos = new Negocios.Logico.productos();
                int i = 0;

                List<Negocios.Constructores.TblBodegaProductos> lst = null;
                lst = productos.buscarProductos("", descripcion, 1, 3);
                if(lst.Count <= 0)
                {
                    this.Close();
                    return;
                }
                foreach (Negocios.Constructores.TblBodegaProductos tProductos in lst)
                {
                    dgvBuscProductos.Rows.Add();
                    // dgvBuscProductos[0, i].Value = (i + 1);
                    dgvBuscProductos[1, i].Value = tProductos.getTblProductos().getCodigoProducto();
                    dgvBuscProductos[2, i].Value = tProductos.getTblProductos().getDescripcion();
                    dgvBuscProductos[6, i].Value = tProductos.getTblProductos().getIva().Equals(true) ? "Si" : "No";
                    dgvBuscProductos[4, i].Value = tProductos.getTblProductos().getTblUndxCajas().getDetalleUnds();
                    dgvBuscProductos[7, i].Value = tProductos.getPvp();
                    dgvBuscProductos[5, i].Value = 1;
                    //Und Medida
                    dgvBuscProductos[9, i].Value = tProductos.getTblProductos().getTblUndxCajas().getCantidCaja();
                    //Precio1
                    dgvBuscProductos[10, i].Value = tProductos.getPrecio1();
                    //Vol1
                    dgvBuscProductos[11, i].Value = tProductos.getVol1();
                    //precio2
                    dgvBuscProductos[12, i].Value = tProductos.getPrecio2();
                    //vol2
                    dgvBuscProductos[13, i].Value = tProductos.getVol2();
                    //precio3
                    dgvBuscProductos[14, i].Value = tProductos.getPrecio3();
                    //vol3
                    dgvBuscProductos[15, i].Value = tProductos.getVol3();
                    //precio4
                    dgvBuscProductos[16, i].Value = tProductos.getPrecio4();
                    //vol4
                    dgvBuscProductos[17, i].Value = tProductos.getVol4();
                    //precio5
                    dgvBuscProductos[18, i].Value = tProductos.getPrecio5();
                    //vol5
                    dgvBuscProductos[19, i].Value = tProductos.getVol5();
                    i++;
                }
            }
            catch (Exception err)
            {

            }
            
        }

       

        private void dgvBuscProductos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void dgvBuscProductos_KeyDown(object sender, KeyEventArgs e)
        {
            //Evento cuando se da enter para seleccionar el producto
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;

                if(dgvBuscProductos[1, dgvBuscProductos.CurrentCell.RowIndex].Value != null)
                {
                    tProductos = new Negocios.Constructores.TblBodegaProductos();
                    tProductos.setTblProductos(new Negocios.Constructores.TblProductos());
                    tProductos.getTblProductos().setTblUndxCajas(new Negocios.Constructores.TblUndXCajas());
                    tProductos.getTblProductos().setCodigoProducto(dgvBuscProductos[1, dgvBuscProductos.CurrentCell.RowIndex].Value.ToString());
                    
                    tProductos.getTblProductos().setDescripcion(dgvBuscProductos[2, dgvBuscProductos.CurrentCell.RowIndex].Value.ToString());
                    tProductos.getTblProductos().setIva(dgvBuscProductos[6, dgvBuscProductos.CurrentCell.RowIndex].Value.ToString().Equals("Si") ? true : false);
                    tProductos.getTblProductos().getTblUndxCajas().setDetalleUnds(dgvBuscProductos[4, dgvBuscProductos.CurrentCell.RowIndex].Value.ToString());
                    tProductos.setPvp(Convert.ToDouble(dgvBuscProductos[7, dgvBuscProductos.CurrentCell.RowIndex].Value.ToString()));

                    //Und Medida
                    tProductos.getTblProductos().getTblUndxCajas().setCantidCaja(Convert.ToInt32(dgvBuscProductos[9, dgvBuscProductos.CurrentCell.RowIndex].Value.ToString()));
                    //Precio1
                    tProductos.setPrecio1(Convert.ToDouble(dgvBuscProductos[10, dgvBuscProductos.CurrentCell.RowIndex].Value));
                    //Vol1
                    tProductos.setVol1(Convert.ToInt32(dgvBuscProductos[11, dgvBuscProductos.CurrentCell.RowIndex].Value));
                    //precio2
                    tProductos.setPrecio2(Convert.ToDouble(dgvBuscProductos[12, dgvBuscProductos.CurrentCell.RowIndex].Value));
                    //vol2
                    tProductos.setVol2(Convert.ToInt32(dgvBuscProductos[13, dgvBuscProductos.CurrentCell.RowIndex].Value));
                    //precio3
                    tProductos.setPrecio3(Convert.ToDouble(dgvBuscProductos[14, dgvBuscProductos.CurrentCell.RowIndex].Value));
                    //vol3
                    tProductos.setVol3(Convert.ToInt32(dgvBuscProductos[15, dgvBuscProductos.CurrentCell.RowIndex].Value));
                    //precio4
                    tProductos.setPrecio4(Convert.ToDouble(dgvBuscProductos[16, dgvBuscProductos.CurrentCell.RowIndex].Value));
                    //vol4
                    tProductos.setVol4(Convert.ToInt32(dgvBuscProductos[17, dgvBuscProductos.CurrentCell.RowIndex].Value));
                    //precio5
                    tProductos.setPrecio5(Convert.ToDouble(dgvBuscProductos[18, dgvBuscProductos.CurrentCell.RowIndex].Value));
                    //vol5
                    tProductos.setVol5(Convert.ToInt32(dgvBuscProductos[19, dgvBuscProductos.CurrentCell.RowIndex].Value));
                }

                this.Close();
            }
        }
    }
}
