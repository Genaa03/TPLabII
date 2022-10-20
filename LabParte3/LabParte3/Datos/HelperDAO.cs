using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LabParte3.Dominio;

namespace LabParte3.Datos
{
    internal class HelperDAO
    {
        private static HelperDAO instancia;
        private SqlConnection conexion;
        private SqlCommand comando = new SqlCommand();


        private HelperDAO()
        {
            conexion = new SqlConnection(Properties.Resources.ConexionDB); //SE CAMBIO BD
        }

        public static HelperDAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }

        private void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable consulta(string nombreSP,List<Parametro> lista)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.Parameters.Clear();

            comando.CommandText = nombreSP;
            foreach(Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Clave, p.Valor);
            }
            tabla.Load(comando.ExecuteReader());

            comando.Parameters.Clear();

            desconectar();
            return tabla;
        }

        public DataTable consultaSinParametros(string nombreSP)
        {
            DataTable tabla = new DataTable();
            conectar();

            comando.CommandText = nombreSP;

            tabla.Load(comando.ExecuteReader());

            desconectar();
            return tabla;
        }

    }
}
