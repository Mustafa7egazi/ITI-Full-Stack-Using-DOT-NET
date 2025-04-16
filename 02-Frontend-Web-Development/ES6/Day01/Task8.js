/* ================ ( 8 ) ==================== */
let randomNames = ["mustafa", "reda", "hegazy", "ali"];

let filteredNames = (names, length) => {
  return names.filter((item) => {
    return item.length > length;
  });
};

console.log(filteredNames(randomNames, 3));
console.log(filteredNames(randomNames, 4));
