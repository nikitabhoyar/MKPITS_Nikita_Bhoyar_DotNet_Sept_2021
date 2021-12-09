

       #include<stdio.h>

       int SumN(int);
       int main()
       {
         int limit;
	    printf("\n Enter upper limit to find sum of 1 to n numbers");
	    scanf("%d",&limit);
	    printf("\n Sum of 1 to %d = %d ",limit,SumN(limit));
         return 0;
       }

            int SumN(int n)
            {
             int i,s=0;
             for(i=0;i<=n;i++)
                {
                 s+=i;
                }
              return s
		    :
		    
            }

