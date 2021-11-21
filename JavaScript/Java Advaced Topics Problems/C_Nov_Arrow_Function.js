var func = (a,b)=> {
    var sum = a+b ;                 //Arrow Function//
    return sum;
}
console.log("Sum of 1 and 3:"), func(1,3);

function func(a,b)
{
    var sum = a+b;                  //Traditional Function//
    return sum;

}
console.log("sum of 1 and 3:" + func(1,3));

var func =(a,b)=> {
    var sub = a-b;
    return sub;
}
console.log("sub of 1 and 4:"),func(1,4);