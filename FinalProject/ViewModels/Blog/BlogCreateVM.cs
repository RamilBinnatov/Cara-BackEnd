﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels.Blog
{
    public class BlogCreateVM
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateDate { get; set; }
        public List<IFormFile> Photos { get; set; }
        public int TagId { get; set; }
        public List<Models.Tag> Tag { get; set; }
        public IEnumerable<int> Blog_TagList { get; set; }

    }
}
