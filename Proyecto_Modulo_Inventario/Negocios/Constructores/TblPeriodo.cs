using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblPeriodo
    {
        private Int32 idPeriodo;
        private TblEmpresa tblEmpresa;
        private DateTime anio;
        //private Set tblBodegas = new HashSet(0);

        public TblPeriodo()
        {
        }


        public TblPeriodo(TblEmpresa tblEmpresa)
        {
            this.tblEmpresa = tblEmpresa;
        }
        public TblPeriodo(TblEmpresa tblEmpresa, DateTime anio)//, Set tblBodegas)
        {
            this.tblEmpresa = tblEmpresa;
            this.anio = anio;
            //this.tblBodegas = tblBodegas;
        }

        public Int32 getIdPeriodo()
        {
            return this.idPeriodo;
        }

        public void setIdPeriodo(Int32 idPeriodo)
        {
            this.idPeriodo = idPeriodo;
        }
        public TblEmpresa getTblEmpresa()
        {
            return this.tblEmpresa;
        }

        public void setTblEmpresa(TblEmpresa tblEmpresa)
        {
            this.tblEmpresa = tblEmpresa;
        }
        public DateTime getAnio()
        {
            return this.anio;
        }

        public void setAnio(DateTime anio)
        {
            this.anio = anio;
        }
        //public Set getTblBodegas()
        //{
        //    return this.tblBodegas;
        //}

        //public void setTblBodegas(Set tblBodegas)
        //{
        //    this.tblBodegas = tblBodegas;
        //}
    }
}
