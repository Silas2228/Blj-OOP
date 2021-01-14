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

        }
    }
}
