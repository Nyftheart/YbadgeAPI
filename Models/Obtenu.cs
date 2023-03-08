using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YbadgesAPI.Models
{
        [Table("Obtenu", Schema = "archi")]
        public class Obtenu
        {
            public int ID { get; set; } // ou [KEY]
           
            [Required(ErrorMessage = "Le Date est obligatoire.")]
            [StringLength(150)]
            [Column("Date")]
            public string Date { get; set; } = "";

        [   Required(ErrorMessage = "Le IdUser est obligatoire.")]
            [StringLength(150)]
            [Column("IdUser")]
            public string IdUser { get; set; } = "";


        }
    }

