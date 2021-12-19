let x = 5 ;
let y = x;
let c =4;
let d = c;
y++;
document.write("<br>The increment value of " +x + "is"  +y);
console.log("<br>The increment value of " +x + "is"  +y);

--y;
document.write("<br>The decrement value of " +y + "is"  +x);
console.log("The decrement value of " +y + "is"  +x);

x--;
document.write("<br>The decrement value of " +x + "is"  +x);
console.log("The decrement value of " +x + "is"  +x);

--x;
document.write("<br>The decrement value of " +x + "is"  +x);
console.log("The decrement value of " +x + "is"  +x);


c++;
document.write("<br>The decrement value of " +d + "is"  +d);
console.log("The decrement value of " +d+ "is"  +d);