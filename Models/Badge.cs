﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;
using YbadgesAPI.Migrations;

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

        [Required(ErrorMessage = "Le LinkOBJ est obligatoire.")]
        [StringLength(150)]
        [Column("LinkOBJ")]
        public string LinkOBJ { get; set; } = "";

        [Required(ErrorMessage = "Le LinkMaterial est obligatoire.")]
        [StringLength(150)]
        [Column("LinkMaterial")]
        public string LinkMaterial { get; set; } = "";

        [Required(ErrorMessage = "Le Categorie est obligatoire.")]
        [StringLength(150)]
        [Column("Categorie")]
        public string Categorie { get; set; } = "";

        [Required(ErrorMessage = "Le tableau des Obtenu est obligatoire.")]
        [Column("Obtenu")]
        public List<Obtenu>? Obtenu { get; set; }

    }

    public class Obtenu
    {
        [System.ComponentModel.DataAnnotations.Key] // Définit cette propriété comme la clé primaire de la classe
        public int Id { get; set; }
        public string? Date { get; set; }
        public string? IdUser { get; set; }
    }


}

