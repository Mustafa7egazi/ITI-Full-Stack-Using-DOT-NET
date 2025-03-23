function capitalizeTheFirst(str) {
    let separatedStr = str.split(" ");
    for (let i = 0; i < separatedStr.length; i++) {
      if (separatedStr[i].length > 0) {  
        separatedStr[i] = separatedStr[i][0].toUpperCase() + separatedStr[i].slice(1);
      }
    }
    return separatedStr.join(" ");
  }
  
console.log(capitalizeTheFirst("the quick brown fox"));