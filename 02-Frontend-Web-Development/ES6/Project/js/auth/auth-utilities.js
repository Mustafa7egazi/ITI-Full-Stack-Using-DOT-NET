function showAuthScreensMessage(message,target){
    target.innerText = "";
    target.innerText = message;
    target.classList.remove("d-none");
    target.classList.add("d-block");
}
function validateIfEmpty(...inputs) {
    for (let input of inputs) {
        if (input.value === "") {
            return false;
        }
    }
    return true;
}

function resetInputs(...inputs) {
    for (let input of inputs) {
        input.value = "";
    }
}

function togglePasswordVisibility(passwordInput, confirmPasswordInput, ...toggleIcons) {
    toggleIcons.forEach(icon => {
        icon.addEventListener("click", () => {
            if (icon.classList.contains("fa-eye")) {
                icon.classList.remove("fa-eye");
                icon.classList.add("fa-eye-slash");
                passwordInput.type = "text"; 
                if (confirmPasswordInput) confirmPasswordInput.type = "text";
            } else if (icon.classList.contains("fa-eye-slash")) {
                icon.classList.remove("fa-eye-slash");
                icon.classList.add("fa-eye");
                passwordInput.type = "password";
                if (confirmPasswordInput) confirmPasswordInput.type = "password";
            }
        });
    });
}

function saveUserLocalStorage(user) {
    let users = localStorage.getItem("users");
    if (users) {
        users = JSON.parse(users);
        users.push(user);
        localStorage.setItem("users", JSON.stringify(users));  
    }else{
        localStorage.setItem("users", JSON.stringify([user]));
    }
}

function searchInLocalStorage(value) {
    let users =   JSON.parse(localStorage.getItem("users"));
    for (let index in users) {
        if (users[index].email === value) {
            return true;
        } 
    }
    return false;
}

function checkCredintials(user){
 let users = JSON.parse(localStorage.getItem("users"));
 for(let index in users){
    if(users[index].email === user.email && users[index].password === user.password){
        localStorage.setItem("currentUser",JSON.stringify({name:users[index].name,email:users[index].email}));
        return true;
    }
 }
 return false;
}

function isUserRemembered(){
    let  isRemembered = localStorage.getItem("rememberMe");
    console.log("remembered: ",isRemembered);
    if(isRemembered === "true"){
        return true;
    }
    return false;
}

export { validateIfEmpty,resetInputs ,togglePasswordVisibility, showAuthScreensMessage ,saveUserLocalStorage,isUserRemembered , searchInLocalStorage,checkCredintials};