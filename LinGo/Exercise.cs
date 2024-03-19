using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinGo
{
    internal class Exercise
    {
        public string type { get; set; }
        public string words { get; set; }
        public List<string> trash { get; set; }
        public Exercise(string type, string words, List<string> trash)
        {
            this.type = type;
            this.words = words;
            this.trash = trash;
        }

    }
}
