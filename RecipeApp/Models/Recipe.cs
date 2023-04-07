using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        public string Description { get; set; }

        [Required]
        [MinLength(2)]
        public string Ingredients { get; set; }

        // COMMENTS
        public ICollection<Comment> Comments { get; set; }
    }
}
