using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblClientes
    {
        private int id_Cliente;
        private String cedulaCliente;
        private String nombresCliente;
        private String apellidosCliente;
        private String direccion;
        private String telefono;
        private String email;
        private float cupo;
        private char estado;
        private float saldo;
        private double interes_Mora;
        private char forma_pago;
        private String telf1;
        private String telf2;
        private String telf_trabajo;
        private String trabajo;
        // private Set tblFacturas = new HashSet(0);

        public TblClientes()
        {
        }


        public TblClientes(String cedulaCliente)
        {
            this.cedulaCliente = cedulaCliente;
        }

        public TblClientes(int id_Cliente,String cedulaCliente, String nombresCliente, String apellidosCliente, String direccion, String telefono, 
            String email, float cupo, char estado, float saldo, double interes_Mora, char forma_pago, String telf1, String telf2, String telf_trabajo, String trabajo)
        {
            this.id_Cliente = id_Cliente;
            this.cedulaCliente = cedulaCliente;
            this.nombresCliente = nombresCliente;
            this.apellidosCliente = apellidosCliente;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.cupo = cupo;
            this.estado = estado;
            this.saldo = saldo;
            this.interes_Mora = interes_Mora;
            this.forma_pago = forma_pago;
            this.telf1 = telf1;
            this.telf2 = telf2;
            this.telf_trabajo = telf_trabajo;
            this.trabajo = trabajo;
        }

        public int getIdCliente()
        {
            return this.id_Cliente;
        }
        public void setIdCliente(int id_Cliente)
        {
            this.id_Cliente = id_Cliente;
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

        public float getCupo()
        {
            return this.cupo;
        }
        public void setCupo(float cupo)
        {
            this.cupo = cupo;
        }

        public char getEstado()
        {
            return estado;
        }

        public void setEstado(char estado)
        {
            this.estado = estado;
        }

        public float getSaldo()
        {
            return saldo;
        }

        public void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }

        public double getInteres_Mora()
        {
            return interes_Mora;
        }

        public void setInteres_Mora(double interes_Mora)
        {
            this.interes_Mora = interes_Mora;
        }

        public char getForma_pago()
        {
            return forma_pago;
        }

        public void setForma_pago(char forma_pago)
        {
            this.forma_pago = forma_pago;
        }

        public String getTelf1()
        {
            return telf1;
        }

        public void setTelf1(String telf1)
        {
            this.telf1 = telf1;
        }

        public String getTelf2()
        {
            return telf2;
        }

        public void setTelf2(String telf2)
        {
            this.telf2 = telf2;
        }

        public String getTelf_trabajo()
        {
            return telf_trabajo;
        }

        public void setTelf_trabajo(String telf_trabajo)
        {
            this.telf_trabajo = telf_trabajo;
        }

        public String getTrabajo()
        {
            return trabajo;
        }

        public void setTrabajo(String trabajo)
        {
            this.trabajo = trabajo;
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
