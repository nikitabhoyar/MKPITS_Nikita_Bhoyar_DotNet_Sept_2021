
#include<stdio.h>

int main()
{
 char Name[10], vovel[10], consonant[10];
 int i,Countv=0, Countc = 0; 
  
 printf("Enter your name\n");
 

 for(i=0;i<6;i++)
   {
    Name[i]=getchar();
   }
   for(i=0;i<6;i++)
   {
   /*printf("%c",Name[i]);*/
   
   if(Name[i]=='a' || Name[i]=='A' || Name[i]=='E' || Name[i]=='e' || Name[i]=='I' || Name[i]=='i' || Name[i]=='O' || Name[i]=='o' || Name[i]=='U' || Name[i]=='u' )
   {
     
    printf("\n countv = %d" , Countv);
    vovel[Countv] = Name[i];
    Countv++;
    
    }
   
   else 
    
    consonant[Countc++] = Name[i];
   
   }
	
   
   printf("\nThere are %d vovles in my name",Countv);
   
   printf("\nThere are %d  consonants in my name",Countc);
   
   for(i = 0; i< Countv ; i++)
   {
   
   printf("\n Index = %d , Vovel=  %c ", i,  vovel[i] );
   
   }
   
   
   for(i = 0; i< Countc ; i++)
   {
   
   printf("\n Index = %d , consonant =  %c ",i, consonant[i]);
   
   }
    
 return 0;
   
   }

