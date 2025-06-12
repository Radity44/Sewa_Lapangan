using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sewa_Lapangan.Models;

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
            UserModel user = new UserModel
            {
                Nama = nama,
                Email = email,
                Password = password
            };

            return UserModel.Register(user);
        }
    }
}
