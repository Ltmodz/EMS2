using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMS.Models;

namespace EMS.ViewModels.TrainingsVM
{
    public class AddVM
    {
        public IEnumerable<Result> results { get; set; }
        public IEnumerable<Grade> grades { get; set; }

        public IEnumerable<Employe> employes { get; set; }
        public Training training { get; set; }
    }
}