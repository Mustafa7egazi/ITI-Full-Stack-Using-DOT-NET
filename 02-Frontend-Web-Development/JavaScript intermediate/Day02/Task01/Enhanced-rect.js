/** Creating all class factory with function constructor */
function Rectangle(width, height) {
  this.width = width;
  this.height = height;
  Rectangle.NumberOfInstances++;
}

Rectangle.prototype.area = function () {
  return this.width * this.height;
};
Rectangle.prototype.perimeter = function () {
  return 2 * (this.width + this.height);
};
Rectangle.prototype.toString = function () {
  return (
    "Rectangle: Width = " +
    this.width +
    ", Height = " +
    this.height +
    ", Area = " +
    this.area() +
    ", Perimeter = " +
    this.perimeter()
  );
};

Rectangle.NumberOfInstances = 0;

Rectangle.prototype.getNumberOfInstances = function () {
  return Rectangle.NumberOfInstances;
};

var rect1 = new Rectangle(5, 10);
var rect2 = new Rectangle(3, 6);

console.log(`${rect1}`);
console.log(`${rect2}`);
console.log(rect1.getNumberOfInstances());
