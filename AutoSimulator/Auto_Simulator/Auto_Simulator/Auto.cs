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
            set { AktuellerGang = value; }
        }

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
                if (marke == "Porsche 250 Ps")
                {
                    PS = 250;
                    AktuelleGeschwindigkeit += Convert.ToInt32((0.02 * PS));

                    if (AktuelleGeschwindigkeit > Convert.ToInt32(110 + PS / 2))
                        AktuelleGeschwindigkeit = Convert.ToInt32(110 + PS / 2);

                }
                else if(marke == "Opel 90 Ps")
                {
                    PS = 90;
                    AktuelleGeschwindigkeit += Convert.ToInt32((0.02 * PS));

                    if (AktuelleGeschwindigkeit > Convert.ToInt32(110 + PS / 2))
                        AktuelleGeschwindigkeit = Convert.ToInt32(110 + PS / 2);
                }
                else if(marke == "Ferrari 370 Ps")
                {
                    PS = 370;
                    AktuelleGeschwindigkeit += Convert.ToInt32((0.02 * PS));

                    if (AktuelleGeschwindigkeit > Convert.ToInt32(110 + PS / 2))
                        AktuelleGeschwindigkeit = Convert.ToInt32(110 + PS / 2);
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
    }
}
