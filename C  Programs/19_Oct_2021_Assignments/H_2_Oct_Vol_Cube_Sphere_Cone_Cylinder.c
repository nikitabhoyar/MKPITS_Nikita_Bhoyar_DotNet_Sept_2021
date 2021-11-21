

#include<stdio.h>
void Vol_Cube(int);
void  Vol_Cone(int,int);
void  Vol_Cylinder(int,int);
void Vol_Sphere(int,int);

   int main()
{
    int length,height,radius;
    
    printf("\n Enter the length for cube:");
    scanf("%d",&length);
    Vol_Cube(length);

    printf("\n Enter the value for  radius and height:");
    scanf("%d %d",&radius,&height);

    Vol_Cone(radius,height);

    Vol_Cylinder(radius,height);

    Vol_Sphere(radius,height);

    return 0;
  
}

void Vol_Cube(int l)
{
   int Vcube = l*l*l;
   printf("\n Volume of Cube  is = %0.2d \n", Vcube);
}

void Vol_Cone(int r ,int h)
{
    float Vcone = (3.14*r*r*h)/3;
    printf("\n Volume of Cone is =%0.2f \n",Vcone);
}

void Vol_Cylinder(int r,int h)
{
   float Vcylinder = 3.14*r*r*h; //  3.13*radius2*height
   printf("\n Volume of Cylinder is =%0.2f \n",Vcylinder);
}

void Vol_Sphere(int r,int h)
{
 float Vsphere = 1.333*3.14*r*r*r; // 4/3= 1.333*3.14*r3//
 printf("\n Volume of Sphere is = %0.2f \n",Vsphere);
}
