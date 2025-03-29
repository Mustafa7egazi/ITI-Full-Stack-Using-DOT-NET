// task3.js
var myMessage = "Your message will be displayed character by character :) <br>" +
    "few seconds and this window will be terminated";

var newWindow;
var index = 0;
var messageText = "";

function typeMessage() {
    if (index < myMessage.length) {
        messageText += myMessage.charAt(index);
        newWindow.document.write(myMessage.charAt(index));
        index++;
        setTimeout(typeMessage, 80); 
    } else {
        setTimeout(() => {
            newWindow.close();
        }, 3000);
    }
}

function showMyMessageWindow() {
   
    newWindow = window.open("", "MessageWindow", "width=600,height=200");
    newWindow.open();
    typeMessage();
}