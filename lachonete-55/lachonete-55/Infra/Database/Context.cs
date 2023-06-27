using MySql.Data.MySqlClient;

namespace lanchonete_55.Infra.Database
{
    public class Context
    {
        private string connection = "server=localhost;database=lanchonete55;user id=root;password=root";
        public readonly MySqlConnection _connection;
        public Context() 
        {
            _connection = new MySqlConnection(connection);
            try
            {
                _connection.Open();
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
