using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EMS.Models;

namespace EMS.ViewModels.EmployeVM
{
    public class PromotionVM
    {
        public PermenentUser permenentUser { get; set; }
        public IEnumerable<JobDegree> jobDegrees { get; set; }
        public IEnumerable<JobGroup> jobGroups { get; set; }
    }
}