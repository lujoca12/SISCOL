using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Class1
    {
        //DECLARO MIS ATRIBUTOS DE LA CLASE CONEXION
        private SqlConnection sqlConexion;
        private SqlCommand sqlComando;
        private SqlDataReader sqlDr;
        private string estado;
        private string bd = "ADERP";
        private string Datasource = "localhost";
        private string Usuario = "sa";
        private string Password = "Lujoc@12@";


        private List<string> listaRetorno;

        public csConexion()
        {
            try
            {
                sqlConexion = new SqlConnection("Data Source=" + Datasource + ";Initial Catalog=" + bd + ";Persist Security Info=True;User ID=" + Usuario + ";Password=" + Password + "");
                estado = "ok";
                sqlDr = null;
                listaRetorno = new List<string>();
            }
            catch (SqlException ex)
            {
                estado = ex.Message;

            }

        }
        //Instancias Instaladas
        public List<string> obtenerServidores()
        {
            SqlDataSourceEnumerator instancias = SqlDataSourceEnumerator.Instance;
            DataTable unaTabla = instancias.GetDataSources();
            for (int i = 0; i < unaTabla.Rows.Count; i++)
            {
                listaRetorno.Add((unaTabla.Rows[0][i]).ToString());
            }
            return listaRetorno;

        }
        //PARA INSERTA UN REGISTRO EN LA BASE DE DATOS COMO PARAMETRO MI VARIABLE SQLSENTENCIA
        public string getUsuario()
        {
            return Usuario;
        }


        public string getPassword()
        {
            return Password;
        }
        public string getDatasource()
        {
            return Datasource;
        }


        public string getBD()
        {
            return bd;
        }
        public int Insertar(string sqlSentencia)
        {
            try
            {
                if (sqlConexion.State.ToString() == "Open")
                    sqlConexion.Close();
                int filasAfectadas = 0;
                sqlConexion.Open();
                sqlComando = new SqlCommand(sqlSentencia, sqlConexion);
                filasAfectadas = sqlComando.ExecuteNonQuery();
                sqlConexion.Close();
                estado = "ok";
                return filasAfectadas;
            }
            catch (Exception ex)
            {
                sqlConexion.Close();
                estado = ex.Message.ToString();
                return 0;
            }

        }

        public string Ejecutar_ProcedimientoAlmacenado(SqlCommand cmd, string sentencia)
        {
            try
            {
                if (sqlConexion.State.ToString() == "Open")
                    sqlConexion.Close();
                sqlConexion.Open();
                cmd.Connection = sqlConexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                estado = "ok";

            }
            catch (SqlException ex)
            {
                sqlConexion.Close();
                estado = ex.Message.ToString();
                MessageBox.Show(estado);
            }
            return estado;
        }

        //PARA ACTUALIZAR UN REGISTRO EN LA BASE DE DATOS COMO PARAMETRO MI VARIABLE SQLSENTENCIA
        public SqlDataReader Actualizar(string sentencia)
        {
            try
            {
                sqlConexion.Open();
                sqlComando = new SqlCommand(sentencia, sqlConexion);
                sqlDr = sqlComando.ExecuteReader();
                estado = "ok";
                sqlConexion.Close();

            }
            catch (Exception ex)
            {
                estado = "error" + ex.Message;
            }
            return sqlDr;
        }
        //PARA OBTENER  UN NUMERO DE FILAS  EN LA BASE DE DATOS COMO PARAMETRO MI VARIABLE 
        //SQLSENTENCIA(SE LO UTILIZA EN AUTORIZAR PEDIDOS )
        public int ObtenerNumeroDeFilas(string sqlSentencia)
        {
            try
            {
                int numeroFilas = 0;
                sqlComando = new SqlCommand(sqlSentencia, sqlConexion);
                sqlConexion.Open();
                numeroFilas = int.Parse(sqlComando.ExecuteScalar().ToString());
                estado = "ok";
                sqlConexion.Close();
                return numeroFilas;

            }
            catch (Exception error)
            {
                estado = error.Message.ToString();
                sqlConexion.Close();
                return 0;
            }
        }
        //PARA OBTENER UN VAOR DE LA BASE DE DATOS COMO PARAMETRO MI VARIABLE SQLSENTENCIA
        public string obtenerUnValor(string sqlSentencia)
        {
            try
            {
                if (sqlConexion.State.ToString() == "Open")
                    sqlConexion.Close();
                string retorno = "";
                sqlComando = new SqlCommand(sqlSentencia, sqlConexion);
                sqlConexion.Open();
                retorno = (sqlComando.ExecuteScalar().ToString());
                estado = "ok";
                sqlConexion.Close();
                return retorno;

            }
            catch (Exception error)
            {
                estado = error.Message.ToString();
                sqlConexion.Close();
                return "";
            }

        }
        public string Estado
        {
            get { return estado; }

        }

        //PARA HACER CONSULTAS  EN LA BASE DE DATOS COMO PARAMETRO MI VARIABLE SQLSENTENCIA
        public SqlDataReader Consultas(string sqlConsulta)
        {
            try
            {
                if (sqlConexion.State.ToString() == "Open")
                    sqlConexion.Close();
                sqlComando = new SqlCommand(sqlConsulta, sqlConexion);
                sqlConexion.Open();
                SqlDataReader sqlDr = sqlComando.ExecuteReader();

                estado = "ok Consulta";
                return sqlDr;

            }
            catch (SqlException ex)
            {
                estado = ex.Message.ToString();
                return null;
            }
        }
        //PARA CONSULTAR EN LA BASE DE DATOS COMO PARAMETRO MI VARIABLE SQLSENTENCIA
        public SqlDataAdapter Consulta(string sqlSentencia)
        {

            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlSentencia, sqlConexion);
            SqlCommandBuilder cB = new SqlCommandBuilder(sqlDa);
            return sqlDa;

        }
        public void AbrirConexion()
        {
            try
            {
                sqlConexion.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void CerrarConexion()
        {
            try
            {
                sqlConexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        public bool ejecutarTransacciones(List<string> sentencias)
        {
            sqlConexion.Open();
            SqlTransaction transaction;
            SqlCommand transacciones = sqlConexion.CreateCommand();
            // Start a local transaction.
            transaction = sqlConexion.BeginTransaction("SampleTransaction");
            transacciones.Connection = sqlConexion;
            transacciones.Transaction = transaction;
            try
            {
                for (int i = 0; i < sentencias.Count; i++)
                {
                    transacciones.CommandText = sentencias[i];
                    transacciones.ExecuteNonQuery();
                }
                transaction.Commit();
                estado = "ok";
                sqlConexion.Close();
                return true;

            }
            catch (Exception ex)
            {
                estado = "excepcion en commit tipo " + ex.GetType() + ":Error " + ex.Message + "\n";

                // Attempt to roll back the transaction. 
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    estado = estado + " Exception rollback " + ex2.GetType() + "mensaje: " + ex2.Message;

                }
                sqlConexion.Close();
                return false;
            }

        }






        //PARA AUTENTICARSE O LOGUEARSE 
        public bool Autenticar(string usuario, string password)
        {
            //consulta a la base de datos
            string sql = @"SELECT COUNT(*)
                          FROM usuario
                          WHERE idUsuario = @user AND Clave = @pass";
            //cadena conexion


            sqlConexion.Open();//abrimos conexion

            SqlCommand cmd = new SqlCommand(sql, sqlConexion); //ejecutamos la instruccion
            cmd.Parameters.AddWithValue("@user", usuario); //enviamos los parametros
            cmd.Parameters.AddWithValue("@pass", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar()); //devuelve la fila afectada

            if (count == 0)
                return false;
            else
                return true;


        }
    }
}
