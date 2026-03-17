// Sources - 
// https://www.c-sharpcorner.com/article/how-to-compare-two-arrays-in-c-sharp/
// https://www.w3schools.com/cs/cs_arrays.php

Console.WriteLine("Please enter your name:");

string firstName = Console.ReadLine();

Console.WriteLine("\nHello " + firstName + "! Please enter the word you want to determine if it's a palindrome!\n");

string word = Console.ReadLine();

char[] firstString = new char[word.Length];
char[] secondString = new char[word.Length];

for (int i = 0; i < word.Length; i++)
{
    firstString[i] = word[i];
}

int counter = 0;
for (int j = word.Length - 1; j >= 0; j--)
{
    secondString[counter] = word[j];
    counter++;
}


bool areEqual = firstString.SequenceEqual(secondString);
// Console.WriteLine(firstString);
// Console.WriteLine(areEqual);

if (areEqual)
{
    Console.WriteLine("\nOoooo, it's perfect!");
}

else
{
   Console.WriteLine("\nLook at the word reversed: " + new string(secondString) + "\nVery ugly if I say so myself. Yuck!");
 
}
