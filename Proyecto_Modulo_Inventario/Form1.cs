using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Proyecto_Modulo_Inventario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        Validaciones_y_Mas.LLamarFormularios llamar;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //AccesoDatos.csConexion cs = new AccesoDatos.csConexion();
                //cs.AbrirConexion();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        Size tamanioPant = System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize;//Metodo para obtener el tamaño de la pantalla
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            SetBackGroundColorOfMDIForm(this);//Metodo para cambiar el color del formulario
            tamanioMinimPant(this, tamanioPant);//Metodo para establecer el tamaño minimo de la pantalla
            //login frm = new login();
            //frm.ShowDialog();
        }
        public void SetBackGroundColorOfMDIForm(Form frm)
        {
            foreach (Control ctl in frm.Controls)
            {
                if ((ctl) is MdiClient)

                // Si el control es del tipo correcto entonces cambia de color
                {
                  //  ctl.BackColor = System.Drawing.Color.White;
                }
            }

        }
        //Metodo para establecer el tamaño minimo del formulario
        public void tamanioMinimPant(Form frm, Size tamanioPant)
        {
            //Estableciendo el tamaño minimo de la pantalla
            frm.Width = tamanioPant.Width - 20;
            frm.Height = tamanioPant.Height - 20;
            //
        }

       

        private void tvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
         
        }
        private void limpiarGroupBox()
        {
        }

       
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.Equals("Nodo3"))
                registrarCompra();

            if (e.Node.Name.Equals("nFactura"))
                registrarFactura();
        }
        private void registrarCompra()
        {
            ///llamar = new Validaciones_y_Mas.LLamarFormularios();
            //Compras frmCompras = new Compras();
            permisos frm = new permisos();
            frm.MdiParent = this;
            frm.Show();
            //llamar.LLamarFrm(frmCompras, this.nTranBodega);
        }

        private void registrarFactura()
        {
            ///llamar = new Validaciones_y_Mas.LLamarFormularios();
            //Compras frmCompras = new Compras();
            Mod_Facturacion.frmFactura frm = new Mod_Facturacion.frmFactura();
            frm.MdiParent = this;
            frm.Show();
            //llamar.LLamarFrm(frmCompras, this.nTranBodega);
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
