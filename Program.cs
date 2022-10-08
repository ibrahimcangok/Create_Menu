using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            hata:
            Console.WriteLine("<<<Menü>>> \n 1)Çorbalar \n 2)Ana Yemekler \n 3)Mezeler \n 4)Salatalar \n 5)Tatlılar \n 6)İçecekler");
            Console.Write("Seçiminiz= ");
            string sec = Console.ReadLine();
            switch (sec)
            {
                case "1":
                    Console.WriteLine("<<<Çorbalar>>> \n 1)Soğuk Çorbalar \n 2)Sıcak Çorbalar");
                    Console.Write("Çorba Seçiminiz= ");
                    string corba = Console.ReadLine();
                    if (corba == "1")
                    {
                        Console.WriteLine(" 1)Ayran Çorbası \n 2)İncelten Çorba");
                        Console.Write("Seçiminiz= ");
                    }
                    string corbasec = Console.ReadLine();
                    if (corbasec == "1")
                        Console.WriteLine("Seçiminiz <<AYRAN ÇORBASI>> Hazırlanıyor...");
                    else if (corbasec == "2")
                        Console.WriteLine("Seçiminiz <<İNCELTEN ÇORBA>> Hazırlanıyor...");
                    if (corba == "2")
                    {
                        Console.WriteLine(" 1)Mercimek Çorbası \n 2)Tarhana Çorbası \n 3)Ezogelin Çorbası ");
                        Console.Write("Seçiminiz= ");
                    }
                    string corbasec2 = Console.ReadLine();
                    if (corbasec2 == "1")
                        Console.WriteLine("Seçiminiz <<MERCİMEK ÇORBASI>>  Hazırlanıyor...");
                    else if (corbasec2 == "2")
                        Console.WriteLine("Seçiminiz <<TARHANA ÇORBASI>> Hazırlanıyor...");
                    else if (corbasec2 == "3")
                        Console.WriteLine("Seçiminiz <<EZOGELİN ÇORBASI>> Hazırlanıyor...");
                    goto hata;
                case "2":
                    Console.WriteLine(" 1)Etli \n 2)Sebzeli");
                    Console.Write("Anayemek Seçiminiz= ");
                    string anasec = Console.ReadLine();
                    if (anasec == "1")
                    {
                        Console.WriteLine(" 1)Kağıt Kebabı \n 2)Lahmacun \n 3)Aide \n 4)Hunkarbegendi");
                        Console.Write("Seçiminiz= ");
                    }
                    string anasecim1 = Console.ReadLine();
                    if (anasecim1 == "1")
                        Console.WriteLine("Seçiminiz <<KAĞIT KEBABI>> Hazırlanıyor...");
                    else if (anasecim1 == "2")
                        Console.WriteLine("Seçiminiz <<LAHMACUN>> Hazırlanıyor...");
                    else if (anasecim1 == "3")
                        Console.WriteLine("Seçiminiz <<AİDE>> Hazırlanıyor...");
                    else if (anasecim1 == "4")
                        Console.WriteLine("Seçiminiz <<HUNKARBEGENDİ>> Hazırlanıyor...");
                    if (anasec == "2")
                    {
                        Console.WriteLine(" 1)Taze Fasulye \n 2)Kuru Fasulye \n 3)Mücver");
                        Console.Write("Seçiminiz= ");
                    }
                    string anasecim2 = Console.ReadLine();
                    if (anasecim2 == "1")
                        Console.WriteLine("Seçiminiz <<TAZE FASULYE>> Hazırlanıyor...");
                    else if (anasecim2 == "2")
                        Console.WriteLine("Seçiminiz <<KURU FASULYE>> Hazırlanıyor...");
                    else if (anasecim2 == "3")
                        Console.WriteLine("Seçiminiz <<MÜCVER>> Hazırlanıyor");
                    goto hata;
                case "3":
                    Console.WriteLine(" 1)Acılı \n 2)Acısız ");
                    Console.Write("Seçiminiz= ");
                    string mezesec = Console.ReadLine();
                    if (mezesec == "1")
                    {
                        Console.WriteLine(" 1)Şakşuka \n 2)Tarator SOS \n 3)Zeytinyağlı Fava");
                        Console.Write("Seçiminiz= ");
                    }
                    string mezesec2 = Console.ReadLine();
                    if (mezesec2 == "1")
                        Console.WriteLine("Seçiminiz <<ŞAKŞUKA>> Hazırlanıyor...");
                    else if (mezesec2 == "2")
                        Console.WriteLine("Seçiminiz <<TARATOR SOS>> Hazırlanıyor...");
                    else if (mezesec2 == "3")
                        Console.WriteLine("Seçiminiz <<ZEYTİNYAĞLI FAVA>> Hazırlanıyor...");
                    if (mezesec == "2")
                    {
                        Console.WriteLine(" 1)Haydari \n 2)Hibeş \n 3)Semizotu Salatası");
                        Console.Write("Seçiminiz= ");
                    }
                    string mezesec3 = Console.ReadLine();
                    if (mezesec3 == "1")
                        Console.WriteLine("Seçiminiz <<HAYDARİ>> Hazırlanıyor...");
                    else if (mezesec3 == "2")
                        Console.WriteLine("Seçiminiz <<HİBEŞ>> Hazırlanıyor...");
                    else if (mezesec3 == "3")
                        Console.WriteLine("Seçiminiz <<SEMİZOTU SALATASI>> Hazırlanıyor...");
                    goto hata;
                case "4":
                    Console.WriteLine("Salatalar \n 1)Çoban \n 2)Mevsim");
                    Console.Write("Seçiminiz= ");
                    string salatasec = Console.ReadLine();
                    if (salatasec == "1")
                        Console.WriteLine("Seçiminiz <<ÇOBAN SALATASI>> Hazırlanıyor...");
                    else if (salatasec == "2")
                        Console.WriteLine("Seçiminiz <<MEVSİM SALATASI>> Hazırlanıyor...");
                    goto hata;
                case "5":
                    Console.WriteLine("Tatlılar \n 1)Fırında Sütlaç \n 2)Kazandibi \n 3)Traliçe");
                    Console.Write("Seçiminiz= ");
                    string tatlisec = Console.ReadLine();
                    if (tatlisec == "1")
                        Console.WriteLine("Seçiminiz <<FIRINDA SÜTLAÇ>> Hazırlanıyor...");
                    else if (tatlisec == "2")
                        Console.WriteLine("Seçiminiz <<KAZANDİBİ>> Hazırlanıyor...");
                    else if (tatlisec == "3")
                        Console.WriteLine("Seçiminiz <<TRALİÇE>> Hazırlanıyor...");
                    goto hata;
                case "6":
                    Console.WriteLine(" İçecekler \n 1)Alkollü \n 2)Gazlı");
                    Console.Write("Seçiminiz= ");
                    string icsecim = Console.ReadLine();
                    if (icsecim == "1")
                    {
                        Console.WriteLine(" 1)Bira \n 2)Rakı \n 3)Roze Şarabı");
                        Console.Write("Seçiminiz= ");
                    }
                    string icsecim2 = Console.ReadLine();
                    if (icsecim2 == "1")
                        Console.WriteLine("Seçiminiz <<BİRA>> Buyruluyor...");
                    else if (icsecim2 == "2")
                        Console.WriteLine("Seçiminiz <<RAKI>> Buyruluyor...");
                    else if (icsecim2 == "3")
                        Console.WriteLine("Seçiminiz <<ROZE ŞARABI>> Buyruluyor...");
                    goto hata;
                default:
                    Console.WriteLine("Menüde Olmayan Bir Seçim Yaptınız..Lütfen Tekrar Deneyiniz!!! ");
                    goto hata;
            }
                        Console.ReadKey();
        }
    }
}
