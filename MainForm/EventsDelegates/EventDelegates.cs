using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.EventsDelegates
{
    internal class EventDelegates
    {
        public delegate void SixHoursBeforeSessionHandler(DateTime sessionTime);

        public event SixHoursBeforeSessionHandler SixHoursBeforeSession;

        public void ScheduleSession(DateTime sessionTime)
        {
           
            DateTime sixHoursBefore = sessionTime.AddHours(-6);
            if (DateTime.Now >= sixHoursBefore)
            {
                
                SixHoursBeforeSession?.Invoke(sessionTime);
            }
        }
    }
}
