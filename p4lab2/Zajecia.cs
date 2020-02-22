using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace p4lab2
{
    
    public class Zajecia
    {
        //Adnotacje. Stosuje sie albo fluenty albo adnotacje
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("NazwaPrzedmiotu")]
        [MinLength(1)]
        public string Nazwa { get; set; }
        public string Sala { get; set; }
        public DateTime Godzina { get; set; }
        public int IloscObecnych { get; set; }


    }
}
