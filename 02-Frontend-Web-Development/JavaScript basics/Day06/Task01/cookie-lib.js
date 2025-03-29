//==================== Cookies Functions ====================
function getCookie(name) {
    var cookies = document.cookie.split(";");
    for (var i = 0; i < cookies.length; i++) {
      var cookie = cookies[i].trim().split("=");
      if (cookie[0] === name) {
        return cookie[1];
      }
    }
    return "";
  }
  
  function setCookie(name, value) {
    document.cookie = name + "=" + value + ";";
  }
  
  function deleteCookie(name) {
    document.cookie = name + "=; expires=Thu, 01 Jan 1970 00:00:00 UTC;";
  }
  
  function allCookiesList() {
    return document.cookie;
  }
  
  function hasCookie(name) {
    return document.cookie.includes(name);
  }
  
  function getGender(nodeList) {
    if (!nodeList) return "";
    for (var i = 0; i < nodeList.length; i++) {
      if (nodeList[i].checked) {
        return nodeList[i].value;
      }
    }
    return "";
  }
  
  var myWindow;
  //==================== Logic for Main Page ====================
  if (window.location.pathname.includes("cookie.html") || window.location.pathname === "/" || window.location.pathname.endsWith("cookie.html")) {
    var nameInput = document.getElementById("name");
    var ageInput = document.getElementById("age");
    var maleRadio = document.getElementById("male");
    var femaleRadio = document.getElementById("female");
    var gender = document.getElementsByName("gender");
    var manImg = document.getElementById("man");
    var womanImg = document.getElementById("woman");
    var colorInput = document.getElementById("color");

  
    if (manImg && maleRadio) {
      manImg.addEventListener("click", function () {
        maleRadio.checked = true;
      });
    }
  
    if (womanImg && femaleRadio) {
      womanImg.addEventListener("click", function () {
        femaleRadio.checked = true;
      });
    }
  
    if (colorInput) {
      colorInput.addEventListener("change", function () {
        setCookie("color", colorInput.value);
        if (
          nameInput.value.trim() !== "" &&
          ageInput.value.trim() !== "" &&
          getGender(gender) !== ""
        ) {
          setCookie("name", nameInput.value);
          setCookie("age", ageInput.value);
          setCookie("gender", getGender(gender));
  
          myWindow = window.open("new-window.html", "_blank");
          window.close();
        }
      });
    }
  }
  
  //==================== Logic for New Window ====================
  if (window.location.pathname.includes("new-window.html")) {
    // Use cookies or other functions here
    var username = getCookie("name");
    var age = getCookie("age");
    var gender = getCookie("gender");
    var color = getCookie("color");
    var counter = getCookie("counter");
    if (counter === "") counter = 0; else counter = Number(counter);
    window.addEventListener("DOMContentLoaded", function () {
      counter++;
      setCookie("counter", counter);
    });

    var imgSrc = (gender == 'male')? 'imgs/1.jpg' : 'imgs/2.jpg';
    
  
    var msg = `<img src="${imgSrc}">
    <p style="display:inline; font-size:32px; font-weight:bold">Welcome
     <span style="color:${getCookie("color")}"> ${username} </span>, 
     you have visited the site  <span style="color:${getCookie("color")}"> ${getCookie("counter")} times :)</span></p>`;
    document.body.innerHTML = `${msg}`;
  }
  