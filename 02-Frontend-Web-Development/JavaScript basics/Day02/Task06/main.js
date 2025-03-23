/* Functions of 4 operations [Add, Subtract , Multiply , Divide] and Callback */
function addition(num1 , num2){ return num1+num2; }
function Subtraction(num1 , num2){ return num1-num2; }
function multiplication(num1 , num2){ return num1*num2; }
function division(num1 , num2){ return num1/num2; }
function applyOperation(num1,num2,operation){
    return operation(num1,num2);
}

/** Taking user input */
var  firstOperand , secondOperand;

do {
    firstOperand = Number(prompt("Enter a valid first operand"));
} while (isNaN(firstOperand));

do {
    secondOperand = Number(prompt("Enter a valid second operand [Note: no division by zero]"));
} while (isNaN(secondOperand) || secondOperand == 0);



/** main program logic */
var outputStructure = [
    '<h1 style="text-align:center"> Adding - Subtracting - Multiplying - Dividing 2 with Callback values</h1><hr/>',
    '<h2 style="color:red"> The Sum of the 2 values: <span style="color:black !important">'
      + applyOperation(firstOperand,secondOperand,addition) +  '</span></h2>',
      '<h2 style="color:red"> The Subtraction of the 2 values: <span style="color:black !important">'
      + applyOperation(firstOperand,secondOperand,Subtraction) +  '</span></h2>',
      '<h2 style="color:red"> The Multiplication of the 32 values: <span style="color:black !important">'
       + applyOperation(firstOperand,secondOperand,multiplication) +  '</span></h2>',
       '<h2 style="color:red"> The Division of the 2 values: <span style="color:black !important">'
        + applyOperation(firstOperand,secondOperand,division) +  '</span></h2>'
];

document.writeln(outputStructure);
 
