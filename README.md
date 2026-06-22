# BintangGUI - GoodBite Location System (Windows Forms)

GUI versi dari project Tugas-CLO-2 milik Bintang, dikonversi dari Console App menjadi Windows Forms App.

## Cara Menjalankan

1. Buka `BintangGUI.sln` di Visual Studio 2022
2. Build dan Run (F5)

## Fitur

- Input Latitude dan Longitude pengguna via form
- Validasi koordinat (range -90/90 untuk lat, -180/180 untuk lon)
- Tombol "Isi Contoh" untuk mengisi koordinat sample Bandung
- Tampilkan daftar toko diurutkan dari yang terdekat
- Highlight toko terdekat dengan warna hijau
- Tombol Reset untuk membersihkan form

## Struktur Project

```
BintangGUI/
├── BintangGUI.sln
└── BintangGUI/
    ├── BintangGUI.csproj
    ├── Program.cs
    ├── MainForm.cs
    ├── MainForm.Designer.cs
    ├── MainForm.resx
    ├── Models/
    │   └── Store.cs
    ├── Services/
    │   └── DistanceService.cs
    └── Helpers/
        └── ValidationHelper.cs
```

## Teknologi

- .NET 8.0 Windows
- Windows Forms (WinForms)
- Target Framework: net8.0-windows
