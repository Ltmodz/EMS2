using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class PermenentUser
    {
        [ForeignKey("Employe")]
        public int id { get; set; }
        [Required(ErrorMessage =" برجاء ادخل المسمي الوظيفي")]
        [Display(Name ="المسمي الوظيفي")]
        public string jobName { get; set; }

        [Required(ErrorMessage ="برجاء ادخال المؤهل الدراسي")]
        [Display(Name = "المؤهل الدراسي")]
        public string qualification { get; set; }
        [Required(ErrorMessage = "برجاء ادخال رقم الملاف ")]
        [Display(Name = "رقم الملاف ")]
        public int fileNumber { get; set; }
        [Required(ErrorMessage = "برجاء ادخال قرار التثبيت")]
        [Display(Name = "قرار التثبيت")]
        public int installmentNumber { get; set; }

        [Required(ErrorMessage = "برجاء ادخال تاريخ التثبيت")]
        [Display(Name = "تاريخ التثبيت")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime installmentDate { get; set; }

        [Required(ErrorMessage = "برجاء ادخال تاريخ الحصول علي الدرجة السابقة")]
        [Display(Name = "تاريخ الحصول علي الدرجة السابقة")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime preRankDate { get; set; }

        [Required(ErrorMessage = "برجاء ادخال تاريخ الحصول علي الدرجة الحالية")]
        [Display(Name = "تاريخ الحصول علي الدرجة الحالية")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime currentRankDate  { get; set; }

        [Required(ErrorMessage ="برجاء اختيار المجموعة الوظيفية")]
        [Display(Name ="المجموعة الوظيفية")]
        public int jobGroupId { get; set; }

        [Required(ErrorMessage = "برجاء اختيار الدرجة الوظيفية")]
        [Display(Name = "الدرجة الوظفية الوظيفية")]
        public int jobDegreeId { get; set; }

        //navigation properties

        public JobGroup jobGroup { get; set; }
        public JobDegree jobDegree { get; set; }

        public Employe Employe { get; set; }
    }
}