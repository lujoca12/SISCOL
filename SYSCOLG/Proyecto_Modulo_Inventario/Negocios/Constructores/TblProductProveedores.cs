using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblProductProveedores:TblProveedores
    {
        private Int32 idProdProveed;
        private TblProductos tblProductos;
        private TblProveedores tblProveedores;

        public TblProductProveedores()
        {
        }

        public TblProductProveedores(TblProductos tblProductos, TblProveedores tblProveedores)
        {
            this.tblProductos = tblProductos;
            this.tblProveedores = tblProveedores;
        }

        public Int32 getIdProdProveed()
        {
            return this.idProdProveed;
        }

        public void setIdProdProveed(Int32 idProdProveed)
        {
            this.idProdProveed = idProdProveed;
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
    }
}
