import { renderCartItemsAsCards } from "./cart-utilities.js"


window.addEventListener('DOMContentLoaded',()=>{

    renderCartItemsAsCards();

})

// window.addEventListener("beforeunload", function () {
//   let path = window.location.href;
//   if (!path.includes("home.html") && !path.includes("product-info.html")) {
//     let isRemembered = this.localStorage.getItem("rememberMe");
//     if (isRemembered === "true")
//       this.localStorage.setItem("status", "loggedIn");
//     else this.localStorage.setItem("status", "loggedOut");

//     return null;
//   }
// });