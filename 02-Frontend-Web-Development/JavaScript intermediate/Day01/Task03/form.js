var form = document.getElementById("book-form");
var bookTitleInput = document.getElementById("bookTitle");
var bookPriceInput = document.getElementById("bookPrice");
var bookAuthorInput = document.getElementById("bookAuthor");
var authorEmailInput = document.getElementById("authorEmail");

var booksTable = document.getElementsByClassName("books-table")[0];
var tbody = document.getElementById("books-tbody");

var bookCount = "";
var counter = 0;
var books = [];
/** ===== Creating author factory ===== */
function Author(name, email) {
  this.name = name;
  this.email = email;
}

/** ===== Creating book factory ===== */
function Book(title, price, author) {
  this.title = title;
  this.price = price;
  this.author = author;
}

/** ===== Validate book count ===== */
function validateBookCount() {
  var bookCountInput = document.getElementById("bookCountInput");
  bookCount = bookCountInput.value.trim();
  var howMany = document.querySelector(".howMany");
  var formContainer = document.querySelector(".form-container");

  if (bookCount === "") {
    alert("Please enter a number of books");
    return;
  }

  if (isNaN(bookCount) || bookCount <= 0) {
    alert("Please enter a positive number of books");
    return;
  }

  howMany.style.display = "none";
  formContainer.style.display = "block";
}

document
  .getElementById("submitBookCount")
  .addEventListener("click", validateBookCount);

form.addEventListener("submit", function (event) {
  event.preventDefault();

  var bookTitle = bookTitleInput.value.trim();
  var bookPrice = bookPriceInput.value.trim();
  var bookAuthor = bookAuthorInput.value.trim();
  var authorEmail = authorEmailInput.value.trim();

  var isValid = true;

  if (bookTitle === "") {
    document.getElementById("bookTitle-error").innerText =
      "Book title is required";
    isValid = false;
  } else {
    document.getElementById("bookTitle-error").innerText = "";
  }

  if (bookPrice === "") {
    document.getElementById("bookPrice-error").innerText =
      "Book price is required";
    isValid = false;
  } else if (isNaN(bookPrice) || bookPrice <= 0) {
    document.getElementById("bookPrice-error").innerText =
      "Book price must be a positive number";
    isValid = false;
  } else {
    document.getElementById("bookPrice-error").innerText = "";
  }

  if (bookAuthor === "") {
    document.getElementById("bookAuthor-error").innerText =
      "Book author is required";
    isValid = false;
  } else {
    document.getElementById("bookAuthor-error").innerText = "";
  }

  if (authorEmail === "") {
    document.getElementById("authorEmail-error").innerText =
      "Author email is required";
    isValid = false;
  } else if (
    !/^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/.test(authorEmail)
  ) {
    document.getElementById("authorEmail-error").innerText =
      "Author email must be a valid email address";
    isValid = false;
  } else {
    document.getElementById("authorEmail-error").innerText = "";
  }

  if (isValid && counter < bookCount) {
    counter++;

    var author = new Author(bookAuthor, authorEmail);
    var book = new Book(bookTitle, bookPrice, author);
    books.push(book);

    // Reset form inputs
    bookTitleInput.value = "";
    bookPriceInput.value = "";
    bookAuthorInput.value = "";
    authorEmailInput.value = "";

    displayBooksData(books);

    if (counter == bookCount) {
      var formContainer = document.querySelector(".form-container");
      formContainer.style.display = "none";
    }
  }
});

function displayBooksData(books) {
  tbody.innerHTML = "";
  if (books.length > 0) {
    booksTable.style.display = "block";
  } else {
    booksTable.style.display = "none";
  }
  for (var index = 0; index < books.length; index++) {
    var row = document.createElement("tr");
    row.innerHTML = `
      <td>${books[index].title}</td>
      <td>${books[index].price}</td>
      <td>${books[index].author.name}</td>
      <td>${books[index].author.email}</td>
      <td>
        <button class="delete-btn" onclick="deleteBook(${index})">Delete</button>
        <button class="edit-btn"  onclick="editBook(${index})">Edit</button>
      </td>
    `;
    tbody.appendChild(row);
  }
}

function deleteBook(index) {
  books.splice(index, 1);
  if (books.length === 0) {
    booksTable.style.display = "none";
    document.querySelector(".howMany").style.display = "block";
  }else{
 displayBooksData(books);
  }
}

function editBook(index) {
  const row = document.querySelectorAll("tr")[index + 1];
  const tdContent = row.querySelectorAll("td");
  const book = books[index];

  tdContent[0].innerHTML = `<input type="text" value="${book.title}">`;
  tdContent[1].innerHTML = `<input type="number" value="${book.price}">`;
  tdContent[2].innerHTML = `<input type="text" value="${book.author.name}">`;
  tdContent[3].innerHTML = `<input type="email" value="${book.author.email}">`;
  tdContent[4].innerHTML = `
    <button class="save-btn edit-btn" onclick="saveBook(${index})">Save</button>
    <button class="cancel-btn delete-btn" onclick="cancelEdit()">Cancel</button>
  `;
}

function saveBook(index) {
  const row = document.querySelectorAll("tr")[index + 1];
  const tdContent = row.querySelectorAll("td");
  const book = books[index];

  book.title = tdContent[0].querySelector("input").value;
  book.price = parseFloat(tdContent[1].querySelector("input").value);
  book.author.name = tdContent[2].querySelector("input").value;
  book.author.email = tdContent[3].querySelector("input").value;

  displayBooksData(books);
}

function cancelEdit() {
  displayBooksData(books);
}
