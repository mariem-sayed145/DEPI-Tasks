// 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()); 
if (number % 3 == 0 && number % 4 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}




// 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
Console.Write("Enter an integer: ");
int number = int.Parse(Console.ReadLine()); 
if (number < 0)
{
    Console.WriteLine("Negative");
}
else
{
    Console.WriteLine("Positive");
}




// 3- Write a program that takes 3 integers from the user then prints the max element and the min element.

Console.Write("Enter first integer: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter second integer: ");
int num2 = int.Parse(Console.ReadLine());   
Console.Write("Enter third integer: ");
int num3 = int.Parse(Console.ReadLine());   

int[] nums = { num1, num2, num3 };
Console.WriteLine($"Max element: {nums.Max()}");
Console.WriteLine($"Min element: {nums.Min()}");    



// 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.

Console.Write("Enter an integer: ");
int number = int.Parse(Console.ReadLine()); 
if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}




// 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

Console.Write("Enter a character: ");
char character = char.Parse(Console.ReadLine());
if ("aeiouAEIOU".IndexOf(character) >= 0)
{
    Console.WriteLine("Vowel");
}
else
{
    Console.WriteLine("Consonant");
}




// 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

Console.Write("Enter an integer: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i);
}



// 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
Console.Write("Enter an integer: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}


// 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number

Console.Write("Enter an integer: ");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}




// 9- Write a program that takes two integers then prints the power.

Console.Write("Enter the base integer: ");
int baseNum = int.Parse(Console.ReadLine());    
Console.Write("Enter the exponent integer: ");
int exponent = int.Parse(Console.ReadLine());   
Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {Math.Pow(baseNum, exponent)}");




// 10- Write a program to enter marks of five subjects and calculate total, average and percentage.

Console.Write("Enter marks for subjects : ");
int[] subjects = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter marks for subject {i + 1}: ");
    subjects[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Total marks: {subjects.Sum()}");
Console.WriteLine($"Average marks: {subjects.Average()}");
Console.WriteLine($"percentage: {subjects.Sum() / 500.0 * 100} %");




// 11- Write a program to input the month number and print the number of day in that month.

Console.Write("Enter the month number (1-12): ");
int month = int.Parse(Console.ReadLine());
switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("Number of days: 31");
        break;

    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("Number of days: 30");
        break;

    case 2:
        Console.WriteLine("Number of days: 28");
        break;

    default:
        Console.WriteLine("Invalid month number");
        break;
}




// 12- Write a program to create a Simple Calculator.

Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine()); 
Console.Write("Enter second number: ");
double num2 = double.Parse(Console.ReadLine());

String[] operation = { "+", "-", "*", "/" };
if (operation.Contains("+"))
{
    Console.WriteLine($"Addition: {num1 + num2}");
}
else if (operation.Contains("-"))
{
    Console.WriteLine($"Subtraction: {num1 - num2}");
}
else if (operation.Contains("*"))
{
    Console.WriteLine($"Multiplication: {num1 * num2}");
}
else if (operation.Contains("/"))
{
    if (num2 != 0)
    {
        Console.WriteLine($"Division: {num1 / num2}");
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
}
else
{
    Console.WriteLine("Invalid operation");
}




// 13- Write a program to allow the user to enter a string and print then REVERSE of it.

Console.WriteLine("Enter a string: ");
string input = Console.ReadLine();
Console.WriteLine($"Reversed string: {new string(input.Reverse().ToArray())}"); 




// 14- Write a program to allow the user to enter int and print the REVERSED of it.

Console.WriteLine("Enter an integer: ");
int input = int.Parse(Console.ReadLine());
Console.WriteLine($"Reversed integer: {int.Parse(new string(input.ToString().Reverse().ToArray()))}");




// 15- Write a program in C# Sharp to find prime numbers within a range of numbers.

bool[] isPrime = new bool[10001];

for (int i = 2; i <= 10000; i++)
{
    isPrime[i] = true;
}

for (int i = 2; i <= 10000; i++)
{
    for (int j = 2; j * j <= i; j++)
    {
        if (i % j == 0)
        {
            isPrime[i] = false;
            break;
        }
    }
}

Console.Write("Enter the starting number of the range: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Enter the ending number of the range: ");
int end = int.Parse(Console.ReadLine());

for (int num = start; num <= end; num++)
{
    if (num > 1 && isPrime[num] == true)
    {
        Console.WriteLine(num);
    }
}




// 16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

Console.Write("Enter a decimal number: ");
int decimalNumber = int.Parse(Console.ReadLine());
int binary = 0 ;
int place = 1;

while (decimalNumber > 0)
{
    int remainder = decimalNumber % 2;
    binary += remainder * place;
    decimalNumber /= 2;
    place *= 10;
}

Console.WriteLine($"Binary representation: {binary}");




/* 17- Create a program that asks the user to input three points (x1, y1),
(x2, y2), and (x3, y3), and determines whether these points lie on a
single straight line.*/

Console.Write("Enter x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Enter y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Enter x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Enter y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Enter x3: ");
double x3 = double.Parse(Console.ReadLine());
Console.Write("Enter y3: ");
double y3 = double.Parse(Console.ReadLine());

if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
{
    Console.WriteLine("The points lie on a single straight line.");
}
else
{
    Console.WriteLine("The points do not lie on a single straight line.");
}




/*
18- Within a company, the efficiency of workers is evaluated based on the
duration required to complete a specific task. A worker's efficiency level
is determined as follows:
- If the worker completes the job within 2 to 3 hours, they are considered
highly efficient.
- If the worker takes 3 to 4 hours, they are instructed to increase their
speed.
- If the worker takes 4 to 5 hours, they are provided with training to
enhance their speed.
- If the worker takes more than 5 hours, they are required to leave the
company.
To calculate the efficiency of a worker, the time taken for the task is
obtained via user input from the keyboard.
*/

Console.Write("Enter the time taken to complete the job: ");
double hours = double.Parse(Console.ReadLine());

if (hours >= 2 && hours <= 3)
{
    Console.WriteLine("Highly efficient");
}
else if (hours > 3 && hours <= 4)
{
    Console.WriteLine("Increase your speed");
}
else if (hours > 4 && hours <= 5)
{
    Console.WriteLine("Training is required to improve your speed");
}
else if (hours > 5)
{
    Console.WriteLine("You are required to leave the company");
}
else
{
    Console.WriteLine("Invalid time");
}





/*
19- . Write a program that prints an identity matrix using for loop, in
other words takes a value n from the user and shows the identity table of
size n * n.
*/

Console.Write("Enter the size of the matrix: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            Console.Write("1 ");
        }
        else
        {
            Console.Write("0 ");
        }
    }

    Console.WriteLine();
}




/*
20- Write a program in C# Sharp to find the sum of all elements of the
array.
*/

Console.Write("Enter the size of the array: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
for (int i = 0; i < size; i++){
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

    Console.WriteLine($"Sum of all elements: {arr.Sum()}");





/*
21- Write a program in C# Sharp to merge two arrays of the same size
sorted in ascending order.
*/

int[] arr1 = { 1, 4, 7 };
int[] arr2 = { 2, 3, 8 };

int[] merged = arr1
    .Concat(arr2)
    .Order()
    .ToArray();

Console.WriteLine(string.Join(" ", merged));



/*
22- Write a program in C# Sharp to count the frequency of each element of
an array.
*/

int[] arr = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
int[]frequency = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    frequency[i] = 1;
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            frequency[i]++;
        }
    }
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] != -1)
    {
        Console.WriteLine($"Element {arr[i]} occurs {frequency[i]} times");
    }
}




/*
23- Write a program in C# Sharp to find maximum and minimum element in an
array
*/

Console.Write("Enter the size of the array: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Maximum element: {arr.Max()}");
Console.WriteLine($"Minimum element: {arr.Min()}");




/*
24- Write a program in C# Sharp to find the second largest element in an
array.
*/
Console.Write("Enter the size of the array: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Array.Sort(arr);
int secondLargest = arr[size - 2];



/*
25-. Consider an Array of Integer values with size N, having values as
in this Example
7 0 0 0 5 6 7 5 0 7 5 3
write a program find the longest distance between Two equal cells. In this example. The
distance is measured by the number Of cells- for example, the distance between the first and
the fourth cell is 2 (cell 2 and cell 3).
In the example above, the longest distance is between the first 7 and the
10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st
And the 10th 7s.
Note:
- Array values will be taken from the user
- If you have input like 1111111 then the distance is the number of
Cells between the first and the last cell.
*/
Console.Write("Enter array size: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

Console.WriteLine("Enter array elements:");

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int maxDistance = 0;

for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (arr[i] == arr[j])
        {
            int distance = j - i - 1;

            if (distance > maxDistance)
            {
                maxDistance = distance;
            }
        }
    }
}

Console.WriteLine($"Longest distance = {maxDistance}");




/*
26- Given a list of space separated words, reverse the order of the words.

Input: this is a test Output: test a is this
Input: all your base Output: base your all
Input: Word Output: Word
Note :
Check the Split Function (Member in String Class) Output will be a Single
Console.WriteLine Statement
*/

Console.Write("Enter a sentence: ");
string input = Console.ReadLine();

string[] words = input.Split(' ');

Array.Reverse(words);

Console.WriteLine(string.Join(" ", words));




/*
27- Write a program to create two multidimensional arrays of same size.
Accept value from user and store them in first array. Now copy all the
elements of first array on second array and print second array.
*/

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] arr1 = new int[rows, columns];
int[,] arr2 = new int[rows, columns];

Console.WriteLine("Enter the elements of first array:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr1[i, j] = int.Parse(Console.ReadLine());
    }
}

// Copy first array to second array
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr2[i, j] = arr1[i, j];
    }
}

// Print second array
Console.WriteLine("Second array:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(arr2[i, j] + " ");
    }

    Console.WriteLine();
}




/*
28- Write a Program to Print One Dimensional Array in Reverse Order
*/
Console.Write("Enter array size: ");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

Console.WriteLine("Enter array elements:");

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Array in reverse order:");

for (int i = n - 1; i >= 0; i--)
{
    Console.Write(arr[i] + " ");
}