using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblEmpresa:TblCiudad
    {
        private Int32 idEmpresa;
        private TblCiudad tblCiudad;
        private String nombreEmpresa;
        private String rucEmpresa;
        private String direccion;
        private String telefono;
        private String logoEmpresa;
        //private Set tblPeriodos = new HashSet(0);

        public TblEmpresa()
        {
        }


        public TblEmpresa(TblCiudad tblPais)
        {
            this.tblCiudad = tblPais;
        }
        public TblEmpresa(TblCiudad tblCiudad, String nombreEmpresa, String rucEmpresa, String direccion, String telefono, String logoEmpresa)//, Set tblPeriodos)
        {
            this.tblCiudad = tblCiudad;
            this.nombreEmpresa = nombreEmpresa;
            this.rucEmpresa = rucEmpresa;
            this.direccion = direccion;
            this.telefono = telefono;
            this.logoEmpresa = logoEmpresa;
            //this.tblPeriodos = tblPeriodos;
        }

        public Int32 getIdEmpresa()
        {
            return this.idEmpresa;
        }

        public void setIdEmpresa(Int32 idEmpresa)
        {
            this.idEmpresa = idEmpresa;
        }
        public TblCiudad getTblCiudad()
        {
            return this.tblCiudad;
        }

        public void setTblCiudad(TblCiudad tblCiudad)
        {
            this.tblCiudad = tblCiudad;
        }
        public String getNombreEmpresa()
        {
            return this.nombreEmpresa;
        }

        public void setNombreEmpresa(String nombreEmpresa)
        {
            this.nombreEmpresa = nombreEmpresa;
        }
        public String getRucEmpresa()
        {
            return this.rucEmpresa;
        }

        public void setRucEmpresa(String rucEmpresa)
        {
            this.rucEmpresa = rucEmpresa;
        }
        public String getDireccion()
        {
            return this.direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }
        public String getTelefono()
        {
            return this.telefono;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }
        public String getLogoEmpresa()
        {
            return this.logoEmpresa;
        }

        public void setLogoEmpresa(String logoEmpresa)
        {
            this.logoEmpresa = logoEmpresa;
        }
        //public Set getTblPeriodos()
        //{
        //    return this.tblPeriodos;
        //}

        //public void setTblPeriodos(Set tblPeriodos)
        //{
        //    this.tblPeriodos = tblPeriodos;
        //}
    }
}
