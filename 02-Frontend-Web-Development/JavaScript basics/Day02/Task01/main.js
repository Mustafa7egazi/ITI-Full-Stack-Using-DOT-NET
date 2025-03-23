function countsE(userInput){
var count = 0;
for (var index = 0; index < userInput.length; index++) {
    if (userInput[index].toLowerCase() == 'e') {
        count+=1
    }
}
return count;
}

var userInput = prompt("Enter your name to count e");
document.writeln('<h1>' +userInput + ' have '+countsE(userInput)+ ' # of e');