using System.Collections.Generic;
using System;

namespace Zapis.Services.ScheduleService
{
    public class ScheduleItem
    {
        public DateTime DateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public List<Message> Messages { get; set; }
    }
}