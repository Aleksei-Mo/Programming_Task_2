// Задача 2. Напишите программу, которая на вход принимаем три числа и выдает максимальное из этих чисел.
Console.Clear(); // Clear the console berofe starting.
Console.WriteLine("This program will find the biggest number out of the entered numbers.");
Console.WriteLine("Enter the first number: ");
double Number_1 = Convert.ToDouble(Console.ReadLine()); //Write the first number to the variable
Console.WriteLine("Enter the second number: ");
double Number_2 = Convert.ToDouble(Console.ReadLine()); //Write the second number to the variable
Console.WriteLine("Enter the third number: ");
double Number_3 = Convert.ToDouble(Console.ReadLine()); //Write the third number to the variable
double MaxNumber=Number_1; // Initialize the variable which we will use to hold the biggest number.
if (Number_2>MaxNumber) // Check the second number for maximum.
{
    MaxNumber=Number_2;
}
if (Number_3>MaxNumber)// Check the third number for maximum.
{
    MaxNumber=Number_3;
}
Console.WriteLine("The biggest number is "+ MaxNumber);