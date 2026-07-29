using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22haizran01
{
    static class Global
    {
        public static readonly string[] Kelimeler =
        {
            "ELMA", "ARMUT", "KİRAZ", "MUZ", "ÇİLEK", "PORTAKAL", "MANDALİNA", "ÜZÜM", "KARPUZ", "KAVUN",
            "MASA", "KAPI", "PENCERE", "SANDALYE", "TELEFON", "BİLGİSAYAR", "TELEVİZYON", "KİTAP", "DEFTER", "KALEM",
            "ARABA", "OTOBÜS", "UÇAK", "GEMİ", "TREN", "BİSİKLET", "MOTOSİKLET", "KAMYON", "TRAKTÖR", "HELİKOPTER",
            "KEDİ", "KÖPEK", "KUŞ", "BALIK", "AT", "İNEK", "KOYUN", "TAVUK", "ASLAN", "KAPLAN",
            "DENİZ", "ORMAN", "DAĞ", "NEHİR", "GÖL", "ŞELALE", "BULUT", "YAĞMUR", "KAR", "RÜZGAR",
            "ANKARA", "İSTANBUL", "İZMİR", "ANTALYA", "BURSA", "ADANA", "TRABZON", "ERZURUM", "DİYARBAKIR", "VAN",
            "GÖZLÜK", "SAAT", "ŞAPKA", "KAZAK", "MONT", "AYAKKABI", "ÇANTA", "ELDİVEN", "ATKI", "ÇORAP",
            "DOKTOR", "MÜHENDİS", "ÖĞRETMEN", "AVUKAT", "POLİS", "HEMŞİRE", "MİMAR", "AŞÇI", "BERBER", "TERZİ",
            "FUTBOL", "BASKETBOL", "VOLEYBOL", "TENİS", "YÜZME", "KOŞU", "SATRANÇ", "GÜREŞ", "BOKS", "HALTER",
            "GÜNEŞ", "AY", "YILDIZ", "GEZEGEN", "UZAY", "DÜNYA", "GALAKSİ", "METEOR", "ROKET", "ASTRONOT"
         };
        public static Oyuncu Oyuncu { get; set; }
        public static OyunDurumu OyunDurumu { get; set; }
        public static string SeciliKelime { get; set; }
        public static string AktifKelime { get; set; }

        public static int DogruTahminSayisi { get; set; }


    }
}
