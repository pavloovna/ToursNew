using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Context.Models
{
    public class ReceivingPoint
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
