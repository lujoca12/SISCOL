using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblPais
    {
        private Int32 idPais;
        private String nombrePais;
        //private Set tblCiudads = new HashSet(0);
        //private Set tblEmpresas = new HashSet(0);

        public TblPais()
        {
        }

        public TblPais(String nombrePais)//, Set tblCiudads, Set tblEmpresas)
        {
            this.nombrePais = nombrePais;
            //this.tblCiudads = tblCiudads;
            //this.tblEmpresas = tblEmpresas;
        }

        public Int32 getIdPais()
        {
            return this.idPais;
        }

        public void setIdPais(Int32 idPais)
        {
            this.idPais = idPais;
        }
        public String getNombrePais()
        {
            return this.nombrePais;
        }

        public void setNombrePais(String nombrePais)
        {
            this.nombrePais = nombrePais;
        }
        //public Set getTblCiudads()
        //{
        //    return this.tblCiudads;
        //}

        //public void setTblCiudads(Set tblCiudads)
        //{
        //    this.tblCiudads = tblCiudads;
        //}
        //public Set getTblEmpresas()
        //{
        //    return this.tblEmpresas;
        //}

        //public void setTblEmpresas(Set tblEmpresas)
        //{
        //    this.tblEmpresas = tblEmpresas;
        //}
    }
}
