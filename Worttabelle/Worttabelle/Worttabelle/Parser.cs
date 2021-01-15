using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WortTabelle
{
    public class Parser
    {
        WortTab wt;

        public Parser(WortTab wrdTb)
        {
            wt = wrdTb;
        }

        public void Parse(string text)
        {

            // text parsen (im Parameter text ist ein ganzer drin! du musst jetzt die Wörter finden).

            string[] foundwords = text.Split(' ', '.', ';', ':', ',');

            foreach(string word in foundwords)
            { 
                wt.AddWord(word);
            }
        }
    }
}
