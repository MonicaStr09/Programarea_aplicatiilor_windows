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

namespace Stirbescu_Monica_Proiect_Paw
{
    public partial class Form3 : Form
    {
        int y = 10;
        int inregistrari = 10;

        List<Rezervare> lista2;
        public Form3(List<Rezervare> listarezervari)
        {
            InitializeComponent();
            lista2 = listarezervari;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAfisareInregistrari_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Rezervare p in lista2)
            {
                textBox1.Text += p.ToString() + Environment.NewLine;
            }
        }

        private void buttonCitireInregistrari_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void buttonSalvareInregistrari_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }
        }

        //DRAG & DROP

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                 if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            Graphics g = Graphics.FromHwnd((panel1.Handle));
            g.DrawString(text, this.Font, new SolidBrush(Color.Blue), 10, y);
            y += 20;
            if (y > 20) //panel1.Height)
            {

                panel1.Invalidate();
                y = 10;
            }
            if (e.Effect == DragDropEffects.Move)
            {
                textBox1.Clear();

            }


            saveFileDialog1.Filter = "(*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();

            }

        }

        private void meniulPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void vizualizareGraficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

    }
}
