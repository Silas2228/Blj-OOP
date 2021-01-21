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
        
        public int Gang
        {
            get { return AktuellerGang; }
            private set { AktuellerGang = value; }
        }
        public int AktuelleGeschwindigkeit
        {
            get { return aktuelleGeschwindigkeit; }
            private set { aktuelleGeschwindigkeit = value; }
        }
        public bool IstMotorGestartet
        {
            get { return istMotorGestartet; }
            set { value = istMotorGestartet; }
        }
        public void StarteMotor(bool motorgestartet)
        {
            istMotorGestartet = motorgestartet;
        }
        public void SchalteMotorAus()
        {
            istMotorGestartet = true;
        }

        public Auto(string Marke, int Ps)
        {
            marke = Marke;
            PS = Ps;
        }

        public void GibGas()
        {
            
            if(istMotorGestartet == true)
            {
                if (marke != null || marke != "")
                {
                    aktuelleGeschwindigkeit += Convert.ToInt32((0.02 * PS));

                    if (aktuelleGeschwindigkeit > Convert.ToInt32(110 + PS / 2))
                        aktuelleGeschwindigkeit = Convert.ToInt32(110 + PS / 2);
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie ein Auto aus!");
                }
            }
           

        }
        public void Bremse()
        {

            if(AktuelleGeschwindigkeit > 0)
            { 
                AktuelleGeschwindigkeit -= 10;
            }
            GangSchaltung();
        }
        public void Hupe()
        {

        }
        public void GangSchaltung()
        {
            if(AktuelleGeschwindigkeit < 10)
            {
                AktuellerGang = 1;
            }
            else if(AktuelleGeschwindigkeit < 20)
            {
                AktuellerGang = 2;
            }
            else if(AktuelleGeschwindigkeit < 30)
            {
                AktuellerGang = 3;
            }
            else if(aktuelleGeschwindigkeit < 40)
            {
                AktuellerGang = 4;
            }
            else if(aktuelleGeschwindigkeit < 70)
            {
                AktuellerGang = 5;
            }
            else
            {
                AktuellerGang = 6;
            }

        }
        public override string ToString()
        {
            return marke + " " + PS.ToString();
        }
    }
}
