
#include <stdio.h>
int main()
{
    int week_num; 
    printf("Enter  you choice of week number: ");
    scanf("%d", &week_num);
    
    switch(week_num)
    {
        case 1: 
            printf(" Your current day name is Monday");
            break;
        case 2: 
            printf("Your current day name is Tuesday");
            break;
        case 3: 
            printf("Your current day name is Wednesday");
            break;
        case 4: 
            printf("Your current day name is Thursday");
            break;
        case 5: 
            printf("Your current day name isFriday");
            break;
        case 6: 
            printf(" Your current day name is Saturday");
            break;
        case 7: 
            printf("Your current day name is Sunday");
            break;
        default: 
            printf("You entered Invalid input!! Please enter proper number week");
    }

    return 0;
}
