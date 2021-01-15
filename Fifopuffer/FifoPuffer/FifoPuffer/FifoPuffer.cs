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

        int puffergroesse = 0;
        int[] eingabe;
        string[] ausgabe = new string[] { };
        
     
        public int Puffergroesse
        {
            get { return puffergroesse; }
            set { puffergroesse = value; }
        }

        public int[] Eingabe
        {
            get { return eingabe; }
            set { eingabe = value; }
        }
        public string[] Ausgabe
        {
            get { return ausgabe; }
            set { ausgabe = value; }
        }

        public void Put(string[] zahl)
        {
            eingabe = new int[puffergroesse];
            int i = 0;
           foreach(string item in zahl)
            {
                eingabe[i] = Convert.ToInt32(item);
                i++;
            }
        }
        public void Get()
        {
            ausgabe = Array.ConvertAll(eingabe, ele => ele.ToString());

        }
    }
}
