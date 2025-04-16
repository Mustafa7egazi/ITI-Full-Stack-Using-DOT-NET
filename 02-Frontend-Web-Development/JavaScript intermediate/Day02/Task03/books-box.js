function Book(title, numofChapters, author, numOfPages) {
  this.title = title;
  this.numofChapters = numofChapters;
  this.author = author;
  this.numOfPages = numOfPages;
}

function Box(width, height, length) {
  this.width = width;
  this.height = height;
  this.length = length;
  this.volume = this.width * this.height * this.length;
  this.content = [];
}

Box.prototype.addBook = function (book) {
  for (var index = 0; index < this.content.length; index++) {
    if (this.content[index].title === book.title) {
      return "Book already exists in the box.";
    }
  }
  this.content.push(book);
  return "Book added to the box.";
};

Box.prototype.removeBook = function (book) {
  for (var index = 0; index < this.content.length; index++) {
    if (this.content[index].title === book.title) {
      this.content.splice(index, 1);
      return "Book removed from the box.";
    } else {
      return "Book not found in the box.";
    }
  }
};

Box.prototype.countBooks = function () {
  return this.content.length;
};

Box.prototype.toString = function () {
  var boxString =
    "Box dimensions: " + this.width + " x " + this.height + " x " + this.length;
  boxString += " | Volume: " + this.volume;
  boxString += " | # Books in the box: " + this.countBooks();
  return boxString;
};

Box.prototype.valueOf = function () {
  return this.countBooks();
};

var book1 = new Book("Book 1", 10, "Author 1", 200);
var book2 = new Book("Book 2", 5, "Author 2", 150);
var book3 = new Book("Book 3", 8, "Author 3", 300);

var box = new Box(10, 20, 30);
box.addBook(book1);
box.addBook(book2);
box.addBook(book3);

console.log(box);
