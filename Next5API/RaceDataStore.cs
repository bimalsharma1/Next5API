using Next5API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Next5API
{
    public class RaceDataStore
    {
        public static RaceDataStore Current { get; } = new RaceDataStore();

        public List<Race> Races { get; set; }

        public RaceDataStore()
        {
            Races = new List<Race>()
                  {
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 1, RaceName = "Brisbane", RaceClosedTime=DateTime.Now.AddSeconds(60), IsSuspended=false,
                                Competitor = new List<Competitor>()
                                {
                                    new Competitor()
                                    {
                                        CompetitorNo =1, Name="Competitor 1", StartPosition=1, RaceNo=1
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =2, Name="Competitor 2", StartPosition=2, RaceNo=1
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =3, Name="Competitor 3", StartPosition=3, RaceNo=1
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =4, Name="Competitor 4", StartPosition=4, RaceNo=1
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =5, Name="Competitor 25", StartPosition=5, RaceNo=1
                                    }

                                }
                        },
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 2, RaceName = "Hot shots", RaceClosedTime=DateTime.Now.AddSeconds(60), IsSuspended=false,
                                Competitor = new List<Competitor>()
                                {
                                    new Competitor()
                                    {
                                        CompetitorNo =1, Name="Competitor 1", StartPosition=1, RaceNo=2
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =2, Name="Competitor 2", StartPosition=2, RaceNo=2
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =3, Name="Competitor 3", StartPosition=3, RaceNo=2
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =4, Name="Competitor 4", StartPosition=4, RaceNo=2
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =5, Name="Competitor 25", StartPosition=5, RaceNo=2
                                    }

                                }
                        },
                        new Race()
                        {
                            MeetingCode = "H", RaceNo = 3, RaceName = "Brisbane", RaceClosedTime=DateTime.Now.AddSeconds(60), IsSuspended=false,
                                Competitor = new List<Competitor>()
                                {
                                    new Competitor()
                                    {
                                        CompetitorNo =1, Name="Competitor 1", StartPosition=1, RaceNo=3
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =2, Name="Competitor 2", StartPosition=2, RaceNo=3
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =3, Name="Competitor 3", StartPosition=3, RaceNo=3
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =4, Name="Competitor 4", StartPosition=4, RaceNo=3
                                    },
                                    new Competitor()
                                    {
                                        CompetitorNo =5, Name="Competitor 25", StartPosition=5, RaceNo=3
                                    }

                                }
                        },

                    };
               
               
           
        }
    }
}
