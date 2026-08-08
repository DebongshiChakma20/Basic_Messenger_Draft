using Microsoft.Data.SqlClient;

public class ContactRepository
{
    private readonly Database database = new Database();

    public void AddContact(string userId, string contactUserId)
    {
        using SqlConnection connection = database.GetConnection();

        connection.Open();

        string sql = """
            INSERT INTO Contacts (userId, contactUserId)
            VALUES (@userId, @contactUserId)
            """;

        using SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@userId", userId);
        command.Parameters.AddWithValue("@contactUserId", contactUserId);

        command.ExecuteNonQuery();
    }

    public bool ContactExists(string userId, string contactUserId)
    {
        using SqlConnection connection = database.GetConnection();

        connection.Open();

        string sql = """
            SELECT COUNT(*)
            FROM Contacts
            WHERE userId = @userId
            AND contactUserId = @contactUserId
            """;

        using SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@userId", userId);
        command.Parameters.AddWithValue("@contactUserId", contactUserId);

        int count = (int)command.ExecuteScalar();

        return count > 0;
    }
}