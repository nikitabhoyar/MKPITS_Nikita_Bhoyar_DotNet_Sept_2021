
#include<stdio.h>
void Vol_Cube(int);
void Vol_Cone(int,int);
void Vol_Cylinder(int,int);
void Vol_Sphere(int,int);
int main()
{

    int radius,length,height;
    char shape;
    printf("\n Enter your choice of character to select the shape of solid: ");
    shape = getchar();
    switch(shape)
    {
      
      case'a':
      case'A':
              printf("\n Enter the value for length: ");
              scanf("%d",&length);
              Vol_Cube(length);
              break;
      case'b':
      case'B':
             printf("\n Enter the value for radius and height: ");
             scanf("%d %d",&radius,&height);
             Vol_Cone(radius,height);
             break;
      case'c':
      case'C':
             printf("\n Enter the value for radius and height: ");
             scanf("%d %d",&radius,&height);
             Vol_Cylinder(radius,height);
             break;
    case'd':
    case'D':
             printf("\n Enter the value for radius and height: ");
             scanf("%d %d",&radius,&height);
             Vol_Sphere(radius,height);
             break;

             default:printf("You enter invalid input!! Please enter a character input!!");
    }
    
    return 0;

}

void Vol_Cube(int l)
{
    int Vcube = l*l*l;
    printf("\n Voume of cube = %d",Vcube);
}

void Vol_Cone(int r,int h)
{
    float Vcone = (3.14*r*r*h)/3;
    printf("\n Volume of Cone = %f",Vcone);
}

void Vol_Cylinder(int r,int h)
{
    float Vcylinder = 3.14*r*r*h;
    printf("\n Volume of Cylinder = %f",Vcylinder);
}

void Vol_Sphere(int r,int h)
{
    float Vsphere = 1.333*3.14*r*r*r;
    printf("\n Volume of Sphere = %f",Vsphere);
}