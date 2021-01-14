using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FifoPuffer
{
    public class FifoPuffer
    {

        int puffergroesse;
        List<string> eingabe = new List<string> { };
        Boolean valid;
        public List<string> ausgabe = new List<string> { };
        public int Puffergroesse
        {
            get { return puffergroesse; }
            set { puffergroesse = value; }
        }
        public List<string> Eingabe
        {
            get { return eingabe; }
            set { eingabe = value; }
        }
        public Boolean Valid
        {
            get { return valid; }
            set { valid = value; }
        }

        public void Put(string eingabezahlen, int b)
        {
            for (int i = 0; i < b; i++)
            {
                Eingabe.Add(eingabezahlen);
            }
        }
        public void Get()
        {
            
        }
        
    }
}
