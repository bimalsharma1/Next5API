using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Next5API.Models
{
    public class Race
    {
        public string MeetingCode { get; set; }
        public int RaceNo { get; set; }
        public string RaceName { get; set; }
        public DateTime RaceClosedTime { get; set; }
        public bool IsSuspended { get; set; }
        public ICollection<Competitor> Competitor { get; set; }

    }
}
