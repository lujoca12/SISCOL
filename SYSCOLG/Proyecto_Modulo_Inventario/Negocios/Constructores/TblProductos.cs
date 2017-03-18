using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblProductos
    {
        private String codigoProducto;
        private String descripcion;
        private String detalle;
        private Boolean iva;
        private Boolean negarStock;
        private Boolean activo;
        private Char estado;
        private int valor_Iva;
        private TblUndXCajas tblUndXCajas;
        private TblClaseProducto tblClaseProducto;

        public TblProductos()
        {
        }


        public TblProductos(String codigoProducto, TblUndXCajas tblUndXCajas, TblClaseProducto tblClaseProducto)
        {
            this.codigoProducto = codigoProducto;
            this.tblClaseProducto = tblClaseProducto;
            this.tblUndXCajas = tblUndXCajas;
        }
        public TblProductos(String codigoProducto,String descripcion, String detalle, Boolean iva, Boolean negarStock, Boolean activo, Char estado, int valor_Iva, TblUndXCajas tblUndXCajas, TblClaseProducto tblClaseProducto)
        {
            this.codigoProducto = codigoProducto;
            this.descripcion = descripcion;
            this.detalle = detalle;
            this.iva = iva;
            this.negarStock = negarStock;
            this.activo = activo;
            this.estado = estado;
            this.valor_Iva = valor_Iva;
            this.tblClaseProducto = tblClaseProducto;
            this.tblUndXCajas = tblUndXCajas;
        }

        public String getCodigoProducto()
        {
            return this.codigoProducto;
        }

        public void setCodigoProducto(String codigoProducto)
        {
            this.codigoProducto = codigoProducto;
        }
        
        public String getDescripcion()
        {
            return this.descripcion;
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }
        public String getDetalle()
        {
            return this.detalle;
        }

        public void setDetalle(String detalle)
        {
            this.detalle = detalle;
        }
        public Boolean getIva()
        {
            return this.iva;
        }

        public void setIva(Boolean iva)
        {
            this.iva = iva;
        }
        public Boolean getNegarStock()
        {
            return this.negarStock;
        }

        public void setNegarStock(Boolean negarStock)
        {
            this.negarStock = negarStock;
        }
        public Boolean getActivo()
        {
            return this.activo;
        }

        public void setActivo(Boolean activo)
        {
            this.activo = activo;
        }
        public Char getEstado()
        {
            return estado;
        }

        public void setEstado(Char estado)
        {
            this.estado = estado;
        }

        public int getValor_Iva()
        {
            return valor_Iva;
        }

        public void setValor_Iva(int valor_Iva)
        {
            this.valor_Iva = valor_Iva;
        }

        public TblClaseProducto getTblClaseProducto()
        {
            return tblClaseProducto;
        }
        public void setTblClaseProducto(TblClaseProducto tblClaseProducto)
        {
            this.tblClaseProducto = tblClaseProducto;
        }
        public TblUndXCajas getTblUndxCajas()
        {
            return tblUndXCajas;
        }
        public void setTblUndxCajas(TblUndXCajas tblUndXCajas)
        {
            this.tblUndXCajas = tblUndXCajas;
        }
    }
}
