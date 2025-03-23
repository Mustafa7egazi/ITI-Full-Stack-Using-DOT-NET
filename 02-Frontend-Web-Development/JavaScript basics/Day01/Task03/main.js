do {
    var userInput = Number(prompt("Please enter a number!"));
 
} while (isNaN(userInput));

if (userInput % 3 == 0 && userInput % 5 != 0) {
    document.writeln("<h1>" +" Output: FIZZ " + "</h1>" );
}else if (userInput % 5 == 0 && userInput % 3 != 0  ) {
    document.writeln("<h1>" +" Output: BUZZ " + "</h1>" );
}else if(userInput % 5 == 0 && userInput % 3 == 0 ){
    document.writeln("<h1>" +" Output: FIZZBUZZ " + "</h1>" );
}else{
    document.writeln("<h1>" +" Output: NONE " + "</h1>" );
}