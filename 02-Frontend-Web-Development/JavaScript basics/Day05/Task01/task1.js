var students = [];

function validateName(name, nameError) {
    if (name === "") {
        nameError.innerHTML = "Name is required.";
        return false;
    }
    if (name.length < 3) {
        nameError.innerHTML = "Name must be at least 3 characters.";
        return false;
    }
    return true;
}

function validateAge(ageStr, age, ageError) {
    if (ageStr === "") {
        ageError.innerHTML = "Age is required.";
        return false;
    }
    if (isNaN(age) || age < 6) {
        ageError.innerHTML = "Age must be a number and >= 6.";
        return false;
    }
    return true;
}

function checkDuplicateStudent(name, age, nameError) {
    for (var i = 0; i < students.length; i++) {
        if (students[i].name === name && students[i].age === age) {
            nameError.innerHTML = "Student with same name and age already exists.";
            return true;
        }
    }
    return false;
}

function getInputValues() {
    var nameInput = document.getElementById("name");
    var ageInput = document.getElementById("age");
    return {
        name: nameInput.value.trim(),
        ageStr: ageInput.value.trim(),
        nameInput: nameInput,
        ageInput: ageInput
    };
}


function createStudent(name, age) {
    return {
        name: name,
        age: age
    };
}

function insertStudentData() {
    var nameError = document.getElementById("name-error");
    var ageError = document.getElementById("age-error");
    
    var { name, ageStr, nameInput, ageInput } = getInputValues();
    var age = Number(ageStr);

    nameError.innerHTML = "";
    ageError.innerHTML = "";

    var isValid = 
        validateName(name, nameError) && 
        validateAge(ageStr, age, ageError) && 
        !checkDuplicateStudent(name, age, nameError);

    if (!isValid) {
        return;
    }

    var student = createStudent(name, age);
    students.push(student);

    nameInput.value = "";
    ageInput.value = "";

    showStudents();
}


function showStudents() {
    var table = document.querySelector(".data-table");
    var tableBody = document.getElementById("table-body");
  
    if (students.length === 0) {
        table.style.display = "none";
        return;
    }
    
    table.style.display = "table";
    tableBody.innerHTML = "";
  
    for (var i = 0; i < students.length; i++) {
        var tr = document.createElement("tr");
        tr.innerHTML =
            "<td>" + (i + 1) + "</td>" +
            "<td>" + students[i].name + "</td>" +
            "<td>" + students[i].age + "</td>" +
            "<td><a href='#' class='delete-link' onclick='deleteStudent(" + i + ")'>Delete</a></td>";
        tableBody.appendChild(tr);
    }
}

function deleteStudent(index) {
    students.splice(index, 1);
    showStudents();
}