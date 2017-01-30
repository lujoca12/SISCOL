using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblProductos
    {
        private String codigoProducto;
        private TblClaseProducto tblClaseProducto;
        private TblUndXCajas tblUndXCajas;
        private String descripcion;
        private String detalle;
        private Boolean iva;
        private Boolean negarStock;
        private Boolean activo;
        //private Set tblDetalleFacturas = new HashSet(0);
        //private Set tblBodegaProductoses = new HashSet(0);
        //private Set tblFamilias = new HashSet(0);
        //private Set tblComprases = new HashSet(0);
        //private Set tblProductProveedoreses = new HashSet(0);
        //private Set tblPrecioses = new HashSet(0);

        public TblProductos()
        {
        }


        public TblProductos(String codigoProducto)
        {
            this.codigoProducto = codigoProducto;
        }
        public TblProductos(String codigoProducto, TblClaseProducto tblClaseProducto, TblUndXCajas tblUndXCajas, String descripcion, String detalle, Boolean iva, Boolean negarStock, Boolean activo)//, Set tblDetalleFacturas, Set tblBodegaProductoses, Set tblFamilias, Set tblComprases, Set tblProductProveedoreses, Set tblPrecioses)
        {
            this.codigoProducto = codigoProducto;
            this.tblClaseProducto = tblClaseProducto;
            this.tblUndXCajas = tblUndXCajas;
            this.descripcion = descripcion;
            this.detalle = detalle;
            this.iva = iva;
            this.negarStock = negarStock;
            this.activo = activo;
            //this.tblDetalleFacturas = tblDetalleFacturas;
            //this.tblBodegaProductoses = tblBodegaProductoses;
            //this.tblFamilias = tblFamilias;
            //this.tblComprases = tblComprases;
            //this.tblProductProveedoreses = tblProductProveedoreses;
            //this.tblPrecioses = tblPrecioses;
        }

        public String getCodigoProducto()
        {
            return this.codigoProducto;
        }

        public void setCodigoProducto(String codigoProducto)
        {
            this.codigoProducto = codigoProducto;
        }
        public TblClaseProducto getTblClaseProducto()
        {
            return this.tblClaseProducto;
        }

        public void setTblClaseProducto(TblClaseProducto tblClaseProducto)
        {
            this.tblClaseProducto = tblClaseProducto;
        }
        public TblUndXCajas getTblUndXCajas()
        {
            return this.tblUndXCajas;
        }

        public void setTblUndXCajas(TblUndXCajas tblUndXCajas)
        {
            this.tblUndXCajas = tblUndXCajas;
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
        //public Set getTblDetalleFacturas()
        //{
        //    return this.tblDetalleFacturas;
        //}

        //public void setTblDetalleFacturas(Set tblDetalleFacturas)
        //{
        //    this.tblDetalleFacturas = tblDetalleFacturas;
        //}
        //public Set getTblBodegaProductoses()
        //{
        //    return this.tblBodegaProductoses;
        //}

        //public void setTblBodegaProductoses(Set tblBodegaProductoses)
        //{
        //    this.tblBodegaProductoses = tblBodegaProductoses;
        //}
        //public Set getTblFamilias()
        //{
        //    return this.tblFamilias;
        //}

        //public void setTblFamilias(Set tblFamilias)
        //{
        //    this.tblFamilias = tblFamilias;
        //}
        //public Set getTblComprases()
        //{
        //    return this.tblComprases;
        //}

        //public void setTblComprases(Set tblComprases)
        //{
        //    this.tblComprases = tblComprases;
        //}
        //public Set getTblProductProveedoreses()
        //{
        //    return this.tblProductProveedoreses;
        //}

        //public void setTblProductProveedoreses(Set tblProductProveedoreses)
        //{
        //    this.tblProductProveedoreses = tblProductProveedoreses;
        //}
        //public Set getTblPrecioses()
        //{
        //    return this.tblPrecioses;
        //}

        //public void setTblPrecioses(Set tblPrecioses)
        //{
        //    this.tblPrecioses = tblPrecioses;
        //}
    }
}
