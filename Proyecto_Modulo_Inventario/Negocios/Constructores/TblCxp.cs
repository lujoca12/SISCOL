using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblCxp
    {
        private Int32 idCxP;
        private TblBancoCheques tblBancoCheques;
        private TblCompras tblCompras;
        private DateTime fechaEmision;
        private float abono;
        private DateTime fechaVencimiento;
        private float totalCxP;

        public TblCxp()
        {
        }


        public TblCxp(TblBancoCheques tblBancoCheques, TblCompras tblCompras)
        {
            this.tblBancoCheques = tblBancoCheques;
            this.tblCompras = tblCompras;
        }
        public TblCxp(TblBancoCheques tblBancoCheques, TblCompras tblCompras, DateTime fechaEmision, float abono, DateTime fechaVencimiento, float totalCxP)
        {
            this.tblBancoCheques = tblBancoCheques;
            this.tblCompras = tblCompras;
            this.fechaEmision = fechaEmision;
            this.abono = abono;
            this.fechaVencimiento = fechaVencimiento;
            this.totalCxP = totalCxP;
        }

        public Int32 getIdCxP()
        {
            return this.idCxP;
        }

        public void setIdCxP(Int32 idCxP)
        {
            this.idCxP = idCxP;
        }
        public TblBancoCheques getTblBancoCheques()
        {
            return this.tblBancoCheques;
        }

        public void setTblBancoCheques(TblBancoCheques tblBancoCheques)
        {
            this.tblBancoCheques = tblBancoCheques;
        }
        public TblCompras getTblCompras()
        {
            return this.tblCompras;
        }

        public void setTblCompras(TblCompras tblCompras)
        {
            this.tblCompras = tblCompras;
        }
        public DateTime getFechaEmision()
        {
            return this.fechaEmision;
        }

        public void setFechaEmision(DateTime fechaEmision)
        {
            this.fechaEmision = fechaEmision;
        }
        public float getAbono()
        {
            return this.abono;
        }

        public void setAbono(float abono)
        {
            this.abono = abono;
        }
        public DateTime getFechaVencimiento()
        {
            return this.fechaVencimiento;
        }

        public void setFechaVencimiento(DateTime fechaVencimiento)
        {
            this.fechaVencimiento = fechaVencimiento;
        }
        public float getTotalCxP()
        {
            return this.totalCxP;
        }

        public void setTotalCxP(float totalCxP)
        {
            this.totalCxP = totalCxP;
        }
    }
}
