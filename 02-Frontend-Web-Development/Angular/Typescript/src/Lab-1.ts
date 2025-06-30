/* 1- define an array with string and number values only*/
let myArray: (string | number)[] = ["hello", 1, "welcome", 2, "hi", 3];

/* 2 -- write a function that accept an array of numbers or string */
/* - if all values are numbers -- return the sum */
/**
 * 
 * - if all values are string -- return all values as a one string
    --if all values string or numbers -- return numbers only and sort them
 */
function AcceptNumbersOrString(input:(string | number)[]) :void{
   
   
    let allStrings:string[] = [];
    let allNums:number[] = [];
    let sum = 0;
    let result = "";
    for (let i = 0; i < input.length; i++) {
        if (typeof input[i] !== "number") {
            allStrings.push(input[i] as string);
            result = allStrings.join(" ");
        }else if (typeof input[i] !== "string") {
            allNums.push(input[i] as number);
            sum += input[i] as number;
        }
    }

    if (allStrings.length === input.length) {
        console.log("All values are strings and its concat is: " + result);
    } else if (allNums.length === input.length) {
        console.log("All values are numbers and its sum: " + sum);
    } else {
        allNums.sort((a, b) => a - b);
        console.log("strings and number values, and sorted numbers: " + allNums.join(", "));
    }
}

let mixedArray: (string | number)[] = ["hello", 8, 6];
let numbersOnly:(string | number)[] = [1,2,3,4,5];
let stringsOnly:(string | number)[] = ["Mustafa" , "Hegazy"];
AcceptNumbersOrString(stringsOnly);



/** 3- - - Create abstract class Shape , rectangle , circle extends from area ... */
abstract class Shape {
    constructor(public dim1: number, public dim2 : number) {}
    abstract area(): number;
}

class Rectangle extends Shape {
    constructor(dim1: number, dim2: number) {
        super(dim1, dim2);
    }
    area(): number {
        return this.dim1 * this.dim2;
    }
}

class Circle extends Shape {
    constructor(r: number) { 
        super(r, 0); 
    }
    area(): number {
        return Math.PI * Math.pow(this.dim1, 2); 
    }
}

/** 4- -- create Interface IEmplyee id,fname,lname,age,salary,address:{city,street,zCode} */
interface IEmployee {
    id: number;
    fname: string;
    lname: string;
    age: number;
    salary: number;
    address: {
        city: string;
        street: string;
        zCode: string;
    };
}


/** 5--- create class Employee Implement IEmplyee -- getSalary */
class Employee implements IEmployee {
 
    constructor(public id: number,public fname: string,public lname: string, public age: number,public salary: number,public address: { city: string; street: string; zCode: string }) {
       
    }

    get getSalary(): number {
        return this.salary;
    }
}

/**-- create class Manager extened Employee -- show Employee Data (empId){show emp data}; */

class Manager extends Employee {

    static emps: Employee[] = [];

    constructor(id: number, fname: string, lname: string, age: number, salary: number, address: { city: string; street: string; zCode: string }) {
        super(id, fname, lname, age, salary, address);


        Manager.emps.push(this);
    }

    static showEmployeeData(empId: number): void {
        let employee = Manager.emps.find(emp => emp.id === empId);
        if (Manager.emps.length > 0 && employee) {
            console.log(`Employee ID: ${employee.id}, 
                Name: ${employee.fname} ${employee.lname},
                Age: ${employee.age}, Salary: ${employee.salary},
                Address: ${employee.address.city}, ${employee.address.street}, ${employee.address.zCode}`);
        } else {
            console.log("Employee not found.");
        }
    }
}


let emp1 = new Manager(1, "Ahmed", "Khaled", 30, 5000, { city: "Menofia", street: "5th st", zCode: "38256" });
let emp2 = new Manager(2, "Ali", "Aloka", 28, 60000, { city: "Alex", street: "saad zaghlol", zCode: "90001" });
let manager = new Manager(3, "Mustafa", "Reda", 35, 80000, { city: "Mansoura", street: "Elhwary st", zCode: "60601" });   

Manager.showEmployeeData(1); 

/**-- enum -- week days -- create function (day)==> {if(this day is a weekend or not)} */
enum WeekDays {
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

function isWeekend(day: WeekDays): string {
    return (day === WeekDays.Saturday || day === WeekDays.Sunday)? "Yes, it's a weekend." : "No, it's a weekday.";
}

console.log(isWeekend(WeekDays.Saturday)); 
