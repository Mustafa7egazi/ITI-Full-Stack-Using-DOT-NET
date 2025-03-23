/**
 * 
sorting functions
 */
var asc = function(a,b){
    return  a-b;
}

var desc = function(a,b){
    return  b-a;
}

/** Take user values */
var userValues = [];
for (let index = 0; index < 5; index++) {
    var value = Number(prompt("Enter numeric value #"+(index+1)));
    isNaN(value)? index-- : userValues[index] = value;
}

var outputStructure = [
    '<h1 style="text-align:center"> Sorting 5 values</h1><hr/>',
    '<h2 style="color:red"> You have entered: <span style="color:black !important">'
       + userValues +  '</span></h2>',
     '<h2 style="color:red"> Your values after asc sort: <span style="color:black !important">'
       + userValues.sort(asc) +  '</span></h2>',
      '<h2 style="color:red"> Your values after desc sort: <span style="color:black !important">'
       + userValues.sort(desc) +  '</span></h2>'
];


document.writeln(outputStructure);