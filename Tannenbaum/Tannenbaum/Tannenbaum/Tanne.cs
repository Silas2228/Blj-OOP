using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    public class Tanne
    {
        int stammbreite;
        int stammhoehe;
        int kronenhoehe;
        string zeichnung;

        public int Stammbreite
        {
            get { return stammbreite; }
            set { stammbreite = value; }
        }
        public int Stammhoehe
        {
            get { return stammhoehe; }
            set { stammhoehe = value; }
        }
        public int Kronenhoehe
        {
            get { return kronenhoehe; }
            set { kronenhoehe = value; }
        }
        public string Zeichnung
        {
            get { return zeichnung; }
            set { zeichnung = value; }
        }
        public void Zeichnen()
        {
            int zeilen = kronenhoehe;
            for (int i = 0; i < zeilen; i++)
            {
                int stars = (i + 1) * 2 -1;
                int spaces = (kronenhoehe - i) - 1;
                for (int j = 0; j < spaces;j++)
                {
                    Zeichnung += " ";
                }
                for(int k = 0; k < stars;k++)
                {
                    Zeichnung += "*";
                }
                zeichnung += Environment.NewLine;
            }
            int bsh = stammhoehe;
            int bsb = stammbreite;
            for (int i = 0;i < bsh; i++)
            {
                int spacesstamm = kronenhoehe - (bsh / 2);
                for(int j = 0; j < spacesstamm; j++)
                {
                    zeichnung += " ";
                }
                for(int k = 0;k < bsb; k++)
                {
                    zeichnung += "*";
                }
                zeichnung += Environment.NewLine;
            }
        }
    }
}
