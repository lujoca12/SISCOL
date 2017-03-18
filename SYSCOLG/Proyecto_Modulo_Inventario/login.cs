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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            reducirTamanioIconos(btnIngresar);
        }

        private void btnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            aumentarTamanioIconos(btnIngresar);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            reducirTamanioIconos(btnCerrar);
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            aumentarTamanioIconos(btnCerrar);
        }
        private void aumentarTamanioIconos(PictureBox btn)
        {
            btn.Width = 50;
            btn.Height = 46;

        }
        private void reducirTamanioIconos(PictureBox btn)
        {
            btn.Width = 47;
            btn.Height = 40;

        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
