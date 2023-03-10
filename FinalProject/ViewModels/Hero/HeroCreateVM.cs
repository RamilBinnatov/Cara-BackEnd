using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels.Hero
{
    public class HeroCreateVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public IFormFile Photo { get; set; }


    }
}
