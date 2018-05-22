using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace NETCore20SimpleBlog.Models.Blogs
{
    public class BlogPost
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        [Required]
        [DataType(DataType.Html)]
        public string Content { get; set; }

        public BlogPost()
        {
            
        }
        public BlogPost(string title, string author, string content)
        {
            Id = Guid.NewGuid();
            Title = title;
            Author = author;
            Content = content;
            CreateDate = DateTime.UtcNow;
        }
        public void Edit(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }
    }
}
