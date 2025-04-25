import { handleLoadingInfo } from "./product-utilities.js";

document.addEventListener("DOMContentLoaded", function () {
  async function renderProductCard() {
    await handleLoadingInfo();
  }

  renderProductCard();
});

// window.addEventListener("beforeunload", function () {
//   let path = window.location.href;
//   if (!path.includes("home.html") && !path.includes("cart.html")) {
//     let isRemembered = this.localStorage.getItem("rememberMe");
//     if (isRemembered === "true")
//       this.localStorage.setItem("status", "loggedIn");
//     else this.localStorage.setItem("status", "loggedOut");

//     return null;
//   }
// });
