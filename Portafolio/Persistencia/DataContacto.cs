using System;
using System.Data.SqlClient;

namespace Portafolio.Persistencia
{
    public class DataContacto
    {
        public readonly string _cadConexion;

        public DataContacto(string CadConexion)
        {
            _cadConexion = CadConexion;
        }

        public void InsertContacto(DataContacto contacto)
        {
            SqlCommand sqlCommand = null;
            var sql = "";
            try
            {
                using (var conexion = new SqlConnection(_cadConexion))
                {

                    sqlCommand = new SqlCommand(sql, conexion);
                    sqlCommand.Parameters.AddWithValue("", "");

                }

            }
            catch (Exception exepcion)
            {

                throw exepcion;
            }


        }
    }
}
