using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WortTabelle
{
    public class WortTab
    {
        string words;
        List<string> wordlist = new List<string> { };
        string Wordstxt;
        public List<string> Wordlist
        {
            get { return wordlist; }
            set { wordlist = value; }
        }
        public string Words
        {
            get { return words; }
            set { words = value; }
        }
        public string wordtxt
        {
            get { return Wordstxt; }
            set { Wordstxt = value; }
        }
        
        public WortTab()
        {
            
        }
        public void AddWord(string[] wordss)
        {
            foreach(String word in wordss)
            {
                wordlist.Add(word);
            }

        }
        public string GetTab()
        {
            //Macht die Wörter liste zu einem String
            string word1 = "";
             foreach(String word in wordlist)
             {
                word1 += word + Environment.NewLine; 
             }
            return word1;
        }
        public string PrintTab()
        {
            //ausgabe der Wörter
            
            return GetTab(); ;
        }
    }
}
