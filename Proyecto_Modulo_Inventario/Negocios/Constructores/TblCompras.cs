using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblCompras
    {
        private Int32 idCompra;
        private TblProdIce tblProdIce;
        private TblProductos tblProductos;
        private TblProveedores tblProveedores;
        private DateTime fechaCompra;
        private String numeroCompra;
        private String concepto;
        private String documentoTipo;
        //private Set tblCompraEfectivos = new HashSet(0);
        //private Set tblCxps = new HashSet(0);

        public TblCompras()
        {
        }


        public TblCompras(TblProdIce tblProdIce, TblProveedores tblProveedores, String numeroCompra)
        {
            this.tblProdIce = tblProdIce;
            this.tblProveedores = tblProveedores;
            this.numeroCompra = numeroCompra;
        }
        public TblCompras(TblProdIce tblProdIce, TblProductos tblProductos, TblProveedores tblProveedores, DateTime fechaCompra, String numeroCompra, String concepto, String documentoTipo)//, Set tblCompraEfectivos, Set tblCxps)
        {
            this.tblProdIce = tblProdIce;
            this.tblProductos = tblProductos;
            this.tblProveedores = tblProveedores;
            this.fechaCompra = fechaCompra;
            this.numeroCompra = numeroCompra;
            this.concepto = concepto;
            this.documentoTipo = documentoTipo;
            //this.tblCompraEfectivos = tblCompraEfectivos;
            //this.tblCxps = tblCxps;
        }

        public Int32 getIdCompra()
        {
            return this.idCompra;
        }

        public void setIdCompra(Int32 idCompra)
        {
            this.idCompra = idCompra;
        }
        public TblProdIce getTblProdIce()
        {
            return this.tblProdIce;
        }

        public void setTblProdIce(TblProdIce tblProdIce)
        {
            this.tblProdIce = tblProdIce;
        }
        public TblProductos getTblProductos()
        {
            return this.tblProductos;
        }

        public void setTblProductos(TblProductos tblProductos)
        {
            this.tblProductos = tblProductos;
        }
        public TblProveedores getTblProveedores()
        {
            return this.tblProveedores;
        }

        public void setTblProveedores(TblProveedores tblProveedores)
        {
            this.tblProveedores = tblProveedores;
        }
        public DateTime getFechaCompra()
        {
            return this.fechaCompra;
        }

        public void setFechaCompra(DateTime fechaCompra)
        {
            this.fechaCompra = fechaCompra;
        }
        public String getNumeroCompra()
        {
            return this.numeroCompra;
        }

        public void setNumeroCompra(String numeroCompra)
        {
            this.numeroCompra = numeroCompra;
        }
        public String getConcepto()
        {
            return this.concepto;
        }

        public void setConcepto(String concepto)
        {
            this.concepto = concepto;
        }
        public String getDocumentoTipo()
        {
            return this.documentoTipo;
        }

        public void setDocumentoTipo(String documentoTipo)
        {
            this.documentoTipo = documentoTipo;
        }
        //public Set getTblCompraEfectivos()
        //{
        //    return this.tblCompraEfectivos;
        //}

        //public void setTblCompraEfectivos(Set tblCompraEfectivos)
        //{
        //    this.tblCompraEfectivos = tblCompraEfectivos;
        //}
        //public Set getTblCxps()
        //{
        //    return this.tblCxps;
        //}

        //public void setTblCxps(Set tblCxps)
        //{
        //    this.tblCxps = tblCxps;
        //}
    }
}
