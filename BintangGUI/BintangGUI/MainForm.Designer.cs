namespace BintangGUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Controls
            pnlHeader      = new Panel();
            lblAppTitle    = new Label();
            lblAppSubtitle = new Label();
            pnlInput       = new GroupBox();
            lblLatitude    = new Label();
            txtLatitude    = new TextBox();
            lblLatHint     = new Label();
            lblLongitude   = new Label();
            txtLongitude   = new TextBox();
            lblLonHint     = new Label();
            btnIsiContoh   = new Button();
            btnCari        = new Button();
            btnReset       = new Button();
            lblNearestInfo = new Label();
            lvHasil        = new ListView();
            colNo          = new ColumnHeader();
            colNama        = new ColumnHeader();
            colLat         = new ColumnHeader();
            colLon         = new ColumnHeader();
            colJarak       = new ColumnHeader();
            pnlFooter      = new Panel();
            lblStatus      = new Label();

            pnlHeader.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();

            // ── pnlHeader ──────────────────────────────────────────────
            pnlHeader.BackColor  = Color.FromArgb(34, 139, 34);
            pnlHeader.Dock       = DockStyle.Top;
            pnlHeader.Height     = 80;
            pnlHeader.Padding    = new Padding(16, 8, 16, 8);
            pnlHeader.Controls.Add(lblAppSubtitle);
            pnlHeader.Controls.Add(lblAppTitle);

            lblAppTitle.AutoSize  = true;
            lblAppTitle.Font      = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location  = new Point(16, 8);
            lblAppTitle.Text      = "🍽️  GOODBITE Location System";

            lblAppSubtitle.AutoSize  = true;
            lblAppSubtitle.Font      = new Font("Segoe UI", 9F);
            lblAppSubtitle.ForeColor = Color.FromArgb(200, 255, 200);
            lblAppSubtitle.Location  = new Point(20, 48);
            lblAppSubtitle.Text      = "Temukan Toko Makanan Terdekat dari Lokasi Anda";

            // ── pnlInput (GroupBox) ────────────────────────────────────
            pnlInput.Text        = "📍 Masukkan Koordinat Lokasi Anda";
            pnlInput.Font        = new Font("Segoe UI", 9F, FontStyle.Bold);
            pnlInput.ForeColor   = Color.FromArgb(34, 139, 34);
            pnlInput.Location    = new Point(16, 96);
            pnlInput.Size        = new Size(630, 160);
            pnlInput.Padding     = new Padding(12);

            // Latitude
            lblLatitude.AutoSize  = true;
            lblLatitude.Font      = new Font("Segoe UI", 9F);
            lblLatitude.ForeColor = Color.Black;
            lblLatitude.Location  = new Point(16, 36);
            lblLatitude.Text      = "Latitude  :";

            txtLatitude.Location    = new Point(130, 32);
            txtLatitude.Size        = new Size(180, 27);
            txtLatitude.Font        = new Font("Segoe UI", 10F);
            txtLatitude.PlaceholderText = "contoh: -6.9175";

            lblLatHint.AutoSize  = true;
            lblLatHint.Font      = new Font("Segoe UI", 8F);
            lblLatHint.ForeColor = Color.Gray;
            lblLatHint.Location  = new Point(320, 36);
            lblLatHint.Text      = "(antara -90 dan 90)";

            // Longitude
            lblLongitude.AutoSize  = true;
            lblLongitude.Font      = new Font("Segoe UI", 9F);
            lblLongitude.ForeColor = Color.Black;
            lblLongitude.Location  = new Point(16, 78);
            lblLongitude.Text      = "Longitude :";

            txtLongitude.Location    = new Point(130, 74);
            txtLongitude.Size        = new Size(180, 27);
            txtLongitude.Font        = new Font("Segoe UI", 10F);
            txtLongitude.PlaceholderText = "contoh: 107.6191";

            lblLonHint.AutoSize  = true;
            lblLonHint.Font      = new Font("Segoe UI", 8F);
            lblLonHint.ForeColor = Color.Gray;
            lblLonHint.Location  = new Point(320, 78);
            lblLonHint.Text      = "(antara -180 dan 180)";

            // Buttons
            btnIsiContoh.Location         = new Point(16, 118);
            btnIsiContoh.Size             = new Size(130, 32);
            btnIsiContoh.Text             = "📋 Isi Contoh";
            btnIsiContoh.Font             = new Font("Segoe UI", 9F);
            btnIsiContoh.BackColor        = Color.WhiteSmoke;
            btnIsiContoh.FlatStyle        = FlatStyle.Flat;
            btnIsiContoh.FlatAppearance.BorderColor = Color.Silver;
            btnIsiContoh.UseVisualStyleBackColor = false;
            btnIsiContoh.Click           += btnIsiContoh_Click;

            btnCari.Location              = new Point(160, 118);
            btnCari.Size                  = new Size(160, 32);
            btnCari.Text                  = "🔍 Cari Toko Terdekat";
            btnCari.Font                  = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCari.BackColor             = Color.FromArgb(34, 139, 34);
            btnCari.ForeColor             = Color.White;
            btnCari.FlatStyle             = FlatStyle.Flat;
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click                += btnCari_Click;

            btnReset.Location             = new Point(334, 118);
            btnReset.Size                 = new Size(100, 32);
            btnReset.Text                 = "🔄 Reset";
            btnReset.Font                 = new Font("Segoe UI", 9F);
            btnReset.BackColor            = Color.FromArgb(220, 53, 69);
            btnReset.ForeColor            = Color.White;
            btnReset.FlatStyle            = FlatStyle.Flat;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click               += btnReset_Click;

            pnlInput.Controls.Add(lblLatitude);
            pnlInput.Controls.Add(txtLatitude);
            pnlInput.Controls.Add(lblLatHint);
            pnlInput.Controls.Add(lblLongitude);
            pnlInput.Controls.Add(txtLongitude);
            pnlInput.Controls.Add(lblLonHint);
            pnlInput.Controls.Add(btnIsiContoh);
            pnlInput.Controls.Add(btnCari);
            pnlInput.Controls.Add(btnReset);

            // ── lblNearestInfo ─────────────────────────────────────────
            lblNearestInfo.AutoSize  = false;
            lblNearestInfo.Dock      = DockStyle.None;
            lblNearestInfo.Location  = new Point(16, 266);
            lblNearestInfo.Size      = new Size(630, 32);
            lblNearestInfo.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNearestInfo.ForeColor = Color.FromArgb(0, 97, 0);
            lblNearestInfo.BackColor = Color.FromArgb(198, 239, 206);
            lblNearestInfo.TextAlign = ContentAlignment.MiddleLeft;
            lblNearestInfo.Padding   = new Padding(8, 0, 0, 0);
            lblNearestInfo.Visible   = false;

            // ── lvHasil ────────────────────────────────────────────────
            lvHasil.View          = View.Details;
            lvHasil.FullRowSelect = true;
            lvHasil.GridLines     = true;
            lvHasil.Location      = new Point(16, 308);
            lvHasil.Size          = new Size(630, 170);
            lvHasil.Font          = new Font("Segoe UI", 9F);
            lvHasil.BorderStyle   = BorderStyle.FixedSingle;

            colNo.Text   = "#";
            colNo.Width  = 35;
            colNama.Text = "Nama Toko";
            colNama.Width = 180;
            colLat.Text  = "Latitude";
            colLat.Width = 110;
            colLon.Text  = "Longitude";
            colLon.Width = 110;
            colJarak.Text = "Jarak";
            colJarak.Width = 100;

            lvHasil.Columns.AddRange(new ColumnHeader[] { colNo, colNama, colLat, colLon, colJarak });

            // ── pnlFooter ──────────────────────────────────────────────
            pnlFooter.BackColor = Color.FromArgb(240, 240, 240);
            pnlFooter.Dock      = DockStyle.Bottom;
            pnlFooter.Height    = 32;
            pnlFooter.Controls.Add(lblStatus);

            lblStatus.AutoSize  = true;
            lblStatus.Font      = new Font("Segoe UI", 8.5F);
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location  = new Point(12, 8);
            lblStatus.Text      = "Masukkan koordinat Anda lalu klik Cari Toko Terdekat";

            // ── MainForm ───────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(664, 530);
            FormBorderStyle     = FormBorderStyle.FixedSingle;
            MaximizeBox         = false;
            StartPosition       = FormStartPosition.CenterScreen;
            Text                = "GoodBite Location System - by Bintang";
            BackColor           = Color.White;

            Controls.Add(pnlHeader);
            Controls.Add(pnlInput);
            Controls.Add(lblNearestInfo);
            Controls.Add(lvHasil);
            Controls.Add(pnlFooter);

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel     pnlHeader;
        private Label     lblAppTitle;
        private Label     lblAppSubtitle;
        private GroupBox  pnlInput;
        private Label     lblLatitude;
        private TextBox   txtLatitude;
        private Label     lblLatHint;
        private Label     lblLongitude;
        private TextBox   txtLongitude;
        private Label     lblLonHint;
        private Button    btnIsiContoh;
        private Button    btnCari;
        private Button    btnReset;
        private Label     lblNearestInfo;
        private ListView  lvHasil;
        private ColumnHeader colNo;
        private ColumnHeader colNama;
        private ColumnHeader colLat;
        private ColumnHeader colLon;
        private ColumnHeader colJarak;
        private Panel     pnlFooter;
        private Label     lblStatus;
    }
}
