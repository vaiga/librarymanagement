using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Librarymanagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace Librarymanagement.Controllers
{
    public class booksController : Controller
    {
        public static List<librarymodel> booklist = new List<librarymodel>();
        
        public ActionResult BOOKS()
        {
            Library DB = new Library();
            booklist = DB.BOOKS();
            return View(booklist);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
     
        public ActionResult Create(librarymodel lb)
        {
            if (ModelState.IsValid)
            {
                Library libb = new Library();
                    string message = libb.Create(lb);
                    if (message == "Book added to library")
                    {

                        return RedirectToAction("BOOKS");
                    }
                    else
                    {
                        ViewBag.Bookexists = message;
                    }                               
            }
            return View();
        }
        public ActionResult Details(int Id)
        {
            Library bookk = new Library();
            
            var libb = bookk.Details(Id);
            return View(libb);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var lb = new librarymodel();
            for (int i = 0; i < booklist.Count; i++)
            {
                if (id == booklist[i].BookId)
                {
                    lb = booklist[i];
                    break;
                }
            }
            return View(lb);
        }

        [HttpPost]
        public ActionResult Edit(librarymodel lb)
        {
            Library libb = new Library();
            libb.Edit(lb);
            return RedirectToAction("books","BOOKS");
        }
        public ActionResult Delete(int id)
        {
            librarymodel bookk = new librarymodel();
            var count = booklist.Count();
            for (int i = 0; i < count; i++)
            {
                if (booklist[i].BookId == id)
                {
                    bookk = booklist[i];
                    break;
                }
            }
            return View(bookk);
        }
        [HttpPost]
        public ActionResult Delete(librarymodel bookk)
        {
            Library db = new Library();
            db.Delete(bookk.BookId);
            return RedirectToAction("books","BOOKS");
        }
        [HttpGet]
        public ActionResult search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult search(string bookName)
        {
            Library db = new Library();
            librarymodel bookk = db.search(bookName);
            return View(bookk);
        }
    }
}




