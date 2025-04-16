/** Creating all class factory with function constructor */
function Rectangle(width, height){
    this.width = width;
    this.height = height;
}

Rectangle.prototype.area = function(){
    return this.width * this.height;
}
Rectangle.prototype.perimeter = function(){
    return 2 * (this.width + this.height); 
}
Rectangle.prototype.displayInfo = function(){
    return "Rectangle: Width = " + this.width + ", Height = " + this.height + ", Area = " + this.area() + ", Perimeter = " + this.perimeter();
}

var rect1 = new Rectangle(5, 10);
var rect2 = new Rectangle(3, 6);

console.log(rect1.displayInfo());
console.log(rect2.displayInfo());
