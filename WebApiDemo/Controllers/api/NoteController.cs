using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers.api
{
    public class NoteController : ApiController

    {

        public NoteController()
        {
        }

        //Get action methods of the previous section

        public IHttpActionResult PostNewStudent(NoteViewModel student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new NotesApiEntities())
            {
                ctx.Notes.Add(new Note()
                {
                    Id = student.Id,
                    Title = student.Title,
                    Note1 = student.Note1
                });

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
