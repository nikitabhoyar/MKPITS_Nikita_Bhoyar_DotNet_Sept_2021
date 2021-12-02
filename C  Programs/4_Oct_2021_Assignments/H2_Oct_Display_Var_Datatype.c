

#include<stdio.h>
int main()
{
    int a = 10;             
    signed int b = 250;             //2byte //1byte = 8bits//
    unsigned int c = 300;
    
    short int d = 70;          
    signed short e = 700;             //2byte//
    unsigned short f = 64;

    long int  g = 300; 
    signed long int h = 483;        //4byte//
    unsigned long int i = 290;

    float j = 2.9;                   
    char k = '18';                      //1byte//

  
    printf("\n Int a= %d",a);
    printf("\n Signed int b = %d" ,b);      //2byte//
    printf("\n Unsigned int c = %u" ,c);

    printf("\n Short Int d = %d",d);
    printf("\n signed short e = %d", e);             //2byte//
    printf("\n unsigned short f = %f",f);

    printf("\n long int g =%d", g);
    printf("\n unsigned long int h= %d",h);
    printf("\n signed long int i=%d",i);

    printf("\n Float g = %f",j);                  //it allocates upto 6 decimal values//
    printf("\n char h = %c",k);                     
   

return 0;


}





