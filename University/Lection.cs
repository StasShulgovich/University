using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{ enum LectionType
    {
        Technician,
        Humanitarian
    }
    class Lection
    {        
      public string LectionName { get; set; }
      public LectionType Type { get; set; }
        
    }
}
