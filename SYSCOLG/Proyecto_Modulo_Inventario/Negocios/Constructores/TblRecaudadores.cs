using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblRecaudadores
    {
        private Int32 idRecaudador;
        private String cedulaRecaudador;
        private String nombreRecaudador;
        private String apellidoRecaudad;
        private TblCxc tblCxc;

        public TblRecaudadores()
        {
        }

        public TblRecaudadores(String cedulaRecaudador, String nombreRecaudador, String apellidoRecaudad, TblCxc tblCxc)
        {
            this.cedulaRecaudador = cedulaRecaudador;
            this.nombreRecaudador = nombreRecaudador;
            this.apellidoRecaudad = apellidoRecaudad;
            this.tblCxc = tblCxc;
        }

        public Int32 getIdRecaudador()
        {
            return this.idRecaudador;
        }

        public void setIdRecaudador(Int32 idRecaudador)
        {
            this.idRecaudador = idRecaudador;
        }
        public String getCedulaRecaudador()
        {
            return this.cedulaRecaudador;
        }

        public void setCedulaRecaudador(String cedulaRecaudador)
        {
            this.cedulaRecaudador = cedulaRecaudador;
        }
        public String getNombreRecaudador()
        {
            return this.nombreRecaudador;
        }

        public void setNombreRecaudador(String nombreRecaudador)
        {
            this.nombreRecaudador = nombreRecaudador;
        }
        public String getApellidoRecaudad()
        {
            return this.apellidoRecaudad;
        }

        public void setApellidoRecaudad(String apellidoRecaudad)
        {
            this.apellidoRecaudad = apellidoRecaudad;
        }
        public TblCxc getTblCxc()
        {
            return this.tblCxc;
        }

        public void setTblCxc(TblCxc tblCxc)
        {
            this.tblCxc = tblCxc;
        }
    }
}
