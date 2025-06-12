using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Sewa_Lapangan.Models
{
    public class UserModel
    {
        public int IdUser { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // Fungsi untuk login user
        public static UserModel Login(string email, string password)
        {
            string query = "SELECT * FROM \"user\" WHERE email = @email AND password = @password";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@password", password)
            };

            using (var reader = DatabaseHelper.QueryExecutor(query, parameters))
            {
                if (reader.Read())
                {
                    return new UserModel
                    {
                        IdUser = Convert.ToInt32(reader["id_user"]),
                        Nama = reader["nama"].ToString(),
                        Email = reader["email"].ToString(),
                        Password = reader["password"].ToString(),
                        Role = reader["role"].ToString()
                    };
                }
            }

            return null; // jika login gagal
        }

        // Fungsi untuk register user baru
        public static bool Register(UserModel user)
        {
            // Cek apakah email sudah ada
            if (EmailExists(user.Email))
                return false;

            string query = "INSERT INTO \"user\" (nama, email, password, role) VALUES (@nama, @email, @password, @role)";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@nama", user.Nama),
                new NpgsqlParameter("@email", user.Email),
                new NpgsqlParameter("@password", user.Password),
                new NpgsqlParameter("@role", "pengguna")
            };

            DatabaseHelper.CommandExecutor(query, parameters);
            return true;
        }

        // Fungsi untuk cek email apakah sudah digunakan
        public static bool EmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM \"user\" WHERE email = @email";
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@email", email)
            };

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    long count = (long)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
