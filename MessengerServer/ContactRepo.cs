using Microsoft.Data.SqlClient;

public class ContactRepository
{
    private readonly Database database = new Database();

    public void AddContact(string userId, string contactUserId)
    {
        using SqlConnection connection = database.GetConnection();

        connection.Open();

        string sql = """
            INSERT INTO Contact (userId, contactUserId)
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
            FROM Contact
            WHERE userId = @userId
            AND contactUserId = @contactUserId
            """;

        using SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@userId", userId);
        command.Parameters.AddWithValue("@contactUserId", contactUserId);

        int count = (int)command.ExecuteScalar();

        return count > 0;
    }

    //private bool saveContact(string userId,string contactUserId)
    //{
    //    try
    //    {
    //        using SqlConnection connection = database.GetConnection();
    //        string query = @"INSERT INTO Contact (userId, contactUserId) VALUES(@userId,@contactUserId)";

    //        using SqlCommand cmd = new SqlCommand(query,connection);

    //        cmd.Parameters.AddWithValue("@userId", userId);
    //        cmd.Parameters.AddWithValue("@contactUserId", contactUserId);
    //        connection.Open();

    //        return cmd.ExecuteNonQuery() > 0;
    //    }
    //    catch
    //    {
    //        return false;
    //    }
    //}

    public List<string[]> getContacts(string userId)
    {
        List<string[]> contacts = new List<string[]>();

        using SqlConnection connection = database.GetConnection();

        string query = """
            SELECT u.UserId, u.Username
            FROM Contact c
            INNER JOIN UserInfo u
                ON c.contactUserId = u.UserId
            WHERE c.userId = @userId
            """;

        using SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@userId", userId);

        connection.Open();

        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            contacts.Add(new string[]
            {
                reader["UserId"].ToString()!,
                reader["Username"].ToString()!
            });
        }

        return contacts;
    }

    
}