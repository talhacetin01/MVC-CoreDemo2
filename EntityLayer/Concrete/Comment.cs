using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment : AEntity
    {
        //[Key]
        //public int CommentId { get; set; }
        [Key]
        public override int Id { get ; set ; }
        public string? CommentUserName { get; set; }
        public string? CommentTitle { get; set; }
        public string? CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public override bool Status { get ; set ; }
        //public int BlogId { get; set; }
        //public Blog? Blog { get; set; }
    }
}
