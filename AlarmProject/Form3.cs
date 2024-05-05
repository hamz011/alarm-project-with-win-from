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
    public partial class Form3 : Form
    {
        int H1, H2, M1, M2; int H1a, H2a, M1a, M2a, ind = 0;
        bool isNew;
        Alarm alarm = new Alarm();
        private bool isDragging = false;
        private Point lastCursorPos;
        private Point lastFormPos;
        public Form3()
        {
            InitializeComponent();
            isNew = true;
        }

        public Form3(int h1, int h2, int m1, int m2, int i)
        {
            H1a = h1; H2a = h2;
            M1a = m1; M2a = m2;
            ind = i;
            isNew = false;

            InitializeComponent();
        }

        private void BUT_hour1_Click(object sender, EventArgs e)
        {
            if (isNew)
            {

                if (H1 >= 0 && H1 < 2)
                {
                    H1 = H1 + 1;
                    Lab_hour1.Text = H1.ToString();
                }
                if (H1 == 2)
                {
                    if (H2 < 3)
                        H2 += 1;
                    else
                        H2 = 3;
                    Lab_hour2.Text = H2.ToString();
                }
            }
            else
            {

                if (H1a >= 0 && H1a < 2)
                {
                    H1a = H1a + 1;
                    Lab_hour1.Text = H1a.ToString();
                }
                if (H1a == 2)
                {
                    if (H2a < 3)
                        H2a += 1;
                    else
                        H2a = 3;
                    Lab_hour2.Text = H2a.ToString();
                }
            }
        }
        private void BUT_hour1a_Click(object sender, EventArgs e)
        {
            if (isNew)
            {

                if (H1 > 0 && H1 <= 2)
                {
                    H1 = H1 - 1;
                    Lab_hour1.Text = H1.ToString();
                }
            }
            else
            {

                if (H1a > 0 && H1a <= 2)
                {
                    H1a = H1a - 1;
                    Lab_hour1.Text = H1a.ToString();
                }
            }
        }



        private void BUT_hour2_Click(object sender, EventArgs e)
        {
            if (isNew)
            {

                if (H2 >= 0 && H2 < 9)
                {
                    if (H1 == 2)
                    {
                        if (H2 < 3)
                            H2 += 1;
                    }
                    else
                        H2 += 1;
                    Lab_hour2.Text = H2.ToString();
                }
            }
            else
            {

                if (H2a >= 0 && H2a < 9)
                {
                    if (H1a == 2)
                    {
                        if (H2a < 3)
                            H2a += 1;
                    }
                    else
                        H2a += 1;
                    Lab_hour2.Text = H2a.ToString();
                }
            }
        }
        private void BUT_hour2a_Click(object sender, EventArgs e)
        {

            if (isNew)
            {
                if (H2 > 0 && H2 <= 9)
                {
                    H2 = H2 - 1;
                    Lab_hour2.Text = H2.ToString();
                }
            }
            else
            {


                if (H2a > 0 && H2a <= 9)
                {
                    H2a = H2a - 1;
                    Lab_hour2.Text = H2a.ToString();
                }
            }
        }




        private void BUT_minute1_Click(object sender, EventArgs e)
        {
            if (isNew)
            {

                if (M1 >= 0 && M1 < 6)
                {
                    if (M1 == 5)
                    {
                        if (M2 < 9)
                            M2 += 1;


                        Lab_minute2.Text = M2.ToString();
                    }
                    else
                        M1 = M1 + 1;
                    Lab_minute1.Text = M1.ToString();
                }
            }
            else
            {

                if (M1a >= 0 && M1a < 6)
                {
                    if (M1a == 5)
                    {
                        if (M2a < 9)
                            M2a += 1;


                        Lab_minute2.Text = M2a.ToString();
                    }
                    else
                        M1a = M1a + 1;
                    Lab_minute1.Text = M1a.ToString();
                }
            }
        }
        private void BUT_minute1a_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                if (M1 > 0 && M1 <= 6)
                {
                    M1 = M1 - 1;
                    Lab_minute1.Text = M1.ToString();
                }
            }
            else
            {

                if (M1a > 0 && M1a <= 6)
                {
                    M1a = M1a - 1;
                    Lab_minute1.Text = M1a.ToString();
                }
            }
        }



        private void BUT_minute2_Click(object sender, EventArgs e)
        {
            if (isNew)
            {

                if (M2 >= 0 && M2 < 9)
                {
                    if (M1 == 6)
                    {
                        M2 = 0;
                    }
                    else
                        M2 += 1;
                    Lab_minute2.Text = M2.ToString();
                }
            }
            else
            {

                if (M2a >= 0 && M2a < 9)
                {
                    if (M1a == 6)
                    {
                        M2a = 0;
                    }
                    else
                        M2a += 1;
                    Lab_minute2.Text = M2a.ToString();
                }
            }
        }
        private void BUT_minute2a_Click(object sender, EventArgs e)
        {
            if (isNew)
            {

                if (M2 > 0 && M2 <= 9)
                {
                    M2 = M2 - 1;
                    Lab_minute2.Text = M2.ToString();
                }
            }
            else
            {

                if (M2a > 0 && M2a <= 9)
                {
                    M2a = M2a - 1;
                    Lab_minute2.Text = M2a.ToString();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Alarmı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                string h = H1a.ToString() + H2a.ToString();
                string m = M1a.ToString() + M2a.ToString();
                string sa = h + ":" + m;
                int id = 100;
                for (int i = 0; i < alarm.alss.Count; i++)
                {
                    if (alarm.alss[i] == sa)
                    {
                        id = i;
                    }

                }
                if (id == 100)
                {
                    MessageBox.Show("Böyle bir alarm bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(alarm.alss[id].ToString() + " saatli alarm silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    alarm.deleteAlarm(id);

                }
                this.Close();
            }
        }
        private void BUT_add_Click(object sender, EventArgs e)
        {
            if (BUT_add.Text == "Ekle")
            {

                alarm.Ha1 = H1;
                alarm.Ha2 = H2;
                alarm.Ma1 = M1;
                alarm.Ma2 = M2;
                if (!alarm.isAdded)
                {
                    if (!alarm.isAdded && alarm.s != 50)
                    {
                        alarm.addAlaarm();
                        if (!alarm.isAdded && alarm.s != 50)
                        {

                            int a = alarm.alss.Count;
                            MessageBox.Show("Alarm " + alarm.alss[a - 1].ToString() + " saatine eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Alarm zaten ekli!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Alarm zaten ekli!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Alarm zaten ekli!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                alarm.Ha1 = H1a;
                alarm.Ha2 = H2a;
                alarm.Ma1 = M1a;
                alarm.Ma2 = M2a;
                alarm.editAlarm(ind);
                MessageBox.Show("Alarm: " + alarm.alss[ind].ToString() + " saatine düzenlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPos = Cursor.Position;
                lastFormPos = this.Location;
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursorPos = Cursor.Position;
                int deltaX = currentCursorPos.X - lastCursorPos.X;
                int deltaY = currentCursorPos.Y - lastCursorPos.Y;
                this.Location = new Point(lastFormPos.X + deltaX, lastFormPos.Y + deltaY);
            }
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
        private void Form3_Load(object sender, EventArgs e)
        {
            if (isNew)
            {
                string nowH = DateTime.Now.Hour.ToString();
                string nowM = DateTime.Now.Minute.ToString();
                int t = 0;
                if (nowH.Length == 1) nowH = "0" + nowH;
                if (nowM.Length == 1) nowM = "0" + nowM;
                string d = nowH + nowM;
                string h1 = "", h2 = "", m1 = "", m2 = "";
                if (SayiMi(d))
                {

                    foreach (var k in d)
                    {
                        t++;
                        if (t == 1)
                            h1 = k.ToString();
                        if (t == 2)
                            h2 = k.ToString();
                        if (t == 3)
                            m1 = k.ToString();
                        if (t == 4)
                            m2 = k.ToString();
                    }
                }

                H1 = int.Parse(h1);
                H2 = int.Parse(h2);
                M1 = int.Parse(m1);
                M2 = int.Parse(m2);

                Lab_hour1.Text = H1.ToString();
                Lab_hour2.Text = H2.ToString();
                Lab_minute1.Text = M1.ToString();
                Lab_minute2.Text = M2.ToString();
            }
            else
            {
                button1.Visible = true;
                Lab_hour1.Text = H1a.ToString();
                Lab_hour2.Text = H2a.ToString();
                Lab_minute1.Text = M1a.ToString();
                Lab_minute2.Text = M2a.ToString();
            }

        }

        private void BUT_close_Click(object sender, EventArgs e)
        {
            bool s = true;
            string h, m;
            if (isNew)
            {

                h = H1.ToString() + H2.ToString();
                m = M1.ToString() + M2.ToString();
            }
            else
            {
                h = H1a.ToString() + H2a.ToString();
                m = M1a.ToString() + M2a.ToString();
            }
            string ala = h + ":" + m;
            for (int i = 0; i < alarm.alss.Count; i++)
            {

                if (alarm.alss[i] == ala)
                {
                    s = false;
                }
                else { s = true; }
            }

            if (s)
            {

                DialogResult d = MessageBox.Show("Alarmı kaydetmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (d == DialogResult.No)
                    this.Close();
                else if (d == DialogResult.Yes)
                {
                    alarm.Ha1 = H1;
                    alarm.Ha2 = H2;
                    alarm.Ma1 = M1;
                    alarm.Ma2 = M2;
                    alarm.addAlaarm();
                    int a = alarm.alss.Count;
                    MessageBox.Show("Alarm " + alarm.alss[a - 1].ToString() + " saatine eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    return;
                }

            }
        }
    }
}
