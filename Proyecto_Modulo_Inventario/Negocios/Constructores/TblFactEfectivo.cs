using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblFactEfectivo
    {
        private Int32 idFactEfect;
        private TblFactura tblFactura;
        private float totalFactura;
        private DateTime fechaFactura;

        public TblFactEfectivo()
        {
        }


        public TblFactEfectivo(TblFactura tblFactura)
        {
            this.tblFactura = tblFactura;
        }
        public TblFactEfectivo(TblFactura tblFactura, float totalFactura, DateTime fechaFactura)
        {
            this.tblFactura = tblFactura;
            this.totalFactura = totalFactura;
            this.fechaFactura = fechaFactura;
        }

        public Int32 getIdFactEfect()
        {
            return this.idFactEfect;
        }

        public void setIdFactEfect(Int32 idFactEfect)
        {
            this.idFactEfect = idFactEfect;
        }
        public TblFactura getTblFactura()
        {
            return this.tblFactura;
        }

        public void setTblFactura(TblFactura tblFactura)
        {
            this.tblFactura = tblFactura;
        }
        public float getTotalFactura()
        {
            return this.totalFactura;
        }

        public void setTotalFactura(float totalFactura)
        {
            this.totalFactura = totalFactura;
        }
        public DateTime getFechaFactura()
        {
            return this.fechaFactura;
        }

        public void setFechaFactura(DateTime fechaFactura)
        {
            this.fechaFactura = fechaFactura;
        }
    }
}
