using System;
using System.Collections.Generic;
using System.Text;

public class PasienDewasa : Pasien
{
    public PasienDewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }

    public void Konsultasi ()
    {
        Console.WriteLine($"{nama} sedang berkonsultasi kepada dokter.");
    }

    public override void Aktivitas()
    {
        Console.WriteLine($"{nama} sedang melakukan pembayaran obat di resepionis.");
    }
}
