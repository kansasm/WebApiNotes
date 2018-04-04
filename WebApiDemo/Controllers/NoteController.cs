using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class NoteController : Controller
    {
        public ActionResult Index()
        {
            //consume Web API Get method here.. 

            return View();
        }

        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(NoteViewModel note)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56825/api/student");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<NoteViewModel>("student", note);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(note);
        }
    }
}