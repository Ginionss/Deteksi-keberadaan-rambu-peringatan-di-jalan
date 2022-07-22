using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;

//USING FRAMEWORK AForge.NET
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using System.IO;

namespace kuning

{
    public partial class Form1 : Form
    {
        private Bitmap citra_asli;
        private Bitmap citra_filter;
        public PictureBox citra_ekstraksiRambu = new PictureBox();
        public BlobCounter blobCounter = new BlobCounter();
        private bool ada_rambu;
        private bool cek = false;
        private bool detek;
        public SimpleShapeChecker shapeChecker;
        public List<IntPoint> cornersRectangle;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            cek = false;
            ada_rambu = false;
            openFileDialog1.Filter = "Pilih Gambar(*.jpg, *.png)|*.jpg;*.jpeg; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                pictureBox3.Image = null;
                citra_ekstraksiRambu.Image = null;
                pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
                citra_asli = (Bitmap)pictureBox1.Image.Clone();
                lb_ukuranAsli.Text = citra_asli.Width.ToString() + " x " + citra_asli.Height.ToString();
            }
        }
        private void button_rotate_Click(object sender, EventArgs e)
        {
            
            try
            {
                System.Drawing.Image newImage = pictureBox1.Image;
                newImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox1.Image = newImage;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message, "Pesan Eror");
            }

        }
        private void detectionButton_Click(object sender, EventArgs e)
        {
            test();
        }
        private void test() 
        {
            citra_asli = (Bitmap)pictureBox1.Image.Clone();
            detek = true;
            try
            {
                pictureBox3.Image = null;
                citra_ekstraksiRambu.Image = null;
                ColorFiltering(citra_asli);
                BLOB(citra_filter);
                if (ada_rambu == false && cek == false)
                {
                    cek = true;
                    ColorFiltering(citra_asli);
                    BLOB(citra_filter);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Pesan Eror");
            }
        }
        public void ColorFiltering(Bitmap image)
        {
            //inisialisasi batas atas dan batas bawah
            byte r = 255;
            byte g = 255;
            byte b = 60;
            byte r1 = 85;
            byte g1 = 85;
            byte b1 = 0;

            if (cek == true)
            {
                r1 = 75;
                g1 = 75;
                b = 75;
            }

            //menerapkan color filtering
            ColorFiltering filter = new ColorFiltering();
            // menerapkan parameter yang ditentukan
            filter.Red = new IntRange(r1, r);
            filter.Green = new IntRange(g1, g);
            filter.Blue = new IntRange(b1, b);
            filter.FillOutsideRange = true;
            // menerapkan color filtering pada gambar
               citra_filter = filter.Apply(image);


               red_textBox.Text = Convert.ToString(r);
               red_textBox1.Text = Convert.ToString(r1);
               green_textBox.Text = Convert.ToString(g);
               green_textBox1.Text = Convert.ToString(g1);
               blue_textBox.Text = Convert.ToString(b);
               blue_textBox1.Text = Convert.ToString(b1);
            
        }
        public void deteksi(Blob blob, int indeks, Bitmap image) 
        {
            //menentukan edge point
            List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blob);
            shapeChecker.IsQuadrilateral(edgePoints, out cornersRectangle);
            int corner = cornersRectangle.Count;
            int selang = blob.Rectangle.Location.X - blob.Rectangle.Location.Y;
            if (corner == 4 )
            {
                if (selang >= 0 && selang < 1500)
                {
                    ada_rambu = true;
                }
            } 
             string corner_jum = string.Format("{0}", cornersRectangle.Count);
             dataGridView1[0, indeks].Value = corner_jum;
             string sel = string.Format("{0}", selang);
             dataGridView1[1, indeks].Value = sel;
        }

        public void BLOB(Bitmap image)
        {
            //blob counter
            //mengaktifkan filter
            blobCounter.FilterBlobs = true;
            int ukuran1;
            int ukuran2;
            //menentukan ukuran minimal objek yang akan dideteksi
            if (citra_asli.Width < 1500 && citra_asli.Width >= 1000)
            {
                ukuran1 = 20;
                ukuran2 = 70;
                blobCounter.MinHeight = 80;
                blobCounter.MinWidth = 80;

            } if (citra_asli.Width < 1000)
            {
                ukuran1 = 10;
                ukuran2 = 50;
                blobCounter.MinHeight = 55;
                blobCounter.MinWidth = 55;
            }
            else
            {
                ukuran1 = 35;
                ukuran2 = 180;
                blobCounter.MinHeight = 155;
                blobCounter.MinWidth = 155;
            }
            //memproses informasi pada gambar
            blobCounter.ProcessImage(image);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            int jum_blob = blobs.Length;

            //menerapkan simple shape checker
            shapeChecker = new SimpleShapeChecker();
            Graphics g = Graphics.FromImage(image);
            Pen greenPen = new Pen(Color.Green, ukuran1);
            int jum = 0;
            dataGridView1.RowHeadersWidth = 130;
            dataGridView1.Rows.Add(jum_blob+1);
            int noBlob = 1;

            for (int i = 0; i < jum_blob; i++)
            {
                ada_rambu = false;
                dataGridView1.Rows[i].HeaderCell.Value = "Blob " + (i + 1);
                deteksi(blobs[i], i, image);
                if (ada_rambu == true)
                {

                    dataGridView1[2, i].Value = "Ya";
                    System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(
                    System.Drawing.Color.Red);
                    g.DrawPolygon(greenPen, ToPointsArray(cornersRectangle));
                    System.Drawing.Font font = new System.Drawing.Font("Segoe UI", ukuran2, FontStyle.Bold);
                    g.DrawString(noBlob.ToString(), font, brush, cornersRectangle[0].X, cornersRectangle[0].Y);
                    Crop cropImage = new Crop(new Rectangle(blobs[i].Rectangle.Location.X, 
                        blobs[i].Rectangle.Location.Y, blobs[i].Rectangle.Width, blobs[i].Rectangle.Height));
                    Bitmap cropResult = cropImage.Apply((Bitmap)pictureBox1.Image.Clone());
                    tampilcrop(cropResult, jum);
                    jum++;
                }
                else
                {
                    System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(
                    System.Drawing.Color.Red);
                    g.DrawPolygon(greenPen, ToPointsArray(cornersRectangle));
                    System.Drawing.Font font = new System.Drawing.Font("Segoe UI", ukuran2, FontStyle.Bold);
                    g.DrawString(noBlob.ToString(), font, brush, cornersRectangle[0].X, cornersRectangle[0].Y);
                    dataGridView1[2, i].Value = "Tidak";
                }

                noBlob++;
                
            }
            if (dataGridView1.RowCount == 1)
            {
                detek = false;
            } 
            greenPen.Dispose();
            g.Dispose();
            pictureBox3.Image = image;

            //string X = string.Format("{0}", blobs[i].Rectangle.Location.X);
            //dataGridView1[1, i].Value = X;
            //string Y = string.Format("{0}", blobs[i].Rectangle.Location.Y);
            //dataGridView1[2, i].Value = Y;
        }

        public void tampilcrop( Bitmap image, int jum)
        {
            
            int x1 = 105 * jum;
            int y1 = 10;

            if (jum >= 5)
            {
                x1 = 105 * (jum - 5);
                y1 = 110;
            }
            citra_ekstraksiRambu = new PictureBox
            {
                Name = "citra_ekstraksiRambu",
                Size = new Size(100, 100),
                Location = new System.Drawing.Point(x1, y1),
                SizeMode = PictureBoxSizeMode.Zoom,
            };
            panel1.Controls.Add(citra_ekstraksiRambu);
            citra_ekstraksiRambu.Image = image;
        }

        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new System.Drawing.Point(points[i].X, points[i].Y);
            }

            return array;
        }

       

    }
}