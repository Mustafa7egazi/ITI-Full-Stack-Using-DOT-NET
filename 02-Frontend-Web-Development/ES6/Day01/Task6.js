/* ================ ( 6 ) ==================== */
let ordinaryNames = ["mustafa", "reda", "hegazy"];
function changeNames(arr) {
  return arr.map((item) => {
    item = item.charAt(0).toUpperCase() + item.slice(1);
    return item;
  });
}
console.log(changeNames(ordinaryNames));
