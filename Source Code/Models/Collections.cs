using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StyleLatex.Models
{

    public class DocOption
    {
        public string name { get; set; }
        public string option { get; set; }
    }

    public class LengthUnit
    {
        public string name { get; set; }
        public string unit { get; set; }
    }

    public class NamePart
    {
        public string partName { get; set; }
        public string partVal { get; set; }
    }

    public class BibEntry
    {
        public string entry { get; set; }
        public List<string> field { get; set; }
    }
}
