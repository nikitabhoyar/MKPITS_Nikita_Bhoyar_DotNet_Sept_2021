 #include<stdio.h>
 int main()
 {
     int shape_no,a,b,h,l,br;
     float area;
     char reply = 'y';
     do
     {
         printf("\n select the number for required number of calculation \n 1.Circle 2.Rectangle 3.Triangle \n");
         scanf("%d",shape_no);

        switch(shape_no) 
        {
            case1: 
                   printf("\n Enter the radius of circle: ");
                   scanf("%d",&a);
                   area=3.14*a*a;
                   printf("\n The area of circle is = %0.3f",area);
                   break;
                   
            case2: 
                   printf("\n Enter the length and breadth of rectangle: ");
                   scanf("%d %d",&l,&br);
                   area=l*br;
                   printf("\n The area of triangle is %0.3f",area);

                   default:printf("\n Invalid key pressed please try again");          
        }
        printf("\n Do you want Run this program again press y/Y for yes and a for no is n/N ? ");
        reply=getch();
        continue;
     }
     while((reply =='y') || (reply=='y'));
     return 0;
 }
