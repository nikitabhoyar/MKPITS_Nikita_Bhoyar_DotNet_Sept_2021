//Program to check a number is a vowel or consonant//


#include<stdio.h>
int main()
{
    char c;
    int lowercase_vowel, uppercase_vowel ;

    printf("Enter any alphabet: ");
    scanf("%c", &c);

    lowercase_vowel = (c=='a' || c == 'e' || c == 'i'|| c =='o' || c == 'u');

    uppercase_vowel = (c=='A' || c == 'E' || c == 'I' || c== 'O' || c== 'U');
    
     if(!isalpha(c))     //isalpha() function check whether is a character is an alphabet or not //
     printf("Error ! Non- alphabetic character");
     else if (lowercase_vowel || uppercase_vowel )
    printf("%c is a vowel " , c);

    else

    printf("%c is a consonant" , c);

    return 0;


}