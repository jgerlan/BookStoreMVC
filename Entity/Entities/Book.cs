using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity.Entities
{
    public class Book
    {
        //ID
        public long isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string publishing { get; set; }
        public int publishingNumber { get; set; }
    }
}