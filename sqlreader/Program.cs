using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
		string connectionString = "YourConnectionString";
        string query = "SELECT * FROM YourTable";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Access the data using the reader
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        // ...

                        // Process the data as needed
                        Console.WriteLine($"ID: {id}, Name: {name}");
                    }
                }
            }
        }
    }
}