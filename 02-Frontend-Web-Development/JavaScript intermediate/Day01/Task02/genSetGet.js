function Person(id, loc, addr) {
  this.id = id;
  this.location = loc;
  this.addr = addr;
}

Person.prototype.getSetGen = function () {
  for (var key in this) {
    if (typeof this[key] !== "function" && key !== "getSetGen") {
      (function (obj, key) {
        var value = obj[key];
        Object.defineProperty(obj, key, {
          get: function () {
            return value;
          },
          set: function (newValue) {
            value = newValue;
          },
          enumerable: true,
        });
      })(this, key);
    }
  }
};

var myObj = new Person("SD-10", "SV", "123 st.");
myObj.getSetGen();

console.log(myObj.id);
myObj.id = "SD-11";
console.log(myObj.id);
myObj.location = "MT";
console.log(myObj.location);
myObj.addr = "Galaa st.";
console.log(myObj.addr);
