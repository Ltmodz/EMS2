using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EMS.Models;

namespace EMS.ViewModels.TrainingsVM
{
    public class IndexVM
    {

        [Required(ErrorMessage ="برجاء اختيار الموظف")]
        [Display(Name ="اسم الموظف")]
        public int  employeId { get; set; }
        public List<Employe> employes { get; set; }
        public List<Training> trainings { get; set; }
    }
}