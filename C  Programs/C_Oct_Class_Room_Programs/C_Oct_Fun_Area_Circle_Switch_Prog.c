
    #include<stdio.h>
    float Area_circle (int,float);
    int Area_rect (int,int);
    
    int main()
   {

    int radius,len,brd,Ar;
    float A,pie=3.14;
	char shape;
    printf("Press the 'c' For finding the Area of Circle : \n and Press 'r' for Finding the area of Area of Rectangle : ");
	shape = getchar();
	switch(shape)
	{
	     case 'c': 
	     case 'C':
	               printf("\n Enter the value radius :");
	               scanf("%d",&radius);
      
	             /*Call to the function*/
				   A = Area_circle(radius,pie);
	               printf(" \n The area of Circle is = %0.2f \n",A);
			       break;
			   
          case 'r':
		  case 'R':
	 
	               printf("\n Enter the length and breadth of the rectangle:");
	               scanf("%d%d",&len,&brd);
	 
	               Ar = Area_rect(len,brd);
	               printf("\n The area of Rectangle is = %d",Ar);
	               break;
    }   
			   
     return 0;
			 
    
    }
   
           float Area_circle(int r,float pie)
	       
		  {
              return pie*r*r;
	       }

           int Area_rect(int l,int b)
            
		  {
               return l*b;
            }
		  
		  
    

