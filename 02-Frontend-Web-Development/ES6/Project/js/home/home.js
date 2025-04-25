import { handleApplyingFilter, handleFilterBtnsClick, handleLoader, handleSlider, makeUserLogOut, navToggler } from "./home-utilities.js";

document.addEventListener("DOMContentLoaded", function () {
  
  async function main() {
   
    navToggler();
  
    let products = await handleLoader();
  
    handleFilterBtnsClick()
  
    handleApplyingFilter(products);
  
    handleSlider();
  
    makeUserLogOut(); 
  }


  main();


});

// window.addEventListener("beforeunload", function () {
//   let path = window.location.href;
//   if (!path.includes("product-info.html") && !path.includes("cart.html")) {
//     let isRemembered = this.localStorage.getItem("rememberMe");
//     if (isRemembered === "true")
//       this.localStorage.setItem("status", "loggedIn");
//     else this.localStorage.setItem("status", "loggedOut");

//     return null;
//   }
// });

