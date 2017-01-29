using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblUndXCajas
    {
        private Int32 idXCajas;
        private String detalleUnds;
        private Int32 cantidCaja;
        //private Set tblProductoses = new HashSet(0);

        public TblUndXCajas()
        {
        }

        public TblUndXCajas(String detalleUnds, Int32 cantidCaja)//, Set tblProductoses)
        {
            this.detalleUnds = detalleUnds;
            this.cantidCaja = cantidCaja;
            //this.tblProductoses = tblProductoses;
        }

        public Int32 getIdXCajas()
        {
            return this.idXCajas;
        }

        public void setIdXCajas(Int32 idXCajas)
        {
            this.idXCajas = idXCajas;
        }
        public String getDetalleUnds()
        {
            return this.detalleUnds;
        }

        public void setDetalleUnds(String detalleUnds)
        {
            this.detalleUnds = detalleUnds;
        }
        public Int32 getCantidCaja()
        {
            return this.cantidCaja;
        }

        public void setCantidCaja(Int32 cantidCaja)
        {
            this.cantidCaja = cantidCaja;
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
