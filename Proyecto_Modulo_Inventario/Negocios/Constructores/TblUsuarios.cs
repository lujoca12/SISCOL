using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblUsuarios
    {
        private Int32 idUsuario;
        private TblRoles tblRoles;
        private String nombreUsuario;
        private String claveUsuario;
        private String nombres;
        private String apellidos;
        private String direccion;
        private String telefono;

        public TblUsuarios()
        {
        }


        public TblUsuarios(TblRoles tblRoles, String nombres, String apellidos, String direccion, String telefono)
        {
            this.tblRoles = tblRoles;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        public TblUsuarios(TblRoles tblRoles, String nombreUsuario, String claveUsuario, String nombres, String apellidos, String direccion, String telefono)
        {
            this.tblRoles = tblRoles;
            this.nombreUsuario = nombreUsuario;
            this.claveUsuario = claveUsuario;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Int32 getIdUsuario()
        {
            return this.idUsuario;
        }

        public void setIdUsuario(Int32 idUsuario)
        {
            this.idUsuario = idUsuario;
        }
        public TblRoles getTblRoles()
        {
            return this.tblRoles;
        }

        public void setTblRoles(TblRoles tblRoles)
        {
            this.tblRoles = tblRoles;
        }
        public String getNombreUsuario()
        {
            return this.nombreUsuario;
        }

        public void setNombreUsuario(String nombreUsuario)
        {
            this.nombreUsuario = nombreUsuario;
        }
        public String getClaveUsuario()
        {
            return this.claveUsuario;
        }

        public void setClaveUsuario(String claveUsuario)
        {
            this.claveUsuario = claveUsuario;
        }
        public String getNombres()
        {
            return this.nombres;
        }

        public void setNombres(String nombres)
        {
            this.nombres = nombres;
        }
        public String getApellidos()
        {
            return this.apellidos;
        }

        public void setApellidos(String apellidos)
        {
            this.apellidos = apellidos;
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
    }
}
