using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Repositories;

namespace repoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var repo = new ApplicationRepository(new Persistence.Contexts.AplicationDbContext())) {

                Models.Country pl = new Models.Country { Id=1, Name="Poland", CountryCode = "PL" };
                Models.Country de = new Models.Country { Id=2, Name="Germany", CountryCode = "GER" };

                //repo.Countries.Add(pl);
                //repo.Countries.Add(de);

                Models.Person marek = new Models.Person { CountryId = 1, EmailAdress = "2222@pl.pl", FirstName = "Marek", LastName = "Marek" };

                repo.People.Add(marek);

                //Console.WriteLine(repo.People.Get(4).Result.LastName);
                //Console.WriteLine(repo.People.Get(4).Result.LastName);

                //repo.People.Remove(repo.People.Get(4).Result);

                de.CountryCode = "DE";

                repo.Countries.Update(de);

                var people = repo.People.GetAll().Result;

                foreach (var item in people) Console.WriteLine(item.FirstName);



                Console.ReadLine();



            }
        }
    }
}
