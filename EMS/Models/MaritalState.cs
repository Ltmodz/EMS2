using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class MaritalState
    {
        public int id { get; set; }
        public string name { get; set; }

        //navigation properties
        public ICollection<Employe> employes { get; set; }
    }
}