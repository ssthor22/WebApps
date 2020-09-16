using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApptTracker.Models
{
    public class AvailAppt
    {
        public int ID { get; set; }

        public Provider provider { get; set; }

        public DateTime apptdatetime { get; set; }

        public int apptlength { get; set; }
    }
}
