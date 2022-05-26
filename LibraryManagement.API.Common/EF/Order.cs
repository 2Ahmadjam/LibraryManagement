using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitapYonetim.Common.EF
{
    public class Order
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string StudentName { get; set; }
        public long StudentNumber { get; set; }
    }
}
