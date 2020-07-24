using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleSteganography
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MSELabel.Text = ""; //temizle
            PSNRLabel.Text = "";

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "İmage Files (*.png, *.jpg) | *.png; *.jpg";
            openDialog.InitialDirectory = @"C:\Users\HP\Desktop\SimpleSteganography";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;
            }
            textBoxMessage.Text = "";
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxFilePath.Text);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < textBoxMessage.TextLength)
                    {
                        Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
                        Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
                        Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);

                        char letter = Convert.ToChar(textBoxMessage.Text.Substring(j, 1));      //substring = jden başlar 1 karakter alır
                        int value = Convert.ToInt32(letter);                                    //message harfi tek tek alınarak ascii koduna çevrilir
                        Console.WriteLine("letter : " + letter + " value : " + value);

                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value)); //mavi rengin içine gömüldü veri(B)
                    }

                    if (i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBoxMessage.TextLength));
                    }
                }
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "İmage Files (*.png, *.jpg) | *.png; *.jpg";
            saveFile.InitialDirectory = @"C:\Users\HP\Desktop\SimpleSteganography";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = saveFile.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;
                //PSNR_MSE(textBoxFilePath.Text);

                img.Save(textBoxFilePath.Text);
            }

            int boyut = img.Width * img.Height;  //resmin boyutunu öğrenme
            int bit = boyut * 3;                //saklanacak veri için olan yer
            mesajLabel.Text = bit + " bit gizleyebilirsiniz.";


            PSNR_MSE(textBoxFilePath.Text);
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxFilePath.Text);
            string message = "";

            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLength = lastpixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;
                    }
                }
            }

            textBoxMessage.Text = message;

            int length = message.Length; //metin uzunluğu
            int bit = length * 8;           //metnin bit değeri
            mesajLabel.Text = bit + " bit gizlenmiştir.";

        }



        private void PSNR_MSE(string ts)
        {
            Bitmap NImage = new Bitmap("C:/Users/HP/Desktop/SimpleSteganography/lena.png");
            Bitmap OImage = new Bitmap(ts);
            //if (OImage == NImage) { Console.WriteLine("Image"); }


            double PSNR = 0;
            double MSE = 0;
            double R = 0;
            double G = 0;
            double B = 0;

            for (int i = 0; i < OImage.Width; i++)
            {
                for (int j = 0; j < OImage.Height; j++)
                {
                    Color O = OImage.GetPixel(i, j);
                    Color N = NImage.GetPixel(i, j);

                    Color O1 = OImage.GetPixel(i, j);
                    int Ot = O1.R & Convert.ToInt32("00000000000000000000000000000001", 2);

                    Color N1 = NImage.GetPixel(i, j);
                    int Nt = N1.R & Convert.ToInt32("00000000000000000000000000000001", 2);

                    int RO, RN;
                    RO = OImage.GetPixel(i, j).R;
                    RN = NImage.GetPixel(i, j).R;

                    int GO, GN;
                    GO = OImage.GetPixel(i, j).G;
                    GN = NImage.GetPixel(i, j).G;

                    int BO, BN;
                    BO = OImage.GetPixel(i, j).B;
                    BN = NImage.GetPixel(i, j).B;


                    int RS = 0;
                    int GS = 0;
                    int BS = 0;

                    RS = RO - RN;
                    RS = RS * RS;
                    R += RS;

                    GS = GO - GN;
                    GS = GS * GS;
                    G += GS;

                    BS = BO - BN;
                    BS = BS * BS;
                    B += BS;

                }

            }

            double hw = (OImage.Width * OImage.Height);
            double sum = R + G + B;

            MSE = sum / hw;

            double S255 = 255 * 255;
            double S255_Mse = S255 / MSE;
            double Lo = Math.Log10(S255_Mse);

            PSNR = 20 * Lo;

            MSELabel.Text = MSE.ToString();
            PSNRLabel.Text = PSNR.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mesajLabel.Text = "0 karakter gizleyebilirsiniz.";
        }

        private void buttonRGB_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img); //Bitmap sınıfından bmp nesnesi tanımlandı
            int[] kirmizi = new int[256];
            int[] yesil = new int[256];
            int[] mavi = new int[256];

            for (int i = 0; i < bmp.Size.Height; i++)
            {
                for (int j = 0; j < bmp.Size.Width; j++)
                {
                    Color renk = bmp.GetPixel(i, j);
                    kirmizi[renk.R]++;
                    yesil[renk.G]++;
                    mavi[renk.B]++;
                }
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = ".";
            sfd.Title = "değerlerin kaydedileceği dosyayı belirtin";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fwriter = File.CreateText(sfd.FileName);
                for (int i = 0; i < 256; i++)
                {
                    fwriter.Write("R:" + kirmizi[i] + "| G:" + yesil[i] + "| B:" + mavi[i] + "\n");
                }
                fwriter.Close();
            }
        }
    }
}
