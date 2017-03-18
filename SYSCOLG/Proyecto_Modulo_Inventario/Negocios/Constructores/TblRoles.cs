using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblRoles
    {
        private char idRol;
        private String nombreRol;
        //private Set tblAccesos = new HashSet(0);
        //private Set tblUsuarioses = new HashSet(0);

        public TblRoles()
        {
        }


        public TblRoles(char idRol)
        {
            this.idRol = idRol;
        }
        public TblRoles(char idRol, String nombreRol)//, Set tblAccesos, Set tblUsuarioses)
        {
            this.idRol = idRol;
            this.nombreRol = nombreRol;
            //this.tblAccesos = tblAccesos;
            //this.tblUsuarioses = tblUsuarioses;
        }

        public char getIdRol()
        {
            return this.idRol;
        }

        public void setIdRol(char idRol)
        {
            this.idRol = idRol;
        }
        public String getNombreRol()
        {
            return this.nombreRol;
        }

        public void setNombreRol(String nombreRol)
        {
            this.nombreRol = nombreRol;
        }
        //public Set getTblAccesos()
        //{
        //    return this.tblAccesos;
        //}

        //public void setTblAccesos(Set tblAccesos)
        //{
        //    this.tblAccesos = tblAccesos;
        //}
        //public Set getTblUsuarioses()
        //{
        //    return this.tblUsuarioses;
        //}

        //public void setTblUsuarioses(Set tblUsuarioses)
        //{
        //    this.tblUsuarioses = tblUsuarioses;
        //}
    }
}
