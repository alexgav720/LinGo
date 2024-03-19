using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinGo
{
    internal class Lesson
    {
        public List<string> sentenses { get; set; }
        public List<string> trash { get; set; }

        public Lesson(List<string> sentenses, List<string> trash)
        {

            this.sentenses = sentenses;
            this.trash = trash;
        }
    }
}
