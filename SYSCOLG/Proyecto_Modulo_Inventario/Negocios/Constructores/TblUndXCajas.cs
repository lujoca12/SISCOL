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
        private String codigo;
        private int unidad;
        //private Set tblProductoses = new HashSet(0);

        public TblUndXCajas()
        {
        }

        public TblUndXCajas(Int32 idXCajas, String detalleUnds, Int32 cantidCaja, String codigo, int unidad)//, Set tblProductoses)
        {
            this.detalleUnds = detalleUnds;
            this.cantidCaja = cantidCaja;
            this.codigo = codigo;
            this.unidad = unidad;
        }
        public String getCodigo()
        {
            return this.codigo;
        }

        public void setCodigo(String codigo)
        {
            this.codigo = codigo;
        }
        public int getUnidad()
        {
            return this.unidad;
        }

        public void setUnidad(int unidad)
        {
            this.unidad = unidad;
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
    }
}
