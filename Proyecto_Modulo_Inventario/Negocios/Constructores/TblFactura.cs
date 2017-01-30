using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblFactura
    {
        private Int32 idFactura;
        private TblClientes tblClientes;
        private TblVendedores tblVendedores;
        private DateTime fechaEmision;
        private String nota;
        //private Set tblCxcs = new HashSet(0);
        //private Set tblFactEfectivos = new HashSet(0);
        //private Set tblDetalleFacturas = new HashSet(0);

        public TblFactura()
        {
        }


        public TblFactura(TblClientes tblClientes, TblVendedores tblVendedores)
        {
            this.tblClientes = tblClientes;
            this.tblVendedores = tblVendedores;
        }
        public TblFactura(TblClientes tblClientes, TblVendedores tblVendedores, DateTime fechaEmision, String nota)//, Set tblCxcs, Set tblFactEfectivos, Set tblDetalleFacturas)
        {
            this.tblClientes = tblClientes;
            this.tblVendedores = tblVendedores;
            this.fechaEmision = fechaEmision;
            this.nota = nota;
        //    this.tblCxcs = tblCxcs;
          //  this.tblFactEfectivos = tblFactEfectivos;
            //this.tblDetalleFacturas = tblDetalleFacturas;
        }

        public Int32 getIdFactura()
        {
            return this.idFactura;
        }

        public void setIdFactura(Int32 idFactura)
        {
            this.idFactura = idFactura;
        }
        public TblClientes getTblClientes()
        {
            return this.tblClientes;
        }

        public void setTblClientes(TblClientes tblClientes)
        {
            this.tblClientes = tblClientes;
        }
        public TblVendedores getTblVendedores()
        {
            return this.tblVendedores;
        }

        public void setTblVendedores(TblVendedores tblVendedores)
        {
            this.tblVendedores = tblVendedores;
        }
        public DateTime getFechaEmision()
        {
            return this.fechaEmision;
        }

        public void setFechaEmision(DateTime fechaEmision)
        {
            this.fechaEmision = fechaEmision;
        }
        public String getNota()
        {
            return this.nota;
        }

        public void setNota(String nota)
        {
            this.nota = nota;
        }
        //public Set getTblCxcs()
        //{
        //    return this.tblCxcs;
        //}

        //public void setTblCxcs(Set tblCxcs)
        //{
        //    this.tblCxcs = tblCxcs;
        //}
        //public Set getTblFactEfectivos()
        //{
        //    return this.tblFactEfectivos;
        //}

        //public void setTblFactEfectivos(Set tblFactEfectivos)
        //{
        //    this.tblFactEfectivos = tblFactEfectivos;
        //}
        //public Set getTblDetalleFacturas()
        //{
        //    return this.tblDetalleFacturas;
        //}

        //public void setTblDetalleFacturas(Set tblDetalleFacturas)
        //{
        //    this.tblDetalleFacturas = tblDetalleFacturas;
        //}
    }
}
