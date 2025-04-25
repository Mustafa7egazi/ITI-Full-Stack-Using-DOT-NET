import {
  validateIfEmpty,
  showAuthScreensMessage,
  saveUserLocalStorage,
  searchInLocalStorage,
  checkCredintials,
  resetInputs,
  togglePasswordVisibility
} from "./auth-utilities.js";

let loginMessage = document.getElementsByClassName("login-message")[0];
let registerMessage = document.getElementsByClassName("register-message")[0];
let loginBtn = document.getElementById("login-btn");
let registerBtn = document.getElementById("register-btn");
//inputs at login
let emailAtLogin = document.getElementById("emailAtLogin");
let passwordAtLogin = document.getElementById("passwordAtLogin");
//inputs at register
let nameAtRegister = document.getElementById("nameAtRegister");
let emailAtRegister = document.getElementById("emailAtRegister");
let passwordAtRegister = document.getElementById("passwordAtRegister");
let confirmPasswordAtRegister = document.getElementById("confirmPasswordAtRegister");



document.addEventListener("DOMContentLoaded", function () {
  if (window.location.href.includes("index.html")) {
    let rememberMeValue = localStorage.getItem("rememberMe");
    let status = localStorage.getItem("status");
    if (rememberMeValue === "true" && status === "loggedIn") {
      window.location.replace("./pages/home.html");
    }
  }
});

// validation regex
let nameRegex = /^[A-Za-z]+(?: [A-Za-z]+)*$/;
let emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
let passwordRegex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$/;

// Register logic
if (window.location.href.includes("register.html")) {

  let showPassIcon = document.querySelectorAll(".small-right-pos");

  togglePasswordVisibility(passwordAtRegister, confirmPasswordAtRegister, showPassIcon[0], showPassIcon[1]);


  registerBtn.addEventListener("click", function (event) {

    event.preventDefault();
    let fullfilled = validateIfEmpty(nameAtRegister, emailAtRegister, passwordAtRegister, confirmPasswordAtRegister);
    if (!fullfilled) {
      showAuthScreensMessage("All fields are required", registerMessage);
      return;
    } else {
      let validData = true;
      if (!nameRegex.test(nameAtRegister.value)) {
        showAuthScreensMessage("Name must be at least 3 characters long and contain only letters", registerMessage);
        validData = false;
        return;
      }
      if (!emailRegex.test(emailAtRegister.value)) {
        showAuthScreensMessage("Email must be in a valid format", registerMessage);
        validData = false;
        return;
      }
      if (!passwordRegex.test(passwordAtRegister.value)) {
        showAuthScreensMessage("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number", registerMessage);
        validData = false;
        return;
      }
      if (passwordAtRegister.value !== confirmPasswordAtRegister.value) {
        showAuthScreensMessage("Passwords do not match", registerMessage);
        validData = false;
        return;
      }

      if (validData) {
        let user = {
          name: nameAtRegister.value,
          email: emailAtRegister.value,
          password: passwordAtRegister.value
        };

        let userExits = searchInLocalStorage(user.email);
        console.log(userExits);
        if (userExits) {
          showAuthScreensMessage("User already exists", registerMessage);
          return;
        } else {
          showAuthScreensMessage("Registration successful", registerMessage);
          saveUserLocalStorage(user);
          resetInputs(nameAtRegister, emailAtRegister, passwordAtRegister, confirmPasswordAtRegister);
          setTimeout(() => {
            window.location.replace("../index.html");
          }, 1000);
        }
      }
    }
  })
}


if (!window.location.href.includes("register.html")) {
  let rememberMe = document.getElementById("rememberMe");

  rememberMe.addEventListener("change", function () {
    if (rememberMe.checked) {
      localStorage.setItem("rememberMe", "true");
    } else {
      localStorage.setItem("rememberMe", "false");
    }
  });

  let showPassIcon = document.querySelector(".small-right-pos");
  togglePasswordVisibility(passwordAtLogin, null, showPassIcon)

  loginBtn.addEventListener("click", function (event) {
    event.preventDefault();
    if (!validateIfEmpty(emailAtLogin, passwordAtLogin)) {
      showAuthScreensMessage("All fields are required", loginMessage);
      return;
    } else {
      let user = {
        email: emailAtLogin.value,
        password: passwordAtLogin.value
      };
      console.log(user);

      if (checkCredintials(user)) {
        showAuthScreensMessage("Login successful", loginMessage);
        localStorage.setItem("status", "loggedIn");
        setTimeout(() => {
          window.location.replace("./pages/home.html");
        }, 500);
        return;
      } else {
        showAuthScreensMessage("Invalid email or password", loginMessage);
        return;
      }
    }
  });


}






