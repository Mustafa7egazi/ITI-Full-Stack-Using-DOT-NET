
window.onload=function () {
  setTimeout(() => {
    document.querySelector(".preloader").style.display = "none";
  }, 2000); // Adjust the timeout duration as needed
};
window.onscroll = function () {
  if (scrollY > 450) {
    var categories = document.getElementsByClassName("category-col");
    categories[0].style.animation = "FadeInLeftRight 1.5s forwards";
    categories[1].style.animation = "FadeInLeftRight 1.5s forwards";
    categories[2].style.animation = "FadeInLeftRight 1.5s forwards";

    if (scrollY > 900) {
      var products = document.querySelectorAll(".product-col");
      products.forEach((product, index) => {
        setTimeout(() => {
          product.classList.add("animated"); // Adds class, allowing transform to transition
        }, index * 400); // Staggered delay
      });
    }
  }
};
