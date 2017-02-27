using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Intranet.Models
{
    public class ScopoProgettoViewModels
    {
        public String Titolo { get; set; }
        public String Descrizione { get; set; }
        public int toRefresh { get; set; }

        //public int MinutoAttuale { get; set; }
        //public int RangeOrario { get; set; } //utilizzato dalla funzione che pesca un record a seconda dell'orario in cui ci troviamo
    }
}

    