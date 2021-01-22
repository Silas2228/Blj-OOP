using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeDysnamischVerkettet
{
    class ZahlenSpeicher
    {
        public enum SortOrder
        {
            ASCENDING,
            DESCENDING
        }
        class Elem
        {
            internal int number;
            internal Elem next;
            internal Elem previous;
        }
        private int size;
        public int Size
        {
            get { return size; }
            set { value = size; }
           
        }
        Elem firstnum;
        Elem current;
        public void Add(int n)
        {
            
            Elem elmt = new Elem();
            Size++;
            elmt.number = n;
            if(firstnum == null)
            {
                firstnum = elmt;
            }
            else
            {
                current = firstnum;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = elmt;
            }

        }
        public Boolean Contains(int n)
        {
            return false;
        }
        public string Get(SortOrder sortorder) 
        {

            if(sortorder == SortOrder.ASCENDING)
            {
                int[] output = { };
                for (int i = 0; i < size; i++)
                {
                    output[i] = Convert.ToInt32(current);
                }
                string zahlen = "";
                Array.Sort(output);
                int j = 0;
                foreach (int zahl in output)
                {
                    zahlen += output[j].ToString() + ",";
                    j++;
                }
                return zahlen;
            }

        }
        void Clear()
        {

        }
    }
}
