using SRP2.Classes;

ReadInput readInput = new ReadInput();
var numbers = readInput.ReadNumbers();

Multiplication multiplication = new Multiplication();
int multipyResult = multiplication.MultipyNumbers(numbers.Item1, numbers.Item1);
Console.WriteLine("This is the Multiply of numbers: " + multipyResult);

Division division = new Division();
double divisionResult = division.Divide(numbers.Item1, numbers.Item2);
Console.WriteLine("This is the Division of numbers: " + divisionResult);

// OCP
Total total = new Total();
int totalResult = total.TotalOpration(numbers.Item1, numbers.Item2);
Console.WriteLine("This is the Total of two numbers: " + totalResult);

Console.ReadKey();
