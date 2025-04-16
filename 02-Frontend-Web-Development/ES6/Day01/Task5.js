/* ================ ( 5 ) ==================== */
let nums2 = [10, 20, 30, 40];
function cleanSummation(arr) {
  return arr.reduce((accumlator, item) => {
    return accumlator + item;
  });
}
console.log(cleanSummation(nums2));
