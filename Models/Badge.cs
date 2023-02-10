using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YbadgesAPI.Models
{

    [Table("Badge", Schema = "archi")]
    public class Badge
    {
        public int ID { get; set; } // ou [KEY]

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(150)]
        [Column("Nom")]
        public string Nom { get; set; } = "";

        [Required(ErrorMessage = "Le Description est obligatoire.")]
        [StringLength(150)]
        [Column("Description")]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "Le LinkImage est obligatoire.")]
        [StringLength(150)]
        [Column("LinkImage")]
        public string LinkImage { get; set; } = "";

        [Required(ErrorMessage = "Le Date est obligatoire.")]
        [StringLength(150)]
        [Column("Date")]
        public string Date { get; set; } = "";

        [Required(ErrorMessage = "Le Obtenu est obligatoire.")]
        [Column("Obtenu")]
        public Boolean Obtenu { get; set; } = false;

    }


}

