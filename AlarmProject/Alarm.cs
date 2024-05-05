using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmProject
{
    class Alarm
    {
        int h1 = 0, h2 = 0, m1 = 0, m2 = 0;
        public int adet = 0;
        static List<string> als = new List<string>();

        public int Ha1
        {
            get { return h1; }
            set { h1 = value; }
        }
        public List<string> alss
        {
            get { return als; }
            set
            {
                als = value;
            }
        }
        public int Ha2
        {
            get { return h2; }
            set { h2 = value; }
        }
        public int Ma1
        {
            get { return m1; }
            set { m1 = value; }
        }
        public int Ma2
        {
            get { return m2; }
            set { m2 = value; }
        }
        public bool isAdded = false;
        public int s = 100;

        public void addAlaarm()
        {
            string h = h1.ToString() + h2.ToString();
            string m = m1.ToString() + m2.ToString();
            string a = h + ":" + m;
            for (int i = 0; i < als.Count; i++)
            {
                if (als[i] == a)
                {
                    isAdded = true;
                    s = 50;
                }
                else if (als[i] == a)
                {
                    isAdded = false;
                    s = 25;
                }
            }
            if (!isAdded && s != 50)
            {
                als.Add(a);
            }
        }
        public void editAlarm(int index)
        {
            string h = h1.ToString() + h2.ToString();
            string m = m1.ToString() + m2.ToString();

            als[index] = h + ":" + m;
        }
        public void deleteAlarm(int index)
        {
            als.RemoveAt(index);

        }

    }
}
