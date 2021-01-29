using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ureche_iudita_paula_proiect.Models
{
    public class Banca
    {
        public int ID { get; set; }
        [Display(Name = "Numele bancii")]
        public string Nume_banca { get; set; }
        public int client_ID { get; set; }
        public int serviciu_ID { get; set; }
    }
}
