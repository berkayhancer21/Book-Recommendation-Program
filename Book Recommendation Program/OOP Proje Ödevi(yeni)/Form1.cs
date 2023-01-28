namespace OOP_Proje_Ödevi_yeni_
{
    public partial class Form1 : Form 
    {
        public static Form1 Current;
        public Form1()
        {
            Current = this;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                    
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            //Fantastik Kitaplar KitaplarBilgi formuna aktarıldı.
            KitaplarBilgi obj = new KitaplarBilgi();
            obj.KitapAdi0 = "Yüzüklerin Efendisi";
            obj.KitapAdi1 = "Harry Potter ve Felsefe Taşı";
            obj.KitapAdi2 = "Hobbit";
            obj.KitapAdi3 = "Cadının Yüreği";
            obj.KitapAdi4 = "Hırsızların Dansı";
            obj.KitapAdi5 = "Karanlığın Şehri";
            obj.KitapAdi6 = "Köprü Krallığı";
            obj.KitapAdi7 = "Çiftçinin Savaşı";
            
            obj.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Polisiye Kitaplar KitaplarBilgi formuna aktarıldı.
            KitaplarBilgi obj = new KitaplarBilgi();
            obj.KitapAdi0 = "Doğu Ekspresinde Cinayet";
            obj.KitapAdi1 = "Beyoğlu Rapsodisi";
            obj.KitapAdi2 = "Hayvan Mezarlığı";
            obj.KitapAdi3 = "Siyah Kan";
            obj.KitapAdi4 = "Çırak";
            obj.KitapAdi5 = "Cehennem";
            obj.KitapAdi6 = "Siyah İnci";
            obj.KitapAdi7 = "Kuzuların Sessizliği";

            obj.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Bilim Kurgu Kitapları KitaplarBilgi formuna aktarıldı.
            KitaplarBilgi obj = new KitaplarBilgi();
            obj.KitapAdi0 = "Ben, Robot";
            obj.KitapAdi1 = "İşte Tanrılar";
            obj.KitapAdi2 = "Mülksüzler";
            obj.KitapAdi3 = "1984";
            obj.KitapAdi4 = "Sineklerin Tanrısı";
            obj.KitapAdi5 = "Kıyamet Kitabı";
            obj.KitapAdi6 = "Ender’in Oyunu";
            obj.KitapAdi7 = "Solaris";

            obj.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //Psikoloji Kitapları KitaplarBilgi formuna aktarıldı.
            KitaplarBilgi obj = new KitaplarBilgi();
            obj.KitapAdi0 = "Büyük Umutlar";
            obj.KitapAdi1 = "Fareler ve İnsanlar";
            obj.KitapAdi2 = "Kumarbaz";
            obj.KitapAdi3 = "Sol Ayağım";
            obj.KitapAdi4 = "Boş Ayna";
            obj.KitapAdi5 = "İnsan Olmak";
            obj.KitapAdi6 = "Seninle Başlamadı";
            obj.KitapAdi7 = "Başarıya Götüren Aile";

            obj.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Romantik Kitaplar KitaplarBilgi formuna aktarıldı.
            KitaplarBilgi obj = new KitaplarBilgi();
            obj.KitapAdi0 = "Anna Karenina";
            obj.KitapAdi1 = "Madame Bovary";
            obj.KitapAdi2 = "Kırmızı ve Siyah";
            obj.KitapAdi3 = "Genç Werther'in Acıları";
            obj.KitapAdi4 = "Vadideki Zambak";
            obj.KitapAdi5 = "Kolera Günlerinde Aşk";
            obj.KitapAdi6 = "İlk Aşk";
            obj.KitapAdi7 = "Bir Kadının Portresi";

            obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //Yapıcı metot çalıştırılarak private olan deger ifadesi sıfıra eşitlendi.
            Kitap nesne1 = new Kitap();

            int deger = Convert.ToInt32(textBox1.Text);
            //Yapıcı metot aşırı yüklenerek kullanıcıdan alınan değer,private olan deger özelliğine aktarıldı.
            
            Kitap nesne2=new Kitap(deger);

            SortedList<int, string> sort = new SortedList<int, string>();

            int[] fantastik = { 1026, 276, 336, 337, 528, 608, 496, 128 };
            int[] polisiye = { 256, 408, 399, 978, 384, 496, 215, 426 };
            int[] bilim_kurgu = { 240, 360, 344, 352, 262, 592, 295, 236 };
            int[] psikoloji = { 656, 128, 192, 189, 280, 184, 285, 143 };
            int[] romantik = { 1062, 396, 592, 128, 336, 398, 120, 678 };

            //Yapıcı metot aşırı yüklenerek bu diziler,Kitap sınıfında private olarak tanımlı olan dizilere aktarıldı.
            Kitap obj = new Kitap(fantastik, polisiye, bilim_kurgu, psikoloji, romantik);
            //Resimleri isimleriyle kullanmamıza yarayan dosya oluşturuldu.
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            if (comboBox1.Text == "Fantastik")
            {               
                sort.Add(1026, "Yüzüklerin Efendisi");
                sort.Add(276, "Harry Potter ve Felsefe Taşı");
                sort.Add(336, "Hobbit");
                sort.Add(337, "Cadının Yüreği");
                sort.Add(528, "Hırsızların Dansı");
                sort.Add(608, "Karanlığın Şehri");
                sort.Add(496, "Köprü Krallığı");
                sort.Add(128, "Çiftçinin Savaşı");

                int sonuc = obj.Yakin_Deger_Bul(obj.propFantastik, nesne2.propDeger);
                if(sort.ContainsKey(sonuc)==true)
                {
                    button7.Text = sort[sonuc];
                    button8.Text = sonuc.ToString();
                    //Bulunan sonuca göre hangi resmin picturebox'ta gösterilceği belirlendi.
                    if (sonuc == 1026)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f1.jpg";
                    if (sonuc == 276)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f2.jfif";
                    if (sonuc == 336)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f3.jpg";
                    if (sonuc == 337)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f4.jfif";
                    if (sonuc == 528)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f5.jfif";
                    if (sonuc == 608)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f6.jfif";
                    if (sonuc == 496)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f7.jfif";
                    if (sonuc == 128)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f8.jfif";

                }

            }

            if (comboBox1.Text == "Polisiye")
            {
                sort.Add(256, "Doğu Ekspresinde Cinayet");
                sort.Add(408, "Beyoğlu Rapsodisi");
                sort.Add(399, "Hayvan Mezarlığı");
                sort.Add(978, "Siyah Kan");
                sort.Add(384, "Çırak");
                sort.Add(496, "Cehennem");
                sort.Add(215, "Siyah İnci");
                sort.Add(426, "Kuzuların Sessizliği");

                int sonuc = obj.Yakin_Deger_Bul(obj.propPolisiye, nesne2.propDeger);
                if (sort.ContainsKey(sonuc) == true)
                {
                    button7.Text = sort[sonuc];
                    button8.Text = sonuc.ToString();
                    //Bulunan sonuca göre hangi resmin picturebox'ta gösterilceği belirlendi.
                    if (sonuc == 256)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po1.jpg";
                    if (sonuc == 408)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po2.jpg";
                    if (sonuc == 399)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po3.jpg";
                    if (sonuc == 978)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po4.jpg";
                    if (sonuc == 384)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po5.jfif";
                    if (sonuc == 496)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po6.jfif";
                    if (sonuc == 215)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po7.jpg";
                    if (sonuc == 426)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po8.jpg";
                }

            }

            if (comboBox1.Text == "Bilim Kurgu")
            {
                sort.Add(240, "Ben, Robot");
                sort.Add(360, "İşte Tanrılar");
                sort.Add(344, "Mülksüzler");
                sort.Add(352, "1984");
                sort.Add(262, "Sineklerin Tanrısı");
                sort.Add(592, "Kıyamet Kitabı");
                sort.Add(295, "Ender’in Oyunu");
                sort.Add(236, "Solaris");

                int sonuc = obj.Yakin_Deger_Bul(obj.propBilimKurgu, nesne2.propDeger);
                if (sort.ContainsKey(sonuc) == true)
                {
                    button7.Text = sort[sonuc];
                    button8.Text = sonuc.ToString();
                    //Bulunan sonuca göre hangi resmin picturebox'ta gösterilceği belirlendi.
                    if (sonuc == 240)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b1.jpg";
                    if (sonuc == 360)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b2.jfif";
                    if (sonuc == 344)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b3.jpg";
                    if (sonuc == 352)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b4.jpg";
                    if (sonuc == 262)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b5.jpg";
                    if (sonuc == 592)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b6.jfif";
                    if (sonuc == 295)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b7.jpg";
                    if (sonuc == 236)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b8.jpg";

                }

            }

            if (comboBox1.Text == "Psikoloji")
            {
                sort.Add(656, "Büyük Umutlar");
                sort.Add(128, "Fareler ve İnsanlar");
                sort.Add(192, "Kumarbaz");
                sort.Add(189, "Sol Ayağım");
                sort.Add(280, "Boş Ayna");
                sort.Add(184, "İnsan Olmak");
                sort.Add(285, "Seninle Başlamadı");
                sort.Add(143, "Başarıya Götüren Aile");

                int sonuc = obj.Yakin_Deger_Bul(obj.propPsikoloji, nesne2.propDeger);
                if (sort.ContainsKey(sonuc) == true)
                {
                    button7.Text = sort[sonuc];
                    button8.Text = sonuc.ToString();
                    //Bulunan sonuca göre hangi resmin picturebox'ta gösterilceği belirlendi.
                    if (sonuc == 656)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps1.jpg";
                    if (sonuc == 128)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps2.jpg";
                    if (sonuc == 192)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps3.jfif";
                    if (sonuc == 189)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps4.jpg";
                    if (sonuc == 280)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps5.jfif";
                    if (sonuc == 184)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps6.jpg";
                    if (sonuc == 285)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps7.jpg";
                    if (sonuc == 143)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps8.jfif";
                }

            }

            if (comboBox1.Text == "Romantik")
            {
                sort.Add(1062, "Anna Karenina");
                sort.Add(396, "Madame Bovary");
                sort.Add(592, "Kırmızı ve Siyah");
                sort.Add(128, "Genç Werther'in Acıları");
                sort.Add(336, "Vadideki Zambak");
                sort.Add(398, "Kolera Günlerinde Aşk");
                sort.Add(120, "İlk Aşk");
                sort.Add(678, "Bir Kadının Portresi");

                int sonuc = obj.Yakin_Deger_Bul(obj.propRomantik, nesne2.propDeger);
                if (sort.ContainsKey(sonuc) == true)
                {
                    button7.Text = sort[sonuc];
                    button8.Text = sonuc.ToString();
                    //Bulunan sonuca göre hangi resmin picturebox'ta gösterilceği belirlendi.
                    if (sonuc == 1062)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r1.jpg";
                    if (sonuc == 396)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r2.jpg";
                    if (sonuc == 592)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r3.jfif";
                    if (sonuc == 128)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r4.jfif";
                    if (sonuc == 336)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r5.jpg";
                    if (sonuc == 398)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r6.jfif";
                    if (sonuc == 120)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r7.jpg";
                    if (sonuc == 678)
                        pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r8.jpg";
                }

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Temizle butonu ile girilen değerler temizlendi.
            textBox1.Clear();
            comboBox1.Text = " ";         
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Çıkış butonuna basılarak çıkış yapmak istenilip istenmediği soruldu ve ona göre formun durumu ayarlandı.
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                ActiveForm.Close();
            }
            else if (sonuc == DialogResult.No)
            {
                ActiveForm.Show();
            }
        }
    }
}