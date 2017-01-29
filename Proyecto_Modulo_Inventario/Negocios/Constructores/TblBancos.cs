using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblBancos
    {
        private Int32 idBanco;
        private String numeroCuenta;
        private String propietarioCuenta;
        //private Set tblBancoChequeses = new HashSet(0);

        public TblBancos()
        {
        }

        public TblBancos(String numeroCuenta, String propietarioCuenta)//, Set tblBancoChequeses)
        {
            this.numeroCuenta = numeroCuenta;
            this.propietarioCuenta = propietarioCuenta;
            //this.tblBancoChequeses = tblBancoChequeses;
        }

        public Int32 getIdBanco()
        {
            return this.idBanco;
        }

        public void setIdBanco(Int32 idBanco)
        {
            this.idBanco = idBanco;
        }
        public String getNumeroCuenta()
        {
            return this.numeroCuenta;
        }

        public void setNumeroCuenta(String numeroCuenta)
        {
            this.numeroCuenta = numeroCuenta;
        }
        public String getPropietarioCuenta()
        {
            return this.propietarioCuenta;
        }

        public void setPropietarioCuenta(String propietarioCuenta)
        {
            this.propietarioCuenta = propietarioCuenta;
        }
        //public Set getTblBancoChequeses()
        //{
        //    return this.tblBancoChequeses;
        //}

        //public void setTblBancoChequeses(Set tblBancoChequeses)
        //{
        //    this.tblBancoChequeses = tblBancoChequeses;
        //}

    }
}
