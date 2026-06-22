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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong");
                return;
            }

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

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Confirm Password harus sama");
                return;
            }

            var user = new
            {
                username = txtUsername.Text,
                email = txtEmail.Text,
                password = txtPassword.Text
            };

            using HttpClient client = new HttpClient();

            string json = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync(
                    "https://localhost:7256/api/auth/register",
                    content
                );

                string result = await response.Content.ReadAsStringAsync();

                MessageBox.Show(result);

                if (response.IsSuccessStatusCode)
                {
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke API: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
