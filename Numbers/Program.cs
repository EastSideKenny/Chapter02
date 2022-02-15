using System.Xml;

// unsigned integer means positive whole number or 0
uint naturalNumber = 23;

// integer means negative or positive whole number or 0
int integerNumber = -23;

// float means single-precision floating point
// F suffix makes it a float literal
float realNumber = 2.3F;

// double means double-precision floating point
double anotherRealNumber = 2.3; // double literal

// three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// check the three variables have the same value
// both statements output true
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;

Console.WriteLine();

if (a+b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine();

Console.WriteLine("Using decimals:");
decimal c = 0.1M; //M suffix means a decimal literal value
decimal d = 0.2M;

if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3}");
}

Console.WriteLine();

var population = 66_000_000; // 66 million in UK
var weight = 1.88; // in kg
var price = 4.99M; // in €
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes
var happy = true; // booleans have value of true or false

// good use of var because it avoids the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// bad use of var because we cannot tell the type, so we
// should use a specific twpe declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

XmlDocument xml3 = new(); // target-typed new in C# 9 or later

//class Person
//{
//    public DateTime BirthDate;
//}

//Person kim = new();
//kim.BirthDate = new(1967, 12, 26); // instead of: new DateTime(1967,12,26)

Console.WriteLine();
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(Datetime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"Number has been set to: {number}");
number = default;
Console.WriteLine($"Number has been reset to its default: {number}");
Console.WriteLine();

string[] names; // can reference any size array of strings

// allocating memory for four strings in an array
names = new string[4];

// storing items at index positions
names[0] = "Jempy";
names[1] = "Charel";
names[2] = "Jeannette";
names[3] = "Claudine";

// looping through the names
for (int i = 0; i < names.Length; i++)
{
    // output the item at index postion i
    Console.WriteLine(names[i]);
}

string[] names2 = new[] { "Jaques", "Karo", "Jeng", "Rita" };