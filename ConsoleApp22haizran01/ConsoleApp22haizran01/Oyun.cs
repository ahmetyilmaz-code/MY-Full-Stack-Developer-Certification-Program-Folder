using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22haizran01
{
    class Oyun
    {
        public static void Basla()
        {
            Console.Write("Oyuncu Adı : ");
            string oyuncuAdi = Console.ReadLine();
            Oyuncu oyuncu = new Oyuncu()
            {
                OyuncuAdi = oyuncuAdi,
            };
            Global.Oyuncu = oyuncu;
            YeniOyun();
        }
        private static void YeniOyun()
        {
            Global.OyunDurumu = OyunDurumu.DevamEdiyor;
            Global.Oyuncu.Can = 3;
            Random random = new Random();
            int index = random.Next(Global.Kelimeler.Length);
            string seciliKelime = Global.Kelimeler[index];
            while (seciliKelime == Global.SeciliKelime)
            {
                index = random.Next(Global.Kelimeler.Length);
                seciliKelime = Global.Kelimeler[index];
            }
            Global.SeciliKelime = seciliKelime;
            Global.AktifKelime = new string('_', seciliKelime.Length);
            Devam();
        }
        private static void Devam()
        {
            Ekran.EkraniYenile();
            HarfTahmin cevap = HarfTahminMi();
            Ekran.EkraniYenile();
            switch (cevap)
            {
                case HarfTahmin.Tahmin:
                    Tahmin();
                    break;
                case HarfTahmin.Harf:
                    Harf();
                    break;
            }
            OyunKontrol();
        }
        private static HarfTahmin HarfTahminMi()
        {
            Console.WriteLine("1-) Tahmin et\n2- Karakter Bul\n==> ");
            char cevap = Console.ReadKey().KeyChar;
            while (cevap != '1' && cevap != '2')
            {
                Console.WriteLine("\nSadece 1 veya 2 ye basınız..");
                cevap = Console.ReadKey().KeyChar;
            }
            HarfTahmin harTahmin = (HarfTahmin)Convert.ToInt32(cevap.ToString());
            return harTahmin;
        }
        private static void Tahmin()
        {
            Console.WriteLine("Tahminiz :");
            string tahmin = Console.ReadLine().ToUpper();
            if (Global.SeciliKelime == tahmin)
            {
                OyunDurumKontrol("Doğru Tahmin", true, HarfTahmin.Tahmin);
            }
            else
            {
                OyunDurumKontrol("Yanlış Tahmin", false);
            }
        }
        private static void Harf()
        {
            Console.WriteLine("Harf Tahmini: ");
            char karakter = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            int karakterVarMi = Global.AktifKelime.IndexOf(karakter);
            if (karakterVarMi > -1)
            {
                Global.Oyuncu.Can--;
                Ekran.Mesaj("Tekrar karakter girildi");
                if (Global.Oyuncu.Can == 0)
                {
                    Global.OyunDurumu = OyunDurumu.Kaybetti;
                }
                return;
            }
            char[] aktifKelimeKarakterleri = Global.AktifKelime.ToCharArray();
            bool dogruTercih = false;
            karakterVarMi = Global.SeciliKelime.IndexOf(karakter);
            if (karakterVarMi > -1)
            {
                for (int i = 0; i < Global.SeciliKelime.Length; i++)
                {
                    if (Global.SeciliKelime[i] == karakter)
                    {                       
                        aktifKelimeKarakterleri[i] = karakter;
                    }
                }
                dogruTercih = true;
            }
            if (dogruTercih)
            {
                Global.AktifKelime = new string(aktifKelimeKarakterleri);
                OyunDurumKontrol("Doğru...", true,HarfTahmin.Harf);
            }
            else
            {
                OyunDurumKontrol("Yanlış", false);
            }
        }
        private static void OyunKontrol()
        {
            switch (Global.OyunDurumu)
            {
                case OyunDurumu.DevamEdiyor:
                    Devam();
                    break;
                case OyunDurumu.Kazandi:
                    Ekran.Mesaj("Tebrikler Kazandiniz...");
                    DevamMiBittiMi();
                    break;
                case OyunDurumu.Kaybetti:
                    Ekran.Mesaj($"Kaybettiniz Oyun Bitti..\nDoğru kelime: {Global.SeciliKelime}");
                    DevamMiBittiMi();
                    break;                
            }
            if (Global.OyunDurumu != OyunDurumu.Bitti)
            {
                YeniOyun();
            }
        }
        private static void OyunDurumKontrol(string mesaj,bool kazandiMi,HarfTahmin harfTahmin = HarfTahmin.Harf) //bos
        {
            if (kazandiMi)
            {
                switch (harfTahmin)
                {
                    case HarfTahmin.Tahmin:
                        Global.OyunDurumu = OyunDurumu.Kazandi;
                        int taminPuanAdedi = Global.SeciliKelime.Length - Global.DogruTahminSayisi;
                        Global.Oyuncu.Puan += 2 * taminPuanAdedi;
                        break;
                    case HarfTahmin.Harf:
                        break;
                }
            }
            else
            {
                Global.Oyuncu.Can--;
                if(Global.Oyuncu.Can ==0)
                {
                    Global.OyunDurumu = OyunDurumu.Kaybetti;
                }
            }
            Ekran.Mesaj(mesaj);
        }
        private static void DevamMiBittiMi()
        {
            Console.WriteLine("Yeni oyun için herhangi bir tuşa basın. Çıkış yapmak için ESC tuşuna basın.");
            ConsoleKey cevap = Console.ReadKey().Key;
            if (cevap == ConsoleKey.Escape)
            {
                Global.OyunDurumu = OyunDurumu.Bitti;
                return;
            }
        }
    }
}
