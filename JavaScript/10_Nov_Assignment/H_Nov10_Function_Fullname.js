

var fname,lname;
fname=prompt("Enter the first name","Nikita");
lname=prompt("Enter the last name","Bhoyar");
fullname=Fullname(fname,lname)
document.getElementById("demo").innerHTML=fullname;
function Fullname(f,l)
{
return f + " " + l;
}