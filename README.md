
# SewaLapangan - Aplikasi Booking & Manajemen Lapangan Olahraga

SewaLapangan adalah aplikasi desktop berbasis Windows Forms untuk sistem pemesanan lapangan olahraga seperti futsal, badminton, dan tennis. Aplikasi ini menyediakan dua role utama yaitu Admin dan User (Pelanggan), yang dapat melakukan pemesanan, pembayaran, dan pengelolaan data.

## 📌 Fitur Utama

### Role Admin

- Manajemen Jadwal Lapangan (tambah, edit, hapus jadwal).
- Kelola Pembayaran (verifikasi pembayaran, ubah status pembayaran).
- Dashboard laporan (melihat data user, pemasukan, total pemesanan, hapus akun user).

### Role User (Pelanggan)

- Melihat jadwal lapangan yang tersedia.
- Melakukan pemesanan dan pembayaran (cash atau transfer).
- Melihat riwayat transaksi.
- Update status pembayaran setelah diverifikasi admin.

## ⚙️ Struktur Project

### 📂 Controllers

- AuthController.cs

### 📂 Models

- DatabaseHelper.cs
- JenisLapanganItem.cs
- LapanganItem.cs
- SessionManager.cs
- StatusPembayaran.cs
- UserModel.cs

### 📂 Views

- LoginForm.cs, RegisterForm.cs
- AdminDashboardForm.cs
- KelolaJadwalForm.cs
- KelolaPembayaranForm.cs
- PemesananForm.cs
- PembayaranDetailForm.cs
- ListPembayaranForm.cs
- RiwayatPesananForm.cs

## 💾 Instalasi & Menjalankan Aplikasi

### 1️⃣ Clone Repository

```bash
git clone https://github.com/Radity4/sewa_lapangan.git
```

### 2️⃣ Buka Project di Visual Studio

- Buka Visual Studio.
- Pilih **Open Project**.
- Arahkan ke folder hasil clone.

### 3️⃣ Konfigurasi Database

- Pastikan sudah install **PostgreSQL**.
- Buat database sesuai dengan skema `sewa_lapangan.sql`.
- Update koneksi database di `DatabaseHelper.cs`:

```csharp
private static string connectionString = "Host=localhost;Port=5432;Database=sewa_lapangan;Username=postgres;Password=yourpassword";
```

### 4️⃣ Jalankan Aplikasi

- Tekan tombol **Start** atau tekan `F5` di Visual Studio.
- Aplikasi berjalan secara lokal di desktop Windows Anda.

## 🔧 Teknologi yang Digunakan

- **Bahasa Pemrograman**: C#
- **Framework**: Windows Forms (WinForms)
- **Database**: PostgreSQL
- **IDE**: Visual Studio 2022
- **Arsitektur**: MVC Sederhana (Controllers - Models - Views)

## 🤝 Kontribusi

Jika Anda ingin berkontribusi dalam pengembangan aplikasi ini:

1. Fork repository ini.
2. Buat branch untuk fitur yang ingin Anda kerjakan.
3. Commit perubahan Anda.
4. Push dan buat pull request.
