// Sources - 
// https://www.c-sharpcorner.com/article/how-to-compare-two-arrays-in-c-sharp/
// https://www.w3schools.com/cs/cs_arrays.php

Console.WriteLine("Please enter your name:"); // asking user for their name

string firstName = Console.ReadLine(); // storing the user input into variable

Console.WriteLine("\nHello " + firstName + "! Please enter the word you want to determine if it's a palindrome!\n");

string word = Console.ReadLine(); // storing the word to be validated

char[] firstString = new char[word.Length]; // array of characters in the word read in
char[] secondString = new char[word.Length]; // array of characters in the word read in

for (int i = 0; i < word.Length; i++) // this for loop appends goes over each character in the word and appends it to the first character array
{
    firstString[i] = word[i];
}

int counter = 0; // global variable vs local so it doesn't reset in for loop
for (int j = word.Length - 1; j >= 0; j--) // similiar to first for loop but reverses the string into the second array
{
    secondString[counter] = word[j];
    counter++;
}


bool areEqual = firstString.SequenceEqual(secondString); //checks if both character arrays line up

if (areEqual)
{
    Console.WriteLine("\nOoooo, it's perfect!");
}

else
{
   Console.WriteLine("\nLook at the word reversed: " + new string(secondString) + "\nVery ugly if I say so myself. Yuck!");
 
}
