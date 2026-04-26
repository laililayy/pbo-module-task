RumahSakit rsMelati = new RumahSakit();  

Dokter d1 = new Dokter("Dr. Rosa", 30, "Umum");
PasienAnak pa1 = new PasienAnak("Rizka", 7, "Maagh");
Perawat pr1 = new Perawat("Nina", 30, "Perawat ICU");
PasienDewasa pd1 = new PasienDewasa("Aril", 40, "Asma");
Orang tm1 = new TenagaMedis("Susi", 35, "ICU");
Pasien p = new Pasien("Alwi", 20, "Types");

rsMelati.TambahOrang(d1);
rsMelati.TambahOrang(pa1);
rsMelati.TambahOrang(pd1);
rsMelati.TambahOrang(pr1);

rsMelati.DaftarOrang();
Console.WriteLine("=== AKTIVITAS ===");
tm1.Aktivitas();
p.Aktivitas();
d1.Aktivitas();
pa1.Aktivitas();
pd1.Aktivitas();

Console.WriteLine("=== METHOD ===");
p.CekKeluhan();
d1.CekSpesialis();
d1.Diagnosa();
pa1.Menangis();
pd1.Konsultasi();
pr1.CekPasien();



