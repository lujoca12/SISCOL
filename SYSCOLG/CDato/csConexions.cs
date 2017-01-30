using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using Microsoft.VisualBasic.FileIO;



namespace CDato
{
    public class csConexions
    {
        //DECLARO MIS ATRIBUTOS DE LA CLASE CONEXION
        private SqlConnection sqlConexion;
        private SqlCommand sqlComando;
        private SqlDataReader sqlDr;
        private string estado;
        private string bd = "bdevenezer";
        private string Datasource = "localhost";
        private string Usuario = "sa";
        private string Password = "milmanu15";


        private List<string> listaRetorno;

        public csConexions()
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

        public csConexions(String baseDatos)
        {
            try
            {
                sqlConexion = new SqlConnection("Data Source=" + Datasource + ";Initial Catalog=" + baseDatos + ";Persist Security Info=True;User ID=" + Usuario + ";Password=" + Password + "");
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

        //Procedimiento sin parametros
        public SqlDataReader Ejecutar_ProcedimientoAlmacenado(String nombre)
        {
            SqlTransaction transaction = null;
            SqlDataReader reader = null;
            try
            {
                if (sqlConexion.State.ToString() == "Open")
                    sqlConexion.Close();
                sqlConexion.Open();

                //Inicio de la transaccion
                transaction = sqlConexion.BeginTransaction("SampleTransaction");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConexion;
                cmd.Transaction = transaction;

                cmd.CommandText = nombre;//Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                //                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                transaction.Commit();
                estado = "ok";
                CerrarConexion();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    estado = estado + " Exception rollback " + ex2.GetType() + "mensaje: " + ex2.Message;

                }
                sqlConexion.Close();
                estado = "excepcion en commit tipo " + ex.GetType() + ":Error " + ex.Message + "\n";
            }
            return reader;
        }
        //Ejecutar Procedimiento full parametros sin devolver nada solo el estado
        public string Ejecutar_ProcedimientoAlmacenadoFullParametros(String nombre, String[] parametros, String[] tipoParametros)
        {
            SqlTransaction transaction = null;
            try
            {
                if (sqlConexion.State.ToString() == "Open")
                    sqlConexion.Close();
                AbrirConexion();
                SqlCommand cmd = new SqlCommand();

                //Inicio de la transaccion
                transaction = sqlConexion.BeginTransaction("SampleTransaction");

                cmd.Connection = sqlConexion;

                cmd.Transaction = transaction;

                cmd.CommandText = nombre;//Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();

                List<SqlParameter> list = new List<SqlParameter>();

                for (int i = 0; i < parametros.Length; i++)
                {
                    list.Add(new SqlParameter("@" + tipoParametros[i].ToString(), parametros[i].ToString()));
                }
                cmd.Parameters.AddRange(list.ToArray<SqlParameter>());

                cmd.ExecuteNonQuery();

                transaction.Commit();
                estado = "ok";

                CerrarConexion();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    estado = estado + " Exception rollback " + ex2.GetType() + "mensaje: " + ex2.Message;

                }
                sqlConexion.Close();
                estado = "excepcion en commit tipo " + ex.GetType() + ":Error " + ex.Message + "\n";
            }
            return estado;
        }


        //Ejecutar Procedimiento full parametros devuelve SqlDataReader
        public SqlDataReader Ejecutar_ProcedimientoAlmacenadoFullParametros1(String nombre, String[] parametros, String[] tipoParametros)
        {
            SqlTransaction transaction = null;
            SqlDataReader reader = null;
            try
            {
                if (sqlConexion.State.ToString() == "Open")
                    sqlConexion.Close();
                AbrirConexion();

                //Inicio de la transaccion
                transaction = sqlConexion.BeginTransaction("SampleTransaction");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConexion;
                cmd.Transaction = transaction;
                cmd.CommandText = nombre;//Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Clear();

                List<SqlParameter> list = new List<SqlParameter>();

                for (int i = 0; i < parametros.Length; i++)
                {
                    list.Add(new SqlParameter("@" + tipoParametros[i].ToString(), parametros[i].ToString()));
                }
                cmd.Parameters.AddRange(list.ToArray<SqlParameter>());

                reader = cmd.ExecuteReader();
                transaction.Commit();
                estado = "ok";

                CerrarConexion();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    estado = estado + " Exception rollback " + ex2.GetType() + "mensaje: " + ex2.Message;

                }
                sqlConexion.Close();
                estado = "excepcion en commit tipo " + ex.GetType() + ":Error " + ex.Message + "\n";
            }
            return reader;
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
                //   MessageBox.Show(err.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                //MessageBox.Show(err.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        

        public DataTable obtenerDataTableCsv(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { ";" });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
                estado = "ok";
            }
            catch (Exception ex)
            {
                estado = ex.Message.ToString();
            }
            return csvData;
        }
        public void InsertDataIntoSQLServerUsingSQLBulkCopy(DataTable csvFileData, string tabla)
        {
            if (sqlConexion.State.ToString() == "Open")
                sqlConexion.Close();
            sqlConexion.Open();

            using (SqlBulkCopy s = new SqlBulkCopy(sqlConexion))
                {
                    s.DestinationTableName = tabla;
                    foreach (var column in csvFileData.Columns)
                        s.ColumnMappings.Add(column.ToString(), column.ToString());
                    s.WriteToServer(csvFileData);
                }
                estado = "ok";
        }
    }
}

