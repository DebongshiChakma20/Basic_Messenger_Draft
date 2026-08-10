using Microsoft.Data.SqlClient;

public class MessageRepository
{
    private readonly Database database = new Database();

    public bool SaveMessage(string senderId, string receiverId, string messageText)
    {
        using SqlConnection connection = database.GetConnection();

        connection.Open();

        string sql = """
            INSERT INTO Messages
                (senderId, receiverId, messageText)
            VALUES
                (@senderId, @receiverId, @messageText)
            """;

        using SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@senderId", senderId);
        command.Parameters.AddWithValue("@receiverId", receiverId);
        command.Parameters.AddWithValue("@messageText", messageText);

        return command.ExecuteNonQuery() > 0;
    }
}