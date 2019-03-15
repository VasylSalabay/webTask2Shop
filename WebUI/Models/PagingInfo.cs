using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; } // загальна кількість книг
        public int ItemsPerPage { get; set; } // кількість книг на сторінці
        public int CurrentPage { get; set; } // номер вказаної сторінки
        public int TotalPages // загальна кількість сторінок
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}