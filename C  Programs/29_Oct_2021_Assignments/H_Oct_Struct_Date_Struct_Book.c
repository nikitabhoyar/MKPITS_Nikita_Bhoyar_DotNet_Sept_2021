
#include<stdio.h>
typedef struct 
{
 int day,month,year;
} Date;

typedef struct 
{
  int BookId,PublishDate,EditionNo;
  char Bname,BAuthor;
  float Bprice;
} Book;

Book getbookdata(); /*Function Declaration */
void showbookdata(Book);

main()
Book b1;
b1=getbookdata();
showbookdata(b1);

Book getbookdata()
{
Book b;
printf("Enter the Book Name: ");
scanf("%s",&b.Bname);
printf("Enter the Book Author Name: ");
scanf("%s",&b.BAuthor);
Printf("Enter the price of Book: ");
scanf("%f",&b.Bprice);
printf("Enter Book Id: ");
scanf("%d",&b.BookId);
fflush(stdin);
print("Enter the PublishDate of Book in dd/mm/yyyy: ");
scanf("%d/%d/%d",&b.PublishDate)
printf("Enter the EditionNo of Book in dd/mm/yyyy: ");
gets("%d/%d/%d",&b.EditionNo);

return b;

void showbookdata(Book b1)
{
printf("\n Book Details are : %d");
}

}





