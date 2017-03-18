using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Modulo_Inventario.Validaciones_y_Mas
{
    class Validar_caja_texto
    {
        int columnaSeleccionada;
        DataGridViewTextBoxEditingControl dText;//variable para el grid cuando esta en edicion en una columna
        string estado = "";
        int posicion=0;

        public Validar_caja_texto()
        {
            estado = "";
        }
        public Validar_caja_texto(string estado)
        {
            this.estado = estado;
        }
        public string getEstado()
        {
            return estado;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        public int getPosicion()
        {
            return posicion;
        }
        public void setPosicion(int posicion)
        {
            this.posicion = posicion;
        }

        public void Validar_Numeros(KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != (char)Keys.Back || e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }
        public void Validar_NumerosMenosCero(KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '1' && e.KeyChar <= '9') && e.KeyChar != (char)Keys.Back || e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        public void Validar_Numeros_Dec(KeyPressEventArgs e, TextBox txtTuCajaTexto)
        {
            //Validacion para saber si se borro la coma
            if (txtTuCajaTexto.TextLength > 0 )//Cuando es > cero quiere decir hay datos
                if (txtTuCajaTexto.TextLength == posicion)//si son iguales quiere decir que se borro la coma
                    this.estado = "";
            if (txtTuCajaTexto.TextLength == 0 && posicion == 0)//Cuando la posicion y el length de la caja son ceros es xq la coma esta al principio y se la borro
                    this.estado = "";

            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != (char)Keys.Back || e.KeyChar == (char)Keys.Space)//condicion para que solo coja numeros enteros y borrar
            {
                e.Handled = true;
                if (estado.Equals(""))//una vez activa la coma no se pueda presionar mas
                {
                    if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == ",")
                    {
                        txtTuCajaTexto.Text += ",";//Aqui se cambia el punto por la coma
                        SendKeys.Send("{END}");//Esto se lo utiliza para k el cursor quede al fin y no al principio
                        this.estado = "ok";//Estado para saber si ya esta la coma en la caja de texto
                        posicion = txtTuCajaTexto.TextLength-1;//Posicion en la caja de texto de la coma
                    }
                }
                
            }
            
        }

        //Para numeros decimales del grid
        public void Validar_Numeros_Dec(KeyPressEventArgs e, int tamanio)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Back)
                    if (tamanio == posicion)
                    {
                        setEstado("");
                    }

                if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != (char)Keys.Back || e.KeyChar == (char)Keys.Space)//condicion para que solo coja numeros enteros y borrar
                {
                    e.Handled = true;
                    if (estado.Equals(""))//una vez activa la coma no se pueda presionar mas
                    {
                        if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == ",")
                        {
                            if (getEstado() == "")
                            {
                                e.KeyChar = ',';
                                e.Handled = false;
                                setEstado("ok");
                                setPosicion(tamanio + 1);
                            }
                        }
                    }

                }
            }
            catch(Exception err)
            {

            }
            

        }
        public void Validar_Letras(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z' && e.KeyChar < 'a' && e.KeyChar > 'z') && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }
        public void Validar_Letras_Espacio(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z' && e.KeyChar < 'a' && e.KeyChar > 'z') && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Enter)
                e.Handled = true;

        }
        public void dgv_Texto_Mayuscula(DataGridViewEditingControlShowingEventArgs e, DataGridView dgv, string nombreColumna)
        {
            dText = (DataGridViewTextBoxEditingControl)e.Control;//Obteniendo el caracter que se esta editando
            dText.KeyPress -= new KeyPressEventHandler(textoMayuscula_KeyPress);//quitando el evento ya agregado

            columnaSeleccionada = dgv.CurrentCell.ColumnIndex; //obteniendo el numero de columna que se esta editando
            //Condicion solo para la columna de codigo y descripcion para que el texto este en mayuscula
            if (dgv.Columns[columnaSeleccionada].Name == nombreColumna)//Nombres de las columnas
            {
                dText.KeyPress += new KeyPressEventHandler(textoMayuscula_KeyPress);
            }
        }

        public void dgv_Solo_Numeros_Decimales(DataGridViewEditingControlShowingEventArgs e, DataGridView dgv, string nombreColumna)
        {
            dText = (DataGridViewTextBoxEditingControl)e.Control;//Obteniendo el caracter que se esta editando

            if (dgv.Columns[columnaSeleccionada].Name == nombreColumna)//Nombres de las columnas
            {
                dText.KeyPress += new KeyPressEventHandler(soloNumerosDecimales_KeyPress);
            }
        }
        public void dgv_Solo_Numeros(DataGridViewEditingControlShowingEventArgs e, DataGridView dgv, string nombreColumna)
        {
            dText = (DataGridViewTextBoxEditingControl)e.Control;//Obteniendo el caracter que se esta editando

            if (dgv.Columns[columnaSeleccionada].Name == nombreColumna)//Nombres de las columnas
            {
                dText.KeyPress += new KeyPressEventHandler(soloNumeros_KeyPress);
            }
        }
        public void Validar_Signo(KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '/' || e.KeyChar == '*') && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

        }
        public void Validar_LetrasMayusculas(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if ((e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;

        }
        private void textoMayuscula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void soloNumerosDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_Numeros_Dec(e, dText.TextLength);
        }
        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public void vaciarCajas(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                if (c is TextBox)

                {
                    c.Text = "";
                }
            }
        }
        public Boolean comprobarCajasLlenas(Form frm)
        {
            Boolean band = false;
            foreach (Control c in frm.Controls)
            {
                if (c is TextBox)

                {
                    if (c.Equals(""))
                        band = true;
                }
            }

            return band;
        }

    }
}
