using System;
using System.ComponentModel.DataAnnotations;

namespace BlogHoffmanNicolas.Models
{
    public class Posts
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public User User { get; set; }
    }
}
