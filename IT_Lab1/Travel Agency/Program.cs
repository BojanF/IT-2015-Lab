using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    class Program
    {
        static public void agencyInitialization(Agency agency, int postsNum)
        {
            agency.Destinations.Add("Rome", 1);
            agency.Destinations.Add("London", 1);
            agency.Destinations.Add("Tokio", 1);
            agency.Destinations.Add("Sofia", 1);
            agency.Destinations.Add("Istanbul", 1);
            agency.Destinations.Add("Toronto", 1);
            agency.Destinations.Add("Miami", 1);
            agency.Destinations.Add("Zagreb", 1);
            agency.Destinations.Add("Belgrade", 1);
            agency.Destinations.Add("Moscow", 1);

            for (int i = 1; i <= postsNum; i++)
            {
                Post p = new Post(i);
                agency.Posts.Add(i, p);
            }
        }
        
        static public bool checkPostID(int id, int postsNum)
        {
            if (id >= 1 && id <= postsNum)
                return true;
            else return false;
        }

        static public void optionOne(Agency agency, int postsNum)
        {
            Console.WriteLine("Enter destination:");

            string dest = Console.ReadLine();

            double clients = agency.TotalClients;
            

            if (agency.checkDestination(dest))
            {
                Console.WriteLine("Enter post ID:");
                string id = Console.ReadLine();
                int postID;
                Int32.TryParse(id, out postID);

                if(!checkPostID(postID, postsNum))
                {
                    Console.WriteLine("Post with ID {0} does not exist.", postID);
                    return;
                }

                Console.WriteLine("Enter credentials: Name, Lastname, Age\nPress Enter after every entry.");
                string name = Console.ReadLine();
                string lastname = Console.ReadLine();
                string age = Console.ReadLine();
                int ageI;
                Int32.TryParse(age, out ageI);

                Ticket t = new Ticket(dest, dest.Length * 1000, new Person(name, lastname, ageI), DateTime.Now);

                Post post = agency.getPost(postID);

                post.AddTicket(t);



                double served = agency.ServedClients;
                agency.ServedClients = ++served;
                agency.TotalClients = ++clients;
                Console.WriteLine("Ticket was successfully purchased.");

            }
            else
            {
                agency.TotalClients = ++clients;
                Console.WriteLine("Destination {0} is not supported!", dest);
            }
        }

        static public void optionTwo(Agency agency, int postsNum)
        {
            
            Console.WriteLine("Enter post ID:");
            string id = Console.ReadLine();
            int postID;
            Int32.TryParse(id, out postID);

            if (!checkPostID(postID, postsNum))
            {
                Console.WriteLine("Post with ID {0} does not exist.", postID);
                return;
            }

            Console.WriteLine("Enter start date in format: MM/DD/YYYY HH:MM");
            string startDate = Console.ReadLine();
            DateTime start, end;
            if (!DateTime.TryParse(startDate, out start))
            {
                Console.WriteLine("Date you entered is not walid!\nStart over!");
                //break;
                return;
            }

            Console.WriteLine("Enter end date in format: MM/DD/YYYY HH:MM");
            string endDate = Console.ReadLine();
           
            if (!DateTime.TryParse(endDate, out end))
            {
                Console.WriteLine("Date you entered is not walid!\nStart over!");
                //break;
                return;
            }

            List<Ticket> result = agency.getPost(postID).soldTicketsIntervalDetails(start, end);
            if (result.Count == 0)
            {
                Console.WriteLine("No tickets were sold in interval {0} - {1}", start, end);
            }
            else
            {
                Console.WriteLine("Tickets sold in interval {0} - {1}", start, end);
                foreach (Ticket t in result)
                    Console.WriteLine(t.ToString());
                Console.WriteLine("Number of tickets {0}", agency.getPost(postID).soldTicketsInterval(start, end));
            }
        }

        static public void optionThree(Agency agency, int postsNum)
        {
            Console.WriteLine("Enter post ID:");
            string id = Console.ReadLine();
            int postID;
            Int32.TryParse(id, out postID);

            if (!checkPostID(postID, postsNum))
            {
                Console.WriteLine("Post with ID {0} does not exist.", postID);
                return;
            }

            Console.WriteLine("Enter start date in format: MM/DD/YYYY HH:MM");
            string startDate = Console.ReadLine();
            DateTime start, end;
            if (!DateTime.TryParse(startDate, out start))
            {
                Console.WriteLine("Date you entered is not walid!\nStart over!");
                //break;
                return;
            }

            Console.WriteLine("Enter end date in format: MM/DD/YYYY HH:MM");
            string endDate = Console.ReadLine();
            if (!DateTime.TryParse(endDate, out end))
            {
                Console.WriteLine("Date you entered is not walid!\nStart over!");
                //break;
                return;
            }

            Console.WriteLine("Post ID:{0}\nFrom: {1}\nTo: {2}\nRevenue: {3:0,0.00} euros.", postID, start, end, agency.getPost(postID).getRevenueInterval(start, end));

        }

        static public void optionFour(Agency agency, int postsNum)
        {
            Console.WriteLine("Enter start date in format: MM/DD/YYYY HH:MM");
            string startDate = Console.ReadLine();
            DateTime start, end;
            if (!DateTime.TryParse(startDate, out start))
            {
                Console.WriteLine("Date you entered is not walid!\nStart over!");
                //break;
                return;
            }

            Console.WriteLine("Enter end date in format: MM/DD/YYYY HH:MM");
            string endDate = Console.ReadLine();

            if (!DateTime.TryParse(endDate, out end))
            {
                Console.WriteLine("Date you entered is not walid!\nStart over!");
                //break;
                return;
            }
            Console.WriteLine("Interval {0} - {1}", start, end);
            for (int i = 1; i <= postsNum; i++)
            {
                List<Ticket> result = agency.getPost(i).soldTicketsIntervalDetails(start, end);
                Console.WriteLine("Post with ID {0}", i);
            
                if (result.Count == 0)
                {
                    Console.WriteLine("No tickets were sold in this interval from this post.");
                }
                else
                {
                    Console.WriteLine("Sold tickets");
                    foreach (Ticket t in result)
                        Console.WriteLine(t.ToString());
                }
            }
        }

        static void Main(string[] args)
        {

            int postsNum;//shalteri
            int menuOption;
            string input, postsS;
            bool exit = false;
            Console.WriteLine("Enter how many posts your agency have");
            postsS = Console.ReadLine();
            Int32.TryParse(postsS, out postsNum);

            Agency agency = new Agency("World");
            agencyInitialization(agency, postsNum);   

            
            
            Console.WriteLine("1.SERVE CLIENT\n2.SALED TICKETS FROM POST\n3.POST REVENUE\n4.TICKETS SOLD BY POST\n5.AGENCY REVENUE\n6.SUCCESS RATION\n7.EXIT");

            while (!exit)
            {
                Console.WriteLine("Chose from Main menu:");
                input = Console.ReadLine();
                Int32.TryParse(input, out menuOption);

                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("SERVE CLIENT");
                        optionOne(agency, postsNum);
                        break;
                    case 2:
                        Console.WriteLine("SOLD TICKETS FROM POST IN GIVEN INTERVAL");
                        optionTwo(agency, postsNum);
                        break;
                    case 3:
                        Console.WriteLine("POST REVENUE IN GIVEN INTERVAL");
                        optionThree(agency, postsNum);
                        break;
                    case 4:
                        Console.WriteLine("TICKETS SOLD BY POST");
                        optionFour(agency, postsNum);
                        break;
                    case 5:
                        Console.WriteLine("AGENCY REVENUE");
                        Console.WriteLine("Total agency revenue is {0:0,0.00} euros.", agency.totalRevenue());
                        break;
                    case 6:
                        if(agency.TotalClients == 0)
                        {
                            Console.WriteLine("Nobody came into agency yet.");
                        }
                        else
                            Console.WriteLine("SUCCESS RATIO\nSuccessfully served {0} of clients.", agency.successRatio());
                        break;                   
                    case 7:
                        Console.WriteLine("EXIT");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Enter number from 1 to 7");
                        break;
                }
            }

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
