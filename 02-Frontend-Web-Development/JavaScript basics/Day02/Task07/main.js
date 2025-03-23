/** Declaring required functions */
function square(number){
return number * number;
}
function processArray(arrOfValues,square) {
    for (let index = 0; index < arrOfValues.length; index++) {
       arrOfValues[index] = square(arrOfValues[index])
    }

    return arrOfValues;
}


console.log(processArray([1,2,3,4],square));