var userName , userEmail , userMobile , userPhone , color;
do{
     userName = prompt("Enter a valid name [numbers not allowed]")
}while (!isNaN(userName));

do{
     userPhone = prompt("Enter a valid 8-length phone [characters not allowed]")
}while (isNaN(userPhone) || userPhone.length != 8);

var mobileChecker = /(010|011|012)\d{8}/;
do{
     userMobile = prompt("Enter a valid 11-length phone [ Must start with 010|011|012 ]")
}while (!mobileChecker.test(userMobile));

var emailChecker = /[a-z]{3}@[0-9]{3}\.com/;
do{
     userEmail = prompt("Enter a valid email [ e.g: abc@123.com ]")
}while (!emailChecker.test(userEmail));

do {
     color = prompt("Choose you color [red or green or blue]");

} while (color != "red" && color != "green" && color != "blue");
var values = ['<h2 style="color:' + color+'">The Name is: ' + '<span style="color:black">' + userName +'</span>'  + '</h2>',
    '<h2 style="color:' + color+'">The Phone is: ' + '<span style="color:black">' + userPhone +'</span>' + '</h2>',
    '<h2 style="color:' + color+'">The Mobile is: ' + '<span style="color:black">' + userMobile +'</span>'  + '</h2>',
    '<h2 style="color:' + color+'">The Email is: ' + '<span style="color:black">' + userEmail +'</span>'  + '</h2>']
for (var index = 0; index < values.length; index++) {
    document.writeln(
        values[index]
    );
}
