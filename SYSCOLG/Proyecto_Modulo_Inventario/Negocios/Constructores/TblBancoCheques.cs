using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblBancoCheques
    {
        private int numeroCheque;
        private TblBancos tblBancos;
        private String concepto;
        private DateTime fechaEmision;
        private DateTime fechaVencimiento;
        private float totalCheque;
        //private Set tblCxps = new HashSet(0);

        public TblBancoCheques()
        {
        }


        public TblBancoCheques(int numeroCheque, TblBancos tblBancos)
        {
            this.numeroCheque = numeroCheque;
            this.tblBancos = tblBancos;
        }
        public TblBancoCheques(int numeroCheque, TblBancos tblBancos, String concepto, DateTime fechaEmision, DateTime fechaVencimiento, float totalCheque)//, Set tblCxps)
        {
            this.numeroCheque = numeroCheque;
            this.tblBancos = tblBancos;
            this.concepto = concepto;
            this.fechaEmision = fechaEmision;
            this.fechaVencimiento = fechaVencimiento;
            this.totalCheque = totalCheque;
            //this.tblCxps = tblCxps;
        }

        public int getNumeroCheque()
        {
            return this.numeroCheque;
        }

        public void setNumeroCheque(int numeroCheque)
        {
            this.numeroCheque = numeroCheque;
        }
        public TblBancos getTblBancos()
        {
            return this.tblBancos;
        }

        public void setTblBancos(TblBancos tblBancos)
        {
            this.tblBancos = tblBancos;
        }
        public String getConcepto()
        {
            return this.concepto;
        }

        public void setConcepto(String concepto)
        {
            this.concepto = concepto;
        }
        public DateTime getFechaEmision()
        {
            return this.fechaEmision;
        }

        public void setFechaEmision(DateTime fechaEmision)
        {
            this.fechaEmision = fechaEmision;
        }
        public DateTime getFechaVencimiento()
        {
            return this.fechaVencimiento;
        }

        public void setFechaVencimiento(DateTime fechaVencimiento)
        {
            this.fechaVencimiento = fechaVencimiento;
        }
        public float getTotalCheque()
        {
            return this.totalCheque;
        }

        public void setTotalCheque(float totalCheque)
        {
            this.totalCheque = totalCheque;
        }
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
