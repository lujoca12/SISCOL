using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblVendedores
    {
        private String cedula;
        private String nombresVendedor;
        private String apellidosVended;
        private String direccion;
        private String telefono;
        private String email;
        //private Set tblFacturas = new HashSet(0);

        public TblVendedores()
        {
        }


        public TblVendedores(String cedula)
        {
            this.cedula = cedula;
        }
        public TblVendedores(String cedula, String nombresVendedor, String apellidosVended, String direccion, String telefono, String email)//, Set tblFacturas)
        {
            this.cedula = cedula;
            this.nombresVendedor = nombresVendedor;
            this.apellidosVended = apellidosVended;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            //this.tblFacturas = tblFacturas;
        }

        public String getCedula()
        {
            return this.cedula;
        }

        public void setCedula(String cedula)
        {
            this.cedula = cedula;
        }
        public String getNombresVendedor()
        {
            return this.nombresVendedor;
        }

        public void setNombresVendedor(String nombresVendedor)
        {
            this.nombresVendedor = nombresVendedor;
        }
        public String getApellidosVended()
        {
            return this.apellidosVended;
        }

        public void setApellidosVended(String apellidosVended)
        {
            this.apellidosVended = apellidosVended;
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
