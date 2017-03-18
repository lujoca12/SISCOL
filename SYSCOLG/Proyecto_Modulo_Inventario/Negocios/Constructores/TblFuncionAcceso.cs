using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblFuncionAcceso
    {
        private Int32 idFuncionAcceso;
        private TblAcceso tblAcceso;
        private String nombreFuncionAcceso;

        public TblFuncionAcceso()
        {
        }


        public TblFuncionAcceso(TblAcceso tblAcceso)
        {
            this.tblAcceso = tblAcceso;
        }
        public TblFuncionAcceso(TblAcceso tblAcceso, String nombreFuncionAcceso)
        {
            this.tblAcceso = tblAcceso;
            this.nombreFuncionAcceso = nombreFuncionAcceso;
        }

        public Int32 getIdFuncionAcceso()
        {
            return this.idFuncionAcceso;
        }

        public void setIdFuncionAcceso(Int32 idFuncionAcceso)
        {
            this.idFuncionAcceso = idFuncionAcceso;
        }
        public TblAcceso getTblAcceso()
        {
            return this.tblAcceso;
        }

        public void setTblAcceso(TblAcceso tblAcceso)
        {
            this.tblAcceso = tblAcceso;
        }
        public String getNombreFuncionAcceso()
        {
            return this.nombreFuncionAcceso;
        }

        public void setNombreFuncionAcceso(String nombreFuncionAcceso)
        {
            this.nombreFuncionAcceso = nombreFuncionAcceso;
        }
    }
}
