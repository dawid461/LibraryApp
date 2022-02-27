using System;
using System.ComponentModel.DataAnnotations;

namespace LibApp.WebUI.Models
{
    public class AddOrUpdateBookFormModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Field '{0}' is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Author")]
        [Required(ErrorMessage = "Field '{0}' is required.")]
        public string AuthorName { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Field '{0}' is required.")]
        public byte GenreId { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Field '{0}' is required.")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Numbers in Stock")]
        [Required(ErrorMessage = "Field '{0}' is required.")]
        [Range(1, 20, ErrorMessage = "The stock quantity must be within the range of {1} to {2}")]
        public int NumberInStock { get; set; }
    }
}
