
//Undefined Datatype//

let name;
console.log(name);  //The undefined datatype represents value that is not assigned .If a variable is declared but the value is not assigned , then the value of that variable will be undefined//

//Null Datatype//

const number = null;
console.log(number);        //Javascript is special value that null represents empty or unknown value//

//Javascript Symbol Datatype//

const value1 = Symbol('hello');
const value2 = Symbol('hello');
console.log(value1);           //A value having the datatype symbol can be referred to as a symbol value .Symbol is an immutable primitive value that is unique//

//Javascript Object Datatype//

const student = {
    FirstName:'ram',
    LastName:' Null',
    class:10
};                           //An Object is a complex datatype that  allows us to store collection of data.//

//Javascript Type//

let data;
data = 5;                    //Javascript is a dynamically typed (lossely types) language .Javascript Automatically
console.log(data);           // determine the variables data type for you //


//Javascript Typedef//
const name = 'ram';
typeof(name);
const number= 4;
typeof(number);
const valuechecked = true;
typeof(valuechecked);
const a = null;
typeof(a);             //To find the type of a variable , you can use the typedef operator//
console.log(name);

