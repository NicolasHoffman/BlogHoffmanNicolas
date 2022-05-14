using System;
using System.ComponentModel.DataAnnotations;

namespace BlogHoffmanNicolas.Models
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        public User User { get; set; }

    }
}
