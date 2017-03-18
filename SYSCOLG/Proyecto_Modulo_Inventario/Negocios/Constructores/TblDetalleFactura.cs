using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblDetalleFactura
    {
        private Int32 idDetalleFactura;
        private TblFactura tblFactura;
        private TblProductos tblProductos;
        private float cantidad;
        private float precio;
        private float descuento;
        private float total;

        public TblDetalleFactura()
        {
        }


        public TblDetalleFactura(TblFactura tblFactura, TblProductos tblProductos)
        {
            this.tblFactura = tblFactura;
            this.tblProductos = tblProductos;
        }
        public TblDetalleFactura(TblFactura tblFactura, TblProductos tblProductos, float cantidad, float precio, float descuento, float total)
        {
            this.tblFactura = tblFactura;
            this.tblProductos = tblProductos;
            this.cantidad = cantidad;
            this.precio = precio;
            this.descuento = descuento;
            this.total = total;
        }

        public Int32 getIdDetalleFactura()
        {
            return this.idDetalleFactura;
        }

        public void setIdDetalleFactura(Int32 idDetalleFactura)
        {
            this.idDetalleFactura = idDetalleFactura;
        }
        public TblFactura getTblFactura()
        {
            return this.tblFactura;
        }

        public void setTblFactura(TblFactura tblFactura)
        {
            this.tblFactura = tblFactura;
        }
        public TblProductos getTblProductos()
        {
            return this.tblProductos;
        }

        public void setTblProductos(TblProductos tblProductos)
        {
            this.tblProductos = tblProductos;
        }
        public float getCantidad()
        {
            return this.cantidad;
        }

        public void setCantidad(float cantidad)
        {
            this.cantidad = cantidad;
        }
        public float getPrecio()
        {
            return this.precio;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }
        public float getDescuento()
        {
            return this.descuento;
        }

        public void setDescuento(float descuento)
        {
            this.descuento = descuento;
        }
        public float getTotal()
        {
            return this.total;
        }

        public void setTotal(float total)
        {
            this.total = total;
        }
    }
}
