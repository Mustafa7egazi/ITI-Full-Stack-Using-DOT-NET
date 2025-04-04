var colorInput = document.getElementsByName("color")[0];

var canvas = document.querySelector("canvas");
var context = canvas.getContext("2d");

var myBtn = document.getElementsByName("button")[0];

canvas.width = window.innerWidth * 0.8;
canvas.height = window.innerHeight * 0.6;

var globalColor = colorInput.value;
var isColorChanged = false;

myBtn.addEventListener("click",function(){
    if (isColorChanged) {
        context.clearRect(0, 0, canvas.width, canvas.height);
    }
    context.strokeStyle = globalColor;
    context.lineWidth= 3;
    for (let index = 0; index < 20; index++) {
        var center = {x:Math.floor(Math.random()*window.innerWidth*0.8) ,
            y:Math.floor(Math.random()*window.innerHeight*0.6)} 
            context.beginPath();
            context.arc(center.x,center.y,r=20,0,2*Math.PI);
            context.stroke();
    }
    isColorChanged = false;
});

colorInput.addEventListener("change",function () {
    globalColor = colorInput.value;
    isColorChanged = true;
});