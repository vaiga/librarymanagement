using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Librarymanagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Librarymanagement.Controllers
{
    public class RequestsController : Controller
    {
        public static List<Request> bookslist = new List<Request>();
        public ActionResult request(int UserId)
        {
            var lb = new Request();
            lb.UserId = UserId;
            return View(lb);
        }
        [HttpPost]
        public ActionResult request(Request re)
        {
            if (ModelState.IsValid)
            {
                Library libb = new Library();
                libb.request(re);
                UserDetails user = new UserDetails { UserId = re.UserId };
                string message = libb.request(re);
                if (message == "Succesfully requested")
                {

                    return RedirectToAction("User", "Home", User);
                }
                else
                {
                    ViewBag.BookRequestStatus = message;
                }
            }           
            return View(re);
        }
        public ActionResult viewrequest()
        {
            Library DB = new Library();
            bookslist = DB.List2();
            return View(bookslist);
        }
        public ActionResult RejectRequest(int id)
        {
           Request bookk = new Models.Request();
            var count = bookslist.Count();
            for (int i = 0; i < count; i++)
            {
                if (bookslist[i].RequestId == id)
                {
                    bookk = bookslist[i];
                    break;
                }
            }
            return View(bookk);
        }

        [HttpPost]
        public ActionResult RejectRequest(int id, Request bookk)
        {
            Library db = new Library();
            db.RejectRequest(bookk.RequestId);
            return RedirectToAction("viewrequest");
        }

        public ActionResult ApproveRequest(int id)
        {
            Request bookk = new Request();
            var count = bookslist.Count();
            for (int i = 0; i < count; i++)
            {
                if (bookslist[i].RequestId == id)
                {
                    bookk = bookslist[i];
                    break;
                }
            }
            return View(bookk);
        }
        [HttpPost]
        public ActionResult ApproveRequest(int id, Request bookk)
        {
            Library db = new Library();
            db.ApproveRequest(bookk.RequestId);
            db.UpdateBookStatus(bookk.BookId);
            return RedirectToAction("viewrequest");
        }
    }
}