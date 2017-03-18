using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblProveedores:TblCompras
    {
        private Int32 idProveedor;
        private Int32 rucProveedor;
        private String nombreProveed;
        private String apellidoProveed;
        private String telefono;
        private String direccion;
        private String email;
        private Int32 serieComprob;
        private Int32 desdeFactura;
        private Int32 hastaFactura;
        private Int32 autorizacion;
        private DateTime fechaEmision;
        private DateTime fechaCaducidad;
        //private Set tblRetencioneses = new HashSet(0);
        //private Set tblComprases = new HashSet(0);
        //private Set tblProductProveedoreses = new HashSet(0);

        public TblProveedores()
        {
        }

        public TblProveedores(Int32 rucProveedor, String nombreProveed, String apellidoProveed, String telefono, String direccion, String email, Int32 serieComprob, Int32 desdeFactura, Int32 hastaFactura, Int32 autorizacion, DateTime fechaEmision, DateTime fechaCaducidad)//, Set tblRetencioneses, Set tblComprases, Set tblProductProveedoreses)
        {
            this.rucProveedor = rucProveedor;
            this.nombreProveed = nombreProveed;
            this.apellidoProveed = apellidoProveed;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.serieComprob = serieComprob;
            this.desdeFactura = desdeFactura;
            this.hastaFactura = hastaFactura;
            this.autorizacion = autorizacion;
            this.fechaEmision = fechaEmision;
            this.fechaCaducidad = fechaCaducidad;
            //this.tblRetencioneses = tblRetencioneses;
            //this.tblComprases = tblComprases;
            //this.tblProductProveedoreses = tblProductProveedoreses;
        }

        public Int32 getIdProveedor()
        {
            return this.idProveedor;
        }

        public void setIdProveedor(Int32 idProveedor)
        {
            this.idProveedor = idProveedor;
        }
        public Int32 getRucProveedor()
        {
            return this.rucProveedor;
        }

        public void setRucProveedor(Int32 rucProveedor)
        {
            this.rucProveedor = rucProveedor;
        }
        public String getNombreProveed()
        {
            return this.nombreProveed;
        }

        public void setNombreProveed(String nombreProveed)
        {
            this.nombreProveed = nombreProveed;
        }
        public String getApellidoProveed()
        {
            return this.apellidoProveed;
        }

        public void setApellidoProveed(String apellidoProveed)
        {
            this.apellidoProveed = apellidoProveed;
        }
        public String getTelefono()
        {
            return this.telefono;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }
        public String getDireccion()
        {
            return this.direccion;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }
        public String getEmail()
        {
            return this.email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }
        public Int32 getSerieComprob()
        {
            return this.serieComprob;
        }

        public void setSerieComprob(Int32 serieComprob)
        {
            this.serieComprob = serieComprob;
        }
        public Int32 getDesdeFactura()
        {
            return this.desdeFactura;
        }

        public void setDesdeFactura(Int32 desdeFactura)
        {
            this.desdeFactura = desdeFactura;
        }
        public Int32 getHastaFactura()
        {
            return this.hastaFactura;
        }

        public void setHastaFactura(Int32 hastaFactura)
        {
            this.hastaFactura = hastaFactura;
        }
        public Int32 getAutorizacion()
        {
            return this.autorizacion;
        }

        public void setAutorizacion(Int32 autorizacion)
        {
            this.autorizacion = autorizacion;
        }
        public DateTime getFechaEmision()
        {
            return this.fechaEmision;
        }

        public void setFechaEmision(DateTime fechaEmision)
        {
            this.fechaEmision = fechaEmision;
        }
        public DateTime getFechaCaducidad()
        {
            return this.fechaCaducidad;
        }

        public void setFechaCaducidad(DateTime fechaCaducidad)
        {
            this.fechaCaducidad = fechaCaducidad;
        }
        //public Set getTblRetencioneses()
        //{
        //    return this.tblRetencioneses;
        //}

        //public void setTblRetencioneses(Set tblRetencioneses)
        //{
        //    this.tblRetencioneses = tblRetencioneses;
        //}
        //public Set getTblComprases()
        //{
        //    return this.tblComprases;
        //}

        //public void setTblComprases(Set tblComprases)
        //{
        //    this.tblComprases = tblComprases;
        //}
        //public Set getTblProductProveedoreses()
        //{
        //    return this.tblProductProveedoreses;
        //}

        //public void setTblProductProveedoreses(Set tblProductProveedoreses)
        //{
        //    this.tblProductProveedoreses = tblProductProveedoreses;
        //}
    }
}
