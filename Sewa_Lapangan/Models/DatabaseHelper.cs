using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Sewa_Lapangan.Models
{
    public class DatabaseHelper
    {
        private static readonly string dbHost = "localhost";
        private static readonly string dbDatabase = "sewa_lapangan";
        private static readonly string dbUsername = "postgres";
        private static readonly string dbPassword = "radity@"; // sesuaikan Password
        private static readonly string dbPort = "5432";

        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        // Mendapatkan koneksi
        public static NpgsqlConnection GetConnection()
        {
            string connString = $"Host={dbHost};Port={dbPort};Username={dbUsername};Password={dbPassword};Database={dbDatabase}";
            connection = new NpgsqlConnection(connString);
            return connection;
        }

        // Eksekusi query tanpa parameter (insert/update/delete)
        public static void ExecuteQuery(string query)
        {
            try
            {
                connection.Open();
                command = new NpgsqlCommand(query, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Query berhasil dijalankan!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        // Eksekusi query dengan parameter (lebih aman)
        public static void CommandExecutor(string query, NpgsqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        // Eksekusi select query (mengembalikan reader)
        public static NpgsqlDataReader QueryExecutor(string query, NpgsqlParameter[] parameters)
        {
            NpgsqlCommand command = new NpgsqlCommand(query, GetConnection());
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
