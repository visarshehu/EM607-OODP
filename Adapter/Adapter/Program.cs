using Adapter;


Adaptee adaptee = new Adaptee();
IBookProvider bookProvider = new BookAdapter(adaptee);
foreach(DTOBook b in bookProvider.GetBooks())
{
    Console.WriteLine("Book title: " + b.Title);
}
