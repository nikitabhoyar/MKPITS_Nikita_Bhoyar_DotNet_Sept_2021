
#include<stdio.h>
#include<string.h>

 struct person
    {
        char name[30];
        int cityNo;
        float salary;
    } p1 ,p2 ;                // person p1 , p2 , p[20]; //Another way of creating structure varaible is//
    

int main()
{
   strcpy(p1.name,"Nikita Bhoyar");
   p1.cityNo=1984;
   p1.salary=2520;
   
   printf("The Details of the person are as follows.\n");
   printf("Person name is : %s \n", p1.name);
   printf("Person city no is: %d \n" , p1.cityNo);
   printf("Person Salary is: %2.f \n ", p1.salary);

   return 0;
}
