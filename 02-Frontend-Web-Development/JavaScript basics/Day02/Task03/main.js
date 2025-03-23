/* Functions of 3 operations [Add , Multiply , Divide] */
function addition(arrOfValues){
    var total = 0;
    for (let index = 0; index < arrOfValues.length; index++) {
        total+=arrOfValues[index];
    }

    return total;
}

function multiplication(arrOfValues){
    var total = 1;
    for (let index = 0; index < arrOfValues.length; index++) {
        total*=arrOfValues[index];
    }
    return total;
}

function division(arrOfValues){
    var total = arrOfValues[0];
    for (let index = 1; index < arrOfValues.length; index++) {
        total/=arrOfValues[index];
    }
    return total;
}
/****************************************************************/

/*Declare operands*/
var firstOperand , secondOperand , thirdOperand, values = [];

/* Getting numbers from user*/ 
do{
    firstOperand = Number(prompt("Enter a valid first number "));
    values[0] = firstOperand;
}while(isNaN(firstOperand));

do{
    secondOperand = Number(prompt("Enter a valid second number, not allowing 0 [can't divide by 0] "));
    values[1] = secondOperand;
}while(isNaN(secondOperand)|| secondOperand == 0);

do{
    thirdOperand = Number(prompt("Enter a valid third number, not allowing 0 [can't divide by 0] "));
    values[2] = thirdOperand;
}while(isNaN(thirdOperand)|| thirdOperand == 0);

/*****************************************************************/
/**
 *  Doing main logic
 */


var outputStructure = [
    '<h1 style="text-align:center"> Adding - Multiplying - And Dividing 3 values</h1><hr/>',
    '<h2 style="color:red"> The sum of the 3 values: <span style="color:black !important">'
      + values.join(" + ") + ' = ' + addition(values) +  '</span></h2>',
      '<h2 style="color:red"> The Multiplication of the 3 values: <span style="color:black !important">'
      + values.join(" x ") + ' = ' + multiplication(values) +  '</span></h2>',
      '<h2 style="color:red"> The division of the 3 values: <span style="color:black !important">'
      + values.join(" / ") + ' = ' + division(values) +  '</span></h2>'
];

document.writeln(outputStructure);



