using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblRetencionCodigo
    {
        private int idRetencionCodigo;
        private String descripcion;
        private Int32 porcentRetener;
        //private Set tblRetencioneses = new HashSet(0);

        public TblRetencionCodigo()
        {
        }


        public TblRetencionCodigo(int idRetencionCodigo)
        {
            this.idRetencionCodigo = idRetencionCodigo;
        }
        public TblRetencionCodigo(int idRetencionCodigo, String descripcion, Int32 porcentRetener)//, Set tblRetencioneses)
        {
            this.idRetencionCodigo = idRetencionCodigo;
            this.descripcion = descripcion;
            this.porcentRetener = porcentRetener;
            //this.tblRetencioneses = tblRetencioneses;
        }

        public int getIdRetencionCodigo()
        {
            return this.idRetencionCodigo;
        }

        public void setIdRetencionCodigo(int idRetencionCodigo)
        {
            this.idRetencionCodigo = idRetencionCodigo;
        }
        public String getDescripcion()
        {
            return this.descripcion;
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }
        public Int32 getPorcentRetener()
        {
            return this.porcentRetener;
        }

        public void setPorcentRetener(Int32 porcentRetener)
        {
            this.porcentRetener = porcentRetener;
        }
        //public Set getTblRetencioneses()
        //{
        //    return this.tblRetencioneses;
        //}

        //public void setTblRetencioneses(Set tblRetencioneses)
        //{
        //    this.tblRetencioneses = tblRetencioneses;
        //}
    }
}
