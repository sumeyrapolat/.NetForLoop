// See https://aka.ms/new-console-template for more information


/*
Console.WriteLine("Please enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    if (i % 2 == 0) {
        continue;
    }
    Console.WriteLine(i);
} 

*/

int sumOfEvenNumbers = 0;
int sumOfOddNumbers = 0;

for (int i =0; i<150; i++)
{
    if (i%2 == 0)
    {
        //çift sayılar
        sumOfEvenNumbers = sumOfEvenNumbers + i;
    } 
    else
    {
        //tek sayılar
        sumOfOddNumbers = sumOfOddNumbers + i;
    }
    
}
Console.WriteLine("sum of even numbers : " + sumOfEvenNumbers);
Console.WriteLine("sum of odd numbers : " + sumOfOddNumbers);