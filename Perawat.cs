using System;
using System.Collections.Generic;
using System.Text;

    public class Perawat : TenagaMedis
    {
        public Perawat(string nama, int umur, string spesialis) : base(nama, umur, spesialis) { }

    public void CekPasien()
    {
        Console.WriteLine($"Perawat {nama} sedang mengecek kondisi pasien");
    }

    public override void Aktivitas()
    {
        Console.WriteLine($"Perawat {nama} sedang mengganti infus");
    }
}
