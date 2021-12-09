

#include<stdio.h>

 typedef struct
{
int date , month, year ;
}
 date;

typedef struct 
{
    int BookId ,BEditionNo, Bprice;;
    date BPublishdate ;
    char Bname[20] , BAuthorname[30];
    
} Book;

int main()
{
    Book b1;
    printf("The Book Details are as follows: \n");
    printf("Enter BookName: ");
    scanf("%s",b1.Bname);

    printf("Enter BookPrice: ");
    scanf("%d",&b1.Bprice);

    printf("Enter BAuthorname: ");
    scanf("%s",b1.BAuthorname);

    printf("Enter BookId number: ");
    scanf("%d",&b1.BookId);

    printf("Enter BookEditionNo: ");
    scanf("%d",&b1.BEditionNo);

    printf("Enter BPublishdate in dd/mm/yyyy: ");
    scanf("%d/%d/%d",&b1.BPublishdate.date,&b1.BPublishdate.month,&b1.BPublishdate.year);
   
    return 0;
}

