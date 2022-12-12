using MySql.Data.MySqlClient;
namespace net1
{
    public class PersonaRepository {
        
        public MySqlConnection obtenerConexion() {

            var sb = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "",
                Port = 3306,
                Database = "curso2"

            };
            MySqlConnection conn = new MySqlConnection(sb.ConnectionString);
            conn.Open();
            return conn;
        }
    }
}