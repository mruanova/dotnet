
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using DojoSurvey.Models;
using Microsoft.Extensions.Options;

namespace DojoSurvey.Factory
{
    public class CarFactory
    {
        private MySqlOptions _options;
        
        public CarFactory(IOptions<MySqlOptions> config)
        {
            _options = config.Value;
        }
        
        internal IDbConnection Connection
        {
            get
            {
                /*
                string server = "localhost";
                string db = "mydb"; //Change to your schema name
                string port = "3306"; //Potentially 8889
                string user = "root";
                string pass = "root";
                string connectionString = $"Server={server};Port={port};Database={db};UserID={user};Password={pass};SslMode=None";
                return new MySqlConnection(connectionString);
                */ 
                return new MySqlConnection(_options.ConnectionString);
            }
        }

        public void Add(Car item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO users (user_name, email, password, created_at, updated_at) VALUES (@Name, @Email, @Password, NOW(), NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, item); // dapper
            }
        }
        // public List<Car> FindAll()
        public IEnumerable<Car> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Car>("SELECT * FROM cars");
            }
        }
        public Car FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Car>("SELECT * FROM users WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
    }
}
