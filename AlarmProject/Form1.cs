﻿using System;
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
    public partial class Form1 : Form
    {

        private bool isDragging = false;
        private Point lastCursorPos;
        private Point lastFormPos;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second= DateTime.Now.Second;
            string now = hour.ToString() + ":" + minute.ToString() + ":" + second.ToString();
            Lab_now.Text = now;

        }

        private void Lab_now_Click(object sender, EventArgs e)
        {
            var alarmH = DateTime.Now.AddHours(int.Parse(textBox1.Text));
            var alarmM = DateTime.Now.AddMinutes(int.Parse(textBox2.Text));
            MessageBox.Show("Test "+alarmH+"\n"+alarmM);
        }


        /*
*Point ResizeLocation = Point.Empty;
void panResize_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
{
if (e.Button == MouseButtons.Left) {
ResizeLocation = e.Location;
ResizeLocation.Offset(-panResize.Width, -panResize.Height);
if (!(ResizeLocation.X > -16 || ResizeLocation.Y > -16))
ResizeLocation = Point.Empty;
}
else
ResizeLocation = Point.Empty;
}
void panResize_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
{
if (e.Button == MouseButtons.Left && !ResizeLocation.IsEmpty) {
if (panResize.Cursor == Cursors.SizeNWSE)
Size = new Size(e.Location.X - ResizeLocation.X, e.Location.Y - ResizeLocation.Y);
else if (panResize.Cursor == Cursors.SizeWE)
Size = new Size(e.Location.X - ResizeLocation.X, Size.Height);
else if (panResize.Cursor == Cursors.SizeNS)
Size = new Size(Size.Width, e.Location.Y - ResizeLocation.Y);
}
else if (e.X - panResize.Width > -16 && e.Y - panResize.Height > -16)
panResize.Cursor = Cursors.SizeNWSE;
else if (e.X - panResize.Width > -16)
panResize.Cursor = Cursors.SizeWE;
else if (e.Y - panResize.Height > -16)
panResize.Cursor = Cursors.SizeNS;
else {
panResize.Cursor = Cursors.Default;
}

}

void panResize_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
{
ResizeLocation = Point.Empty;
}
*
*/
    }

}
