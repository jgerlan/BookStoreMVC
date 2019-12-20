using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities;

namespace Repository.DAO
{
    interface IBookDAO
    {
        List<BookEntity> getAllBooks();
        void updateBook();
        void deleteBook();
        void addBook();
    }
}
