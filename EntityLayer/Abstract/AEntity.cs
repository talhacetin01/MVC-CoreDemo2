using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public abstract class AEntity
    {
        [Key]
        public abstract int Id { get; set; }
        public abstract bool Status { get; set; }
    }
}
