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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        Point posicionFormulario;
        Boolean accionMouse;

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

            //DialogResult msg;
            //msg = MessageBox.Show("Desea salir del Sistema de Facturación", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (msg == DialogResult.Yes)
            //{
                this.Close();
            //}
        }
    }
}
