using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Context.Models
{
    public class Tour
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        public int TicketCount { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] ImagePriview { get; set; }

        [Required]
        public decimal Price {  get; set; }

        [Required]
        public bool IsActual { get; set; }

        [Required]
        public string CountryCode {  get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<TypeTour> TypeTours { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
