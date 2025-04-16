/* ================ ( 7 ) ==================== */
let str = "hello javascript";

function checkTheString(myStr) {
  let capitalFlag = false;
  myStr.split("").find((item) => {
    console.log(item);
    if (item.toUpperCase() == item && item != " ") {
      capitalFlag = true;
    }
  });

  if (capitalFlag) {
    return "String contains has uppercase";
  } else {
    return "String is lowercase";
  }
}

console.log(checkTheString(str));
