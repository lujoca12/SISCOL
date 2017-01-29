using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblClaseProducto
    {
        private Int32 idClaseProduct;
        private TblTipoProducto tblTipoProducto;
        private String nombreClaseProd;
        //private Set tblProductoses = new HashSet(0);

        public TblClaseProducto()
        {
        }


        public TblClaseProducto(TblTipoProducto tblTipoProducto)
        {
            this.tblTipoProducto = tblTipoProducto;
        }
        public TblClaseProducto(TblTipoProducto tblTipoProducto, String nombreClaseProd)//, Set tblProductoses)
        {
            this.tblTipoProducto = tblTipoProducto;
            this.nombreClaseProd = nombreClaseProd;
           // this.tblProductoses = tblProductoses;
        }

        public Int32 getIdClaseProduct()
        {
            return this.idClaseProduct;
        }

        public void setIdClaseProduct(Int32 idClaseProduct)
        {
            this.idClaseProduct = idClaseProduct;
        }
        public TblTipoProducto getTblTipoProducto()
        {
            return this.tblTipoProducto;
        }

        public void setTblTipoProducto(TblTipoProducto tblTipoProducto)
        {
            this.tblTipoProducto = tblTipoProducto;
        }
        public String getNombreClaseProd()
        {
            return this.nombreClaseProd;
        }

        public void setNombreClaseProd(String nombreClaseProd)
        {
            this.nombreClaseProd = nombreClaseProd;
        }
        //public Set getTblProductoses()
        //{
        //    return this.tblProductoses;
        //}

        //public void setTblProductoses(Set tblProductoses)
        //{
        //    this.tblProductoses = tblProductoses;
        //}
    }
}
