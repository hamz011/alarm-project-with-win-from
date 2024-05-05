
namespace AlarmProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lab_now = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BUT_close = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lab_now
            // 
            this.Lab_now.AutoSize = true;
            this.Lab_now.Font = new System.Drawing.Font("Modern No. 20", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_now.Location = new System.Drawing.Point(66, 44);
            this.Lab_now.Name = "Lab_now";
            this.Lab_now.Size = new System.Drawing.Size(368, 103);
            this.Lab_now.TabIndex = 1;
            this.Lab_now.Text = "00:00:00";
            this.Lab_now.Click += new System.EventHandler(this.Lab_now_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BUT_close
            // 
            this.BUT_close.BackgroundImage = global::AlarmProject.Properties.Resources.close;
            this.BUT_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BUT_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BUT_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUT_close.Location = new System.Drawing.Point(448, 12);
            this.BUT_close.Name = "BUT_close";
            this.BUT_close.Size = new System.Drawing.Size(40, 40);
            this.BUT_close.TabIndex = 0;
            this.BUT_close.UseVisualStyleBackColor = false;
            this.BUT_close.Click += new System.EventHandler(this.BUT_close_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(0, 191);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 88);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMemberChanged += new System.EventHandler(this.listBox1_ValueMemberChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yaklaşan Alarmlar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelButton = this.BUT_close;
            this.ClientSize = new System.Drawing.Size(500, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Lab_now);
            this.Controls.Add(this.BUT_close);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUT_close;
        private System.Windows.Forms.Label Lab_now;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

