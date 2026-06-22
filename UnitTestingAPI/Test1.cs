using Microsoft.VisualStudio.TestTools.UnitTesting;
using TubesKPL.Models;
using TubesKPL.Services;

namespace UnitTestingAPI
{
    [TestClass]
    public sealed class Test1
    {
        private AuthService _authService;

        [TestInitialize]
        public void Setup()
        {
            _authService = new AuthService();
        }

        // TEST REGISTER BERHASIL
        [TestMethod]
        public void Register_Should_Return_Success()
        {
            User user = new User
            {
                Username = "Ridho",
                Email = "ridho@gmail.com",
                Password = "12345678"
            };

            var result = _authService.Register(user);

            Assert.AreEqual("Register berhasil", result);
        }

        // TEST EMAIL KOSONG
        [TestMethod]
        public void Register_Should_Fail_If_Email_Empty()
        {
            User user = new User
            {
                Username = "Ridho",
                Email = "",
                Password = "12345678"
            };

            var result = _authService.Register(user);

            Assert.AreEqual("Email wajib diisi", result);
        }

        // TEST LOGIN BERHASIL
        [TestMethod]
        public void Login_Should_Return_Success()
        {
            User user = new User
            {
                Username = "Ridho",
                Email = "ridho123@gmail.com",
                Password = "12345678"
            };

            _authService.Register(user);

            var result = _authService.Login(user);

            Assert.AreEqual("Login berhasil", result);
        }

        // TEST PASSWORD SALAH
        [TestMethod]
        public void Login_Should_Fail_If_Password_Wrong()
        {
            User user = new User
            {
                Username = "Ridho",
                Email = "ridho321@gmail.com",
                Password = "12345678"
            };

            _authService.Register(user);

            User wrongUser = new User
            {
                Email = "ridho321@gmail.com",
                Password = "salahpassword"
            };

            var result = _authService.Login(wrongUser);

            Assert.AreEqual("Email atau password salah", result);
        }
    }
}
