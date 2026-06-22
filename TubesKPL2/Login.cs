using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace TubesKPL2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong");
                return;
            }

            var user = new
            {
                email = txtEmail.Text,
                password = txtPassword.Text
            };

            using HttpClient client = new HttpClient();

            string json = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync(
                    "https://localhost:7256/api/auth/login",
                    content
                );

                string result = await response.Content.ReadAsStringAsync();

                MessageBox.Show(result);

                if (response.IsSuccessStatusCode)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke API: " + ex.Message);
            }
        }
    }
}
