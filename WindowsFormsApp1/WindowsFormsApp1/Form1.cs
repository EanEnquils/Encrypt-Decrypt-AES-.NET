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
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form


    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int bSize = 128;

        public Form1()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pobieszbutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FileNameText.Text = openFileDialog1.FileName;

            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            richText.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();

        }

        private void Szyfrowanie_Click(object sender, EventArgs e)
        {
            //Algoritm Szyfrowania
            if (KeyText.Text == "")
                return;
            byte[] bytes = Encoding.Unicode.GetBytes(richText.Text);

            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.BlockSize = bSize;
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(KeyText.Text));
            crypt.IV = IV;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }
                richText.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        private void Deszyfrowanie_Click(object sender, EventArgs e)
        {
            //Algoritm Deszyfrowania
            if (KeyText.Text == "")
                return;
            byte[] bytes = Convert.FromBase64String(richText.Text);

            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();

            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(KeyText.Text));
            crypt.IV = IV;
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    richText.Text = Encoding.Unicode.GetString(decryptedBytes);
                }
              
            }

        }

        private void Zapiszjako_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(richText.Text);
            sw.Close();
            fs.Close();
        }
    }
}
