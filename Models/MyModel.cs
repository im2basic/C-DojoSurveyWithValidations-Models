using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyIII.Models
{
    public class MyModel
    {
        [Required(ErrorMessage = "Name must be at least 3 characters long.")]
        [MinLength(3)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please choose a location.")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please choose a language.")]
        public string FavoriteLanguage { get; set; }
        [MinLength(20,ErrorMessage = "Comment must be at leaset 20 characters long.")]
        public string Comment { get; set; }
    }
}