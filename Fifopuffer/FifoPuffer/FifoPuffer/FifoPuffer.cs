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

        public void Put(int zahl)
        {
           eingabe = new int[puffergroesse];
           for(int i = 0;i < eingabe.Length;i++)
           {
                eingabe[i] += zahl; 
           }
        }
        public string Get(string txtbox)
        {
            int i = 0;
            ausgabe = Array.ConvertAll(eingabe, ele => ele.ToString());
            for(int b = 0; b < eingabe.Length; b++)
            {
                txtbox += ausgabe[i] + ",";
            }
            return txtbox;
        }
        
    }
}
