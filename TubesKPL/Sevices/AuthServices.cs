using System.Diagnostics;
using TubesKPL.Models;

namespace TubesKPL.Services
{
    public class AuthService
    {
        // Static database sementara
        private static List<User> users = new List<User>();

        // REGISTER
        public string Register(User user)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            // Defensive Programming
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                return "Username wajib diisi";
            }

            if (string.IsNullOrWhiteSpace(user.Email))
            {
                return "Email wajib diisi";
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                return "Password wajib diisi";
            }

            if (user.Password.Length < 8)
            {
                return "Password minimal 8 karakter";
            }

            // Cek email sudah digunakan
            var existingUser = users.FirstOrDefault
            (
                u => u.Email == user.Email
            );

            if (existingUser != null)
            {
                return "Email sudah digunakan";
            }

            stopwatch.Stop();
            Console.WriteLine($"Waktu Register: {stopwatch.ElapsedMilliseconds} ms");

            user.Id = users.Count + 1;

            users.Add(user);

            return "Register berhasil";
        }

        // LOGIN
        public string Login(User loginUser)
        {

            Stopwatch stopwatch = Stopwatch.StartNew();


            if (string.IsNullOrWhiteSpace(loginUser.Email))
            {
                return "Email wajib diisi";
            }

            if (string.IsNullOrWhiteSpace(loginUser.Password))
            {
                return "Password wajib diisi";
            }

            var user = users.FirstOrDefault
            (
                u => u.Email == loginUser.Email &&
                     u.Password == loginUser.Password
            );

            if (user == null)
            {
                return "Email atau password salah";
            }
            stopwatch.Stop();
            Console.WriteLine($"Waktu login: {stopwatch.ElapsedMilliseconds} ms");

            return "Login berhasil";
        }

        public object GetAllUsers()
        {
            return users.Select(u => new
            {
                u.Id,
                u.Username,
                u.Email
            });
        }
    }
}