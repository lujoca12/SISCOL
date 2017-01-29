using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblProdIce
    {
        private Int32 idProdIce;
        private String descripcion;
        private float porcentajeIce;
        //private Set tblComprases = new HashSet(0);

        public TblProdIce()
        {
        }

        public TblProdIce(String descripcion, float porcentajeIce)//, Set tblComprases)
        {
            this.descripcion = descripcion;
            this.porcentajeIce = porcentajeIce;
            //this.tblComprases = tblComprases;
        }

        public Int32 getIdProdIce()
        {
            return this.idProdIce;
        }

        public void setIdProdIce(Int32 idProdIce)
        {
            this.idProdIce = idProdIce;
        }
        public String getDescripcion()
        {
            return this.descripcion;
        }

        public void setDescripcion(String descripcion)
        {
            this.descripcion = descripcion;
        }
        public float getPorcentajeIce()
        {
            return this.porcentajeIce;
        }

        public void setPorcentajeIce(float porcentajeIce)
        {
            this.porcentajeIce = porcentajeIce;
        }
        //public Set getTblComprases()
        //{
        //    return this.tblComprases;
        //}

        //public void setTblComprases(Set tblComprases)
        //{
        //    this.tblComprases = tblComprases;
        //}
    }
}
