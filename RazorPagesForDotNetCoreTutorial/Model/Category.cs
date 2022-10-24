﻿using System.ComponentModel.DataAnnotations;

namespace RazorPagesForDotNetCoreTutorial.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]      
        public string Name { get; set; }
        [Display(Name="Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be in range of 1-100!!!")]
        public int DisplayOrder { get; set; }
    }
}
