using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblTipoProducto:TblClaseProducto
    {
        private Int32 idTipoProducto;
        private String nombreTipoProd;
        //private Set tblClaseProductos = new HashSet(0);

        public TblTipoProducto()
        {
        }

        public TblTipoProducto(String nombreTipoProd)//, Set tblClaseProductos)
        {
            this.nombreTipoProd = nombreTipoProd;
            //this.tblClaseProductos = tblClaseProductos;
        }

        public Int32 getIdTipoProducto()
        {
            return this.idTipoProducto;
        }

        public void setIdTipoProducto(Int32 idTipoProducto)
        {
            this.idTipoProducto = idTipoProducto;
        }
        public String getNombreTipoProd()
        {
            return this.nombreTipoProd;
        }

        public void setNombreTipoProd(String nombreTipoProd)
        {
            this.nombreTipoProd = nombreTipoProd;
        }
        //public Set getTblClaseProductos()
        //{
        //    return this.tblClaseProductos;
        //}

        //public void setTblClaseProductos(Set tblClaseProductos)
        //{
        //    this.tblClaseProductos = tblClaseProductos;
        //}
    }
}
