﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels.Tag
{
    public class TagCreateVM
    {
        [Required]
        public string Name { get; set; }
    }
}
