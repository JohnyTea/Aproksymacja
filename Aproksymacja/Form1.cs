using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aproksymacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void licz_button_Click(object sender, EventArgs e)
        {
            string[] textSplitX;
            string[] textSplitY;
            char[] znakiOdstepu = { ' ' };
            textSplitX = x_textBox.Text.Split(znakiOdstepu, StringSplitOptions.RemoveEmptyEntries);
            textSplitY = y_TextBox.Text.Split(znakiOdstepu, StringSplitOptions.RemoveEmptyEntries);
            double[] x = new double[textSplitX.Length];
            double[] y = new double[textSplitY.Length];

            for (int i = 0; i < textSplitX.Length; i++)
            {
                x[i] = double.Parse(textSplitX[i]);
                y[i] = double.Parse(textSplitY[i]);
            }

            double[] sumay;
            double[] sumax;
            double[,] macierz;

            if (stopien1_RB.Checked)
            {
                sumay = new double[2];
                sumax = new double[3];
                macierz = new double[2, 3];


            }
            else if (stopien2_RB.Checked)
            {
                sumay = new double[3];
                sumax = new double[5];
                macierz = new double[3, 4];

            }
            else {
                sumay = new double[4];
                sumax = new double[7];
                macierz = new double[4, 5];
            }

            for (int i = 0; i < sumax.Length; i++)
            {
                for (int j = 0; j < textSplitX.Length; j++)
                {
                    sumax[i] += Math.Pow(x[j], i);
                }
            }

            for (int i = 0; i < sumay.Length; i++)
            {
                for (int j = 0; j < textSplitY.Length; j++)
                {
                    sumay[i] += y[j] * Math.Pow(x[j], i);
                }
            }
            //czytanie danych i tworzenie macierza pierwsza kolumna [X,0] to wyraz wolny potem kolejne x. 
            //a11 w macierzu znajduje sie w [0,1] wyraz wolny tego rownania w [0,0], a35 w [2,5] wyraz wolny w [2,0];

            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                macierz[i, 0] = sumay[i];
            }

            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                for (int j = i, k = 1; j < i + macierz.GetLength(0); j++, k++)
                {
                    macierz[i, k] = sumax[j];
                }
            }

            double[] wyniki = RozwiazRownanie(macierz);

            double wynik = 0;
            double szukanyX = double.Parse(szukanyx_TextBox.Text);
            for (int i = 1; i < wyniki.Length; i++)
            {
                wynik += wyniki[i] * Math.Pow(szukanyX, i - 1);
            }
            wynik_TextBox.Text = String.Format("{0:0.##}", wynik);

        }

        private void zamienWiersz(int index, double[,] macierz)
        {
            Random rand = new Random();
            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                int los = rand.Next(0, macierz.GetLength(0));
                if (macierz[los, index + 1] != 0 && macierz[los, los + 1] != 0)
                {
                    for (int j = 0; j < macierz.GetLength(0); j++)
                    {
                        double bufor = macierz[index, j];
                        macierz[index, j] = macierz[los, j];
                        macierz[los, j] = bufor;
                    }
                }
            }
        }

        private bool sprawdzMacierz(double[,] macierz)
        {
            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                if (macierz[i, i + 1] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private double[] RozwiazRownanie(double[,] macierz)
        {

            while (!sprawdzMacierz(macierz))
            {
                for (int i = 0; i < macierz.GetLength(0); i++)
                {
                    if (macierz[i, i + 1] == 0)
                    {
                        zamienWiersz(i, macierz);
                    }
                }
            }

            double m;
            for (int k = 1; k < macierz.GetLength(1); k++) //redukowanie do 0 pod przekatna
            {
                for (int i = k; i < macierz.GetLength(0); i++)
                {
                    m = macierz[i, k] / macierz[k - 1, k];
                    for (int j = 0; j < macierz.GetLength(1); j++)
                    {
                        macierz[i, j] -= m * macierz[k - 1, j];
                    }
                }
            }

            double[] wyniki = new double[7];


            for (int i = macierz.GetLength(0) - 1; i >= 0; i--) //obliczanie kolejnych x od konca
            {
                wyniki[i + 1] = macierz[i, 0] / macierz[i, i + 1];
                for (int j = i + 2; j < macierz.GetLength(1); j++)
                {
                    wyniki[i + 1] -= macierz[i, j] * wyniki[j] / macierz[i, i + 1];
                }
            }

            return wyniki;
        }
    }
}
