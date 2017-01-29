using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblBodegaProductos
    {
        private Int32 idBodegaProduct;
        private TblBodega tblBodega;
        private TblProductos tblProductos;
        private float stock;
        private float stockMinimo;
        private float stockMaximo;

        public TblBodegaProductos()
        {
        }


        public TblBodegaProductos(TblBodega tblBodega, TblProductos tblProductos)
        {
            this.tblBodega = tblBodega;
            this.tblProductos = tblProductos;
        }
        public TblBodegaProductos(TblBodega tblBodega, TblProductos tblProductos, float stock, float stockMinimo, float stockMaximo)
        {
            this.tblBodega = tblBodega;
            this.tblProductos = tblProductos;
            this.stock = stock;
            this.stockMinimo = stockMinimo;
            this.stockMaximo = stockMaximo;
        }

        public Int32 getIdBodegaProduct()
        {
            return this.idBodegaProduct;
        }

        public void setIdBodegaProduct(Int32 idBodegaProduct)
        {
            this.idBodegaProduct = idBodegaProduct;
        }
        public TblBodega getTblBodega()
        {
            return this.tblBodega;
        }

        public void setTblBodega(TblBodega tblBodega)
        {
            this.tblBodega = tblBodega;
        }
        public TblProductos getTblProductos()
        {
            return this.tblProductos;
        }

        public void setTblProductos(TblProductos tblProductos)
        {
            this.tblProductos = tblProductos;
        }
        public float getStock()
        {
            return this.stock;
        }

        public void setStock(float stock)
        {
            this.stock = stock;
        }
        public float getStockMinimo()
        {
            return this.stockMinimo;
        }

        public void setStockMinimo(float stockMinimo)
        {
            this.stockMinimo = stockMinimo;
        }
        public float getStockMaximo()
        {
            return this.stockMaximo;
        }

        public void setStockMaximo(float stockMaximo)
        {
            this.stockMaximo = stockMaximo;
        }
    }
}
