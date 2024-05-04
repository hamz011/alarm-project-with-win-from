using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmProject
{
    class Alarm
    {
        private int now, hour, minute;
        private List<DateTime> alarms = new List<DateTime>();
        public void addAlarm(int h, int m)
        {
            var alarmH = DateTime.Now.AddHours(h);
            var alarmM = DateTime.Now.AddMinutes(m);
            
        }

    }
}
