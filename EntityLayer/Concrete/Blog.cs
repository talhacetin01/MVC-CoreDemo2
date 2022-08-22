﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog : AEntity
    {
        public override int Id { get ; set ; }
        public string? BlogName { get; set; }
        public string? BlogContent { get; set; }
        public string? BlogThumbnailImage { get; set; }
        public string? BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public override bool Status { get ; set ; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
