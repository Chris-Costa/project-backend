using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_backend.Entities
{
    public class Comment 
    {
        
        [Key]
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Reply { get; set; }
        
    }
}