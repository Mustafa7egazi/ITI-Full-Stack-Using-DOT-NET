var circles = document.getElementsByClassName('circle');
var stopBtn = document.getElementById('stopBtn');
var myInterval;
var index = 0;

function resetLights() {
    for (var i = 0; i < circles.length; i++) {
        circles[i].className = 'circle gray';
    }
}


function lightUp(index) {
    resetLights();
    var label = document.getElementById('statusLabel');

    if (index === 0) {
        circles[0].className = 'circle red';
        label.innerHTML = "Stop";
        label.style.color = "#FF0000"; // Red
    } else if (index === 1) {
        circles[1].className = 'circle yellow';
        label.innerHTML = "Steady";
        label.style.color = "#FFD700"; // Yellow (Goldenrod)
    } else if (index === 2) {
        circles[2].className = 'circle green';
        label.innerHTML = "Go";
        label.style.color = "#00AA00"; // Green
    }
}



function startTrafficLight() {
    index = 0;
    myInterval = setInterval(function () {
        lightUp(index);
        index = index + 1;
        if (index > 2) {
            index = 0;
        }
    }, 1500);
}


stopBtn.onclick = function () {
    clearInterval(myInterval);
};


startTrafficLight();
