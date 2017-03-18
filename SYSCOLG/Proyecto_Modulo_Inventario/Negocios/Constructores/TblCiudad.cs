using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Modulo_Inventario.Negocios.Constructores
{
    public class TblCiudad:TblPais
    {
        private Int32 idCiudad;
        private String nombreCiudad;


        public TblCiudad()
        {
        }

        //public TblCiudad(TblPais tblPais)
        //{
        //    this.tblPais = tblPais;
        //}
        //public TblCiudad(TblPais tblPais, String nombreCiudad)
        //{
        //    this.tblPais = tblPais;
        //    this.nombreCiudad = nombreCiudad;
        //}

        public Int32 getIdCiudad()
        {
            return this.idCiudad;
        }

        public void setIdCiudad(Int32 idCiudad)
        {
            this.idCiudad = idCiudad;
        }
        //public TblPais getTblPais()
        //{
        //    return this.tblPais;
        //}

        //public void setTblPais(TblPais tblPais)
        //{
        //    this.tblPais = tblPais;
        //}
        public String getNombreCiudad()
        {
            return this.nombreCiudad;
        }

        public void setNombreCiudad(String nombreCiudad)
        {
            this.nombreCiudad = nombreCiudad;
        }
    }
}
