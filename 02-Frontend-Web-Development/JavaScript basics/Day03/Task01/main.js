
function getRandomTwo(arr){
    var firstIndx = Math.floor(Math.random() * 5);
    var secondIndx;
    do {
        secondIndx = Math.floor(Math.random() * 5)
    } while (secondIndx == firstIndx);

    return [arr[firstIndx] , arr[secondIndx]];
}


var names = ["Ahmed","Islam","Sandra","Fatma","Ali"];

output = [
 '<h1 style="text-align:center"> Two random names among five</h1> </br>',
 `<h2 style="text-align:center">${getRandomTwo(names)} </h2> <br/>`
];

document.writeln(output);


