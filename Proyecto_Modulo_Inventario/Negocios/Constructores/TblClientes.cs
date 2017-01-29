using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblClientes
    {
        private String cedulaCliente;
        private String nombresCliente;
        private String apellidosCliente;
        private String direccion;
        private String telefono;
        private String email;
       // private Set tblFacturas = new HashSet(0);

        public TblClientes()
        {
        }


        public TblClientes(String cedulaCliente)
        {
            this.cedulaCliente = cedulaCliente;
        }
        public TblClientes(String cedulaCliente, String nombresCliente, String apellidosCliente, String direccion, String telefono, String email)//, Set tblFacturas)
        {
            this.cedulaCliente = cedulaCliente;
            this.nombresCliente = nombresCliente;
            this.apellidosCliente = apellidosCliente;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            //this.tblFacturas = tblFacturas;
        }

        public String getCedulaCliente()
        {
            return this.cedulaCliente;
        }

        public void setCedulaCliente(String cedulaCliente)
        {
            this.cedulaCliente = cedulaCliente;
        }
        public String getNombresCliente()
        {
            return this.nombresCliente;
        }

        public void setNombresCliente(String nombresCliente)
        {
            this.nombresCliente = nombresCliente;
        }
        public String getApellidosCliente()
        {
            return this.apellidosCliente;
        }

        public void setApellidosCliente(String apellidosCliente)
        {
            this.apellidosCliente = apellidosCliente;
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
        public String getEmail()
        {
            return this.email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }
        //public Set getTblFacturas()
        //{
        //    return this.tblFacturas;
        //}

        //public void setTblFacturas(Set tblFacturas)
        //{
        //    this.tblFacturas = tblFacturas;
        //}
    }
}
