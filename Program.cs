using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {


        Selamla();
        BaslangicEkrani();
        HasarVer("Goblin", 20);
        int gelenSayi = KritikVurusYap(50);
        Console.WriteLine("Kritik vuruş sonucu: " + gelenSayi);
        HasarVer("Ejderha", 50);       
        BitisEkrani();

    }
    static int KritikVurusYap(int safHasar)
    {
        int sonuc = safHasar * 2;
        return sonuc;
    }
    static void HasarVer(string dusmanAdi, int hasarMik)
    {
        Console.WriteLine(dusmanAdi + " sana saldirdi ve " + hasarMik + " hasar verdi!");
    }
    static void Selamla()
    {
        Console.WriteLine("Welcome to the system!");
        Console.WriteLine("----------------------");
    }
    static void BaslangicEkrani()
    {
        Console.WriteLine("Test Oyunu, Version: 1.13. Baslamak icin enter a basiniz.");
        Console.ReadLine();
    }
    static void BitisEkrani()
    {
        Console.WriteLine("Oyun bitti (yazilimci: askei)");
    }
}
