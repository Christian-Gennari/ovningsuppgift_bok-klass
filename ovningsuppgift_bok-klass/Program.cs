using ovningsuppgift_bok_klass;

List<Book> books = [
    new Book(),
    new Book("Pancakes", "Mabel Sirrup"),
    new Book("Are You Dancing?", "R. U. Asking", 399),
    new Book("Bricklaying", "Bill Jerome Wall"),
];

foreach (var book in books)
{
  Console.WriteLine($"{book.title} by {book.author}, {book.price} SEK");
}
