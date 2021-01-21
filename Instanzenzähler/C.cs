using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instanzenzähler
{
    class C
    {
        private static int instancecounter = 0;


        public static int CreateInstance()
        {
           
            if(instancecounter < 10)
            {
                 instancecounter++;
            }
            else
            {
                MessageBox.Show("Es könen nur Maximal 10 Instanzen erstellt werden.");
            }
            return instancecounter;
        }
        public static int ResetInstance()
        {
            return instancecounter = 0;
        }
    }
}
