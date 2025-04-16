function Shape(dim1, dim2) {
  if (this.constructor === Shape) {
    throw "this is an abstract class";
  }

  this.dim1 = dim1;
  this.dim2 = dim2;
}

function Rectangle(width, height) {
  Shape.call(this, width, height);
  if (Rectangle.instanceCount >= 1) {
    throw "Only one instance of Rectangle can be created";
  }
  Rectangle.instanceCount++;
}

/** Here I have created rectangle custom methods */
Rectangle.prototype.area = function () {
  return this.dim1 * this.dim2;
};
Rectangle.prototype.perimeter = function () {
  return 2 * (this.dim1 + this.dim2);
};
Rectangle.prototype.toString = function () {
  return "Rectangle: width = " + this.dim1 + ", height = " + this.dim2;
};

Rectangle.instanceCount = 0;

function Square(dim) {
  Rectangle.call(this, dim, dim);
  if (Square.instanceCount >= 1) {
    throw "Only one instance of Square can be created";
  }
  Square.instanceCount++;
}

/** Here I will make square
 * that inherit from rectangle
 * take what he needs from it
 */

Square.prototype = Object.create(Rectangle.prototype);
Square.prototype.constructor = Square;
Square.instanceCount = 0;
Square.prototype.perimeter = function () {
  return 4 * this.dim1;
};

var r1 = new Rectangle(5, 10);
console.log(`${r1}`);

var rect2 = new Rectangle(2, 3);
console.log(`${rect2}`);
