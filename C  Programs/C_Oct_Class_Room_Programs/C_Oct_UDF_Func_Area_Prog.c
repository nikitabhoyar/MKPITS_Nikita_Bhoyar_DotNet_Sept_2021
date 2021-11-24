



      #include<stdio.h>
	 float Area_Circle();
	 int Area_Rect();
	 int Area_Tri();
	 
	 int main()
      {
	     float A;
		int AR;
		int AT;
		
		A=Area_Circle();
		printf("\n Area of circle = %2f \n",A);
		
		AR=Area_Rect();
		printf("\n Area of Rectangle = %d \n",AR);
		
		AT=Area_Tri();
     	printf("\n Area of Triangle = %d \n",AT);
	    
	     return 0;	    
	}

          float Area_Circle()
            {
             int r;
             printf("\n Enter the radius of circle: ");
             scanf("%d",&r);
             return 3.14*r*r;
            }
		
		 int Area_Rect()
		   {
		    int len,brd;
		    printf("\n Enter the length and breadth for the Rectangle:");
		    scanf("%d%d",&len,&brd);
		    return len*brd;
		    }
		  
		 int Area_Tri()
		  {
		   int b,h;
		   printf("\n Enter the base and height for the Triangle :");
		   scanf("%d%d",&b,&h);
		   return (b*h)/2;
		   }

