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

namespace magicsquaregenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            auth auth_form = new auth();
            auth_form.ShowDialog();
        }

        private TextBox GetMagicSize()
        {
            return magicSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("Введите размерность квадрата: ");
            int n = int.Parse(magicSize.Text);

            int[,] magicSquare = GenerateMagicSquare(n);

            Console.WriteLine("Сгенерированный магический квадрат:");
            PrintMagicSquare(magicSquare);

            string fileName = "magic_square.png";
            SaveMagicSquareImage(magicSquare, fileName);

            Console.WriteLine($"Квадрат сохранен в файле {fileName}.");

            // Открываем файл с помощью системного приложения по умолчанию
            System.Diagnostics.Process.Start(fileName);
        }

        static int[,] GenerateMagicSquare(int n)
        {
            int[,] magicSquare = new int[n, n];

            int row = n - 1;
            int col = n / 2;
            magicSquare[row, col] = 1;

            for (int i = 2; i <= n * n; i++)
            {
                if (magicSquare[(row + 1) % n, (col + 1) % n] == 0)
                {
                    row = (row + 1) % n;
                    col = (col + 1) % n;
                }
                else
                {
                    row = (row - 1 + n) % n;
                }

                magicSquare[row, col] = i;
            }

            return magicSquare;
        }

        static void PrintMagicSquare(int[,] magicSquare)
        {
            int n = magicSquare.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{magicSquare[i, j],-4}");
                }
                Console.WriteLine();
            }
        }

        static void SaveMagicSquareImage(int[,] magicSquare, string fileName)
        {
            int n = magicSquare.GetLength(0);
            int imageSize = 50;
            Bitmap image = new Bitmap(n * imageSize, n * imageSize);

            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.Clear(Color.White);

                using (Font font = new Font(FontFamily.GenericSansSerif, 14))
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            string number = magicSquare[i, j].ToString();
                            SizeF textSize = graphics.MeasureString(number, font);

                            float x = j * imageSize + (imageSize - textSize.Width) / 2;
                            float y = i * imageSize + (imageSize - textSize.Height) / 2;

                            graphics.DrawString(number, font, Brushes.Black, x, y);
                        }
                    }
                }
            }

            image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}