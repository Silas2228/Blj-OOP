using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Auto_Simulator
{
    class Auto
    {
        string marke;
        int PS;
        int AktuelleGeschwindigkeit;
        int AktuellerGang;
        bool istMotorGestartet = false;


        public string Marke
        {
            get{ return marke; }
            set { marke = value; }
        }

        public void StarteMotor()
        {

        }
        public void SchalteMotorAus()
        {
            istMotorGestartet = true;
        }
        public void GibGas(string gas)
        {
            if(istMotorGestartet == true)
            {
                string textbox = "";
                if(marke == "Porsche 250 Ps")
                {
                    for(int i = 0; i < 250; i++)
                    {
                        gas = i.ToString();
                    }
                }
                else if(marke == "Opel 90 Ps")
                {

                }
                else
                {

                }
                
            }
        }
        public void Bremse()
        {

        }
        public void Hupe()
        {

        }
    }
}
