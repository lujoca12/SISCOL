using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblEmpresa
    {
        private Int32 idEmpresa;
        private TblPais tblPais;
        private String nombreEmpresa;
        private String rucEmpresa;
        private String direccion;
        private String telefono;
        private float logoEmpresa;
        //private Set tblPeriodos = new HashSet(0);

        public TblEmpresa()
        {
        }


        public TblEmpresa(TblPais tblPais)
        {
            this.tblPais = tblPais;
        }
        public TblEmpresa(TblPais tblPais, String nombreEmpresa, String rucEmpresa, String direccion, String telefono, float logoEmpresa)//, Set tblPeriodos)
        {
            this.tblPais = tblPais;
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
        public TblPais getTblPais()
        {
            return this.tblPais;
        }

        public void setTblPais(TblPais tblPais)
        {
            this.tblPais = tblPais;
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
        public float getLogoEmpresa()
        {
            return this.logoEmpresa;
        }

        public void setLogoEmpresa(float logoEmpresa)
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
