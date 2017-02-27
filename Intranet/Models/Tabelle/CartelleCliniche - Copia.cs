using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Intranet.Models
{
    public class CartelleCliniche
    {
        [Key]
        public Guid IDCartellaClinica { get; set; }

        public String NomePaziente { get; set; }

        public String Descrizione { get; set; }

        public String href { get; set; } //utilizzato per selezionare il campo dal menù
    }
}

    