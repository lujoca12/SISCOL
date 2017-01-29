using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblRetenciones
    {
        private Int32 idRetencion;
        private TblProveedores tblProveedores;
        private TblRetencionCodigo tblRetencionCodigo;
        private float totalFactura;
        private float valorSIva;
        private float valorNIva;
        private String serieComprobRetenc;
        private DateTime fechaEmision;
        private String autorizacion;

        public TblRetenciones()
        {
        }


        public TblRetenciones(TblProveedores tblProveedores, TblRetencionCodigo tblRetencionCodigo)
        {
            this.tblProveedores = tblProveedores;
            this.tblRetencionCodigo = tblRetencionCodigo;
        }
        public TblRetenciones(TblProveedores tblProveedores, TblRetencionCodigo tblRetencionCodigo, float totalFactura, float valorSIva, float valorNIva, String serieComprobRetenc, DateTime fechaEmision, String autorizacion)
        {
            this.tblProveedores = tblProveedores;
            this.tblRetencionCodigo = tblRetencionCodigo;
            this.totalFactura = totalFactura;
            this.valorSIva = valorSIva;
            this.valorNIva = valorNIva;
            this.serieComprobRetenc = serieComprobRetenc;
            this.fechaEmision = fechaEmision;
            this.autorizacion = autorizacion;
        }

        public Int32 getIdRetencion()
        {
            return this.idRetencion;
        }

        public void setIdRetencion(Int32 idRetencion)
        {
            this.idRetencion = idRetencion;
        }
        public TblProveedores getTblProveedores()
        {
            return this.tblProveedores;
        }

        public void setTblProveedores(TblProveedores tblProveedores)
        {
            this.tblProveedores = tblProveedores;
        }
        public TblRetencionCodigo getTblRetencionCodigo()
        {
            return this.tblRetencionCodigo;
        }

        public void setTblRetencionCodigo(TblRetencionCodigo tblRetencionCodigo)
        {
            this.tblRetencionCodigo = tblRetencionCodigo;
        }
        public float getTotalFactura()
        {
            return this.totalFactura;
        }

        public void setTotalFactura(float totalFactura)
        {
            this.totalFactura = totalFactura;
        }
        public float getValorSIva()
        {
            return this.valorSIva;
        }

        public void setValorSIva(float valorSIva)
        {
            this.valorSIva = valorSIva;
        }
        public float getValorNIva()
        {
            return this.valorNIva;
        }

        public void setValorNIva(float valorNIva)
        {
            this.valorNIva = valorNIva;
        }
        public String getSerieComprobRetenc()
        {
            return this.serieComprobRetenc;
        }

        public void setSerieComprobRetenc(String serieComprobRetenc)
        {
            this.serieComprobRetenc = serieComprobRetenc;
        }
        public DateTime getFechaEmision()
        {
            return this.fechaEmision;
        }

        public void setFechaEmision(DateTime fechaEmision)
        {
            this.fechaEmision = fechaEmision;
        }
        public String getAutorizacion()
        {
            return this.autorizacion;
        }

        public void setAutorizacion(String autorizacion)
        {
            this.autorizacion = autorizacion;
        }
    }
}
