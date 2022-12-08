using System;

// App Kasir Penjualan Komputer
//Ruler
// 1. Cek Keranjang

// 2. Proses Pembelian
    //1.Keranjang.
    //2.Proses
// 3. Tutup
// History ??

namespace BasicProgramming
{ 
    class Program
    {
        static int Proses(int[] harga, int[] jml)
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += harga[i] * jml[i];
            }
            return total;
        }

        static double Persen(int total, int persen)
        {
            double angka = 100;
            return persen / angka * total;
    
        }

        //static int Penampung()
        //{

        //}

        static void Message()
        {
            Console.WriteLine("Pembelian Sudah Terisi!!");
        }

        static void MessageMenu()
        {
            Console.WriteLine("-------------------Keranjang-------------------");
            Console.WriteLine("No." + " " + "List Barang" + " " + "Harga" + " " + "Jumlah");
        }

        

        static void Main(string[] args)
        {

            string ulang = "y";
            
            string[] part = {"Processor","Motherboard","RAM","VGA","Hardisk"};
            string[] processor = {"Processor A", "Processor B", "Processor C"};
            string[] motherboard = {"Motherboard A", "Motherboard B", "Motherboard C" };
            string[] ram = {"RAM A", "RAM B", "RAM C"};
            string[] vga = {"VGA A", "VGA B", "VGA C" };
            string[] hardisk = {"Hardisk 126GB", "Hardisk 328GB", "Hardisk 656GB"};

            int[] harga_processor = {10000 ,20000 , 30000 };
            int[] harga_motherboard = {10000, 20000, 30000 };
            int[] harga_ram = { 10000, 20000, 30000 };
            int[] harga_vga = { 10000, 20000, 30000 };
            int[] harga_hardisk = { 10000, 20000, 30000 };

            string[] list_barang = new string[5];
            int[] total_harga = new int[5];
            int[] jml = new int[5];

            do
            {
                Console.WriteLine("-------------------Aplikasi Pembelian Part Komputer -------------------");
                Console.WriteLine("--- 1.Cek Keranjang \t---\n--- 2.Proses Pembelian  ---\n--- 3.Tutup Aplikasi \t---");
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.Write("Pilih : ");
                string x = Console.ReadLine();
                
                switch (x)
                {
                    case "1":
                        Console.WriteLine("1. Cek Keranjang");
                        MessageMenu();
                        for (int i = 0; i < 5; i++)
                        {
                           if (list_barang[i] == null)
                            {
                                Console.WriteLine("---Belum Terisi---");
                            }
                            else {
                                Console.WriteLine((1+i)+".  " + list_barang[i] +" "+ total_harga[i] +" "+ jml[i] );
                                
                            }
                        }
                        Console.WriteLine("-------------------Keranjang-------------------");
                        break;
                    case "2":
                        Console.WriteLine("-------------------------");
                        Console.WriteLine(" 1.Pilih Barang\n 2.Proses");
                        Console.WriteLine("-------------------------");
                        Console.Write("Pilih : ");
                        string pp = Console.ReadLine();
                        switch (pp)
                        {
                            case "1":
                                for (int i = 0; i < part.Length; i++)
                                {
                                    Console.WriteLine((1+i) +". "+ part[i]);
                                }
                                Console.Write("Pilih Barang : ");
                                string pb = Console.ReadLine();
                                switch (pb)
                                {
                                    case "1":
                                        for (int i = 0; i < processor.Length; i++)
                                        {
                                            Console.WriteLine(1+i + "." + processor[i]);
                                        }
                                        Console.Write("Pilih Jenis Processor : ");
                                        int cpu = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Jumlah Barang : ");
                                        int jmlh_cpu = Convert.ToInt32(Console.ReadLine());

                                        if (list_barang[0] == null && total_harga[0] == 0)
                                        {
                                            list_barang[0] = processor[cpu - 1];
                                            total_harga[0] = harga_processor[cpu - 1];
                                            jml[0] = jmlh_cpu;
                                        } else if (cpu<0 && cpu >= 6)
                                        { Console.Write("Pilihan Tidak Ada !!"); } else { Message(); }
                                        break;
                                    case "2":
                                        for (int i = 0; i < motherboard.Length; i++)
                                        {
                                            Console.WriteLine((1 + i) + ".  " + motherboard[i]);
                                        }
                                        Console.Write("Pilih Jenis Motherboard : ");
                                        int mb = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Jumlah Barang : ");
                                        int jmlh_mb = Convert.ToInt32(Console.ReadLine());
                                        if (list_barang[1] == null && total_harga[1] == 0)
                                        {
                                            list_barang[1] = motherboard[mb - 1];
                                            total_harga[1] = harga_motherboard[mb - 1];
                                            jml[1] = jmlh_mb;
                                        }
                                        else if (mb < 0 && mb >= 6)
                                        { Console.Write("Pilihan Tidak Ada !!"); }
                                        else { Message(); }
                                        break;
                                    case "3":
                                        for (int i = 0; i < ram.Length; i++)
                                        {
                                            Console.WriteLine((1 + i) + ".  " + ram[i]);
                                        }
                                        Console.Write("Pilih Jenis RAM : ");
                                        int rm = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Jumlah Barang : ");
                                        int jmlh_rm = Convert.ToInt32(Console.ReadLine());
                                        if (list_barang[2] == null && total_harga[2] == 0)
                                        {
                                            list_barang[2] = ram[rm - 1];
                                            total_harga[2] = harga_ram[rm - 1];
                                            jml[2] = jmlh_rm;
                                        }
                                        else if (rm < 0 && rm >= 6)
                                        { Console.Write("Pilihan Tidak Ada !!"); }
                                        else { Message(); }

                                        break;
                                    case "4":
                                        for (int i = 0; i < vga.Length; i++)
                                        {
                                            Console.WriteLine((1 + i) + ".  " + vga[i]);
                                        }
                                        Console.Write("Pilih Jenis Graphic Card : ");
                                        int vg = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Jumlah Barang : ");
                                        int jmlh_vg = Convert.ToInt32(Console.ReadLine());
                                        if (list_barang[3] == null && total_harga[3] == 0)
                                        {
                                            list_barang[3] = vga[vg - 1];
                                            total_harga[3] = harga_vga[vg - 1];
                                            jml[3] = jmlh_vg;
                                        }
                                        else if (vg < 0 && vg >= 6)
                                        { Console.Write("Pilihan Tidak Ada !!"); }
                                        else { Message(); }
                                        break;
                                    case "5":
                                        for (int i = 0; i < hardisk.Length; i++)
                                        {
                                            Console.WriteLine((1 + i) + ".  " + hardisk[i]);
                                        }
                                        Console.Write("Pilih Jenis Hardisk : ");
                                        int hd = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Jumlah Barang : ");
                                        int jmlh_hd = Convert.ToInt32(Console.ReadLine());
                                        if (list_barang[4] == null && total_harga[4] == 0)
                                        {
                                            list_barang[4] = hardisk[hd - 1];
                                            total_harga[4] = harga_motherboard[hd - 1];
                                            jml[4] = jmlh_hd;
                                        }
                                        else if (hd < 0 && hd >= 6)
                                        { Console.Write("Pilihan Tidak Ada !!"); }
                                        else { Message(); }
                                        break;
                                    default:
                                        break;
                                }

                                break;
                            case "2":
                                if (list_barang != null)
                                {
                                    //call method
                                    int hasil_harga = Proses(total_harga, jml);
                                    double ppn = Persen(hasil_harga, 12);
                                    double diskon = Persen(hasil_harga, 5);
                                    double total_h = ((hasil_harga - ppn) + diskon);

                                    MessageMenu();
                                    for (int i = 0; i < 5; i++)
                                    {
                                        if (list_barang[i] == null)
                                        {
                                            Console.WriteLine("---Belum Terisi---");
                                        }
                                        else
                                        {
                                            Console.WriteLine((1 + i) + ".  " + list_barang[i] + " " + total_harga[i] + " " + jml[i]);

                                        }
                                    }
                                    Console.WriteLine("-------------------Keranjang-------------------");
                                    Console.WriteLine("Total Rp. " +total_h);
                                    Console.Write("Bayar Rp. ");
                                    int bayar = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("=================================================");
                                    Console.WriteLine("======Total  Harga Rp. " + hasil_harga + "\t======");
                                    Console.WriteLine("======PPN 12%      Rp. " + ppn + " \t======");
                                    Console.WriteLine("======Diskon 5%    Rp. " + diskon + " \t======");
                                    Console.WriteLine("======Total        Rp. " + total_h + "\t======");
                                    Console.WriteLine("======Pembayaran   Rp. " + bayar + "\t======" );
                                    Console.WriteLine("======Kembalian    Rp. " + (bayar - total_h) + "\t======");
                                    Console.WriteLine("=================================================");
                                } else
                                {
                                    Console.WriteLine("Keranjang Belum Terisi");
                                }
                                
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("3. Tutup");
                        ulang = "n";
                        break;
                    default:
                        Console.WriteLine("Pilihan Tidak Ada !!");
                        ulang = "n";
                        break;

                }

            } while (ulang == "y");
        }
    }
}