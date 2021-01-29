using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ureche_iudita_paula_proiect.Models
{
    public class Serviciu
    {
        public int ID { get; set; }
        [Display(Name = "Servicii")]
        public string Serviciu_oferit { get; set; }

    }
}
