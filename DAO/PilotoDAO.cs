using System.Data.SqlClient;
using ApiRest.Models;

namespace ApiRest.DAO
{
    public class PilotoDAO
    {
        //
        string connectionString = "server=DESKTOP-NAQSPQP; database=ejemplo ; integrated security = true";


        public Piloto ObtenerPorId(int id)
        {
            Piloto piloto = null;

            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                var command = conexion.CreateCommand();

                //La query que se lanzará en el comando
                command.CommandText = "SELECT TOP 1 * FROM PILOTOF1 WHERE id=@id";

                //Los parámetros que se utilizan para el comando, siempre con el prefijo @ en la query (@id)
                command.Parameters.AddWithValue("id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        piloto = new Piloto
                        {
                            Id = (int)reader["id"],
                            Nombre = (string)reader["nombre"]
                        };
                    }
                }

                conexion.Close();
            }

            return piloto;
        }
    }
}