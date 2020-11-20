using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerikUpDown
{
    public partial class Form1 : Form
    {
        // Sınıf Field : alanları
        int R, G, B;
        float buyukluk = 8.0f;
        string yaziTipi = "Arial";
        FontStyle stil = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // numerik up down un değeri değişti olayı oldu.
            // label1 in fontunu büyüklüğünü ayarla
            //                cast tip dönüşüm
            buyukluk = (float)numericUpDown1.Value;
            Font font = new Font(yaziTipi, buyukluk, stil);  // enum numaralandırıcı  {izmir istanbul ankara} {0,1,2}
            label1.Font = font;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            G = (int)numericUpDown3.Value;
            label1.ForeColor = Color.FromArgb(R, G, B);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            B = (int)numericUpDown4.Value;
            label1.ForeColor = Color.FromArgb(R, G, B);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  form açılırken combobx1 de sistemde yüklü fontları aktaralım
            // font famly name ile doldurduk
            foreach (FontFamily ff in FontFamily.Families)
                comboBox1.Items.Add(ff.Name);
            for (int i = 0; i < 16; i++)
                comboBox2.Items.Add((FontStyle)i);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kombobox1 in seçilen öğesi değişince 
            // seçilen font family name yapalım label1 in fontunu
            yaziTipi = comboBox1.SelectedItem.ToString();
            Font font = new Font(yaziTipi,buyukluk,stil);
            label1.Font = font;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combobox2 seçilmiş indeks değişti. o halde seçilen yeni fontstili ile
            // font yeniden oluşturulup labela atansın
            stil = (FontStyle)comboBox2.SelectedIndex;
            Font font = new Font(yaziTipi, buyukluk, stil);
            label1.Font = font;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // txtboxın yazısı değişti olayının çağırıldığı metot
            label1.Text = textBox1.Text;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // numerik 2 değeri değişti. 
            // rengin kırmızı bileşenini ayarla
            //       cast tip dönüşümü
            R = (int)numericUpDown2.Value;
            label1.ForeColor = Color.FromArgb(R, G, B); // (int)numericUpDown3.Value, (int)numericUpDown4.Value böyle de olabilir.

        }
    }
}
