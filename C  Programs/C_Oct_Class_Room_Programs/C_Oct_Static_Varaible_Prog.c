


        #include<stdio.h>
	    void Display();
        int main()
          {
		 
           Display();
           Display();
           Display();

           }
          void Display()
          {
           static int x=100;
                      x+=20;
 
           printf("\n x=%d",x);
           }
	    

