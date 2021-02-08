using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TripShare
{
    public class ExpenseMapper
    {
        [Required]
        public byte TableNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "You have to enter the amount of expense")]
        [Range(0.01,1000000)]
        public decimal Amount { get; set; }
        [Required]
        public IEnumerable<string> MembersInvolved { get; set; }
        [MaxLength(50)]
        public string Comment { get; set; }
    }
}
