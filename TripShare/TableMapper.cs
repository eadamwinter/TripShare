using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TripShare
{
    public class TableMapper
    {
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string TableName { get; set; }
        [Required]
        public List<MembersInfo> Members { get; set; }
    }
}
