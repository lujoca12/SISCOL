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
    class pais
    {
        CDato.csConexions conex;
        SqlDataReader reader = null;
        Validaciones_y_Mas.LLenarCombo llenar;


        public List<Validaciones_y_Mas.LLenarCombo> getCboPais()
        {
            List<Validaciones_y_Mas.LLenarCombo> lista = new List<Validaciones_y_Mas.LLenarCombo>();
            conex = new csConexions();

            reader = conex.Consultas("SELECT * FROM tbl_pais");

            while (reader.Read())
            {
                llenar = new Validaciones_y_Mas.LLenarCombo();
                llenar.id = reader.GetInt32(0);
                llenar.Nombre = reader.GetValue(1).ToString();
                lista.Add(llenar);
            }

            return lista;
        }

        
    }
}
