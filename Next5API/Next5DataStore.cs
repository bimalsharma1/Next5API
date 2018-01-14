using Next5API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Next5API
{
    public class Next5DataStore
    {
        public static Next5DataStore Current { get; } = new Next5DataStore();

        public List<Next5> Next5 { get; set; }


        public Next5DataStore()
        {
            Next5 = new List<Next5>()
            {
                new Next5() {   
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "T", RaceNo = 1, RaceName = "Brisbane", RaceClosedTime=DateTime.UtcNow.AddSeconds(930), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "G", RaceNo = 2, RaceName = "DIRT Claiming", RaceClosedTime=DateTime.UtcNow.AddSeconds(935), IsSuspended=true
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 3, RaceName = "3YO BM 70 HANDICAP", RaceClosedTime=DateTime.UtcNow.AddSeconds(940), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "T", RaceNo = 2, RaceName = "MAIDEN HANDICAP", RaceClosedTime=DateTime.UtcNow.AddSeconds(945), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "G", RaceNo = 2, RaceName = "3YO FILLIES MAIDEN", RaceClosedTime=DateTime.UtcNow.AddSeconds(950), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 1, RaceName = "MAIDEN PLATE", RaceClosedTime=DateTime.UtcNow.AddSeconds(960), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "T", RaceNo = 1, RaceName = "3YO MAIDEN PLATE", RaceClosedTime=DateTime.UtcNow.AddSeconds(970), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "G", RaceNo = 3, RaceName = "AWT : HANDICAP", RaceClosedTime=DateTime.UtcNow.AddSeconds(980), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 3, RaceName = "CLASS 5", RaceClosedTime=DateTime.UtcNow.AddSeconds(990), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "T", RaceNo = 1, RaceName = "CLASS 5", RaceClosedTime=DateTime.UtcNow.AddSeconds(1900), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "G", RaceNo = 1, RaceName = "Brisbane", RaceClosedTime=DateTime.UtcNow.AddSeconds(1910), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 3, RaceName = "MAIDEN PLATE", RaceClosedTime=DateTime.UtcNow.AddSeconds(120), IsSuspended=false
                        }
                    }
                },new Next5() { 
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 2, RaceName = "MAIDEN PLATE", RaceClosedTime=DateTime.UtcNow.AddSeconds(130), IsSuspended=false
                        }
                    }
                }
            };
        }
    }
}
