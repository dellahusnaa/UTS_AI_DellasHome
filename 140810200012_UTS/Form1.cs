/*
Nama    : Della Fauziyyah
NPM     : 140810200012
Tanggal : 23 Oktober 2022
Deskripsi Program:  Della's House
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _140810200012_UTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            Graphics dc = this.CreateGraphics();
            this.Show();

            /*LANGIT*/
            Pen Sky = new Pen(Color.SkyBlue);
            SolidBrush cSky = new SolidBrush(Color.SkyBlue);
            dc.FillRectangle(cSky, 0, 0, 1000, 1000);
            dc.DrawRectangle(Sky, 0, 0, 1000, 1000);

            /*TANAH*/
            Pen P = new Pen(Color.SandyBrown, 5);
            SolidBrush brown = new SolidBrush(Color.SandyBrown);
            Rectangle R = new Rectangle(-20, 350, 1000, 400);
            dc.DrawEllipse(P,R);
            dc.FillEllipse(brown,R);

            /*TEMBOK*/
            Pen Tembok = new Pen(Color.DarkRed, 3);
            SolidBrush cream = new SolidBrush(Color.Coral);
            //Lantai 1
            dc.DrawRectangle(Tembok, 300, 300, 400, 170);
            dc.FillRectangle(cream, 300, 300, 400, 170);    
            //Lantai 2
            dc.DrawRectangle(Tembok, 300, 180, 110, 120);
            dc.FillRectangle(cream, 300, 180, 110, 120);

            /*ATAP*/
            Pen atap= new Pen(Color.DarkRed, 3);
            SolidBrush red = new SolidBrush(Color.DarkRed);
            //Atap lantai 1
            dc.FillRectangle(red, 413, 240, 237, 60);
            dc.DrawRectangle(atap, 413, 240, 237, 60);
            Point[] segitigaSiku =
            {
                new Point(650, 300), //ujung kiri
                new Point(700, 300), //ujung kanan
                new Point(650, 241), //pucuk
            };
            dc.FillPolygon(red, segitigaSiku);
            dc.DrawPolygon(atap, segitigaSiku);
            //Atap lantai 2
            Point[] segitigaSisi =
            {
                new Point(300, 180), //ujung kiri
                new Point(410, 180), //ujung kanan
                new Point(360, 80), //pucuk
            };
            dc.FillPolygon(red, segitigaSisi);
            dc.DrawPolygon(atap, segitigaSisi);

            /*JENDELA*/
            Pen Jendela = new Pen(Color.Red, 3);     
            //jendela lantai 1
            dc.DrawRectangle(Jendela, 340, 205, 45, 45); 
            dc.DrawRectangle(Jendela, 320, 205, 45, 45); 
            //jendela lantai 2          
            dc.DrawRectangle(Jendela, 605, 330, 45, 25); //atas
            dc.DrawRectangle(Jendela, 560, 330, 45, 25); //atas
            dc.DrawRectangle(Jendela, 515, 330, 45, 25); //atas
            dc.DrawRectangle(Jendela, 605, 355, 45, 25); //bawah
            dc.DrawRectangle(Jendela, 560, 355, 45, 25); //kanan
            dc.DrawRectangle(Jendela, 515, 355, 45, 25); //kanan

            /*PINTU*/
            //Jendela Pintu
            Pen Pintu = new Pen(Color.Red, 3);
            SolidBrush cPintu = new SolidBrush(Color.DarkRed);
            dc.FillRectangle(cPintu, 330, 370, 70, 100);
            dc.DrawRectangle(Pintu, 330, 370, 70, 100);  
            //Gagang Pintu
            Pen Pintu2 = new Pen(Color.Red, 3);
            SolidBrush cPintu2= new SolidBrush(Color.Red);
            dc.FillEllipse(cPintu2, 340, 415, 10, 10);
            dc.DrawEllipse(Pintu2, 340, 415, 10, 10);

            /*MATAHARI*/
            //Bulatan tengah
            Pen Matahari = new Pen(Color.Orange, 3);
            SolidBrush cMatahari = new SolidBrush(Color.Yellow);
            dc.FillEllipse(cMatahari, 710, 65, 50, 50);
            dc.DrawEllipse(Matahari, 710, 65, 50, 50);
            //Line
            Pen L = new Pen(Color.Orange, 3);
            //line tegak lurus//
            dc.DrawLine(L, 680, 90, 710, 90); 
            dc.DrawLine(L, 760, 90, 790, 90);
            dc.DrawLine(L, 735, 115, 735, 145);
            dc.DrawLine(L, 735, 35, 735, 65);
            //line miring//
            dc.DrawLine(L, 750, 110, 780, 133);            
            dc.DrawLine(L, 690, 133, 720, 110);
            dc.DrawLine(L, 750, 72, 780, 45);
            dc.DrawLine(L, 690, 45, 720, 72);

            /*JALAN*/
            Pen Jalan= new Pen(Color.DarkGray, 3);
            SolidBrush cJalan = new SolidBrush(Color.Gray);
            Point[] jalan =
            {
                new Point(400, 470), //ujung kiri
                new Point(100, 2300), //ujung kanan
                new Point(330, 470), //pucuk
            };
            dc.FillPolygon(cJalan, jalan);
            dc.DrawPolygon(Jalan, jalan);
     
            /*KESET*/
            // String
            String drawString = "Welcome";
            // Buat font dan brush.
            Font drawFont = new Font("Times New Roman", 8);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            // Buat rectangle keset
            float x = 335;
            float y = 475;
            float width = 60;
            float height = 13;
            RectangleF drawRect = new RectangleF(x, y, width, height);
            Pen Keset  = new Pen(Color.Brown);
            SolidBrush cKeset = new SolidBrush(Color.Brown);
            dc.FillRectangle(cKeset, x, y, width, height);
            dc.DrawRectangle(Keset, x, y, width, height);
            // Set format  string
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            // Menampilkan string
            dc.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);

            /*PAPAN NAMA*/
            Pen Gagang = new Pen(Color.SaddleBrown, 5);
            SolidBrush cGagang = new SolidBrush(Color.SaddleBrown);
            dc.FillRectangle(cGagang, 760, 400, 15, 60);
            dc.DrawRectangle(Gagang, 760, 400, 15, 60); 
            //Nama
            //string//
            String nama = "Della's House";
            //Buat font dan brush//
            Font font = new Font("Times New Roman", 8);
            SolidBrush brush = new SolidBrush(Color.White);
            // Buat rectangle keset//
            float x2 = 722;
            float y2 = 390;
            float width2 = 90;
            float height2 = 18;
            RectangleF kotak = new RectangleF(x2, y2, width2, height2);
            Pen Papan  = new Pen(Color.Brown);
            SolidBrush cPapan = new SolidBrush(Color.Brown);
            dc.FillRectangle(cPapan, x2, y2, width2, height2);
            dc.DrawRectangle(Papan, x2, y2, width2, height2);
            //Set format  string//
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            //Menampilkan string//
            dc.DrawString(nama, font, brush, kotak, format);

            /*POHON*/
            //Kayu
            Pen Kayu = new Pen(Color.SaddleBrown, 5);
            SolidBrush cKayu = new SolidBrush(Color.SaddleBrown);
            dc.FillRectangle(cKayu, 140, 250, 25, 200);
            dc.DrawRectangle(Kayu, 140, 250, 25, 200); 
            //Daun
            Pen Daun = new Pen(Color.DarkGreen, 3);
            SolidBrush cDaun = new SolidBrush(Color.ForestGreen);         
            dc.FillEllipse(cDaun, 65, 120, 170, 200);            
            dc.DrawEllipse(Daun, 65, 120, 170, 200);
            //Buah Apel
            Pen Buah= new Pen(Color.DarkRed, 3);
            SolidBrush cBuah = new SolidBrush(Color.DarkRed);         
            dc.FillEllipse(cBuah, 90, 190, 15, 20);
            dc.DrawEllipse(Buah, 90, 190, 15, 20);
            dc.FillEllipse(cBuah, 140, 220, 15, 20);
            dc.DrawEllipse(Buah, 140, 220, 15, 20);
            dc.FillEllipse(cBuah,170,150, 15, 20);
            dc.DrawEllipse(Buah, 170,150, 15, 20);
            dc.FillEllipse(cBuah,100,270, 15, 20);
            dc.DrawEllipse(Buah, 100,270, 15, 20);
            dc.FillEllipse(cBuah, 180, 200, 15, 20);
            dc.DrawEllipse(Buah, 180, 200, 15, 20);
            dc.FillEllipse(cBuah, 120, 146, 15, 20);
            dc.DrawEllipse(Buah, 120, 146, 15, 20);
            dc.FillEllipse(cBuah, 180, 250, 15, 20);
            dc.DrawEllipse(Buah, 180, 250, 15, 20);

            /*MASUKKAN GAMBAR BURUNG*/
            Image img = Image.FromFile(@"C:\Users\Acer\source\repos\140810200012_UTS\140810200012_UTS\burung1.png");
            dc.DrawImage(img, 500, 70, 40,30);
            dc.Dispose();   
        }
    }
}