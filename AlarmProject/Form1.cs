using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio.Wave;

namespace AlarmProject
{
    public partial class Form1 : Form
    {

        private bool isDragging = false;
        private Point lastCursorPos;
        private Point lastFormPos;
        private string alarmMusicPath = "../../Resources/audio/Alarm1.mp3";
        string path = "../../Resources/audio/alarm2.mp3";
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
        }


        private void BUT_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPos = Cursor.Position;
                lastFormPos = this.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursorPos = Cursor.Position;
                int deltaX = currentCursorPos.X - lastCursorPos.X;
                int deltaY = currentCursorPos.Y - lastCursorPos.Y;
                this.Location = new Point(lastFormPos.X + deltaX, lastFormPos.Y + deltaY);
            }
        }
        static void Play(string path)
        {
            // NAudio kütüphanesini kullanarak MP3 dosyasını çal
            using (var audioFile = new AudioFileReader(path))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                // Dosya çalarken ekrana sürekli olarak zaman bilgisi yazdır
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Console.WriteLine(audioFile.CurrentTime.ToString());
                    System.Threading.Thread.Sleep(500); // Yazdırma aralığını ayarla
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        Alarm alarm = new Alarm();
        string nowHMh;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            string now = hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();
            Lab_now.Text = now;
            string nowHM = hour.ToString() + ":" + minute.ToString();
            nowHMh = nowHM;
            listBox1.Items.Clear();
            for (int i = 0; i < alarm.alss.Count; i++)
            {
                listBox1.Items.Add(alarm.alss[i]);
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == nowHMh)
                {
                    Play(path);
                    
                }
            }

        }

        private void Lab_now_Click(object sender, EventArgs e)
        {
            //var alarmH = DateTime.Now.AddHours(int.Parse(textBox1.Text));
            //var alarmM = DateTime.Now.AddMinutes(int.Parse(textBox2.Text));
            //MessageBox.Show("Test "+alarmH+"\n"+alarmM);
            Form2 fr2 = new Form2();
            fr2.ShowDialog();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_ValueMemberChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text");
            
        }
    }

}
