using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    class Agency
    {
        public string Name { get; set; }
        public Dictionary<int, Post> Posts;
        public Dictionary<string, int> Destinations;
        public double ServedClients { get; set; }
        public double TotalClients { get; set; }

        public Agency(string Name/*, List<Post> Posts, List<string> Destinations*/)
        {
            this.Name = Name;
            
            Posts = new Dictionary<int, Post>();
            Destinations = new Dictionary<string, int>();

            ServedClients = 0;
            TotalClients = 0;


        }

        public bool checkDestination(string dest)
        {
            if (Destinations.ContainsKey(dest))
                return true;
            else return false;
        }

        public Post getPost(int id)
        {
            
            return Posts[id];
        }

        public List<string> getDestinations()
        {
            //List<>
            return new List<string>(this.Destinations.Keys); 
        }

        public int totalRevenue()
        {
            int total = 0;
            foreach (Post p in Posts.Values)
                total += p.postRevenue();
            return total;
        }

        public String successRatio()
        {
            return String.Format("{0:0.##}%", (ServedClients / TotalClients) * 100);
        }

    }
}
