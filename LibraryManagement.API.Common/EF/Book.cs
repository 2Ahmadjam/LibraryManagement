using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitapYonetim.Common.EF
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }

    }
    
}