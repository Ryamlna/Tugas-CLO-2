using BintangGUI.Helpers;
using BintangGUI.Models;
using BintangGUI.Services;

namespace BintangGUI
{
    public partial class MainForm : Form
    {
        private List<Store> stores = new List<Store>
        {
            new Store { Name = "Food Paradise",       Latitude = -6.914744, Longitude = 107.609810 },
            new Store { Name = "Healthy Food Corner", Latitude = -6.917464, Longitude = 107.619123 },
            new Store { Name = "Good Meal Cafe",      Latitude = -6.920000, Longitude = 107.610000 },
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtLatitude.Text))
            {
                MessageBox.Show("Latitude tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLatitude.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLongitude.Text))
            {
                MessageBox.Show("Longitude tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLongitude.Focus();
                return;
            }

            if (!double.TryParse(txtLatitude.Text.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out double userLat))
            {
                MessageBox.Show("Latitude harus berupa angka desimal!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtLongitude.Text.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out double userLon))
            {
                MessageBox.Show("Longitude harus berupa angka desimal!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ValidationHelper.ValidateCoordinate(userLat, userLon);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Koordinat Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate distances and populate ListView
            lvHasil.Items.Clear();

            var results = new List<(Store store, double distance)>();

            foreach (var store in stores)
            {
                double distance = DistanceService.CalculateDistance(userLat, userLon, store.Latitude, store.Longitude);
                results.Add((store, distance));
            }

            // Sort by nearest
            results = results.OrderBy(r => r.distance).ToList();

            int rank = 1;
            foreach (var (store, distance) in results)
            {
                var item = new ListViewItem(rank.ToString());
                item.SubItems.Add(store.Name);
                item.SubItems.Add($"{store.Latitude:F6}");
                item.SubItems.Add($"{store.Longitude:F6}");
                item.SubItems.Add($"{distance:F2} KM");

                // Highlight nearest
                if (rank == 1)
                {
                    item.BackColor = Color.FromArgb(198, 239, 206);
                    item.ForeColor = Color.FromArgb(0, 97, 0);
                    item.Font = new Font(lvHasil.Font, FontStyle.Bold);
                }

                lvHasil.Items.Add(item);
                rank++;
            }

            // Show nearest store info
            if (results.Count > 0)
            {
                var nearest = results[0];
                lblNearestInfo.Text = $"🏆 Toko Terdekat: {nearest.store.Name}  ({nearest.distance:F2} KM)";
                lblNearestInfo.Visible = true;
            }

            lblStatus.Text = $"Ditemukan {results.Count} toko | Koordinat user: ({userLat:F6}, {userLon:F6})";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLatitude.Clear();
            txtLongitude.Clear();
            lvHasil.Items.Clear();
            lblNearestInfo.Visible = false;
            lblStatus.Text = "Masukkan koordinat Anda lalu klik Cari Toko Terdekat";
            txtLatitude.Focus();
        }

        private void btnIsiContoh_Click(object sender, EventArgs e)
        {
            // Fill with sample Bandung coordinates
            txtLatitude.Text = "-6.9175";
            txtLongitude.Text = "107.6191";
        }
    }
}
