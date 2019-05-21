using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMS.Models;

namespace EMS.ViewModels.EmployeVM
{
    public class EditVM
    {
        public Employe employe { get; set; }
        public IEnumerable<MaritalState> maritalStates { get; set; }

        public PromotionVM promotionVM { get; set; }
    }
}