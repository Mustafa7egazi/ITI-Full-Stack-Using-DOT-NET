import { addToCart } from "../home/home-utilities.js";
import { checkLoginStatus } from "../home/home-utilities.js";
async function handleLoadingInfo() {
  checkLoginStatus();

  let loader = document.getElementById("loader");
  let mainPage = document.querySelector(".main-content");

  let id = window.location.href.split("=")[1];

  let response = await fetch(`https://fakestoreapi.com/products/${id}`);
  let product = await response.json();
  console.log(product);

  let cardContainer = document.querySelector(".cart-item-container");
  let card = document.createElement("div");
  card.classList.add("container");
  card.innerHTML = `
    <div class="card mb-3 mx-auto" style="max-width: 540px;">
  <div class="row g-0 align-items-center">
    <div class="col-md-4">
      <img src="${product.image}" class="img-fluid rounded-start" alt="...">
    </div>
    <div class="col-md-8">
      <div class="card-body">
        <h5 class="card-title lh-1">${product.title}</h5>
        <p class="card-text my-auto"><span class="lato-bold">Desc: </span>${
          product.description
        }</p>
        <p class="card-text mt-3 mb-auto"><span class="lato-bold">Category: </span>${
          product.category
        }</p>
        <p class="card-text my-auto"><span class="lato-bold">Price: </span>${
          product.price
        }$</p>
        <p class="card-text my-auto"><span class="lato-bold">Purchaed by: </span>${
          product.rating.count
        } person</p>
        <p class="card-text my-auto"><span class="lato-bold">Rating: </span>${
          product.rating.rate
        } out of 5 <i class="fa fa-star"></i></p>
        <button class="btn btn-warning" data-product="${encodeURIComponent(
          JSON.stringify(product)
        )}">Add to cart and purchase</button>
      </div>
    </div>
  </div>
</div>
    `;

  let addToCartBtn = card.querySelector(".btn-warning");
  addToCartBtn.addEventListener("click", function (e) {
    e.preventDefault();
    let product = JSON.parse(decodeURIComponent(this.dataset.product));
    addToCart(product);
    window.location.replace("./cart.html");
  });
  cardContainer.appendChild(card);

  setTimeout(() => {
    loader.classList.add("d-none");
    mainPage.classList.remove("d-none");
  }, 800);
}

export { handleLoadingInfo };
