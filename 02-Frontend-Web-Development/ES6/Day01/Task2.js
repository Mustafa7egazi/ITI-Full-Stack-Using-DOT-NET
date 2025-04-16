/* ================ ( 2 ) ==================== */
function maxMinFinder(firstItem, ...rest) {
  let max = firstItem,
    min = firstItem;

  rest.forEach((item) => {
    if (item > max) {
      max = item;
    }

    if (item < min) {
      min = item;
    }
  });

  return { min: min, max: max };
}

let arr = [1, 2, 3, 4, 5, 6];
maxMinFinder(...arr);

console.log(maxMinFinder(...arr).min, maxMinFinder(...arr).max);
