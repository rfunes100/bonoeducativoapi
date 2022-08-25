using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;


namespace bonoeducativo.Modelo
{
    public class relative_associated
    {

        [Key]
        public Guid? relasso_id { get; set; }
        public int relasso_expedient { get; set; }
        public string? relasso_name { get; set; }
        public DateTime? relasso_date_born { get; set; }
        public int? relasso_rel_code { get; set; }
        public string? reasso_sex { get; set; }


    }
}
