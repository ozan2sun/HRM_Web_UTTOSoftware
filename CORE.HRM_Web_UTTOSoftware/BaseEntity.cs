using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;

namespace CORE.HRM_Web_UTTOSoftware
{
    public abstract class BaseEntity
    {
        [Required]
        public int ID { get; set; }

        [Display(Name = "Fotoğraf")]
        public string PhotoName { get; set; }

        [NotMapped]
        [Display(Name = "Fotoğraf")]
        public IFormFile Photo { get; set; }


        [Display(Name = "Aktif Mi")]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

    }
}
