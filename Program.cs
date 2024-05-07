using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string tujuan = "ANDA BELUM MEMILIH TUJUAN";
      string member ,nama = "", email = "", no_hp = "", jenis_kereta = "", kelas = "", kota = "";
      float disc = 0f, harga_tiket = 0f;
      int jumlah_tiket;
      float sub_total, total_bayar, diskon;
      while (true)
      {
        kembali:
        string pilihan;
        Console.WriteLine("+===========================================+");
        Console.WriteLine("              TRAVEL AYOK LIBUR              ");
        Console.WriteLine("+===========================================+");
        Console.WriteLine("1. Identitas");
        Console.WriteLine("2. Tujuan");
        Console.WriteLine("3. Jenis Kereta");
        Console.WriteLine("4. Konfirmasi");
        Console.WriteLine("5. Keluar");
        Console.WriteLine("+--------------------------------------------+");
        Console.Write("Masukan Pilihan : ");
        pilihan = Console.ReadLine() ?? "";

        if (pilihan == "1")
        {
          //! IDENTITAS
          Console.WriteLine("+===========================================+");
          Console.WriteLine("             FORMULIR IDENTITAS");
          Console.WriteLine("+===========================================+");
          Console.Write("Masukan Nama :");
          nama = Console.ReadLine() ?? "";
          Console.Write("Masukan email :");
          email = Console.ReadLine() ?? "";
          Console.Write("Masukan NoHp :");
          no_hp = Console.ReadLine() ?? "";
          Console.WriteLine("+===========================================+");
        }
        else if (pilihan == "2")
        {
          //! TUJUAN
          Console.WriteLine("+============================================+");
          Console.WriteLine("| KODE |               TUJUAN                |");
          Console.WriteLine("+--------------------------------------------+");
          Console.WriteLine("| JKT  |  JAKARTA                            |");
          Console.WriteLine("| SLO  |  SOLO                               |");
          Console.WriteLine("| SBY  |  SURABAYA                           |");
          Console.WriteLine("|  x   |  untuk kembali ke menu              |");
          Console.WriteLine("+============================================+");
          LabelTujuan:
          Console.Write("Pilihan : ");
          tujuan = Console.ReadLine() ?? "";
          if (tujuan.ToLower() == "x")
          {
            goto kembali;
          }
          else if (tujuan.ToLower() != "jkt" && tujuan.ToLower() != "slo" && tujuan.ToLower() != "sby")
          {
            Console.WriteLine("INPUT INVALID");
            goto LabelTujuan; 
          }
        }
        //! JENIS KERETA
        else if (pilihan == "3")
        {
          labelkereta:
          Console.WriteLine("+============================================+");
          Console.WriteLine("                   JENIS KERETA");
          Console.WriteLine("+============================================+");
          switch (tujuan.ToLower())
          {
            case "jkt":
              kota = "JAKARTA";
              Console.WriteLine("1. EKS-700000-JAKARTA");
              Console.WriteLine("2. BNS-400000-JAKARTA");
              Console.WriteLine("3. EKN-100000-JAKARTA");
              Console.WriteLine("X. KEMBALI KE MENU");
              LabelJKT:
              Console.Write("Pilihan :  ");
              jenis_kereta = Console.ReadLine() ?? "";
              if (jenis_kereta.ToLower() == "x")
              {
                goto kembali;
              }
              else if (jenis_kereta != "1" && jenis_kereta != "2" && jenis_kereta != "3")
              {
                Console.WriteLine("INPUT INVALID !");
                goto LabelJKT;
              }
              switch (jenis_kereta)
              {
                case "1":
                  kelas = "Eksekutif";
                  harga_tiket = 700000;
                  continue;
                case "2":
                  kelas = "Bisnis";
                  harga_tiket = 400000;
                  continue;
                case "3":
                  kelas = "Ekonomi";
                  harga_tiket = 100000;
                  continue;
                default:
                  Console.WriteLine("Input Invalid, Silahkan Masukan Kembali !");
                  goto labelkereta;
              }
            case "slo":
              kota = "SOLO";
              Console.WriteLine("1. EKS-800000-SOLO");
              Console.WriteLine("2. BNS-500000-SOLO");
              Console.WriteLine("3. EKN-200000-SOLO");
              Console.WriteLine("X. KEMBALI KE MENU");
              LabelSLO:
              Console.Write("Pilihan :  ");
              jenis_kereta = Console.ReadLine() ?? "";
              if (jenis_kereta.ToLower() == "x")
              {
                goto kembali;
              }
              else if (jenis_kereta != "1" && jenis_kereta != "2" && jenis_kereta != "3")
              {
                Console.WriteLine("INPUT INVALID !");
                goto LabelSLO;
              }
              switch (jenis_kereta)
              {
                case "1":
                  kelas = "Eksekutif";
                  harga_tiket = 800000;
                  continue;
                case "2":
                  kelas = "Bisnis";
                  harga_tiket = 500000;
                  continue;
                case "3":
                  kelas = "Ekonomi";
                  harga_tiket = 200000;
                  continue;
                default:
                  Console.WriteLine("Input Invalid, Silahkan Masukan Kembali !");
                  goto labelkereta;
              }
            case "sby":
              kota = "SURABAYA";
              Console.WriteLine("1. EKS-900000-SURABAYA");
              Console.WriteLine("2. BNS-600000-SURABAYA");
              Console.WriteLine("3. EKN-300000-SURABAYA");
              Console.WriteLine("X. KEMBALI KE MENU");
              LabelSBY:
              Console.Write("Pilihan :  ");
              jenis_kereta = Console.ReadLine() ?? "";
              if (jenis_kereta.ToLower() == "x")
              {
                goto kembali;
              }
              else if (jenis_kereta != "1" && jenis_kereta != "2" && jenis_kereta != "3")
              {
                Console.WriteLine("INPUT INVALID !");
                goto LabelSBY;
              }
              switch (jenis_kereta)
              {
                case "1":
                  kelas = "Eksekutif";
                  harga_tiket = 900000;
                  continue;
                case "2":
                  kelas = "Bisnis";
                  harga_tiket = 600000;
                  continue;
                case "3":
                  kelas = "Ekonomi";
                  harga_tiket = 300000;
                  continue;
                default:
                  Console.WriteLine("Input Invalid, Silahkan Masukan Kembali !");
                  goto labelkereta;
              }
            default:
              Console.WriteLine(tujuan);
              Console.WriteLine("SILAHKAN KEMBALI DAN PILIH TUJUAN ANDA !");
              Console.WriteLine("X. KEMBALI KE MENU");
              Console.Write("Pilihan : ");
              string kembali = Console.ReadLine() ?? "";
              if (kembali.ToLower() == "x")
              {
                goto kembali;
              }
              continue;
          }
        }
        //! KONFIRMASI TIKET
        else if (pilihan == "4")
        {
          if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(no_hp) || string.IsNullOrEmpty(jenis_kereta))
          {
            Console.WriteLine("+--------------------------------------------+");
            Console.WriteLine("    HARAP LENGKAPI DATA TERLEBIH DAHULU ! ");
            Console.WriteLine("+--------------------------------------------+");
            Thread.Sleep(1500);
          }
          else
          {
            Console.WriteLine($"Anda Memilih Tiket Kereta kelas {kelas} Dengan Tujuan {kota}");
            LabelJumlah:
            Console.Write("Masukan Jumlah Tiket : ");
            jumlah_tiket = int.Parse(Console.ReadLine()?? "");
            if (jumlah_tiket <1)
            {
              Console.WriteLine("INPUT INVALID");
              goto LabelJumlah;
            }
            Console.Write("Apakah Anda Member ? (y/n) : ");
            member = Console.ReadLine() ?? "";
            if (member.ToLower() == "y") 
            {
              disc = 0.1f;
            }
            //! HITUNG
            sub_total = harga_tiket * jumlah_tiket;
            diskon = sub_total * disc;
            total_bayar = sub_total - diskon;

            Console.WriteLine("+===========================================+");
            Console.WriteLine("               TRAVEL AYOK LIBUR             ");
            Console.WriteLine("+===========================================+");
            Console.WriteLine($"Nama Pemesan  : {nama}");
            Console.WriteLine($"Email Pemesan : {email}");
            Console.WriteLine($"NoHp Pemesan  : {no_hp}");
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine($"Tujuan        : {kota}");
            Console.WriteLine($"Kelas         : {kelas}");
            Console.WriteLine($"Harga tiket   : Rp.{harga_tiket}");
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine($"Sub Total     : Rp.{sub_total}");
            Console.WriteLine($"Diskon        : Rp.{diskon}");
            Console.WriteLine($"Total Bayar   : Rp.{total_bayar}");
            Console.WriteLine("+===========================================+");
            break;
          }
        }
        //! KELUAR DARI PROGRAM
        else if (pilihan == "5")
        {
          Console.WriteLine("Keluar Dari Program....");
          break;
        }
      }
    }
  }
}