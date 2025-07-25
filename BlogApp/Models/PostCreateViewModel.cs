﻿using BlogApp.Entity;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace BlogApp.Models
{
    public class PostCreateViewModel
    {
        public bool IsActive { get; set; }
        public int PostId { get; set; }

        [Required]
        
        [Display(Name = "Başlık")]
        public string? Title { get; set; }

       
        [Display(Name = "İçerik")]
        public string? Content{ get; set; }


        [Required] 
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }


        [Required]
        [Display(Name = "Url")]
        public string? Url { get; set; }

        public List<Tag> Tags { get; set; } = new();
    }
}
