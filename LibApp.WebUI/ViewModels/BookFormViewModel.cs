using LibApp.Application.Core.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibApp.WebUI.ViewModels
{
    public class BookFormViewModel
    {
        public IEnumerable<GenreDto> Genres { get; set; }
        public string Title
        {
            get
            {
                if (Id != 0)
                {
                    return "Edit Book";
                }

                return "New Book";
            }
        }
        public int Id { get; set; }

        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Field '{0}' is required !")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Gatunek")]
        [Required(ErrorMessage = "Field '{0}' is required !")]
        public byte GenreId { get; set; }

        [Display(Name = "Data wydania")]
        [Required(ErrorMessage = "Field '{0}' is required !")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Autor")]
        [Required(ErrorMessage = "Field '{0}' is required !")]
        public string AuthorName { get; set; }

        [Display(Name = "Identical quantity in stock")]
        [Required(ErrorMessage = "Field '{0}' is required !")]
        [Range(1, 20, ErrorMessage = "The number of books in stock must be between {1} and {2}")]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
    }
}
