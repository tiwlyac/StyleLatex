using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StyleLatex.Helper
{
    public class EntryMenu {
        public string entryName { get; set; }
        public UserControl fieldListTab { get; set; }
        public List<FieldTab> tabList { get; set; }
    }

    public class FieldTab
    {
        public string fieldName { get; set; }
        public UserControl fieldTab { get; set; }
        
    }

    public class PartNameFormat {
        public string prefix { get; set; }
        public string suffix { get; set; }
        public string partVal { get; set; }
    }
}
