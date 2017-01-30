using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblBodega
    {
        private Int32 idBodega;
        private TblPeriodo tblPeriodo;
        private String nombreBodega;
        //private Set tblBodegaProductoses = new HashSet(0);

        public TblBodega()
        {
        }


        public TblBodega(TblPeriodo tblPeriodo)
        {
            this.tblPeriodo = tblPeriodo;
        }
        public TblBodega(TblPeriodo tblPeriodo, String nombreBodega)//, Set tblBodegaProductoses)
        {
            this.tblPeriodo = tblPeriodo;
            this.nombreBodega = nombreBodega;
            //this.tblBodegaProductoses = tblBodegaProductoses;
        }

        public Int32 getIdBodega()
        {
            return this.idBodega;
        }

        public void setIdBodega(Int32 idBodega)
        {
            this.idBodega = idBodega;
        }
        public TblPeriodo getTblPeriodo()
        {
            return this.tblPeriodo;
        }

        public void setTblPeriodo(TblPeriodo tblPeriodo)
        {
            this.tblPeriodo = tblPeriodo;
        }
        public String getNombreBodega()
        {
            return this.nombreBodega;
        }

        public void setNombreBodega(String nombreBodega)
        {
            this.nombreBodega = nombreBodega;
        }
        //public Set getTblBodegaProductoses()
        //{
        //    return this.tblBodegaProductoses;
        //}

        //public void setTblBodegaProductoses(Set tblBodegaProductoses)
        //{
        //    this.tblBodegaProductoses = tblBodegaProductoses;
        //}
    }
}
