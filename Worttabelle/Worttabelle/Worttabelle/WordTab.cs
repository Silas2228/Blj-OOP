using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worttabelle
{
    class WordTab
    {
        string woerter;
        string[] source;
        public string Woerter
        {
            get { return woerter; }
            set { woerter = value; }
        }

        public void AddWord()
        {
            source = woerter.Split(new char[] { '.', '?', ' ', '!', ';' }, StringSplitOptions.RemoveEmptyEntries);

        }
        public void GetTab()
        {

        }
        public void PrintTab()
        {

        }
    }
}
