using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
namespace Auto_Simulator
{
    class Auto
    {
        string marke;
        int PS;
        int aktuelleGeschwindigkeit;
        int AktuellerGang;
        bool istMotorGestartet = false;


        public string Marke
        {
            get{ return marke; }
            set { marke = value; }
        }
        public int AktuelleGeschwindigkeit
        {
            get { return aktuelleGeschwindigkeit; }
            set { aktuelleGeschwindigkeit = value; }
        }

        public void StarteMotor(bool motorgestartet)
        {
            istMotorGestartet = motorgestartet;
        }
        public void SchalteMotorAus()
        {
            istMotorGestartet = true;
        }
        public void GibGas()
        {
            if(istMotorGestartet == true)
            {
    
                if(marke == "Porsche 250 Ps")
                {
                    while(aktuelleGeschwindigkeit != 250)
                    {
                        aktuelleGeschwindigkeit++;
                    }
                }
                else if(marke == "Opel 90 Ps")
                {
                    while(aktuelleGeschwindigkeit != 90)
                    {
                        aktuelleGeschwindigkeit++;
                    }
                }
                else if(marke == "Ferrari 370 Ps")
                {
                  while(aktuelleGeschwindigkeit != 370)
                    {
                        aktuelleGeschwindigkeit++;
                    }
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie ein Auto aus!");
                }
            }
           

        }
        public void Bremse()
        {
            aktuelleGeschwindigkeit--;
        }
        public void Hupe()
        {

        }
    }
}
