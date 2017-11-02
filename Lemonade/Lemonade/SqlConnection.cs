using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class GameDatabase
    {
        SqlConnection db;
        public GameDatabase()
        {
            db = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LemonadeStandDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            db.Open();
        }
        public void RecordGame(string name, double score)
        {
            string sql = "INSERT INTO [Table] (Name, Score) VALUES(@name, @score)";
            using (db)
            {          
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = db;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@score", score);
                    try
                    {
                        command.ExecuteNonQuery();
                        db.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
