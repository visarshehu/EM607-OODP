using System;

namespace Adapter
{
	public class BookAdapter : IBookProvider
	{
        Adaptee _bookService;

		public BookAdapter(Adaptee bookService)
		{
            _bookService = bookService;
		}

        public List<DTOBook> GetBooks()
        {
            string data = _bookService.GetCVS();
            string[] lines = data.Split('\n');
            List<DTOBook> lstBooks = new List<DTOBook>();

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;

                DTOBook book = new DTOBook();
                book.FirstName = line.Split(",")[0];
                book.LastName = line.Split(",")[1];
                book.Title = line.Split(",")[2];
                lstBooks.Add(book);
            }
            return lstBooks;
        }
    }
}

