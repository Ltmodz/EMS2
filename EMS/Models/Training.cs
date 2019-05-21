using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class Training
    {
        public int id { get; set; }
        [Required(ErrorMessage ="برجاء ادخال اسم الدورة")]
        [Display(Name = " اسم الدورة  ")]
        public string name { get; set; }

        [Required(ErrorMessage ="برجاء ادخال اسم جهة التدريب")]
        [Display(Name = "  اسم جهة التدريب ")]
        public string organization { get; set; }

        [Required(ErrorMessage = "برجاء ادخال تاريخ بدء الدورة")]
        [Display(Name = " تاريخ بدء الدورة")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime startDate { get; set; }

        [Required(ErrorMessage = "برجاء ادخال تاريخ انهاء الدورة")]
        [Display(Name = " تاريخ انهاء الدورة")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime endDate { get; set; }

        [Required(ErrorMessage = "برجاء ادخال  نتيجة الدورة ")]
        [Display(Name = "نتيجة الدورة ")]
        public int resultId { get; set; }


        [Required(ErrorMessage = "برجاء ادخال  تقدير الدورة ")]
        [Display(Name = "تقدير الدورة ")]
        public int gradeId { get; set; }

        [Required(ErrorMessage = "برجاء ادخال  الموظف الحاصل الدورة ")]
        [Display(Name = "اسم الموظف  ")]
        public int employeId { get; set; }


        //navigation properties
        public Employe employe { get; set; }
        public Result result { get; set; }
        public Grade grade { get; set; }
    }
}