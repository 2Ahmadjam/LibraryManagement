using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.API.Common.EF
{
   public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public long StudentNumber { get; set; }
        public string Mail { get; set; }
        public string Telephne { get; set; }

    }
}
