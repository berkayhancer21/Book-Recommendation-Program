using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Proje_Ödevi_yeni_
{
    public partial class KitaplarBilgi : Form
    {
        public static KitaplarBilgi Current;
        public KitaplarBilgi()
        {
            Current = this;
            InitializeComponent();
        }
        //Form1'den gelecek olan verileri KitaplarBilgi formuna aktarabilmek için değişkenler oluşturuldu.
        public string KitapAdi0 = " ";
        public string KitapAdi1 = " ";
        public string KitapAdi2 = " ";
        public string KitapAdi3 = " ";
        public string KitapAdi4 = " ";
        public string KitapAdi5 = " ";
        public string KitapAdi6 = " ";
        public string KitapAdi7 = " ";

        private void KitaplarBilgi_Load(object sender, EventArgs e)
        {
            //Form1'den gelen Kitap isimleri KitaplarBilgi formunda bulunan buttonlara aktarıldı. 
            button1.Text = KitapAdi0;
            button2.Text = KitapAdi1;
            button3.Text = KitapAdi2;
            button4.Text = KitapAdi3;
            button5.Text = KitapAdi4;
            button6.Text = KitapAdi5;
            button7.Text = KitapAdi6;
            button8.Text = KitapAdi7;
            //1. butonda yazılan isimlere göre koyulacak resimlerin belirlenmesi
            if (button1.Text == "Yüzüklerin Efendisi")
            {    
                pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f1.jpg";
            }
            if (button1.Text == "Doğu Ekspresinde Cinayet")
            {
                pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po1.jpg";
            }
            if (button1.Text == "Ben, Robot")
            {             
                pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b1.jpg";
            }
            if (button1.Text == "Büyük Umutlar")
            {              
                pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps1.jpg";
            }
            if (button1.Text == "Anna Karenina")
            {             
                pictureBox1.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r1.jpg";
            }
            //2. butonda yazılan isimlere göre koyulacak resimlerin belirlenmesi
            if (button2.Text == "Harry Potter ve Felsefe Taşı")
            {              
                pictureBox2.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f2.jfif";
            }
            if (button2.Text == "Beyoğlu Rapsodisi")
            {           
                pictureBox2.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po2.jpg";
            }
            if (button2.Text == "İşte Tanrılar")
            {             
                pictureBox2.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b2.jfif";
            }
            if (button2.Text == "Fareler ve İnsanlar")
            {              
                pictureBox2.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps2.jpg";
            }
            if (button2.Text == "Madame Bovary")
            {             
                pictureBox2.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r2.jpg";
            }
            //3. butonda yazılan isimlere göre koyulacak resimlerin belirlenmesi
            if (button3.Text == "Hobbit")
            {             
                pictureBox3.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f3.jpg";
            }
            if (button3.Text == "Hayvan Mezarlığı")
            {               
                pictureBox3.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po3.jpg";
            }
            if (button3.Text == "Mülksüzler")
            {              
                pictureBox3.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b3.jpg";
            }
            if (button3.Text == "Kumarbaz")
            {              
                pictureBox3.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps3.jfif";
            }
            if (button3.Text == "Kırmızı ve Siyah")
            {              
                pictureBox3.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r3.jfif";
            }
            //4. butonda yazılan isimlere göre koyulacak resimlerin belirlenmesi
            if (button4.Text == "Cadının Yüreği")
            {               
                pictureBox4.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f4.jfif";
            }
            if (button4.Text == "Siyah Kan")
            {            
                pictureBox4.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po4.jpg";
            }
            if (button4.Text == "1984")
            {              
                pictureBox4.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b4.jpg";
            }
            if (button4.Text == "Sol Ayağım")
            {              
                pictureBox4.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps4.jpg";
            }
            if (button4.Text == "Genç Werther'in Acıları")
            {              
                pictureBox4.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r4.jfif";
            }
            //5. butonda yazılan isimlere göre koyulacak resimlerin belirlenmesi
            if (button5.Text == "Hırsızların Dansı")
            {             
                pictureBox5.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f5.jfif";
            }
            if (button5.Text == "Çırak")
            {             
                pictureBox5.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po5.jfif";
            }
            if (button5.Text == "Sineklerin Tanrısı")
            {              
                pictureBox5.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b5.jpg";
            }
            if (button5.Text == "Boş Ayna")
            {            
                pictureBox5.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps5.jfif";
            }
            if (button5.Text == "Vadideki Zambak")
            {             
                pictureBox5.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r5.jpg";
            }
            //6. butonda yazılan isimlere göre koyulacak resimlerin belirlenmesi
            if (button6.Text == "Karanlığın Şehri")
            {             
                pictureBox6.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f6.jfif";
            }
            if (button6.Text == "Cehennem")
            {             
                pictureBox6.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po6.jfif";
            }
            if (button6.Text == "Kıyamet Kitabı")
            {            
                pictureBox6.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b6.jfif";
            }
            if (button6.Text == "İnsan Olmak")
            {              
                pictureBox6.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps6.jpg";
            }
            if (button6.Text == "Kolera Günlerinde Aşk")
            {              
                pictureBox6.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r6.jfif";
            }
            //7. butonda yazılan isimlere göre koyulacak resimlerin belirlenmesi
            if (button7.Text == "Köprü Krallığı")
            {            
                pictureBox7.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f7.jfif";
            }
            if (button7.Text == "Siyah İnci")
            {             
                pictureBox7.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po7.jpg";
            }
            if (button7.Text == "Ender’in Oyunu")
            {              
                pictureBox7.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b7.jpg";
            }
            if (button7.Text == "Seninle Başlamadı")
            {              
                pictureBox7.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps7.jpg";
            }
            if (button7.Text == "İlk Aşk")
            {              
                pictureBox7.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r7.jpg";
            }
            //8. butonda yazılan isimlere göre koyulacak resimlerin belirlenmesi
            if (button8.Text == "Çiftçinin Savaşı")
            {           
                pictureBox8.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\f8.jfif";
            }
            if (button8.Text == "Kuzuların Sessizliği")
            {              
                pictureBox8.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\po8.jpg";
            }
            if (button8.Text == "Solaris")
            {              
                pictureBox8.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\b8.jpg";
            }
            if (button8.Text == "Başarıya Götüren Aile")
            {                
                pictureBox8.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\ps8.jfif";
            }
            if (button8.Text == "Bir Kadının Portresi")
            {               
                pictureBox8.ImageLocation = System.AppContext.BaseDirectory + "\\Project Photos\\r8.jpg";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buton 1'e basılınca richtextbox'a yazılacak yazıların belirlenmesi.
            if(button1.Text== "Yüzüklerin Efendisi")
            {
            richTextBox1.Text = "Yazarı:J.R.R. Tolkien\nBasım Yılı:1954\nSayfa Sayısı:1026";          
            }
            if (button1.Text == "Doğu Ekspresinde Cinayet")
            {
                richTextBox1.Text = "Yazarı:Agatha Christie\nBasım Yılı:2006\nSayfa Sayısı:256";              
            }
            if (button1.Text == "Ben, Robot")
            {
                richTextBox1.Text = "Yazarı:Isaac Asimov \nBasım Yılı:1950\nSayfa Sayısı:240";              
            }
            if (button1.Text == "Büyük Umutlar")
            {
                richTextBox1.Text = "Yazarı:Charles Dickens \nBasım Yılı:1860\nSayfa Sayısı:656";            
            }
            if (button1.Text == "Anna Karenina")
            {
                richTextBox1.Text = "Yazarı:Lev Tolstoy\nBasım Yılı:1878\nSayfa Sayısı:1062";              
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Buton 2'ye basılınca richtextbox'a yazılacak yazıların belirlenmesi.
            if (button2.Text == "Harry Potter ve Felsefe Taşı")
            {
                richTextBox1.Text = "Yazarı:J.K. Rowling \nBasım Yılı:1997\nSayfa Sayısı:276";              
            }
            if (button2.Text == "Beyoğlu Rapsodisi")
            {
                richTextBox1.Text = "Yazarı:Ahmet Ümit \nBasım Yılı:2003\nSayfa Sayısı:408 ";             
            }
            if (button2.Text == "İşte Tanrılar")
            {
                richTextBox1.Text = "Yazarı:Isaac Asimov \nBasım Yılı:1972 \nSayfa Sayısı:360";             
            }
            if (button2.Text == "Fareler ve İnsanlar")
            {
                richTextBox1.Text = "Yazarı:John Steinbeck \nBasım Yılı:1937\nSayfa Sayısı:128 ";             
            }
            if (button2.Text == "Madame Bovary")
            {
                richTextBox1.Text = "Yazarı:Gustave Flaubert \nBasım Yılı:1856\nSayfa Sayısı:396";             
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Buton 3'e basılınca richtextbox'a yazılacak yazıların belirlenmesi.
            if (button3.Text == "Hobbit")
            {
                richTextBox1.Text = "Yazarı:J.R.R. Tolkien \nBasım Yılı:1856\nSayfa Sayısı:396";              
            }
            if (button3.Text == "Hayvan Mezarlığı")
            {
                richTextBox1.Text = "Yazarı:Stephen King \nBasım Yılı:1983\nSayfa Sayısı:399";              
            }
            if (button3.Text == "Mülksüzler")
            {
                richTextBox1.Text = "Yazarı:Ursula K. Le Guin \nBasım Yılı:1974\nSayfa Sayısı:344";               
            }
            if (button3.Text == "Kumarbaz")
            {
                richTextBox1.Text = "Yazarı:Fyodor Dostoyevski \nBasım Yılı:1867\nSayfa Sayısı:192 ";             
            }
            if (button3.Text == "Kırmızı ve Siyah")
            {
                richTextBox1.Text = "Yazarı:Stendhal \nBasım Yılı:1830\nSayfa Sayısı:592";              
            }


        }
        private void button4_Click(object sender, EventArgs e)
        {
            //Buton 4'e basılınca richtextbox'a yazılacak yazıların belirlenmesi.
            if (button4.Text == "Cadının Yüreği")
            {
                richTextBox1.Text = "Yazarı:Genevieve Gornichec \nBasım Yılı:2022\nSayfa Sayısı:337 ";          
            }
            if (button4.Text == "Siyah Kan")
            {
                richTextBox1.Text = "Yazarı:Jean-Christophe Grangé \nBasım Yılı:2004\nSayfa Sayısı:978 ";             
            }
            if (button4.Text == "1984")
            {
                richTextBox1.Text = "Yazarı:George Orwell \nBasım Yılı:1949\nSayfa Sayısı:352 ";            
            }
            if (button4.Text == "Sol Ayağım")
            {
                richTextBox1.Text = "Yazarı:Christy Brown \nBasım Yılı:1954\nSayfa Sayısı:189 ";           
            }
            if (button4.Text == "Genç Werther'in Acıları")
            {
                richTextBox1.Text = "Yazarı:Johann Wolfgang von Goethe \nBasım Yılı:1774 \nSayfa Sayısı:128 ";              
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Buton 5'e basılınca richtextbox'a yazılacak yazıların belirlenmesi.
            if (button5.Text == "Hırsızların Dansı")
            {
                richTextBox1.Text = "Yazarı:Mary E. Pearson \nBasım Yılı:2018\nSayfa Sayısı:528 ";               
            }
            if (button5.Text == "Çırak")
            {
                richTextBox1.Text = "Yazarı:Tess Gerritsen \nBasım Yılı:2008\nSayfa Sayısı:384 ";           
            }
            if (button5.Text == "Sineklerin Tanrısı")
            {
                richTextBox1.Text = "Yazarı:William Golding \nBasım Yılı:1954 \nSayfa Sayısı:262 ";               
            }
            if (button5.Text == "Boş Ayna")
            {
                richTextBox1.Text = "Yazarı:Karyl Mcbride \nBasım Yılı:2018\nSayfa Sayısı:280 ";             
            }
            if (button5.Text == "Vadideki Zambak")
            {
                richTextBox1.Text = "Yazarı:Honoré de Balzac \nBasım Yılı:1835\nSayfa Sayısı:336 ";               
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            //Buton 6'ya basılınca richtextbox'a yazılacak yazıların belirlenmesi.
            if (button6.Text == "Karanlığın Şehri")
            {
                richTextBox1.Text = "Yazarı:Sule Avlamaz \nBasım Yılı:2022\nSayfa Sayısı:608 ";              
            }
            if (button6.Text == "Cehennem")
            {
                richTextBox1.Text = "Yazarı:Dan Brown  \nBasım Yılı:2013\nSayfa Sayısı:496 ";            
            }
            if (button6.Text == "Kıyamet Kitabı")
            {
                richTextBox1.Text = "Yazarı:Connie Willis \nBasım Yılı:2013\nSayfa Sayısı:592 ";              
            }
            if (button6.Text == "İnsan Olmak")
            {
                richTextBox1.Text = "Yazarı:Engin Geçtan \nBasım Yılı:1983\nSayfa Sayısı:184 ";              
            }
            if (button6.Text == "Kolera Günlerinde Aşk")
            {
                richTextBox1.Text = "Yazarı:Gabriel García Márquez \nBasım Yılı:1985\nSayfa Sayısı:398 ";            
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            //Buton 7'ye basılınca richtextbox'a yazılacak yazıların belirlenmesi.
            if (button7.Text == "Köprü Krallığı")
            {
                richTextBox1.Text = "Yazarı:Danielle L. Jensen  \nBasım Yılı:2018\nSayfa Sayısı:496 ";              
            }
            if (button7.Text == "Siyah İnci")
            {
                richTextBox1.Text = "Yazarı:Anna Sewell  \nBasım Yılı:1877 \nSayfa Sayısı:215 ";             
            }
            if (button7.Text == "Ender’in Oyunu")
            {
                richTextBox1.Text = "Yazarı:Orson Scott Card  \nBasım Yılı:1985\nSayfa Sayısı:295 ";              
            }
            if (button7.Text == "Seninle Başlamadı")
            {
                richTextBox1.Text = "Yazarı:Mark Wolynn  \nBasım Yılı:2016\nSayfa Sayısı:285 ";              
            }
            if (button7.Text == "İlk Aşk")
            {
                richTextBox1.Text = "Yazarı:İvan Turgenyev \nBasım Yılı:2001\nSayfa Sayısı:120 ";             
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            //Buton 8'e basılınca richtextbox'a yazılacak yazıların belirlenmesi.
            if (button8.Text == "Çiftçinin Savaşı")
            {
                richTextBox1.Text = "Yazarı:Elise Kova  \nBasım Yılı:2022\nSayfa Sayısı:128 ";              
            }
            if (button8.Text == "Kuzuların Sessizliği")
            {
                richTextBox1.Text = "Yazarı:Thomas Harris  \nBasım Yılı:1991\nSayfa Sayısı:426 ";           
            }
            if (button8.Text == "Solaris")
            {
                richTextBox1.Text = "Yazarı:Stanisław Lem  \nBasım Yılı:1961 \nSayfa Sayısı:236 ";              
            }
            if (button8.Text == "Başarıya Götüren Aile")
            {
                richTextBox1.Text = "Yazarı:Doğan Cüceloğlu  \nBasım Yılı:2006\nSayfa Sayısı:143 ";           
            }
            if (button8.Text == "Bir Kadının Portresi")
            {
                richTextBox1.Text = "Yazarı:Henry James  \nBasım Yılı:2016\nSayfa Sayısı:678 ";              
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Geri tuşuna tıklanarak bu formdan ilk forma geçiş sağlandı.
            Hide();
            Form1.Current.Show();
        }
    }
}
