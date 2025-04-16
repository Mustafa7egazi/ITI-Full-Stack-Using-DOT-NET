/* ================ ( 3 ) ==================== */
let fruits = ["apple", "strawberry", "banana", "orange", "mango"];

// a
let outA = fruits.every((item) => typeof item == "string");
console.log(outA);
// b
let outB = fruits.some((item) => item.startsWith("a"));
console.log(outB);
// c
let outC = fruits.filter(
  (item) => item.startsWith("b") || item.startsWith("s")
);
console.log(outC);
// d
let outD = fruits.find((item) => item.startsWith("a"));
console.log(outD);
// e
let outE = fruits.map((item) => {
  return `I love ${item}`;
});
// f
outE.forEach((item) => {
  console.log(item);
});
