using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entities;

namespace WebUI.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository repository;
    //    public int pageSize = 4;

        public BooksController(IBookRepository repo)
        {
            repository = repo;
        }
        public BooksController():base()
        {

        }

        public ViewResult List(string genre="", int page = 1)
        {
            List<Book> kek = new List<Book>
                {
                new Book { Name="Mova programs c# i platforma .Net 4.5", Author = "Troeslen e.t", Price = 1123},
                new Book { Name = "Mova programs c++ i platforma .Net 4.5", Author = "oeslen e.t", Price = 2323 },
                new Book { Name = "Mova programs c i platforma .Net 4.5", Author = "Troesn e.t", Price = 14523 },
            };

            //    BooksListViewModel model = new BooksListViewModel
            //    {
            //        Books = repository.Books
            //        .Where(b => genre == null || b.Genre == genre)
            //        .OrderBy(book => book.BookId)
            //        .Skip((page - 1) * pageSize)
            //        .Take(pageSize),
            //        PagingInfo = new PagingInfo
            //        {
            //            CurrentPage = page,
            //            ItemsPerPage = pageSize,
            //            TotalItems = genre == null ?
            //                repository.Books.Count() :
            //                repository.Books.Where(book => book.Genre == genre).Count()
            //        },
            //        CurrentGenre = genre
            //    };

            //    return View(model);
            //  return View(repository.Books);
            return View(kek);
        }
    }
}