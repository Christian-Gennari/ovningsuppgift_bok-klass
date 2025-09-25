using System;

namespace ovningsuppgift_bok_klass;

public class Book
{
  public string title;
  public string author;
  public int price;

  public Book()
  {
    title = "Okänd";
    author = "Okänd";
    price = 199;
  }

  public Book(string title, string author)
  {
    this.title = title;
    this.author = author;
    this.price = 199;
  }

  public Book(string title, string author, int price)
  {
    this.title = title;
    this.author = author;
    this.price = price;
  }
}



