using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblFamilia
    {
        private Int32 idFamilia;
        private TblProductos tblProductos;
        private String nombreFamilia;

        public TblFamilia()
        {
        }

        public TblFamilia(TblProductos tblProductos, String nombreFamilia)
        {
            this.tblProductos = tblProductos;
            this.nombreFamilia = nombreFamilia;
        }

        public Int32 getIdFamilia()
        {
            return this.idFamilia;
        }

        public void setIdFamilia(Int32 idFamilia)
        {
            this.idFamilia = idFamilia;
        }
        public TblProductos getTblProductos()
        {
            return this.tblProductos;
        }

        public void setTblProductos(TblProductos tblProductos)
        {
            this.tblProductos = tblProductos;
        }
        public String getNombreFamilia()
        {
            return this.nombreFamilia;
        }

        public void setNombreFamilia(String nombreFamilia)
        {
            this.nombreFamilia = nombreFamilia;
        }
    }
}
