using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Next5API.Models
{
    public class Meeting
    {
        public string MeetingCode { get; set; }
        public MeetingType MeetingTypeCode { get; set; }
        public string MeetingName { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}
