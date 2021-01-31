using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementApi.Models
{
    public class ApplicationModel
    {

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Middle Name is required")]
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Date Of Birth is required")]
        public string DateOfBirth { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender is required")]
        public string Gender { get; set; }
        public SelectList GenderList { get; set; }
        [Required(ErrorMessage = "County is required")]
        public string County { get; set; }
        public SelectList CountyCodes { get; set; }
        [Required(ErrorMessage = "Sub County")]
        public string SubCounty { get; set; }
        public SelectList SubCountyCodes { get; set; }
        [Required(ErrorMessage = "Class is required")]
        public string Class { get; set; }
        public SelectList ClassCodes { get; set; }
        [Required(ErrorMessage = "Term is required")]
        public string Term { get; set; }
        public SelectList TermCodes { get; set; }
        public string NemisNo { get; set; }
        public string AcademicYear { get; set; }

        //family details
        public string Names { get; set; }
        public string Type { get; set; }

        public string Occupation { get; set; }
        public string MobileNo { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string Email { get; set; }
        public string CompanyTelNo { get; set; }
        public string ResidentialAddress { get; set; }
        public string ApartmentNo { get; set; }
        public string HouseNo { get; set; }
        public string Address { get; set; }

        public string success { get; set; }

    }
}