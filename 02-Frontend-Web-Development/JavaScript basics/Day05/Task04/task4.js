//====================== Getting elements===========================
var nameInput = document.getElementById("name");
var emailInput = document.getElementById("email");
var passwordInput = document.getElementById("password");
var genderInputNodeList = document.getElementsByName("gender");
var sportsInputNodeList = document.getElementsByName("sports");
var countryInput = document.getElementById("country");
var submitButton = document.getElementsByClassName("submit")[0];
var resetButton = document.getElementsByClassName("reset")[0];
//================= Span validation messages =====================
var nameValidationMessage = document.getElementById("name-message");
var emailValidationMessage = document.getElementById("email-message");
var emailValidationMessage = document.getElementById("email-message");
var passwordValidationMessage = document.getElementById("password-message");
var genderValidationMessage = document.getElementById("gender-message");
var countryValidationMessage = document.getElementById("country-message");
var sportsValidationMessage = document.getElementById("sports-message");

//=================== aquire gender func ===================
function gettingGender(gendersNodeList) {
  for (var i = 0; i < gendersNodeList.length; i++) {
    if (gendersNodeList[i].checked) {
      return gendersNodeList[i].value;
    }
  }
}

//=================== aquire sports func ===================
function gettingSports(sportsNodeList) {
  var checkedSports = [];
  for (var i = 0; i < sportsNodeList.length; i++) {
    if (sportsNodeList[i].checked) {
      checkedSports.push(sportsNodeList[i].value);
    }
  }
  return checkedSports;
}

//=================== Validation func ===================
var isAllValid = false;
function validateInputs() {
  isAllValid = true;

  // Validate Name
  if (nameInput.value == "" || nameInput.value == null) {
    nameValidationMessage.style.display = "block";
    nameValidationMessage.innerHTML = "Name is required";
    isAllValid = false;
  } else if (nameInput.value.length < 3) {
    nameValidationMessage.style.display = "block";
    nameValidationMessage.innerHTML = "Name must be more than 3 characters";
    isAllValid = false;
  } else {
    nameValidationMessage.style.display = "none";
  }

  // Validate Email
  if (emailInput.value == "" || emailInput.value == null) {
    emailValidationMessage.style.display = "block";
    emailValidationMessage.innerHTML = "Email is required";
    isAllValid = false;
  } else if (!/^\w+@\w+\.\w+$/.test(emailInput.value)) {
    emailValidationMessage.style.display = "block";
    emailValidationMessage.innerHTML = "Email is not valid";
    isAllValid = false;
  } else {
    emailValidationMessage.style.display = "none";
  }

  // Validate Password
  if (passwordInput.value == "" || passwordInput.value == null) {
    passwordValidationMessage.style.display = "block";
    passwordValidationMessage.innerHTML = "Password is required";
    isAllValid = false;
  } else if (passwordInput.value.length < 8) {
    passwordValidationMessage.style.display = "block";
    passwordValidationMessage.innerHTML = "Password must be at least 8 characters";
    isAllValid = false;
  } else {
    passwordValidationMessage.style.display = "none";
  }

  // Validate Gender
  if (gettingGender(genderInputNodeList) == undefined) {
    genderValidationMessage.style.display = "block";
    genderValidationMessage.innerHTML = "Gender is required";
    isAllValid = false;
  } else {
    genderValidationMessage.style.display = "none";
  }

  // Validate Sports
  if (gettingSports(sportsInputNodeList).length < 2) {
    sportsValidationMessage.style.display = "block";
    sportsValidationMessage.innerHTML = "Select at least 2 sports";
    isAllValid = false;
  } else {
    sportsValidationMessage.style.display = "none";
  }

  // Validate Country
  if (countryInput.value == "" || countryInput.value == null) {
    countryValidationMessage.style.display = "block";
    countryValidationMessage.innerHTML = "Country is required";
    isAllValid = false;
  } else {
    countryValidationMessage.style.display = "none";
  }

  return isAllValid;
}


//=================== Submit and Reset func ===================

function submitData() {
  
if (validateInputs()) {
  
    alert("You have submitted your data successfully");
    resetData();
}else{
  isAllValid = false;
}
}

function resetData() {
  nameInput.value = "";
  emailInput.value = "";
  passwordInput.value = "";
  for (var i = 0; i < genderInputNodeList.length; i++) {
    genderInputNodeList[i].checked = false;
  }
  for (var i = 0; i < sportsInputNodeList.length; i++) {
    sportsInputNodeList[i].checked = false;
  }
  countryInput.value = "";
}

submitButton.addEventListener("click", submitData);
resetButton.addEventListener("click", resetData);
