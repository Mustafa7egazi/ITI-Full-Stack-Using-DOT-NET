function makeFibonacciGenerator(array, size = 10) {
  array[Symbol.iterator] = function* () {
    for (let i = 0; i < size; i++) {
      if (i === 0) {
        array[i] = 0; 
      } else if (i === 1) {
        array[i] = 1; 
      } else {
        array[i] = array[i - 1] + array[i - 2]; 
      }
      yield array[i]; 
    }
  };
}

let fibArray = [];
makeFibonacciGenerator(fibArray, 7);

for (let num of fibArray) {
  console.log(num);
}

console.log(fibArray);
