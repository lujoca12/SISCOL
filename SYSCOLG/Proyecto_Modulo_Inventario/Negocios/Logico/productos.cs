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
    class productos
    {
        CDato.csConexions conex;
        SqlDataReader reader = null;
        Validaciones_y_Mas.LLenarCombo llenar;
        Constructores.TblBodegaProductos tProductos;

        public String guardarProductos(Constructores.TblEmpresa emp)
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
        public List<Negocios.Constructores.TblBodegaProductos> cargarGrid()
        {
            List<Constructores.TblBodegaProductos> lstProductos = new List<Constructores.TblBodegaProductos>();

            try
            {
                lstProductos.Clear();
                conex = new csConexions();
                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenado("obtenerClientes");

                while (reader.Read())
                {
                    tProductos = new Constructores.TblBodegaProductos();
                    //dgvEmpresa[0, i].Value = (i + 1);
                    //tProductos.setIdCliente(reader.GetInt32(16));
                    //tProductos.setCedulaCliente(reader.GetValue(5) == null ? "" : reader.GetValue(5).ToString());
                    //tProductos.setNombresCliente(reader.GetValue(0) == null ? null : reader.GetString(0));
                    //tProductos.setApellidosCliente(reader.GetValue(1) == null ? "" : reader.GetValue(1).ToString());
                    //tProductos.setDireccion(reader.GetValue(2) == null ? null : reader.GetValue(2).ToString());
                    //tProductos.setTelefono(reader.GetValue(3) == null ? null : reader.GetValue(3).ToString());

                    lstProductos.Add(tProductos);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstProductos;
        }
        //Metodo para hacer dos tipos de busquedas, ya sea x el codigo o por la descripcion
        public List<Negocios.Constructores.TblBodegaProductos> buscarProductos(String codigoProducto, String descripcion, int idBodega, int idEmpresa)
        {
            List<Constructores.TblBodegaProductos> lstProductos = new List<Constructores.TblBodegaProductos>();
            tProductos = new Constructores.TblBodegaProductos();
            string proced = "";

            try
            {
                lstProductos.Clear();
                conex = new csConexions();
                if (codigoProducto != "")
                    proced = "obtenerProductosxCodigo";
                else if(descripcion != "")
                    proced = "obtenerProductosxDescripcion";

                Object[] objdatos = { codigoProducto, idBodega, idEmpresa };
                Object[] tipodato = { "codigo", "idBodega","idEmpresa" };

                SqlDataReader reader = conex.Ejecutar_ProcedimientoAlmacenadoFullParametros1(proced,objdatos,tipodato);

                while (reader.Read())
                {
                    tProductos = new Constructores.TblBodegaProductos();
                    tProductos.setTblProductos(new Constructores.TblProductos());
                    tProductos.getTblProductos().setTblUndxCajas(new Constructores.TblUndXCajas());
                    tProductos.getTblProductos().setCodigoProducto(reader.GetString(8));
                    tProductos.getTblProductos().setDescripcion(reader.GetString(0));
                    tProductos.getTblProductos().setDetalle(reader.GetValue(1) == null ? null : reader.GetValue(1).ToString());
                    tProductos.getTblProductos().setIva(Convert.ToInt32(reader.GetValue(2)) <= 0?false:true);
                    tProductos.getTblProductos().setNegarStock(Convert.ToInt32(reader.GetValue(5))<=0 ? false : true);
                    tProductos.getTblProductos().setActivo(Convert.ToInt32(reader.GetValue(6)) <= 0 ? false : true);
                    tProductos.getTblProductos().setEstado(Convert.ToChar(reader.GetString(7)));
                    tProductos.getTblProductos().setValor_Iva(reader.GetInt32(9));
                    tProductos.getTblProductos().getTblUndxCajas().setIdXCajas(reader.GetInt32(10));
                    tProductos.getTblProductos().getTblUndxCajas().setDetalleUnds(reader.GetString(11));
                    tProductos.getTblProductos().getTblUndxCajas().setCantidCaja(reader.GetInt32(12));
                    tProductos.getTblProductos().getTblUndxCajas().setCodigo(Convert.ToString(reader.GetValue(13)));
                    tProductos.setPvp(Convert.ToDouble(reader.GetValue(28)));
                    lstProductos.Add(tProductos);
                }
                conex.CerrarConexion();
                reader.Close();
            }
            catch (Exception err)
            {

            }

            return lstProductos;
        }
    }
}
