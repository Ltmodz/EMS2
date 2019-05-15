using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class Employe
    {
        public int id { get; set; }

        [Required(ErrorMessage ="برجاء ادخال اسم الموظف")]
        [Display(Name="اسم الموظف")]
        public string name { get; set; }

        [Required(ErrorMessage ="برجاء ادخال رقم الموبيل")]
        [Display(Name = "رقم الموبيل")]
        [MaxLength(11,ErrorMessage ="رقم الموبيل يجب ان يكون 11 رقم")]
        [MinLength(11, ErrorMessage = "رقم الموبيل يجب ان يكون 11 رقم")]
        public string phoneNumber { get; set; }

        [Required(ErrorMessage=" برجاء ادخال عنوان الموظف ")]
        [Display(Name = "العنوان الموظف")]
        public string address { get; set; }

        [MaxLength(14, ErrorMessage = "رقم القومي يجب ان يكون 14 رقم")]
        [MinLength(14, ErrorMessage = "رقم القومي يجب ان يكون 14 رقم")]
        [Required(ErrorMessage ="برجاء ادخال رقم القومي")]
        [Display(Name = " الرقم القومي")]
        public string nationalID { get; set; }

        [Required(ErrorMessage = "برجاء ادخال تاريخ الميلاد")]
        [Display(Name = " تاريخ الميلاد ")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "برجاء ادخال تاريخ التعاقد")]
        [Display(Name = " تاريخ التعاقد")]
        public DateTime contractionDate { get; set; }

        [Required(ErrorMessage = "برجاء ادخال  نسبة العجز")]
        [Display(Name = " نسبة العجز")]
        public int disablity { get; set; }
    }
}