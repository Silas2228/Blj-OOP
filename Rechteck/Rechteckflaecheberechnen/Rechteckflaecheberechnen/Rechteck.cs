using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteckflaecheberechnen
{
    class Rechteck
    {
        
        double _fleache;
        public double Fleache
        {
            get { return _fleache; }
        }

        public void berechnenflaeche(double hoeherechteck, double breiterechteck)
        {
            if(hoeherechteck == 0 || breiterechteck == 0)
            {
                throw new Exception("Hoehe und breite müssen ueber 0 sein!");
            }
            _fleache = hoeherechteck * breiterechteck;
        }
        

    }
}
