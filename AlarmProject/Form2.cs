using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmProject
{
    public partial class Form2 : Form
    {
        Alarm alarm = new Alarm();
        private bool isDragging = false;
        private Point lastCursorPos;
        private Point lastFormPos;
        public Form2()
        {
            InitializeComponent();
        }
        bool SayiMi(string text)
        {
            int s = 0;
            foreach (char chr in text)
            {
                s++;
                if (s == 3) continue;
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int t = 0;
            string d = listBox1.SelectedItem.ToString();
            int i = listBox1.SelectedIndex;
            if (SayiMi(d))
            {

                string h1 = "",h2="", m1 = "",m2="";
                foreach (var k in d)
                {
                    t++;
                    if (t == 1)
                         h1= k.ToString();
                    if (t == 2) h2 = k.ToString();
                    if (t == 3)
                        continue;
                    if (t == 4)
                        m1 = k.ToString();
                    if (t==5)
                    
                        m2 = k.ToString();
                    
                
                }

                MessageBox.Show("H " + h1 + " "+h2+"\nM " + m1+" "+m2);
                Form3 fr3 = new Form3(int.Parse(h1), int.Parse(h2), int.Parse(m1), int.Parse(m2), i);
                fr3.BUT_add.Text = "Düzenle";
                fr3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen doğru biçimde saat seçiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BUT_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.BUT_add.Text = "Ekle";
            fr3.ShowDialog();
        }

       

        private void Form2_MouseHover(object sender, EventArgs e)
        {
            Alarm al = new Alarm();
            listBox1.Items.Clear();
            foreach (var alarm in al.alss)
            {
                listBox1.Items.Add(alarm);

            }
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            Alarm al = new Alarm();
            listBox1.Items.Clear();
            foreach (var alarm in al.alss)
            {
                listBox1.Items.Add(alarm);

            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPos = Cursor.Position;
                lastFormPos = this.Location;
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursorPos = Cursor.Position;
                int deltaX = currentCursorPos.X - lastCursorPos.X;
                int deltaY = currentCursorPos.Y - lastCursorPos.Y;
                this.Location = new Point(lastFormPos.X + deltaX, lastFormPos.Y + deltaY);
            }
        }

     
    }
}
