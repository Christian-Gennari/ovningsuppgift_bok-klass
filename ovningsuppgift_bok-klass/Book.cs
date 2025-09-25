using System;

namespace ovningsuppgift_bok_klass;


public class Book
{
  public string title = "Okänd";
  public string author = "Okänd";
  public int price = 199;

  public Book() { }

  public Book(string title, string author)
  {
    this.title = title;
    this.author = author;
  }

  public Book(string title, string author, int price)
  {
    this.title = title;
    this.author = author;
    this.price = price;
  }

}



