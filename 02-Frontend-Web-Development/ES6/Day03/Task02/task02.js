import { Rectangle, Square, Circle } from "./shapes.js";

let rect = new Rectangle(10, 20);
let square = new Square(20);
let circle = new Circle(30);

console.log(rect.area());
console.log(Rectangle.numOfObjects);
console.log(square.area());
console.log(circle.area());
