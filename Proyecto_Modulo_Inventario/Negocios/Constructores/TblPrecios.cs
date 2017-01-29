using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblPrecios
    {
        private Int32 idPrecio;
        private TblProductos tblProductos;
        private float costo;
        private DateTime fechaPrecio;
        private DateTime fechaCaducidad;
        private float pvp;
        private float precio1;
        private float precio2;
        private float precio3;
        private float precio4;
        private float precio5;
        private float volumen1;
        private float volumen2;
        private float volumen3;
        private float volumen4;
        private float volumen5;

        public TblPrecios()
        {
        }


        public TblPrecios(TblProductos tblProductos)
        {
            this.tblProductos = tblProductos;
        }
        public TblPrecios(TblProductos tblProductos, float costo, DateTime fechaPrecio, DateTime fechaCaducidad, float pvp, float precio1, float precio2, float precio3, float precio4, float precio5, float volumen1, float volumen2, float volumen3, float volumen4, float volumen5)
        {
            this.tblProductos = tblProductos;
            this.costo = costo;
            this.fechaPrecio = fechaPrecio;
            this.fechaCaducidad = fechaCaducidad;
            this.pvp = pvp;
            this.precio1 = precio1;
            this.precio2 = precio2;
            this.precio3 = precio3;
            this.precio4 = precio4;
            this.precio5 = precio5;
            this.volumen1 = volumen1;
            this.volumen2 = volumen2;
            this.volumen3 = volumen3;
            this.volumen4 = volumen4;
            this.volumen5 = volumen5;
        }

        public Int32 getIdPrecio()
        {
            return this.idPrecio;
        }

        public void setIdPrecio(Int32 idPrecio)
        {
            this.idPrecio = idPrecio;
        }
        public TblProductos getTblProductos()
        {
            return this.tblProductos;
        }

        public void setTblProductos(TblProductos tblProductos)
        {
            this.tblProductos = tblProductos;
        }
        public float getCosto()
        {
            return this.costo;
        }

        public void setCosto(float costo)
        {
            this.costo = costo;
        }
        public DateTime getFechaPrecio()
        {
            return this.fechaPrecio;
        }

        public void setFechaPrecio(DateTime fechaPrecio)
        {
            this.fechaPrecio = fechaPrecio;
        }
        public DateTime getFechaCaducidad()
        {
            return this.fechaCaducidad;
        }

        public void setFechaCaducidad(DateTime fechaCaducidad)
        {
            this.fechaCaducidad = fechaCaducidad;
        }
        public float getPvp()
        {
            return this.pvp;
        }

        public void setPvp(float pvp)
        {
            this.pvp = pvp;
        }
        public float getPrecio1()
        {
            return this.precio1;
        }

        public void setPrecio1(float precio1)
        {
            this.precio1 = precio1;
        }
        public float getPrecio2()
        {
            return this.precio2;
        }

        public void setPrecio2(float precio2)
        {
            this.precio2 = precio2;
        }
        public float getPrecio3()
        {
            return this.precio3;
        }

        public void setPrecio3(float precio3)
        {
            this.precio3 = precio3;
        }
        public float getPrecio4()
        {
            return this.precio4;
        }

        public void setPrecio4(float precio4)
        {
            this.precio4 = precio4;
        }
        public float getPrecio5()
        {
            return this.precio5;
        }

        public void setPrecio5(float precio5)
        {
            this.precio5 = precio5;
        }
        public float getVolumen1()
        {
            return this.volumen1;
        }

        public void setVolumen1(float volumen1)
        {
            this.volumen1 = volumen1;
        }
        public float getVolumen2()
        {
            return this.volumen2;
        }

        public void setVolumen2(float volumen2)
        {
            this.volumen2 = volumen2;
        }
        public float getVolumen3()
        {
            return this.volumen3;
        }

        public void setVolumen3(float volumen3)
        {
            this.volumen3 = volumen3;
        }
        public float getVolumen4()
        {
            return this.volumen4;
        }

        public void setVolumen4(float volumen4)
        {
            this.volumen4 = volumen4;
        }
        public float getVolumen5()
        {
            return this.volumen5;
        }

        public void setVolumen5(float volumen5)
        {
            this.volumen5 = volumen5;
        }
    }
}
