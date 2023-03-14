using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ENTITIES.HRM_Web_UTTOSoftware.Enums;
using CORE.HRM_Web_UTTOSoftware;

namespace ENTITIES.HRM_Web_UTTOSoftware.Entities
{
    public class Person:BaseEntity
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string FirstName { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string LastName { get; set; }

        [Display(Name = "İkinci Adı")]
        public string MiddleName { get; set; }

        [Display(Name = "İkinci Soyadı")]
        public string MaidenName { get; set; }

        [Display(Name = "Departman")]
        [Required]
        public DepartmansEnum DepartmansEnum { get; set; }

        [Display(Name = "Meslek")]
        public string Job { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [Display(Name = "İşe Giriş Tarihi")]
        public Nullable<DateTime> HireDate { get; set; }

        [Display(Name = "İşten Çıkış Tarihi")]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public Nullable<DateTime> LeaveJobDate { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [Required(ErrorMessage = "Lütfen doğum tarihinizi giriniz")]
       
        public DateTime BirthDate { get; set; }

        [Display(Name = "Adres")]
        [Required(ErrorMessage = "Lütfen Adresinizi Giriniz")]
        public string Address { get; set; }

        [Display(Name = "Mail")]
        public string Mail { get; set; }

        [Display(Name = "TC Kimlik No")]
        [Range(11,11,ErrorMessage ="Lütfen 11 Haneli TC Kimlik No Giriniz")]
        public int TC { get; set; }

        [Display(Name = "Telefon")]
        public string PersonelPhoneNumber { get; set; }

        [Display(Name ="Şirket Bilgisi")]
        public string  CompanyInfo { get; set; }

        //package versiyon test

        //test ozan için

    }
}
