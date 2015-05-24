using Microsoft.AspNet.Mvc.Rendering;
using MoreTagHelpers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoreTagHelpers.ViewModels
{
    public class AddMovieVM
    {
        [Required(ErrorMessage = "Please enter a title for this movie.")]
        [Display(Name = "Title:")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please select a release date for this movie.")]
        [Display(Name = "Release Date:")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter a running time for this movie")]
        [Range(1, 1000, ErrorMessage = "The running time must be between 1 and 1000 minutes.")]
        [Display(Name = "Running Time:")]
        public int RunningTime { get; set; }

        [Display(Name = "Description:")]
        public string Description { get; set; }

        [Display(Name = "Genre:")]
        public int SelectedGenre { get; set; }
        public List<SelectListItem> AllGenres { get; set; }
    }
}
