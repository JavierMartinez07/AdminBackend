using Dapper;
using System.Data.SqlClient;

namespace AdminBackend.Repositories
{
    /// <summary>
    /// Clase BaseRepository que proporciona una conexión a una base de datos y un método para ejecutar una consulta genérica.
    /// </summary>
    public abstract class BaseRepository
    {
        /// <summary>
        /// Obtiene la conexión a la base de datos especificada en la cadena de conexión.
        /// </summary>
        /// <returns>Objeto <see cref="SqlConnection"/></returns>
        private static SqlConnection GetConecction()
        {

            try
            {
                string connString = "Data Source=DESKTOP-TIQ4RNN;Initial Catalog=AdminBackend;Integrated Security=True;";
                var con = new SqlConnection(connString);
                return con;

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Ejecuta la consulta dada con los parámetros especificados y devuelve el resultado como una lista de objetos del tipo especificado en T.
        /// </summary>
        /// <typeparam name="T">Tipo de objetos en la lista de resultados</typeparam>
        /// <param name="query">Consulta SQL a ejecutar</param>
        /// <param name="parametros">Parámetros de consulta opcionales</param>
        /// <returns>Lista de objetos de tipo T</returns>
        protected static List<T> Query<T>(string query, object parametros = null)
        {
            try
            {
                var con = GetConecction();
                con.Open();
                var result = con.Query<T>(query, parametros).AsList<T>();
                con.Close();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
