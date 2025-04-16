/* ================ ( 4) ==================== */
let nums = [1, 2, -3, 4, -5, 8, -20];
function onlyPositive(arr) {
  return arr.filter((item) => {
    return item > 0;
  });
}
console.log(onlyPositive(nums));
