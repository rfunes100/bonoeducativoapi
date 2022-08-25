using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bonoeducativo.Modelo
{
    public class associated
    {
        [Key]
        public Guid? aso_id { get; set; }
        public int aso_code { get; set; }
        public int? aso_cia { get; set; }
        public string? aso_name { get; set; }
        public DateTime? aso_date_born { get; set; }
        public string? aso_sex { get; set; }
        public string? aso_state { get; set; }
        public string? aso_alter_code { get; set; }
        public int? aso_expedient { get; set; }


    }
}
