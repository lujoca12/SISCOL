using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
   public class TblAcceso
    {
        private Int32 idAcceso;
        private TblRoles tblRoles;
        private String nombreAcceso;
        //private Set tblFuncionAccesos = new HashSet(0);

        public TblAcceso()
        {
        }


        public TblAcceso(TblRoles tblRoles)
        {
            this.tblRoles = tblRoles;
        }
        public TblAcceso(TblRoles tblRoles, String nombreAcceso)//, Set tblFuncionAccesos)
        {
            this.tblRoles = tblRoles;
            this.nombreAcceso = nombreAcceso;
            //this.tblFuncionAccesos = tblFuncionAccesos;
        }

        public Int32 getIdAcceso()
        {
            return this.idAcceso;
        }

        public void setIdAcceso(Int32 idAcceso)
        {
            this.idAcceso = idAcceso;
        }
        public TblRoles getTblRoles()
        {
            return this.tblRoles;
        }

        public void setTblRoles(TblRoles tblRoles)
        {
            this.tblRoles = tblRoles;
        }
        public String getNombreAcceso()
        {
            return this.nombreAcceso;
        }

        public void setNombreAcceso(String nombreAcceso)
        {
            this.nombreAcceso = nombreAcceso;
        }
        //public Set getTblFuncionAccesos()
        //{
        //    return this.tblFuncionAccesos;
        //}

        //public void setTblFuncionAccesos(Set tblFuncionAccesos)
        //{
        //    this.tblFuncionAccesos = tblFuncionAccesos;
        //}
    }
}
