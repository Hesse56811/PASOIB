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

namespace LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();

        private void шифрованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void создатьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void создатьКлючToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            if (comboBox1.Text == "режим электронной книги(ECB)")
            {
                label3.Text = "Режим ECB";
                DES.Mode = CipherMode.ECB;
            }
            if (comboBox1.Text == "режим сцепления блоков(CBC)"){    
                DES.Mode = CipherMode.CBC;
                label3.Text = "Режим CBC";
            }
            if (comboBox1.Text == "режим обратной связи по шифротексту(CFB)")
            {
                DES.Mode = CipherMode.CFB;
                label3.Text = "Режим CFB";

            }
            if (comboBox1.Text == "режим обратной связи по выходу(OFB)")
            {
                DES.Mode = CipherMode.OFB;
                label3.Text = "Режим OFB";

            }
            fs.Write(DES.Key, 0, DES.Key.Length);
            fs.Close();
        }

        private void прочестьИнформациюОКлючеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void зашифроватьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            saveFileDialog2.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            byte[] key = new byte[DES.Key.Length];
            fs.Read(key, 0, key.Length);
            fs.Close();
            label1.Text = "Ключ добавлен";
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog2.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }

        private void отобразитьШифрованнуюИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void отобразитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void saveFileDialog2_FileOk_1(object sender, CancelEventArgs e)
        {
            string text;
            text = richTextBox1.Text;
            FileStream fs = new FileStream(saveFileDialog2.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.Write(DES.IV, 0, DES.IV.Length);
            ICryptoTransform trans = DES.CreateEncryptor();
            CryptoStream cs = new CryptoStream(fs, trans, CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(text);
            sw.Flush();
            cs.FlushFinalBlock();
            sw.Close();
            fs.Close();
            label1.Text = "Информация зашифрована";
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog3.FileName, FileMode.Open, FileAccess.Read);
            fs.Seek(DES.IV.Length, SeekOrigin.Begin);
            StreamReader sr = new StreamReader(fs);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }

        private void расшифроватьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private void openFileDialog4_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog4.FileName, FileMode.Open, FileAccess.Read);
            byte[] iv = new byte[DES.IV.Length];
            fs.Read(iv, 0, iv.Length);
            DES.IV = iv;
            ICryptoTransform trans = DES.CreateDecryptor();
            CryptoStream cs = new CryptoStream(fs, trans, CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            richTextBox2.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }
    }
}
