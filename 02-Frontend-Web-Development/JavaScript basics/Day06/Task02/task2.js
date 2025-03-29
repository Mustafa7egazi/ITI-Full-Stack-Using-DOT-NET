var allUsers = [];
var usersTable = document.getElementsByClassName("auto-table")[0];
var detailsTable = document.getElementsByClassName("my-table")[0];

function renderUsers(users) {
  var tbody = document.getElementById("users");
  tbody.innerHTML = "";
  if (allUsers.length == 0) {
    usersTable.style.display = "none";
  } else {
    usersTable.style.display = "table";
    for (var i = 0; i < users.length; i++) {
      var tr = document.createElement("tr");
      tr.innerHTML = `
                          <td> ${users[i].id} </td>
                          <td> ${users[i].name} </td>
                          <td> ${users[i].email} </td>
                          <td><a style="display:block" href='#' class='delete-btn' onclick='deleteUser(${i});'>Delete User</a> 
                          <a style="display:block" href='#' class='details-btn' onclick='viewUserDetails(${i});'>View Details</a>
                          </td>`;
      tbody.appendChild(tr);
    }
  }
}

function deleteUser(index) {
    detailsTable.style.display = 'none'
  allUsers.splice(index, 1);
  renderUsers(allUsers);
}

function viewUserDetails(index) {
  var tbody = document.getElementById("userDetailsBody");
  tbody.innerHTML = "";

  var theUser = allUsers[index];

  for (var key in theUser) {
    if (Object.prototype.hasOwnProperty.call(theUser, key)) {
      var value = theUser[key];

      if (typeof value === "object" && value !== null) {
        for (var subKey in value) {
          if (Object.prototype.hasOwnProperty.call(value, subKey)) {
            var tr = document.createElement("tr");
            tr.innerHTML = 
            `<td>${key}.${subKey}</td><td>
            ${(typeof value[subKey] == "object")? JSON.stringify(value[subKey]): value[subKey]}
            </td>`;
            tbody.appendChild(tr);
          }
        }
      } else {
        var tr = document.createElement("tr");
        tr.innerHTML = `<td>${key}</td><td>${value}</td>`;
        tbody.appendChild(tr);
      }
    }
  }

  detailsTable.style.display = "table";
}

var getAllBtn = document.getElementById("getAllUsersBtn");
getAllBtn.addEventListener("click", function () {
  var xhr = new XMLHttpRequest();
  xhr.open("GET", "https://jsonplaceholder.typicode.com/users");
  xhr.send();
  xhr.onreadystatechange = function () {
    if (xhr.readyState == 4 && xhr.status == 200) {
      var users = JSON.parse(xhr.response);
      allUsers = users;
      renderUsers(allUsers);
    }
  };
});
