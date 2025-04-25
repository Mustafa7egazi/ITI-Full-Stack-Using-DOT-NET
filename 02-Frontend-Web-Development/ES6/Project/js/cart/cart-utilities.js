import { checkLoginStatus } from "../home/home-utilities.js";
function renderCartItemsAsCards() {

   checkLoginStatus();

  let loader = document.getElementById("loader");
  let homePage = document.querySelector(".main-content");

  let cartItemsContainer = document.querySelector(".cart-items-container");
  cartItemsContainer.innerHTML = "";

  let allCartItems =  JSON.parse(localStorage.getItem("inCart"));
  let currentUser =JSON.parse( localStorage.getItem("currentUser"));
  let currentUserCart = allCartItems.filter(
    (item) => item.owner == currentUser.email
  );

  console.log(currentUserCart);
  let cartItems = currentUserCart || [];

  let row = document.createElement("div");
  row.classList.add(
    "row",
    "g-3",
    "justify-content-center",
    "w-100",
    "text-center"
  );
  let rowOfMoney = document.createElement("div");
  rowOfMoney.classList.add(
    "container",
    "row",
    "w-100",
    "text-center",
    "lato-bold"
  );

  // Create shipment button container
  let shipmentBtnContainer = document.createElement("div");
  shipmentBtnContainer.classList.add("container", "text-center", "my-4");

  // Create shipment button
  let shipmentBtn = document.createElement("button");
  shipmentBtn.classList.add("btn", "btn-primary", "px-4", "py-2");
  shipmentBtn.textContent = "Ship Orders";
  shipmentBtn.id = "shipOrdersBtn";

  
  shipmentBtn.style.display = cartItems.length > 0 ? "inline-block" : "none";

  const itemQuantities = {};

  let totalPrice = cartItems.reduce((total, item) => {
    itemQuantities[item.product.id] = 1;
    return total + Number(item.product.price);
  }, 0);


  rowOfMoney.innerHTML = `<h5 class="w-100 text-center">Total Money To Purchase: ${totalPrice.toFixed(
    2
  )}$</h5>`;

  cartItems.forEach((cartItem, index) => {
    let item = document.createElement("div");
    item.classList.add(
      "col-12",
      "col-md-6",
      "col-lg-4",
      "d-flex",
      "justify-content-center"
    );
    item.dataset.itemId = cartItem.product.id; // Store item ID for reference

    item.innerHTML = `
    <div class="card w-100" style="max-width: 540px; min-height: 120px;">
      <div class="row g-0 h-100">
        <div class="col-12 col-md-4 d-flex align-items-center">
          <img src="${cartItem.product.image}" 
            class="img-fluid p-2" 
            style="height: 150px; object-fit: contain;"
            alt="${cartItem.product.title}">
        </div>
        <div class="col-12 col-md-8">
          <div class="card-body d-flex flex-column h-100">
            <h5 class="card-title lato-regular txt-elips">${cartItem.product.title}</h5>
            <p class="card-text lato-regular price">Price: ${cartItem.product.price}</p>
            <div class="mt-auto">
              <p class="card-text mb-0">
                <small class="text-muted">
                  <i class="fa-solid fa-minus cursor-pointer"></i> 
                  <span class="amount mx-2">Amount: 1</span>
                  <i class="fa-solid fa-plus cursor-pointer"></i>
                </small>
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
    `;

    let plusButton = item.querySelector(".fa-plus");
    let minusButton = item.querySelector(".fa-minus");
    let amountSpan = item.querySelector(".amount");
    const itemPrice = Number(cartItem.product.price);

    plusButton.addEventListener("click", () => {
      let amount = parseInt(amountSpan.textContent.split(": ")[1]);
      amountSpan.textContent = `Amount: ${amount + 1}`;
      itemQuantities[cartItem.product.id] = amount + 1;

      totalPrice = cartItems.reduce((total, item) => {
        return (
          total +
          Number(item.product.price) * (itemQuantities[item.product.id] || 0)
        );
      }, 0);

      rowOfMoney.innerHTML = `<h5 class="w-100 text-center">Total Money To Purchase: ${totalPrice.toFixed(
        2
      )}$</h5>`;
    });

    minusButton.addEventListener("click", () => {
      let amount = parseInt(amountSpan.textContent.split(": ")[1]);
      if (amount > 1) {
        amountSpan.textContent = `Amount: ${amount - 1}`;
        itemQuantities[cartItem.product.id] = amount - 1;
      } else {
        item.remove();

        cartItems = cartItems.filter(
          (item) => item.product.id !== cartItem.product.id
        );

        localStorage.setItem("inCart", JSON.stringify(cartItems));

        delete itemQuantities[cartItem.product.id];

        if (cartItems.length === 0) {
          shipmentBtn.style.display = "none";
        }
      }

      totalPrice = cartItems.reduce((total, item) => {
        return (
          total +
          Number(item.product.price) * (itemQuantities[item.product.id] || 0)
        );
      }, 0);

      rowOfMoney.innerHTML = `<h5 class="w-100 text-center">Total Money To Purchase: ${totalPrice.toFixed(
        2
      )}$</h5>`;

      if (cartItems.length === 0) {
        rowOfMoney.innerHTML = `<h5 class="w-100 ps-5 text-center"><i class="fa-solid fa-triangle-exclamation" style="color: #0c0d0d;"></i>Your cart is empty</h5>`;
      }
    });

    row.appendChild(item);
  });

  shipmentBtn.addEventListener("click", () => {
    localStorage.removeItem("inCart");
    window.location.replace("./thank-you.html");
  });

  shipmentBtnContainer.appendChild(shipmentBtn);
  cartItemsContainer.appendChild(row);
  cartItemsContainer.appendChild(rowOfMoney);
  cartItemsContainer.appendChild(shipmentBtnContainer);

  if (cartItems.length === 0) {
    rowOfMoney.innerHTML = `<h5 class="w-100 ps-5 text-center"><i class="fa-solid fa-triangle-exclamation" style="color: #0c0d0d;"></i>Your cart is empty</h5>`;
  }

  setTimeout(() => {
    loader.style.display = "none";
    homePage.classList.remove("d-none");
    homePage.classList.add("d-block");
  }, 800);
}

export { renderCartItemsAsCards };
