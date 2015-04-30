using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeniorStudent
{
    public class Classes
    {
        public List<String> classList { get; set; }

        public Classes()
        {
            classList = new List<string>();
        }

        public void AddClass(String newClass)
        {
            classList.Add(newClass);
        }
    }
}
