using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_backend.Entities
{
    public class Comment 
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string Reply { get; set; }

        [ForeignKey("BlogId")]
        public Blog? Blog { get; set; }
        public int BlogId { get; set; }
        
    }
}