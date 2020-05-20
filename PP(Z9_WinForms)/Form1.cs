using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Z9_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(enter_n.Text);
            int k = Int32.Parse(enter_k.Text);
            double[] arr = new double[n];
            Random rand = new Random();
            string rez = "";
            FileStream f = new FileStream("C:/Users/Алина/Desktop/t.dat", FileMode.Open);
            BinaryWriter fOut = new BinaryWriter(f);
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.NextDouble()+rand.Next(-10, 10);
                rez += "arr[" + i.ToString() + "] = " + arr[i]+"\n";
                fOut.Write(arr[i]);
            }
            fOut.Close();
            rez += "\n" + "Результат: " + "\n";
            f = new FileStream("C:/Users/Алина/Desktop/t.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long m = f.Length;
            for (long i = 8; i < m; i += 16)
            {
                f.Seek(i, SeekOrigin.Begin);
                arr[0] = fIn.ReadDouble();
                if (arr[0] > k)
                {
                    rez += arr[0] + "\n";
                }
            }
            arr_n.Text = rez;
            fIn.Close();
            f.Close();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("C:/Users/Алина/Desktop/text.txt");
            string rez = "";
            int n = 1;
            while (n < lines.Length)
            {
                rez += lines[n] + "\n";
                n += 2;
            }
            out_str.Text = rez;
        }
    }
}
