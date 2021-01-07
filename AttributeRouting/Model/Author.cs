using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AttributeRouting.Model
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Required] 
        public string Name { get; set; }
    }
}