using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Proje_Ödevi_yeni_
{
    public class Kitap
    {
        //private özellikler tanımlandı.

        private int deger;

        private int[] Fantastik = new int[8];
        private int[] Polisiye = new int[8];
        private int[] Bilim_Kurgu = new int[8];
        private int[] Psikoloji = new int[8];
        private int[] Romantik = new int[8];

        //get-set blokları ile dışarıdan erişime açıldı.

        public int propDeger { get { return deger; } set { deger = value; } }   
        public int[] propFantastik { get { return Fantastik; } set { Fantastik = value; } }
        public int[] propPolisiye { get { return Polisiye; } set { Polisiye = value; } }
        public int[] propBilimKurgu { get { return Bilim_Kurgu; } set { Bilim_Kurgu = value; } }
        public int[] propPsikoloji { get { return Psikoloji; } set { Psikoloji = value; } }
        public int[] propRomantik { get { return Romantik; } set { Romantik = value; } }

        //Parametreli yapıcı metot ve parametresiz yapıcı metotlar tanımlandı.
        public Kitap(int[] fantastik, int[] polisiye, int[] bilim_Kurgu, int[] psikoloji, int[] romantik)
        {
            Fantastik = fantastik;
            Polisiye = polisiye;
            Bilim_Kurgu = bilim_Kurgu;
            Psikoloji = psikoloji;
            Romantik = romantik;
        }

        public Kitap()
        {
            deger = 0;
        }

        public Kitap(int deger)
        {
            this.deger = deger;
        }

        

        //Yakın değer bulma metodu oluşturuldu.
        public int Yakin_Deger_Bul(int[]dizi,int girilen_deger )
        {
            // Değişkenlerin tanımlanması
            int x, sayi, yakinlik, enyakin, i, enyakin2 = -1, yakinlik2 = -1;
            sayi = girilen_deger;  // “sayi”nın girilmesi
            x = dizi[0]; // İlk “x” değerinin girilmesi

            enyakin = x;   // İlk değere göre değişkenlere değer atanması
            yakinlik = Math.Abs(x - sayi);
            for (i = 0; i < 8; i++)
            {
                x = dizi[i];
                // Koşullar kontrol edilirken “yakinlik” ve “enyakin” değerlerin değiştirilmesi
                if (Math.Abs(x - sayi) < yakinlik)
                {
                    yakinlik = Math.Abs(x - sayi);
                    enyakin = x;
                }
                else if (Math.Abs(x - sayi) == yakinlik)
                {
                    if (x != enyakin)
                    {
                        yakinlik2 = yakinlik;
                        enyakin2 = x;
                    }
                }
            }
            if (yakinlik2 == yakinlik)
                return enyakin2;
            return enyakin;

        }

    }
}
