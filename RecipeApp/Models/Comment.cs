using System;
using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
    public class Comment
    {

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string CommentText { get; set; }

        [Required]
        public DateTime CommentDate { get; set; }
        
        // RECIPE
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
