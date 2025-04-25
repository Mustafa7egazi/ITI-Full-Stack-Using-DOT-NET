import Modal from "../global-utility.js";

function shuffle(array) {
  let i = array.length,
    j,
    temp;
  while (--i > 0) {
    j = Math.floor(Math.random() * (i + 1));
    temp = array[j];
    array[j] = array[i];
    array[i] = temp;
  }
  return array;
}

function navToggler() {
  let toggler = document.getElementById("customNavbarToggler");
  let navbarCollapse = document.getElementById("navbarNav");

  toggler.addEventListener("click", function () {
    navbarCollapse.classList.toggle("show");
    let isExpanded = navbarCollapse.classList.contains("show");
    this.setAttribute("aria-expanded", isExpanded);
  });

  document.addEventListener("click", function (event) {
    if (
      !toggler.contains(event.target) &&
      !navbarCollapse.contains(event.target)
    ) {
      navbarCollapse.classList.remove("show");
      toggler.setAttribute("aria-expanded", "false");
    }
  });
}

function handleSlider() {
  let slides = document.querySelectorAll(".slider-item");
  let currentIndex = 0;

  let showSlide = (index, direction = "right") => {
    slides.forEach((slide, i) => {
      slide.classList.add("d-none");
      slide.classList.remove("active", "slide-in-left", "slide-in-right");
    });

    let nextSlide = slides[index];
    nextSlide.classList.remove("d-none");
    nextSlide.classList.add("active");

    // Apply the correct animation
    if (direction === "right") {
      nextSlide.classList.add("slide-in-right");
    } else {
      nextSlide.classList.add("slide-in-left");
    }
  };

  document.getElementById("next-slide").addEventListener("click", (e) => {
    e.preventDefault();
    let nextIndex = (currentIndex + 1) % slides.length;
    showSlide(nextIndex, "right");
    currentIndex = nextIndex;
  });

  document.getElementById("prev-slide").addEventListener("click", (e) => {
    e.preventDefault();
    let prevIndex = (currentIndex - 1 + slides.length) % slides.length;
    showSlide(prevIndex, "left");
    currentIndex = prevIndex;
  });

  showSlide(currentIndex);
}

async function handleLoader() {
  checkLoginStatus();
  addToCart();
  let loader = document.getElementById("loader");
  let homePage = document.querySelector(".main-content");

  let username = JSON.parse(localStorage.getItem("currentUser")).name;
  username !== ""
    ? (document.getElementById("username").innerHTML = username)
    : (document.getElementById("username").innerHTML = "Guest");

    let response,products;
  try {
     response = await fetch("https://fakestoreapi.com/products");
     products = await response.json();
  } catch (error) {
    let warningModal = new Modal({
      title: "Time out!",
      message: "Please reload",
      type: "warning",
    });
    warningModal.open();  
  }

  products = shuffle(products);
  console.log(products);

  let productContainer = document.querySelector(".products-container");
  let row = document.createElement("div");
  row.classList.add("row", "product-row", "position-relative");

  for (let product of products) {
    let item = document.createElement("div");
    item.classList.add(
      "col-12",
      "col-md-6",
      "col-lg-4",
      "position-relative",
      "card-container"
    );
    item.innerHTML = `<div class="card mb-4">
     <div class="image-container position-relative">
        <img src="${product.image}" class="card-img-top" alt="...">
        <div class="overlay">
          <div class="text"><i class="fa-solid fa-circle-info" data-product="${encodeURIComponent(
      JSON.stringify(product)
    )}"> Product Info </i></div>
        </div>
      </div>
      <div class="card-body">
        <h5 class="card-title lato-regular txt-elips">${product.title}</h5>
        <p class="card-text lato-regular">Price: ${product.price}$</p>
        <a href="#" class="btn btn-warning text-light lato-regular add-to-cart" data-product="${encodeURIComponent(
      JSON.stringify(product)
    )}">Add To Cart</a>
      </div>
    </div>`;

    let addToCartBtn = item.querySelector(".add-to-cart");
    let showInfo = item.querySelector(".fa-circle-info");
    addToCartBtn.addEventListener("click", function (e) {
      e.preventDefault();
      let product = JSON.parse(decodeURIComponent(this.dataset.product));
      addToCart(product);
    });

    showInfo.addEventListener("click", function (e) {
      e.preventDefault();
      let product = JSON.parse(decodeURIComponent(this.dataset.product));
      window.location.replace(`./product-info.html?id=${product.id}`);
    });

    row.appendChild(item);
  }

  productContainer.appendChild(row);
  setTimeout(() => {
    loader.style.display = "none";
    homePage.classList.remove("d-none");
    homePage.classList.add("d-block");
  }, 800);

  return products;
}

function addToCart(product) {
  let arrOfInCartProducts = JSON.parse(localStorage.getItem("inCart")) || [];
  let currentUser = JSON.parse(localStorage.getItem("currentUser"));
 
  let cartIcon = document.querySelector(".shoping-cart");
  let alreadyInCart;
  if (arrOfInCartProducts != [] && product) {
    alreadyInCart = arrOfInCartProducts.find((item) => {
      return item.id == product.id && item.owner == currentUser.email;
    });
  }

  if (product && !alreadyInCart) {
    arrOfInCartProducts.push({
      id: product.id,
      product: product,
      owner: currentUser.email,
    });
    localStorage.setItem("inCart", JSON.stringify(arrOfInCartProducts));
    let warningModal = new Modal({
      title: "Item added to the cart!",
      message: "you can customize the quantity in the cart page!",
      type: "success",
    });
    warningModal.open();
  } else if (product && alreadyInCart) {
    let warningModal = new Modal({
      title: "This item already added!",
      message: "you can customize the quantity in the cart page!",
      type: "warning",
    });
    warningModal.open();
  }

  if (window.location.href.includes("home.html")) {
    let hasItems = arrOfInCartProducts.find(
      (item) => item.owner === currentUser.email
    );
    cartIcon.style.setProperty(
      "--cart-badge-display",
      hasItems ? "block" : "none"
    );

    let currentUserCart = arrOfInCartProducts.filter((cartItem)=>{
      return cartItem.owner == currentUser.email;
    });
    cartIcon.setAttribute("data-count", currentUserCart.length);

    cartIcon.replaceWith(cartIcon.cloneNode(true)); // clean events from node
    cartIcon = document.querySelector(".shoping-cart");


    cartIcon.addEventListener("click", () => {
      let items = arrOfInCartProducts.find(
        (item) => item.owner === currentUser.email
      );
      if (items) {
        window.location.replace("./cart.html");
      } else {
        let warningModal = new Modal({
          title: "You cart is Empty!",
          message: "Add items to your cart first!",
          type: "warning",
        });
        warningModal.open();
      }
    });
  }
}

function checkLoginStatus() {
  let status = localStorage.getItem("status");
  let remembered = localStorage.getItem("rememberMe");
  if (status === "loggedOut" && remembered === "false") {
    window.location.replace("../index.html");
  }
}

function makeUserLogOut() {
  let logOutBtn = document.getElementById("logout");
  logOutBtn.addEventListener("click", function () {
    localStorage.setItem("currentUser", "");

    localStorage.setItem("status", "loggedOut");
    localStorage.setItem("rememberMe", "false");
    window.location.replace("../index.html");
  });
}

function handleFilterBtnsClick() {
  let priceBtn = document.querySelector(".price-btn");
  let categoryBtn = document.querySelector(".category-btn");
  let allBtn = document.querySelector(".all-btn");
  let priceFilter = document.querySelector(".filter-price");
  let categoryFilter = document.querySelector(".filter-category");

  allBtn.addEventListener("click", function () {
    allBtn.classList.add("active");
    priceBtn.classList.remove("active");
    categoryBtn.classList.remove("active");
    priceFilter.classList.add("d-none");
    categoryFilter.classList.add("d-none");
  });

  priceBtn.addEventListener("click", function () {
    allBtn.classList.remove("active");
    priceBtn.classList.add("active");
    categoryBtn.classList.remove("active");

    priceFilter.classList.remove("d-none");
    categoryFilter.classList.add("d-none");
  });

  categoryBtn.addEventListener("click", function () {
    allBtn.classList.remove("active");
    priceBtn.classList.remove("active");
    categoryBtn.classList.add("active");
    document.querySelector(".filter-category").classList.remove("d-none");
    document.querySelector(".filter-price").classList.add("d-none");
  });
}

function handleApplyingFilter(products) {
  let categorySelect = document.querySelector(".categorySelect");
  let priceFrom = document.getElementById("price-from");
  let priceTo = document.getElementById("price-to");
  let applyPriceFilter = document.querySelector(".applyPriceFilter");
  let applyCategoryFilter = document.querySelector(".applyCategoryFilter");
  let allWithNoFilter = document.querySelector(".all-btn");

  let categoryMap = {
    men: "men's clothing",
    women: "women's clothing",
    electronic: "electronics",
  };

  function filterProducts(products, min, max, selectedCategory) {
    if (min && max && min > max) {
      [min, max] = [max, min];
    }

    let categories = [];
    if (selectedCategory && selectedCategory !== "ALL") {
      let mapped =
        categoryMap[selectedCategory.toLowerCase()] || selectedCategory;
      categories = [mapped.toLowerCase()];
    } else {
      categories = Object.values(categoryMap).map((c) => c.toLowerCase());
    }

    return products.filter((product) => {
      let productCategory = product.category.toLowerCase();
      let inCategory = categories.includes(productCategory);

      let priceOk = true;
      if (min && max) priceOk = product.price >= min && product.price <= max;
      else if (min) priceOk = product.price >= min;
      else if (max) priceOk = product.price <= max;

      return inCategory && priceOk;
    });
  }

  allWithNoFilter.onclick = () => {
    reRenderProducts(products);
  };

  applyPriceFilter.addEventListener("click", () => {
    let min = Number(priceFrom.value);
    let max = Number(priceTo.value);
    let selectedCategory = categorySelect.value;
    let filtered = filterProducts(products, min, max, selectedCategory);
    reRenderProducts(filtered);
  });

  applyCategoryFilter.addEventListener("click", () => {
    let min = Number(priceFrom.value);
    let max = Number(priceTo.value);
    let selectedCategory = categorySelect.value;
    let filtered = filterProducts(products, min, max, selectedCategory);
    reRenderProducts(filtered);
  });
}

function reRenderProducts(listOfFilteredProducts) {
  console.log(listOfFilteredProducts);
  let productContainer = document.querySelector(".products-container");
  productContainer.innerHTML = "";
  let row = document.createElement("div");
  row.classList.add("row", "product-row");

  if (listOfFilteredProducts.length > 0) {
    for (let product of listOfFilteredProducts) {
      let item = document.createElement("div");
      item.classList.add("col-12", "col-md-6", "col-lg-4");

      item.innerHTML = `<div class="card mb-4">
        <div class="image-container position-relative">
          <img src="${product.image}" class="card-img-top" alt="...">
          <div class="overlay">
            <div class="text"><i class="fa-solid fa-circle-info" data-product="${encodeURIComponent(
              JSON.stringify(product)
            )}"> Product Info </i></div>
          </div>
        </div>
        <div class="card-body">
          <h5 class="card-title lato-regular txt-elips">${product.title}</h5>
          <p class="card-text lato-regular">Price: ${product.price}$</p>
          <a href="#" class="btn btn-warning text-light lato-regular add-to-cart" data-product="${encodeURIComponent(
            JSON.stringify(product)
          )}">Add To Cart</a>
        </div>
      </div>`;

      let addToCartBtn = item.querySelector(".add-to-cart");
      let showInfo = item.querySelector(".fa-circle-info");
      addToCartBtn.addEventListener("click", function (e) {
        e.preventDefault();
        let product = JSON.parse(decodeURIComponent(this.dataset.product));
        addToCart(product);
      });

      showInfo.addEventListener("click", function (e) {
        e.preventDefault();
        let product = JSON.parse(decodeURIComponent(this.dataset.product));
        window.location.replace(`./product-info.html?id=${product.id}`);
      });

      row.appendChild(item);
    }
  } else {
    // let item = document.createElement("div");
    // item.classList.add("col-12", "col-md-6", "col-lg-4", "w-100");

    // item.innerHTML = `<h3 class="w-100 text-center"> There are no products in this range</h3>`;
    // row.appendChild(item);

    let warningModal = new Modal({
      title: "Products mismatch!",
      message: "There are no products in this range!",
      type: "warning",
    });
    warningModal.open();

    setTimeout(() => {
      window.location.reload();
    }, 1000);

  }

  productContainer.appendChild(row);
}

export {
  navToggler,
  handleLoader,
  checkLoginStatus,
  handleSlider,
  makeUserLogOut,
  handleFilterBtnsClick,
  handleApplyingFilter,
  addToCart,
};
