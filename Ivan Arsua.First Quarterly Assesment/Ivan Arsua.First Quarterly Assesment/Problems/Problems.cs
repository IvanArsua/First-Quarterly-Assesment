using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Resources;
using Newtonsoft;

namespace Ivan_Arsua.First_Quarterly_Assesment.Problems
{
    public class Problems
    {
        public string problems { get; set; }        
        public List<diabetes> Diabetes { get; set; }
    }

    public class diabetes
    {
        public string Diabetes { get; set; }
        public string medications { get; set; }
        public string medicationsClasses { get; set; }
        public List<ClassName> className { get; set; }
    }

    public class ClassName
    {
        public string className { get; set; }
        public List<AssociatedDrug> associatedDrug { get; set; }
        public List<AssociatedDrug2> associatedDrug2 { get; set; }
    }
    public class AssociatedDrug
    {
        public string associatedDrug { get; set; }
        public string name { get; set; }
        public string dose { get; set; }
        public string strength { get; set; }
    }
    public class AssociatedDrug2
    {
        public string associatedDrug2 { get; set; }
        public string name { get; set; }
        public string dose { get; set; }
        public string strength { get; set; }
    }
       

}
        



   