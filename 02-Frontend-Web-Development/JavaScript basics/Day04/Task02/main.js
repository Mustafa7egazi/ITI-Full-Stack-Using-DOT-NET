var currentImageIndex = 0;
function controlSlider(action) {
  var imgs = [
    "imgs/1.jpg",
    "imgs/2.jpg",
    "imgs/3.jpg",
    "imgs/4.jpg",
    "imgs/5.jpg",
  ];

  var img = document.getElementsByTagName("img")[0];
    if (action == "next" && currentImageIndex < imgs.length - 1) {
        currentImageIndex++;
        img.src = imgs[currentImageIndex];  
    }else if (action == "prev" && currentImageIndex > 0) {
        currentImageIndex--;
        img.src = imgs[currentImageIndex];  
    }else if(action == "next" && currentImageIndex == imgs.length - 1){
        currentImageIndex = 0;
        img.src = imgs[currentImageIndex]
    }else if(action == "prev" && currentImageIndex == 0){
        currentImageIndex = imgs.length - 1;
        img.src = imgs[currentImageIndex]
    }
    
}
