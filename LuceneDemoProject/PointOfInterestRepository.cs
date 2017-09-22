using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneDemoProject
{
    public class PointOfInterestRepository
    {
        public static PointOfInterest Get(int id)
        {
            return GetAll().SingleOrDefault(x => x.Id.Equals(id));
        }

        public static List<PointOfInterest> GetAll()
        {
            return new List<PointOfInterest>
            {
                 new PointOfInterest {Name ="Hyatt",Id=1,Type="Hotel", Description = "City in Serbia"},
                 new PointOfInterest {Name ="Indigo",Id=2,Type="Airline", Description = "City in Russia"},
                 new PointOfInterest {Name ="Novotel",Id=3,Type="Hotel",Description = "City in USA"},
                 new PointOfInterest {Name ="Ibiz",Id=4,Type="Hotel", Description = "City in India"},
                 new PointOfInterest {Name ="Nanamaktta",Id=5,Type="Place", Description = "City in Hong-Kong"},
             };

        }
    }
}
