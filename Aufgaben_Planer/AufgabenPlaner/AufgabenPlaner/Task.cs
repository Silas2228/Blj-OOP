using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenPlaner
{
    class Task
    {
        string titel;
        string beschreibung;
        DateTime dueDate;
        DateTime CreationDate;
        Task state;
        Boolean isArchived;

        public string Titel
        {
            get { return titel; }
            set { value = titel; }
        }
        public string Beschreibung
        {
            get { return beschreibung; }
            set { value = beschreibung; }
        }
        public DateTime DueDate
        {
            get { return dueDate; }
            set { value = dueDate; }
        }
        public Task State
        {
            get { return state; }
            set { value = state; }
        }
        public Boolean IsArchived
        {
            get { return isArchived; }
            set { value = isArchived; }
        }
            
    }
}
