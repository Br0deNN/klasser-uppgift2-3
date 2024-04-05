using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_uppgift2
{
    class namn
    {
        private string? firstname;
        private string? lastname;

        public string Firstname
        {
            get { return firstname; }

            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }

            set { lastname = value; }

        }

        public void metod()
        {
            Console.WriteLine(Firstname + " " + Lastname);
        }

        public static bool IsEighteenOrOlder(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            DateTime eighteenYearsAgo = today.AddYears(-18);

            // Kontrollera om användaren är minst 18 år gammal
            if (birthDate > eighteenYearsAgo)
            {
                return false;
            }

            return true;
        }
    }
}
