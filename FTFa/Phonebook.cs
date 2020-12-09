using System.Collections.Generic;

namespace FTFa
{
    public class Phonebook
    {
        private readonly Dictionary<string, string> Entries;

        public Phonebook()
        {
            Entries = new Dictionary<string, string>();
        }

        public bool AddEntry(string number, string name)
        {
            try
            {
                Entries.Add(number, name);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Dictionary<string, string> GetEntries()
        {
            return Entries;
        }
    }
}
