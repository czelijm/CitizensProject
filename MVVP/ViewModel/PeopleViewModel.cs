using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVP.ViewModel
{
    public class PeopleViewModel
    {
        private Person _choosenPerson;
        public Person ChoosenPerson { get { return _choosenPerson; } set { _choosenPerson = value; } }

        public PeopleViewModel()
        {
            ChoosenPerson = new Models.Person { CountryId = 1, EmailAdress = "2222@pl.pl", FirstName = "Marek", LastName = "Marek" };
        }

    }
}
