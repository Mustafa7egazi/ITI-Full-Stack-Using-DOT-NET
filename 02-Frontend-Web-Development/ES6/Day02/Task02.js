let header = document.getElementsByTagName("h1")[0];
let usersContainer = document.getElementsByClassName("users")[0];
let postsContainer = document.getElementsByClassName("posts")[0];

async function getAllUsers() {
  let response = await fetch("https://jsonplaceholder.typicode.com/users");
  let users = await response.json();
  return users;
}

async function getSpecificUserPosts(username) {
  return getAllUsers().then((users) => {
    let user = users.find((u) => u.name === username);
    
    return fetch(`https://jsonplaceholder.typicode.com/posts?userId=${user.id}`)
      .then((res) => res.json())
      .then((posts) => {
        return posts; 
      });
  });
}

header.addEventListener("click", () => {
  getAllUsers().then((allUsers) => {
    for (let index = 0; index < allUsers.length; index++) {
      let btn = document.createElement("button");
      btn.classList.add("userBtn");
      btn.addEventListener("click", getPosts);
      btn.innerHTML = allUsers[index].name;
      usersContainer.appendChild(btn);
    }
  });
});

function getPosts(e) {
  getSpecificUserPosts(e.target.innerHTML)
    .then((posts) => {
      return posts
    })
    .then((posts) => {
      console.log(posts);
      postsContainer.innerHTML = "";
      for (let index = 0; index < posts.length; index++) {
        let div = document.createElement("div");
        div.classList.add("post");
        let postHeader = document.createElement("h4");
        postHeader.innerHTML = posts[index].title;
        div.appendChild(postHeader);
        let postBody = document.createElement("p");
        postBody.innerHTML = posts[index].body;
        div.appendChild(postBody);
        postsContainer.appendChild(div);
      }
    })
    .catch((err) => {
      console.log("Error while getting data", err);
    });
}
