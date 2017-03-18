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
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }
        public string codiProducto = "";
        public string descripcion = "", unidadMed = "", iva = "", conversionTipo1 = "", conversionValor1 = "", idBodega = "";
    }
}
