let person = {};
let personProxy = new Proxy(person, {
  set: (personObject, key, value) => {
    if (key === "name" && value.length < 7) {
      throw new Error("Name must be at least 7 characters");
    } else if (key === "name" && value.length >= 7) {
      personObject[key] = value;
    } else if (
      key === "age" &&
      (typeof value !== "number" || !(value >= 25 && value <= 60))
    ) {
      throw new Error("Age must be a number between 25 and 60");
    } else if (
      key === "age" &&
      typeof value === "number" &&
      value >= 25 &&
      value <= 60
    ) {
      personObject[key] = value;
    } else if (key === "address" && typeof value !== "string") {
      throw new Error("Address must be a string");
    } else if (key === "address" && typeof value === "string") {
      personObject[key] = value;
    } else {
      throw new Error("Invalid property syntax {Allowed: name, age, address}");
    }
  },

  get: (personObject, key) => {
    if (key in personObject) {
      return personObject[key];
    } else {
      throw new Error("You are trying to access an invalid property");
    }
  },
});

// setting values at person through its proxy
try {
  personProxy.name = "Mustafa Hegazy";
  personProxy.age = 24;  // will throw an error
  personProxy.address = "Cairo, Egypt";
} catch (error) {
  console.log(error.message); 
}
