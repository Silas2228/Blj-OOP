using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WortTabelle
{
    public class WortTab
    {
  
        Dictionary<string, int> words = new Dictionary<string, int>();

        public void AddWord(string word)
        {
            if (words.ContainsKey(word))
            {
                words[word] += 1;
            }
            else
            {
                words.Add(word, 1);
            }
            
        }

        /*      key       value 
         *      ---       ----- 
         *      das         2
         *      ist         1
         *      ein         1 
         *      guter       1
         *      text        1 
         */

        public string GetTab()
        {
           string tabelle = "Wort                 Anzahl" + Environment.NewLine;
           tabelle += "---------------------------------" + Environment.NewLine;

            foreach (string key in words.Keys)
            {
                string word = key;
                int anzahl = words[key];
                tabelle += word + "\t\t" +anzahl.ToString() + Environment.NewLine;
            }
            

            return tabelle;
        }

        public void PrintTab(TextBox printTo)
        {
            printTo.Text = this.GetTab();
        }

       
    }
}
