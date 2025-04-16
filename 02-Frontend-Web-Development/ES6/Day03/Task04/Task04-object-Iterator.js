let person = {
  name: "Mustafa Hegazy",
  age: 24,
  country: "Egypt",
};

let iter = function () {
  const keys = [];

  for (let key in this) {
    keys.push(key);
  }

  let index = 0;

  return {
    next: () => {
      return index < keys.length
        ? { value: this[keys[index++]], done: false }
        : { value: undefined, done: true };
    },
  };
};

person[Symbol.iterator] = iter;

for (const value of person) {
  console.log(value);
}
