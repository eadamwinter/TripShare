using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripShare
{
    public class NewTableViewModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string TableName { get; set; }
        [Required]
        public List<string> Names { get; set; }
        [Required]
        [Range(2,15)]
        public byte NumberOfMembers { get; set; }
    }
}
