using Microsoft.Data.SqlClient;

public class Database
{
    private readonly string connectionString="Server=localhost;Database=MessengerDB;Integrated Security=True;TrustServerCertificate=True;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}