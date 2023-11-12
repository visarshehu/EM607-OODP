using System;
namespace Adapter
{
	public interface IBookProvider
	{
		public List<DTOBook> GetBooks();
	}

}

