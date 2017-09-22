using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuceneDemoProject;

namespace Search.Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PointOfInterest> sampleData = PointOfInterestRepository.GetAll();
            LuceneSearch.AddUpdateLuceneIndex(sampleData);
            while (true)
            {
                Console.WriteLine("Enter your seach keyword");
                string query = Console.ReadLine();
                IEnumerable<PointOfInterest> hits = LuceneSearch.Search(query);
                foreach (PointOfInterest hit in hits)
                {
                    Console.WriteLine($"Name:{hit.Name}\nId={hit.Id}\nDescription={hit.Description}\nType={hit.Type}\n\n");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
