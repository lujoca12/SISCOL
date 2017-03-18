using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblCxc
    {
        private Int32 idCxC;
        private TblFactura tblFactura;
        private TblRecaudadores tblRecaudadores;
        private DateTime fechaEmision;
        private float abono;
        private DateTime fechaVencimiento;
        private float totalCxC;
        private int idRecaudador;

        public TblCxc()
        {
        }


        public TblCxc(TblFactura tblFactura, TblRecaudadores tblRecaudadores, int idRecaudador)
        {
            this.tblFactura = tblFactura;
            this.tblRecaudadores = tblRecaudadores;
            this.idRecaudador = idRecaudador;
        }
        public TblCxc(TblFactura tblFactura, TblRecaudadores tblRecaudadores, DateTime fechaEmision, float abono, DateTime fechaVencimiento, float totalCxC, int idRecaudador)
        {
            this.tblFactura = tblFactura;
            this.tblRecaudadores = tblRecaudadores;
            this.fechaEmision = fechaEmision;
            this.abono = abono;
            this.fechaVencimiento = fechaVencimiento;
            this.totalCxC = totalCxC;
            this.idRecaudador = idRecaudador;
        }

        public Int32 getIdCxC()
        {
            return this.idCxC;
        }

        public void setIdCxC(Int32 idCxC)
        {
            this.idCxC = idCxC;
        }
        public TblFactura getTblFactura()
        {
            return this.tblFactura;
        }

        public void setTblFactura(TblFactura tblFactura)
        {
            this.tblFactura = tblFactura;
        }
        public TblRecaudadores getTblRecaudadores()
        {
            return this.tblRecaudadores;
        }

        public void setTblRecaudadores(TblRecaudadores tblRecaudadores)
        {
            this.tblRecaudadores = tblRecaudadores;
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
        public float getTotalCxC()
        {
            return this.totalCxC;
        }

        public void setTotalCxC(float totalCxC)
        {
            this.totalCxC = totalCxC;
        }
        public int getIdRecaudador()
        {
            return this.idRecaudador;
        }

        public void setIdRecaudador(int idRecaudador)
        {
            this.idRecaudador = idRecaudador;
        }
    }
}
