﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAPI2.Models
{
    public class Post
    {
        public Post()
        {
            Category = new Category();
            User = new User();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PostedOn { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
    }
}