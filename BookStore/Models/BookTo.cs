using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;

namespace BookStore.Models
{
    public static class BookTo
    {
        public static HttpClient HttpClient { get; }

        static BookTo()
        {
            HttpClient = new HttpClient();
        }

        public static string POST(BookModel book)
        {



            return "";
        }
    }
}