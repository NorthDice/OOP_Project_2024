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

        public class SessionScheduler
        {
            public event SixHoursBeforeSessionHandler SixHoursBeforeSession;

            public void ScheduleSession(DateTime sessionTime)
            {
                throw new NotImplementedException();
            }
        }
    }
}
