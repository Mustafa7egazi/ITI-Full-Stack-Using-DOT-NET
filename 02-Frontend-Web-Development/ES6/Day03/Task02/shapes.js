class Shape {
  constructor(dim1, dim2) {

    
  if (this.constructor == Shape) {
    throw "Can't instantiate abstract class!";
  }

    this.dim1 = dim1;
    this.dim2 = dim2;
  }

  area() {
    return this.dim1 * this.dim2;
  }
  parameter() {
    return 2 * (this.dim1 + this.dim2);
  }
}

class Rectangle extends Shape {
  static numOfObjects = 0;
  constructor(dim1, dim2) {
    super(dim1, dim2);
    Rectangle.numOfObjects++;
  }
}

class Square extends Shape {
  static numOfObjects = 0;
  constructor(dim) {
    super(dim, dim);
    Square.numOfObjects++;
  }
}

class Circle extends Shape {
  static numOfObjects = 0;
  constructor(raduis) {
    super(raduis, raduis);
    Circle.numOfObjects++;
  }

  area() {
    return Math.PI * this.dim1 * this.dim2;
  }

  parameter() {
    return 2 * Math.PI * this.dim1;
  }
}

export { Rectangle, Square, Circle };
