var sum = 0;
var recievedValue = 0;
do {
  recievedValue = Number(prompt("Enter a number to sum, 0 to exit"));
  if (!isNaN(recievedValue)) sum += recievedValue;
} while (sum < 100 && recievedValue != 0);

document.writeln("<h1>" +"Your sumation is "+ sum + "</h1>" );
