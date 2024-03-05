using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Context.Models
{
    public class HotelComment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        public DateTimeOffset CreationDate { get; set; }

    }
}
