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
        int[] eingabe = new int[10];
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
           for(int i = 0;i < 10;i++)
            {
                eingabe[i] += zahl; 
            }
        }
        public string Get(string txtbox)
        {
            int i = 0;
            foreach(var num in eingabe)
            {
                i++;
                ausgabe[i] = num.ToString(); 
            }
            for(int b = 0; b < ausgabe.Length; b++)
            {
                txtbox += ausgabe[i] + ",";
            }
            return txtbox;

        }
        
    }
}
