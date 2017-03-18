using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Modulo_Inventario.Validaciones_y_Mas
{
    class LLamarFormularios
    {
        TabPage tab;
        public void LLamarFrm(Form frm, TabControl tabControl1)
        {
            tabControl1.TabPages.Clear();
            tab = new TabPage(frm.Text + "      ");
            
            frm.TopLevel = false;

            frm.Parent = tab;

            frm.Visible = true;

            tabControl1.TabPages.Add(tab);

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // frm.Location = new Point(((tab.Width - frm.Width) /2 ), ((tab.Height - frm.Height))/2);

            frm.Width = tab.Width;
            frm.Height = tab.Height;

            tabControl1.SelectedTab = tab;


        }
        
    }
}
