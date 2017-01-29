using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblCompraEfectivo
    {
        private Int32 idCompraEfectivo;
        private TblCompras tblCompras;
        private float totalCompra;
        private DateTime fechaCompra;
        private String responsable;

        public TblCompraEfectivo()
        {
        }


        public TblCompraEfectivo(TblCompras tblCompras)
        {
            this.tblCompras = tblCompras;
        }
        public TblCompraEfectivo(TblCompras tblCompras, float totalCompra, DateTime fechaCompra, String responsable)
        {
            this.tblCompras = tblCompras;
            this.totalCompra = totalCompra;
            this.fechaCompra = fechaCompra;
            this.responsable = responsable;
        }

        public Int32 getIdCompraEfectivo()
        {
            return this.idCompraEfectivo;
        }

        public void setIdCompraEfectivo(Int32 idCompraEfectivo)
        {
            this.idCompraEfectivo = idCompraEfectivo;
        }
        public TblCompras getTblCompras()
        {
            return this.tblCompras;
        }

        public void setTblCompras(TblCompras tblCompras)
        {
            this.tblCompras = tblCompras;
        }
        public float getTotalCompra()
        {
            return this.totalCompra;
        }

        public void setTotalCompra(float totalCompra)
        {
            this.totalCompra = totalCompra;
        }
        public DateTime getFechaCompra()
        {
            return this.fechaCompra;
        }

        public void setFechaCompra(DateTime fechaCompra)
        {
            this.fechaCompra = fechaCompra;
        }
        public String getResponsable()
        {
            return this.responsable;
        }

        public void setResponsable(String responsable)
        {
            this.responsable = responsable;
        }
    }
}
