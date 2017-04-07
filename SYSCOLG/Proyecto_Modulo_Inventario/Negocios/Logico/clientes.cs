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
    class clientes
    {
        CDato.csConexions conex;
        SqlDataReader reader = null;
        Validaciones_y_Mas.LLenarCombo llenar;
        Constructores.TblClientes tClientes;

        public String guardarClientes(Constructores.TblClientes client)
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
        public List<Negocios.Constructores.TblClientes> cargarClientes()
        {
            List<Constructores.TblClientes> lstClientes = new List<Constructores.TblClientes>();

            try
            {
                lstClientes.Clear();
                conex = new csConexions();
                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenado("obtenerClientes");

                while (reader.Read())
                {
                    tClientes = new Constructores.TblClientes();

                    lstClientes.Add(tClientes);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstClientes;
        }
        //Metodo para hacer dos tipos de busquedas, ya sea x el codigo o por ruc
        public List<Negocios.Constructores.TblClientes> buscarClientes(String cedula_ruc, String codigo, int idEmpresa)
        {
            List<Constructores.TblClientes> lstClientes = new List<Constructores.TblClientes>();
            tClientes = new Constructores.TblClientes();
            string proced = "";

            try
            {
                Object[] objdatos = null;
                Object[] tipodato = null;
                lstClientes.Clear();
                conex = new csConexions();
                if (cedula_ruc != "")
                {
                    proced = "obtenerClientesCodigoCedula";
                    objdatos = new Object[] { "", cedula_ruc, idEmpresa };
                    tipodato = new Object[] { "codigoCliente", "cedula_ruc", "idEmpresa" };
                }
                else if (codigo != "")
                {
                    proced = "obtenerClientesCodigoCedula";
                    objdatos = new Object[] { codigo, "", idEmpresa };
                    tipodato = new Object[] { "codigoCliente", "cedula_ruc", "idEmpresa" };
                }

                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenadoFullParametros1(proced, objdatos, tipodato);
                
                while (reader.Read())
                {
                    tClientes = new Constructores.TblClientes();
                    tClientes.setApellidosCliente(reader.GetValue(1) == null?"":reader.GetValue(1).ToString());
                    tClientes.setNombresCliente(reader.GetValue(0) == null ? "" : reader.GetValue(0).ToString());
                    tClientes.setCedulaCliente(reader.GetValue(5) == null ? "" : reader.GetValue(5).ToString());
                    tClientes.setTelefono(reader.GetValue(3) == null ? "" : reader.GetValue(3).ToString());
                    tClientes.setDireccion(reader.GetValue(2) == null ? "" : reader.GetValue(2).ToString());
                    tClientes.setCodigoCliente(reader.GetValue(17) == null ? "" : reader.GetValue(17).ToString());
                    tClientes.setCupo(Convert.ToDouble(reader.GetValue(7)));
                    tClientes.setSaldo(Convert.ToDouble(reader.GetValue(9)));
                    lstClientes.Add(tClientes);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstClientes;
        }

        public List<Negocios.Constructores.TblClientes> buscarClientesAvanzados(String cedula_ruc, String descripcion, int idEmpresa, String tipoBusqueda)
        {
            List<Constructores.TblClientes> lstClientes = new List<Constructores.TblClientes>();
            tClientes = new Constructores.TblClientes();
            string proced = "";

            try
            {
                Object[] objdatos = null;
                Object[] tipodato = null;
                lstClientes.Clear();
                conex = new csConexions();
                if (cedula_ruc != "")
                {
                    proced = "obtenerClientesBusqAvanzada";
                    objdatos = new Object[] { "", cedula_ruc, idEmpresa , tipoBusqueda};
                    tipodato = new Object[] { "descripcion", "cedula_ruc", "idEmpresa", "tipoBusqueda" };
                }
                else if (descripcion != "")
                {
                    proced = "obtenerClientesBusqAvanzada";
                    objdatos = new Object[] { descripcion, "", idEmpresa , tipoBusqueda};
                    tipodato = new Object[] { "descripcion", "cedula_ruc", "idEmpresa", "tipoBusqueda" };
                }

                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenadoFullParametros1(proced, objdatos, tipodato);

                while (reader.Read())
                {
                    tClientes = new Constructores.TblClientes();
                    tClientes.setApellidosCliente(reader.GetValue(1) == null ? "" : reader.GetValue(1).ToString());
                    tClientes.setNombresCliente(reader.GetValue(0) == null ? "" : reader.GetValue(0).ToString());
                    tClientes.setCedulaCliente(reader.GetValue(5) == null ? "" : reader.GetValue(5).ToString());
                    tClientes.setTelefono(reader.GetValue(3) == null ? "" : reader.GetValue(3).ToString());
                    tClientes.setDireccion(reader.GetValue(2) == null ? "" : reader.GetValue(2).ToString());
                    tClientes.setCodigoCliente(reader.GetValue(17) == null ? "" : reader.GetValue(17).ToString());
                    tClientes.setCupo(Convert.ToDouble(reader.GetValue(7)));
                    tClientes.setSaldo(Convert.ToDouble(reader.GetValue(9)));
                    lstClientes.Add(tClientes);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstClientes;
        }
        public List<Negocios.Constructores.TblClientes> cargarGrid()
        {
            List<Constructores.TblClientes> lstClientes = new List<Constructores.TblClientes>();

            try
            {
                lstClientes.Clear();
                conex = new csConexions();
                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenado("obtenerClientes");

                while (reader.Read())
                {
                    tClientes = new Constructores.TblClientes();
                    //dgvEmpresa[0, i].Value = (i + 1);
                    tClientes.setIdCliente(reader.GetInt32(16));
                    tClientes.setCedulaCliente(reader.GetValue(5) == null ? "" : reader.GetValue(5).ToString());
                    tClientes.setNombresCliente(reader.GetValue(0) == null ? null : reader.GetValue(0).ToString());
                    tClientes.setApellidosCliente(reader.GetValue(1) == null ? "" : reader.GetValue(1).ToString());
                    tClientes.setDireccion(reader.GetValue(2) == null ? null : reader.GetValue(2).ToString());
                    tClientes.setTelefono(reader.GetValue(3) == null ? null : reader.GetValue(3).ToString());
                    tClientes.setCupo(Convert.ToDouble(reader.GetValue(7)));
                    tClientes.setSaldo(Convert.ToDouble(reader.GetValue(9)));
                    lstClientes.Add(tClientes);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstClientes;
        }
    }
}
