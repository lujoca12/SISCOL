using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDato;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proyecto_Modulo_Inventario.Admin
{
    public partial class frmPais : Form
    {
        CDato.csConexions conex;
        SqlDataReader reader = null;
        Negocios.Logico.empresa empresa;
        List<Validaciones_y_Mas.LLenarCombo> lista;
        Validaciones_y_Mas.Validar_caja_texto cajasTexto;
        Point posicionFormulario;
        Boolean accionMouse;

        public frmPais()
        {
            InitializeComponent();
        }
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCerrar_MouseHover(object sender, EventArgs e)
        {
            lblCerrar.BackColor = Color.Red;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.BackColor = Color.Black;
        }

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
    }
}
