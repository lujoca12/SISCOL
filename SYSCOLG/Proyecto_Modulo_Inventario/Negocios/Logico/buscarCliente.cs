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
    class buscarCliente
    {
        CDato.csConexions conex;
        SqlDataReader reader = null;
        Validaciones_y_Mas.LLenarCombo llenar;
        Constructores.TblClientes tClientes;

        public String guardarClientes(Constructores.TblEmpresa emp)
        {
            try
            {
                conex = new csConexions();

                Object[] objdatos = { emp.getIdEmpresa(), emp.getNombreEmpresa(), emp.getRucEmpresa(), emp.getDireccion(), emp.getTelefono(), emp.getIdCiudad(), emp.getLogoEmpresa() };
                Object[] tipodato = { "idempresa", "empresa", "ruc", "direccion", "telefono", "idCiudad", "logo" };


                // pbtImagen.Image.Save("@"+rutafoto, System.Drawing.Imaging.ImageFormat.Jpeg);//dice que la ruta esta muy larga

                conex.Ejecutar_ProcedimientoAlmacenadoFullParametros("insertarEmpresa", objdatos, tipodato);

            }
            catch (Exception err)
            {

            }

            return conex.Estado;
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
                    tClientes.setApellidosCliente(reader.GetValue(1) == null ? "": reader.GetValue(1).ToString());
                    tClientes.setDireccion(reader.GetValue(2) == null ? null : reader.GetValue(2).ToString());
                    tClientes.setTelefono(reader.GetValue(3) == null ? null : reader.GetValue(3).ToString());

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
