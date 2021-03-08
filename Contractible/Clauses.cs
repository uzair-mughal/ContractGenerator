using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Contarctible
{
    [Serializable]
    public class Clause
    {
        private string name;
        private string description;
        private string wording;

        public Clause(string name, string description, string wording)
        {
            this.name = name;
            this.description = description;
            this.wording = wording;
        }
        public Clause(Clause obj)
        {
            this.name = obj.name;
            this.description = obj.description;
            this.wording = obj.wording;
        }
        public void Store_Clause()
        {
            string filename = "Clauses.txt";
            FileStream s = File.Open(filename, FileMode.Append);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, this);
            s.Close();
        }
        public string get_name()
        {
            return name;
        }
        public string get_description()
        {
            return description;
        }
        public string get_wording()
        {
            return wording;
        }
    }
}
