using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class NoteViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note1 { get; set; }
        //public Nullable<System.DateTime> CreatedOn { get; set; }
        public string IsDeleted { get; set; }

        public CategoryViewModel Category { get; set;  }
        public UserViewModel User { get; set; }
    }
}