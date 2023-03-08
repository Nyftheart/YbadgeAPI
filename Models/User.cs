using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YbadgesAPI.Models
{

    [Table("User", Schema = "archi")]
    public class User
    {
        public int ID { get; set; } // ou [KEY]

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(150)]
        [Column("Nom")]
        public string Nom { get; set; } = "";

        [Required(ErrorMessage = "Le Prenom est obligatoire.")]
        [StringLength(150)]
        [Column("Prenom")]
        public string Prenom { get; set; } = "";

        [Required(ErrorMessage = "Le Email est obligatoire.")]
        [StringLength(150)]
        [Column("Email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Le MDP est obligatoire.")]
        [StringLength(150)]
        [Column("MDP")]
        public string MDP { get; set; } = "";

        [Required(ErrorMessage = "Le Classe est obligatoire.")]
        [StringLength(150)]
        [Column("Classe")]
        public string Classe { get; set; } = "";

        [Required(ErrorMessage = "Le Filiere est obligatoire.")]
        [StringLength(150)]
        [Column("Filiere")]
        public string Filiere { get; set; } = "";
    }


}
