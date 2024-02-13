﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository {
  public class BookRepository {
    public List<BookModel> GetAllBooks() {
      return DataSource();
    }
    public BookModel GetBookById(int id) {
      return DataSource().Where( x => x.Id == id ).FirstOrDefault();
    }
    public List<BookModel> SearchBook(string title, string authorName) {
      return DataSource().Where( x => x.Title.Contains(title) || x.Author.Contains(authorName) ).ToList();
    }
    private List<BookModel> DataSource() {
      return new List<BookModel>{
        new BookModel(){ Id = 1, Title="mvc", Author = "nitish"},
        new BookModel() { Id = 2, Title = "mvc", Author = "nitish" },
        new BookModel() { Id = 3, Title = "c#", Author = "monika" },
        new BookModel() { Id = 4, Title = "java", Author = "webgentle" },
        new BookModel() { Id = 5, Title = "php", Author = "webgentle" }
      };
    }
  }
}
