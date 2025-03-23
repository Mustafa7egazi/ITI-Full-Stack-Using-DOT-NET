var radius, number, angel;

do{

    radius = Number(prompt("Enter a valid radius value"))

}while(isNaN(radius) || radius < 0);


do{

    number = Number(prompt("Enter a valid number to calc square root"))

}while(isNaN(number) || radius < 0);


do{

    angel = angel(prompt("Enter a valid angel"))

}while(isNaN(number));


var output = [
    `<h1 style = "text-align:center"> Circle area - square root - Cos </h1></br>`,
     `<h2 style = "text-align:center"> Circle area: PI x r^2 : ${Math.PI * radius * radius} </h2></br>`,
     `<h2 style = "text-align:center"> Square root: √${number} : ${Math.sqrt(number)} </h2></br>`,
      `<h2 style = "text-align:center"> Cos: Cos(${angel}) : ${Math.cos((Math.PI * angel)/180)} </h2></br>`
];

document.writeln(output);