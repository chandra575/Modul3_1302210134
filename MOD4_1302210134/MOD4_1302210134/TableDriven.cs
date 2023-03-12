using System;
using System.Collections.Generic;

class KodePos
{
    private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"A. Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public string getKodePos(string kelurahan)
    {
        if (tabelKodePos.ContainsKey(kelurahan))
        {
            return tabelKodePos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan.";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodepos = new KodePos();

        Console.WriteLine(kodepos.getKodePos("Batununggal"));
        Console.WriteLine(kodepos.getKodePos("A. Kujangsari"));
        Console.WriteLine(kodepos.getKodePos("Mengger"));
        Console.WriteLine(kodepos.getKodePos("Wates"));
        Console.WriteLine(kodepos.getKodePos("Cijaura"));
        Console.WriteLine(kodepos.getKodePos("Jatisari"));
        Console.WriteLine(kodepos.getKodePos("Margasari"));
        Console.WriteLine(kodepos.getKodePos("Sekejati"));
        Console.WriteLine(kodepos.getKodePos("Kebonwaru"));
        Console.WriteLine(kodepos.getKodePos("Maleer"));
        Console.WriteLine(kodepos.getKodePos("Samoja"));
        Console.WriteLine(kodepos.getKodePos("Sukabirus"));
    }
}

