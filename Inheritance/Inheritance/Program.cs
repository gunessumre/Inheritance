using System;

public abstract class BaseKisi
{
    
    public string Ad { get; set; }
    public string Soyad { get; set; }

    
    public abstract void bilgileriYazdir();
}

public class Ogrenci : BaseKisi
{
    
    public int ogrenciNumarasi { get; set; }

    
    public override void bilgileriYazdir()
    {
        Console.WriteLine("Öğrenci Bilgileri:");
        Console.WriteLine($"Öğrenci Numarası: {ogrenciNumarasi}, Ad: {Ad}, Soyad: {Soyad}");
    }
}

public class Ogretmen : BaseKisi
{
    
    public decimal Maas { get; set; }

    
    public override void bilgileriYazdir()
    {
        Console.WriteLine("Öğretmen Bilgileri:");
        Console.WriteLine($"Maaş: {Maas}$, Ad: {Ad}, Soyad: {Soyad}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Jack",
            Soyad = "London",
            ogrenciNumarasi = 2399
        };

       
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Martin",
            Soyad = "Eden",
            Maas = 4.000m
        };

        
        ogrenci.bilgileriYazdir();
        Console.WriteLine();
        ogretmen.bilgileriYazdir();
    }
}