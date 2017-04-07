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
        

    }
}
