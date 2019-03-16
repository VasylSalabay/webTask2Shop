using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Domain.Entities
{
    public class Book
    {
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "ID")]
        public int BookId { get; set; }

        [Display(Name = "Назва")]
        [Required(ErrorMessage = "Будьласка,введіть назву книги")]
        public string Name { get; set; }

        [Display(Name = "Автор")]
        [Required(ErrorMessage = "Будьласка, вкажіть ім'я автора")]
        public string Author { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описання")]
        [Required(ErrorMessage = "Будьласка, введіть описання книги")]
        public string Description { get; set; }

        [Display(Name = "Жанр")]
        [Required(ErrorMessage = "Будьласка, вкажіть жанр твору")]
        public string Genre { get; set; }

        [Display(Name = "Ціна (uah)")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Будьласка, введіть позитивне значення ціни")]
        public decimal Price { get; set; }
    }
}
