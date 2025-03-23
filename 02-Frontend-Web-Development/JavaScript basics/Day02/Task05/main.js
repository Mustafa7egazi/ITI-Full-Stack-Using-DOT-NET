/* Search function */
function searchForLetter(text, letter) {
  var arrOfInecies = [], arrIndex = 0;
  for (let index = 0; index < text.length; index++) {
    if (text[index].toLowerCase() == letter.toLowerCase()) {
      arrOfInecies[arrIndex] = index;
      arrIndex++;
    }
  }
  return arrOfInecies;
}

/**
 *  Taking user inputs
 */
var userInput = prompt("Enter a sentence");
var letterToSearch = prompt("Enter a letter to search for");

/** main program logic */
var output = [
  '<h1 style="text-align:center"> Searching for letter in a string</h1><hr/>',
  '<h2 style="color:red"> You have entered: <span style="color:black !important">' +
    userInput.toLowerCase() +
    "</span></h2>",
  '<h2 style="color:red"> We found your letter ' +
    "'" +
    letterToSearch.toLowerCase() +
    "' at these indices" +
    ':  <span style="color:black !important">' +
    searchForLetter(userInput, letterToSearch)  +
    "</span></h2>",
];

console.log(searchForLetter(userInput, letterToSearch));

document.writeln(output);
