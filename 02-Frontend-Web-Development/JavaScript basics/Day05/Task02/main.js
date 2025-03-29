// main.js
var currentImageIndex = 0;
var autoplayInterval = null;

const imgs = [
    "imgs/1.jpg",
    "imgs/2.jpg",
    "imgs/3.jpg",
    "imgs/4.jpg",
    "imgs/5.jpg",
];

function updateImage() {
    var img = document.querySelector(".slides img");
    img.src = imgs[currentImageIndex];
}

function controlSlider(action) {
    if (action === "next") {
        currentImageIndex = (currentImageIndex < imgs.length - 1) 
            ? currentImageIndex + 1 
            : 0;
    } else if (action === "prev") {
        currentImageIndex = (currentImageIndex > 0) 
            ? currentImageIndex - 1 
            : imgs.length - 1;
    }
    updateImage();
}

function startAutoplay() {
    if (!autoplayInterval) {
        autoplayInterval = setInterval(() => {
            controlSlider("next");
        }, 2000);
    }
}

function stopAutoplay() {
    if (autoplayInterval) {
        clearInterval(autoplayInterval);
        autoplayInterval = null;
    }
}