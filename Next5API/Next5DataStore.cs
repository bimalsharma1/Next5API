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
                new Next5() { MeetingName="Flemington",  
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 1, RaceName = "Brisbane", RaceClosedTime=DateTime.Now.AddSeconds(60), IsSuspended=false,
                                Competitor = new List<Competitor>()
                                {
                                    new Competitor()
                                    {
                                        CompetitorNo =1, Name="Queen", StartPosition=1, RaceNo=1
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =2, Name="Queen2", StartPosition=2, RaceNo=1
                                    }
                                }
                        }
                    }
                },new Next5() { MeetingName="Doomben",
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 1, RaceName = "Brisbane", RaceClosedTime=DateTime.Now.AddSeconds(60), IsSuspended=false,
                                Competitor = new List<Competitor>()
                                {
                                    new Competitor()
                                    {
                                        CompetitorNo =1, Name="Queen", StartPosition=1, RaceNo=1
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =2, Name="Queen2", StartPosition=2, RaceNo=1
                                    }
                                }
                        }
                    }
                },new Next5() { MeetingName="Aria",
                    Races = new List<Race>()
                    {
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 1, RaceName = "Brisbane", RaceClosedTime=DateTime.Now.AddSeconds(60), IsSuspended=false,
                                Competitor = new List<Competitor>()
                                {
                                    new Competitor()
                                    {
                                        CompetitorNo =1, Name="Queen", StartPosition=1, RaceNo=1
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =2, Name="Queen2", StartPosition=2, RaceNo=1
                                    }
                                }
                        }
                    }
                },
            };
        }
    }
}
