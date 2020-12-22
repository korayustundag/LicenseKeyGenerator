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

namespace LicenseKeyGenerator
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string Generate()
        {
            string a = "";
            for (int i = 0; i < 5; i++)
            {
                a += RandomString(5) + "-";
            }
            return a.Remove(a.Length - 1);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koray USTUNDAG -  https://github.com/korayustundag", "About");
        }

        private void pieceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxKeys.Items.Add(Generate());
        }

        private void pieceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                listBoxKeys.Items.Add(Generate());
            }
        }

        private void pieceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                listBoxKeys.Items.Add(Generate());
            }
        }

        private void pieceToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 500; i++)
            {
                listBoxKeys.Items.Add(Generate());
            }
        }

        private void pieceToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                listBoxKeys.Items.Add(Generate());
            }
        }

        private void pieceToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5000; i++)
            {
                listBoxKeys.Items.Add(Generate());
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Text File|*.txt";
            if (s.ShowDialog() == DialogResult.OK)
            {
                string myFile = "";
                foreach (string item in listBoxKeys.Items)
                {
                    myFile += item + Environment.NewLine;
                }
                File.WriteAllText(s.FileName, myFile);
                MessageBox.Show("The generated keys are saved.", "License Key Generator");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
