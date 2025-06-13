using Npgsql;
using Sewa_Lapangan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewa_Lapangan.Controllers
{
    public class AuthController
    {
        // Fungsi Login
        public static UserModel Login(string email, string password)
        {
            return UserModel.Login(email, password);
        }

        // Fungsi Register
        public static bool Register(string nama, string email, string password)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Cek email sudah ada?
                string cekQuery = "SELECT COUNT(*) FROM \"user\" WHERE email = @Email";
                using (var cmdCek = new NpgsqlCommand(cekQuery, conn))
                {
                    cmdCek.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(cmdCek.ExecuteScalar());

                    if (count > 0)
                    {
                        return false; // email sudah terdaftar
                    }
                }

                // Insert user baru
                string insertQuery = @"
            INSERT INTO ""user"" (nama, email, password, role)
            VALUES (@Nama, @Email, @Password, 'pengguna')";

                using (var cmdInsert = new NpgsqlCommand(insertQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@Nama", nama);
                    cmdInsert.Parameters.AddWithValue("@Email", email);
                    cmdInsert.Parameters.AddWithValue("@Password", password);
                    cmdInsert.ExecuteNonQuery();
                }

                return true;
            }
        }

    }
}
