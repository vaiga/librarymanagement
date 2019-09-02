using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Librarymanagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Librarymanagement.Controllers
{
    public class suggestionsController : Controller
    {
        public static List<suggestion> bookslist = new List<suggestion>();
        public ActionResult suggest(int UserId)
        {
            var lb = new suggestion();
            lb.UserId = UserId;
            return View(lb);

           
            
        }
        [HttpPost]
        public IActionResult suggest(suggestion su)
        {
            if (ModelState.IsValid)
            {

                Library libb = new Library();
                libb.suggest(su);
            }

           
            
            return View(su);
        }
        public IActionResult viewsuggestion()
        {
            Library DB = new Library();
            bookslist = DB.list2();
            return View(bookslist);
        }
        public ActionResult Reject(int id)
        {
            suggestion bookk = new suggestion();
            var count = bookslist.Count();
            for (int i = 0; i < count; i++)
            {
                if (bookslist[i].SuggestionId == id)
                {
                    bookk = bookslist[i];
                    break;
                }
            }
            return View(bookk);
        }
        [HttpPost]
        public IActionResult Reject(int id, suggestion bookk)

        {
            Library db = new Library();

            db.Reject(bookk.SuggestionId);

            return RedirectToAction("viewsuggestion");
        }

        public ActionResult Approve(int id)
        {
            suggestion bookk = new suggestion();
            var count = bookslist.Count();
            for (int i = 0; i < count; i++)
            {
                if (bookslist[i].SuggestionId == id)
                {
                    bookk = bookslist[i];
                    break;
                }
            }
            return View(bookk);
        }
        [HttpPost]
        public IActionResult Approve(int id, suggestion bookk)

        {
            Library db = new Library();
            db.Approve(bookk.SuggestionId);
            suggestion newbookk = new suggestion();
            newbookk.BookAuthor = bookk.BookAuthor;
            newbookk.BookName = bookk.BookName;
            newbookk.BookPublishedYear = Convert.ToInt32(bookk.BookPublishedYear);
            newbookk.BookCategory = bookk.BookCategory;
            
            return RedirectToAction("viewsuggestion");

        }

    }
}