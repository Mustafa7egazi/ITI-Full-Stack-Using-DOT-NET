"use strict";
/* 1- define an array with string and number values only*/
let myArray = ["hello", 1, "welcome", 2, "hi", 3];
/* 2 -- write a function that accept an array of numbers or string */
/* - if all values are numbers -- return the sum */
/**
 *
 * - if all values are string -- return all values as a one string
    --if all values string or numbers -- return numbers only and sort them
 */
function AcceptNumbersOrString(input) {
    let allStrings = [];
    let allNums = [];
    let sum = 0;
    let result = "";
    for (let i = 0; i < input.length; i++) {
        if (typeof input[i] !== "number") {
            allStrings.push(input[i]);
            result = allStrings.join(" ");
        }
        else if (typeof input[i] !== "string") {
            allNums.push(input[i]);
            sum += input[i];
        }
    }
    if (allStrings.length === input.length) {
        console.log("All values are strings and its concat is: " + result);
    }
    else if (allNums.length === input.length) {
        console.log("All values are numbers and its sum: " + sum);
    }
    else {
        allNums.sort((a, b) => a - b);
        console.log("strings and number values, and sorted numbers: " + allNums.join(", "));
    }
}
let mixedArray = ["hello", 8, 6];
let numbersOnly = [1, 2, 3, 4, 5];
let stringsOnly = ["Mustafa", "Hegazy"];
AcceptNumbersOrString(stringsOnly);
/** 3- - - Create abstract class Shape , rectangle , circle extends from area ... */
class Shape {
    constructor(dim1, dim2) {
        this.dim1 = dim1;
        this.dim2 = dim2;
    }
}
class Rectangle extends Shape {
    constructor(dim1, dim2) {
        super(dim1, dim2);
    }
    area() {
        return this.dim1 * this.dim2;
    }
}
class Circle extends Shape {
    constructor(r) {
        super(r, 0);
    }
    area() {
        return Math.PI * Math.pow(this.dim1, 2);
    }
}
/** 5--- create class Employee Implement IEmplyee -- getSalary */
class Employee {
    constructor(id, fname, lname, age, salary, address) {
        this.id = id;
        this.fname = fname;
        this.lname = lname;
        this.age = age;
        this.salary = salary;
        this.address = address;
    }
    get getSalary() {
        return this.salary;
    }
}
/**-- create class Manager extened Employee -- show Employee Data (empId){show emp data}; */
class Manager extends Employee {
    constructor(id, fname, lname, age, salary, address) {
        super(id, fname, lname, age, salary, address);
        Manager.emps.push(this);
    }
    static showEmployeeData(empId) {
        let employee = Manager.emps.find(emp => emp.id === empId);
        if (Manager.emps.length > 0 && employee) {
            console.log(`Employee ID: ${employee.id}, 
                Name: ${employee.fname} ${employee.lname},
                Age: ${employee.age}, Salary: ${employee.salary},
                Address: ${employee.address.city}, ${employee.address.street}, ${employee.address.zCode}`);
        }
        else {
            console.log("Employee not found.");
        }
    }
}
Manager.emps = [];
let emp1 = new Manager(1, "Ahmed", "Khaled", 30, 5000, { city: "Menofia", street: "5th st", zCode: "38256" });
let emp2 = new Manager(2, "Ali", "Aloka", 28, 60000, { city: "Alex", street: "saad zaghlol", zCode: "90001" });
let manager = new Manager(3, "Mustafa", "Reda", 35, 80000, { city: "Mansoura", street: "Elhwary st", zCode: "60601" });
Manager.showEmployeeData(1);
/**-- enum -- week days -- create function (day)==> {if(this day is a weekend or not)} */
var WeekDays;
(function (WeekDays) {
    WeekDays[WeekDays["Sunday"] = 0] = "Sunday";
    WeekDays[WeekDays["Monday"] = 1] = "Monday";
    WeekDays[WeekDays["Tuesday"] = 2] = "Tuesday";
    WeekDays[WeekDays["Wednesday"] = 3] = "Wednesday";
    WeekDays[WeekDays["Thursday"] = 4] = "Thursday";
    WeekDays[WeekDays["Friday"] = 5] = "Friday";
    WeekDays[WeekDays["Saturday"] = 6] = "Saturday";
})(WeekDays || (WeekDays = {}));
function isWeekend(day) {
    return (day === WeekDays.Saturday || day === WeekDays.Sunday) ? "Yes, it's a weekend." : "No, it's a weekday.";
}
console.log(isWeekend(WeekDays.Saturday));
