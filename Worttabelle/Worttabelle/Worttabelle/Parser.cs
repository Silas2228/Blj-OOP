using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WortTabelle
{
    public class Parser
    {
        WortTab wt = new WortTab();
        string[] wordss;
        public void Parse(string txtbox)
        {
            wordss = txtbox.Split(' ');
            wt.AddWord(wordss);
        }
    }
}
