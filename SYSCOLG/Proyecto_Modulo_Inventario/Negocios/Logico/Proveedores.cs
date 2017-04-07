using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDato;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proyecto_Modulo_Inventario.Negocios.Logico
{
    class tProveedores
    {
        CDato.csConexions conex;
        SqlDataReader reader = null;
        Validaciones_y_Mas.LLenarCombo llenar;
        Constructores.TblProveedores tProveed;

        public String guardarProveedor(Constructores.TblProveedores proveed)
        {
            try
            {
                conex = new csConexions();

                // Object[] objdatos = { emp.getIdEmpresa(), emp.getNombreEmpresa(), emp.getRucEmpresa(), emp.getDireccion(), emp.getTelefono(), emp.getIdCiudad(), emp.getLogoEmpresa() };
                //Object[] tipodato = { "idempresa", "empresa", "ruc", "direccion", "telefono", "idCiudad", "logo" };


                // pbtImagen.Image.Save("@"+rutafoto, System.Drawing.Imaging.ImageFormat.Jpeg);//dice que la ruta esta muy larga

                //conex.Ejecutar_ProcedimientoAlmacenadoFullParametros("insertarEmpresa", objdatos, tipodato);

            }
            catch (Exception err)
            {

            }

            return conex.Estado;
        }
        public List<Negocios.Constructores.TblProveedores> cargarProveedores()
        {
            List<Constructores.TblProveedores> lstProveedores = new List<Constructores.TblProveedores>();

            try
            {
                lstProveedores.Clear();
                conex = new csConexions();
                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenado("obtenerProveedores");

                while (reader.Read())
                {
                    tProveed = new Constructores.TblProveedores();

                    lstProveedores.Add(tProveed);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstProveedores;
        }
        //Metodo para hacer dos tipos de busquedas, ya sea x el codigo o por ruc
        public List<Negocios.Constructores.TblProveedores> buscarProveedores(String cedula_ruc, String codigo, int idEmpresa)
        {
            List<Constructores.TblProveedores> lstProveedores = new List<Constructores.TblProveedores>();
            tProveed = new Constructores.TblProveedores();
            string proced = "";

            try
            {
                Object[] objdatos = null;
                Object[] tipodato = null;
                lstProveedores.Clear();
                conex = new csConexions();
                if (cedula_ruc != "")
                {
                    proced = "obtenerProvCodigoCedula";
                    objdatos = new Object[] { "", cedula_ruc, idEmpresa };
                    tipodato = new Object[] { "codigoCliente", "cedula_ruc", "idEmpresa" };
                }
                else if (codigo != "")
                {
                    proced = "obtenerProvCodigoCedula";
                    objdatos = new Object[] { codigo, "", idEmpresa };
                    tipodato = new Object[] { "codigoCliente", "cedula_ruc", "idEmpresa" };
                }

                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenadoFullParametros1(proced, objdatos, tipodato);

                while (reader.Read())
                {
                    tProveed = new Constructores.TblProveedores();
                    tProveed.setApellidoProveed(reader.GetValue(3) == null ? "" : reader.GetValue(3).ToString());
                    tProveed.setNombreProveed(reader.GetValue(2) == null ? "" : reader.GetValue(2).ToString());
                    tProveed.setRucProveedor(reader.GetValue(1) == null ? "" : reader.GetValue(1).ToString());
                    tProveed.setTelefono(reader.GetValue(4) == null ? "" : reader.GetValue(4).ToString());
                    tProveed.setDireccion(reader.GetValue(5) == null ? "" : reader.GetValue(5).ToString());
                    tProveed.setIdProveedor(reader.GetInt32(0));
                    lstProveedores.Add(tProveed);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstProveedores;
        }

        public List<Negocios.Constructores.TblProveedores> buscarproveedoresAvanzados(String cedula_ruc, String descripcion, int idEmpresa, String tipoBusqueda)
        {
            List<Constructores.TblProveedores> lstProveedores = new List<Constructores.TblProveedores>();
            tProveed = new Constructores.TblProveedores();
            string proced = "";

            try
            {
                Object[] objdatos = null;
                Object[] tipodato = null;
                lstProveedores.Clear();
                conex = new csConexions();
                if (cedula_ruc != "")
                {
                    proced = "obtenerProveedBusqAvanzada";
                    objdatos = new Object[] { "", cedula_ruc, idEmpresa, tipoBusqueda };
                    tipodato = new Object[] { "descripcion", "cedula_ruc", "idEmpresa", "tipoBusqueda" };
                }
                else if (descripcion != "")
                {
                    proced = "obtenerProveedBusqAvanzada";
                    objdatos = new Object[] { descripcion, "", idEmpresa, tipoBusqueda };
                    tipodato = new Object[] { "descripcion", "cedula_ruc", "idEmpresa", "tipoBusqueda" };
                }

                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenadoFullParametros1(proced, objdatos, tipodato);

                while (reader.Read())
                {
                    tProveed = new Constructores.TblProveedores();
                    tProveed.setApellidoProveed(reader.GetValue(3) == null ? "" : reader.GetValue(3).ToString());
                    tProveed.setNombreProveed(reader.GetValue(2) == null ? "" : reader.GetValue(2).ToString());
                    tProveed.setRucProveedor(reader.GetValue(1) == null ? "" : reader.GetValue(1).ToString());
                    tProveed.setTelefono(reader.GetValue(4) == null ? "" : reader.GetValue(4).ToString());
                    tProveed.setDireccion(reader.GetValue(5) == null ? "" : reader.GetValue(5).ToString());
                    tProveed.setIdProveedor(reader.GetInt32(0));
                    lstProveedores.Add(tProveed);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstProveedores;
        }
        public List<Negocios.Constructores.TblProveedores> cargarGrid()
        {
            List<Constructores.TblProveedores> lstProveedores = new List<Constructores.TblProveedores>();

            try
            {
                lstProveedores.Clear();
                conex = new csConexions();
                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenado("obtenerProveedores");

                while (reader.Read())
                {
                    tProveed = new Constructores.TblProveedores();
                    tProveed.setApellidoProveed(reader.GetValue(3) == null ? "" : reader.GetValue(3).ToString());
                    tProveed.setNombreProveed(reader.GetValue(2) == null ? "" : reader.GetValue(2).ToString());
                    tProveed.setRucProveedor(reader.GetValue(1) == null ? "" : reader.GetValue(1).ToString());
                    tProveed.setTelefono(reader.GetValue(4) == null ? "" : reader.GetValue(4).ToString());
                    tProveed.setDireccion(reader.GetValue(5) == null ? "" : reader.GetValue(5).ToString());
                    tProveed.setIdProveedor(reader.GetInt32(0));
                    lstProveedores.Add(tProveed);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstProveedores;
        }
    }
}
