using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours.Context.Enums;

namespace Tours.Context.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
        public Role RoleId { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<HotelComment> HotelComments { get; set; }

    }
}
